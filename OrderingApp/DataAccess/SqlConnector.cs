using Dapper;
using OrderingApp.DataAccess;
using OrderingApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderingApp
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new product to the database
        /// </summary>
        /// <param name="model">The Product information</param>
        /// <returns>The Product information, including the unique modifier</returns>

        private const string db = "OrderingAppDB";
        public ProductModel CreateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.ProductName);
                p.Add("@Description", model.ProductDescription);
                p.Add("@ImageByte", model.ProductImageByte, dbType: DbType.Binary);
                p.Add("@ProductId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@CategoryId", model.ProductCategoryId);
                p.Add("@StockQuantity", model.ProductStockQuantity);

                connection.Execute("dbo.spProduct_Insert", p, commandType: CommandType.StoredProcedure);

                model.ProductId = p.Get<int>("@ProductId");

                return model;
            }
        }

        public ProductModel UpdateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.ProductName);
                p.Add("@Description", model.ProductDescription);
                p.Add("@ImageByte", model.ProductImageByte, dbType: DbType.Binary);
                p.Add("@ProductId", model.ProductId);
                p.Add("@StockQuantity", model.ProductStockQuantity);
                p.Add("@Price", model.ProductPrice);
                p.Add("@inStock", model.ProductinStock);

                connection.Execute("dbo.spProduct_Update", p, commandType: CommandType.StoredProcedure);

                return model;
            }

        }
        public ProductModel DeleteProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ProductId", model.ProductId);

                connection.Execute("dbo.spProduct_Delete", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

        public DataTable ProductViewGetAll()
        {

            string qry = "SELECT ProductId,Name,Description,ImageByte,CategoryId,Price,inStock FROM dbo.Product";
            SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db));
            SqlCommand cmd = new SqlCommand(qry, connection);
            connection.Open();
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    connection.Close();
                    return dt;

                }
            }
            catch
            {
                throw;
            }

        }
        public OrderModel SaveOrder(OrderModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@OrderId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@OrderDate", model.OrderDate);
                p.Add("@CustomerName", model.CustomerName);
                p.Add("@OrderTotalPrice", model.OrderTotalPrice);
                connection.Execute("dbo.spOrder_Insert", p, commandType: CommandType.StoredProcedure);
                model.OrderId = p.Get<int>("@OrderId");
                return model;
            }
        }
        public List<OrderLineModel> SaveOrderLine(List<OrderLineModel> model, int OrderId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (OrderLineModel orderline in model)
                {
                    var p = new DynamicParameters();
                    p.Add("@OrderId", OrderId);
                    p.Add("@ProductId", orderline.ProductId);
                    p.Add("@Quantity", orderline.OrderQuantity);
                    connection.Execute("dbo.spOrderLine_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        public BindingSource ViewOrderReport(BindingSource bsource, int OrderId)
        {

            //query order
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT [Order].[CustomerName], [Order].[OrderDate], [Order].[OrderTotalPrice] FROM " +
                    $"[Order] WHERE[OrderId] = {OrderId}";

                bsource.DataSource = connection.Query<OrderModel>(query, commandType: CommandType.Text);

            }
            return bsource;
        }

        public DataTable ViewOrderLineReport(OrderModel order)
        {
            List<OrderLineView> output = new List<OrderLineView>();
            DataTable dt = new DataTable();
            //query orderline
            if (order != null)
            {
                //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
                //{
                //    if (connection.State == ConnectionState.Closed)
                //    {
                //        connection.Open();
                //    }
                //    //string query = "SELECT [dbo].[Product].[Name], [dbo].[OrderLine].[Quantity], [dbo].[Product].[Price] " +
                //    //    "FROM [Product] INNER JOIN [OrderLine] ON [Product].[ProductId] = [OrderLine].[ProductId] " +
                //    //    $"WHERE [OrderLine].[OrderId] = {order.OrderId} ;";

                //    output = connection.Query<OrderLineView>("dbo.spOrderLine_View", new { order.OrderId }, commandType: CommandType.StoredProcedure).AsList();
                //    //output = connection.Query<OrderLineView>(query, commandType: CommandType.Text).AsList();


                //}
                string qry = "SELECT [dbo].[Product].[Name], [dbo].[OrderLine].[Quantity], [dbo].[Product].[Price] " +
                                "FROM [Product] INNER JOIN [OrderLine] ON [Product].[ProductId] = [OrderLine].[ProductId] " +
                                $"WHERE [OrderLine].[OrderId] = {order.OrderId}";
                SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db));
                SqlCommand cmd = new SqlCommand(qry, connection);
                connection.Open();
                try
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        sda.SelectCommand = cmd;

                        sda.Fill(dt);
                        connection.Close();


                    }
                }
                catch
                {
                    throw;
                }



            }
            return dt;
            //return output;
        }

    }
}