using OrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingApp.DataAccess
{
    public interface IDataConnection
    {
        ProductModel CreateProduct(ProductModel model);
        ProductModel DeleteProduct(ProductModel model);
        ProductModel UpdateProduct(ProductModel model);

        OrderModel SaveOrder(OrderModel model);
        List<OrderLineModel> SaveOrderLine(List<OrderLineModel> model, int OrderId);

        DataTable ProductViewGetAll();
        BindingSource ViewOrderReport(BindingSource bsource, int OrderId);
        //List<OrderLineView> ViewOrderLineReport(OrderModel order);
        DataTable ViewOrderLineReport(OrderModel order);
    }
}
