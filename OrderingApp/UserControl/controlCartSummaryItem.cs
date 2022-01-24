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
    public partial class controlCartSummaryItem : UserControl
    {
        public controlCartSummaryItem()
        {
            InitializeComponent();
        }
        private string _productName;
        private int _productQuantity;
        private double _productSubtotalPrice;

        public string ProductName 
        {
            get { return _productName; }
            set { _productName = value; this.lblName.Text = _productName; }
        }
        public int ProductQuantity 
        {
            get { return _productQuantity; }
            set { _productQuantity = value; this.lblQtyValue.Text = _productQuantity.ToString(); }
        }
        public double ProductSubtotalPrice 
        {
            get { return _productSubtotalPrice; }
            set { _productSubtotalPrice = value; this.lblSubtotalValue.Text = _productSubtotalPrice.ToString(); }
        }

    }
}
