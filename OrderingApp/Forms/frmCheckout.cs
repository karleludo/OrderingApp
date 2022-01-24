using Dapper;
using OrderingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class frmCheckout : Form
    {
        //list variable with orderLine already stored;
        public List<OrderLineModel> _currentOrderLineList { get; set; } = new List<OrderLineModel>();
        
        //List variable with checkout controls for recomputation;
        public List<controlCartItem> _currentShoppingCart { get; set; } = new List<controlCartItem>();
        
        //represents the customer callout name
        public string _currentCustomerName { get; set; }

        //build the OrderModel for database
        public int _orderId { get; private set; }

        DataTable _OrderLineList;
        OrderModel _currentOrder;
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            lblGreetings.Text = $"Hello, {_currentCustomerName}. Thank you for using the OrderingApp kiosk.";
            RenderShoppingCart();
            GenerateCartSummaryItems();
        }
        private void RenderShoppingCart()
        {
            flpShoppingCart.Controls.Clear();
            List<controlCartItem> ShoppingCart = new List<controlCartItem>();
            ShoppingCart = _currentShoppingCart;
            foreach (controlCartItem item in ShoppingCart)
            {
                item.DisableControls();
                flpShoppingCart.Controls.Add(item);
                
            }
            setPricingValues();
            //TODO - cartItem events or don't have buttons on cart summary
        }
        private double setPricingValues()
        {
            double temp = 0; ;
            foreach (controlCartItem item in _currentShoppingCart)
            {
                temp += item.ProductSubtotalPrice;
            }

            double discount = 0;
            double tax = 0;

            double discountDeducted = temp * discount;

            double discountedPrice = temp - discountDeducted;
            double taxAdded = discountedPrice * tax;


            double total = discountedPrice + taxAdded;


            //set label.Text
            lblSubtotalValue.Text = temp.ToString();

            lblDiscountShow.Text = (discount * 100).ToString() + "%";
            lblDiscountValue.Text = discountDeducted.ToString();

            lblTaxShow.Text = (tax * 100).ToString() + "%";
            lblTaxValue.Text = taxAdded.ToString();
            lblTotalValue.Text = total.ToString();
            return total;
            //TODO - probably assign these to global variables;
            //TODO - assign these to property values so I don't have to recompute on the checkout form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }
        private void GenerateCartSummaryItems() 
        {
            foreach (controlCartItem item in _currentShoppingCart)
            {
                controlCartSummaryItem cartSumItem = new controlCartSummaryItem();
                cartSumItem.ProductName = item.ProductHeader;
                cartSumItem.ProductQuantity = item.ProductQuantity;
                cartSumItem.ProductSubtotalPrice = item.ProductSubtotalPrice;
                flpCartSummary.Controls.Add(cartSumItem);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OrderModel order = new OrderModel();

            order.CustomerName = _currentCustomerName;
            order.OrderDate = DateTime.UtcNow;
            order.OrderTotalPrice = setPricingValues();
            GlobalConfig.Connection.SaveOrder(order);

            RenderShoppingCart();

            GlobalConfig.Connection.SaveOrderLine(_currentOrderLineList, order.OrderId);
            this._orderId = order.OrderId;
            

            _currentOrder = order;
            BindingSource OrderLineViewBinding = new BindingSource();
            OrderLineViewBinding = GlobalConfig.Connection.ViewOrderReport(OrderBindingSource, this._orderId);
            _OrderLineList = GlobalConfig.Connection.ViewOrderLineReport(_currentOrder);

            using (frmReceipt frm = new frmReceipt(_currentOrder, _OrderLineList, OrderLineViewBinding)) 
            {               
                frm.ShowDialog();
            }

            //TODO - generate receipt

            //TODO - open genRep on confirm(i.e. dialogresult)
            //TODO - create form for showing transaction report (join query)


        }
        
    }
}
