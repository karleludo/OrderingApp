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
    public partial class controlProductCard : UserControl
    {        
        public controlProductCard()
        {
            InitializeComponent();

        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler AddToCartEvent;
        private int _productId;
        private Image _icon;
        private string _productHeader;
        private string _productDescription;
        private double _productPrice;
        private int _productCategoryId;


        public int ProductId 
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public Image Icon 
        {
            get { return _icon; }
            set { _icon = value; pbProductImage.Image = value; }
        }


        public string ProductHeader
        {
            get { return _productHeader; }
            set { _productHeader = value; lblProductHeader.Text = value; }
        }

        public string ProductDescription
        {
            get { return _productDescription; }
            set { _productDescription = value; lblProductDescription.Text = value; }
        }

        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; lblProductPrice.Text = value.ToString(); }
        }
        public int ProductCategoryId
        {
            get { return _productCategoryId; }
            set {_productCategoryId = value; }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCartEvent?.Invoke(this, e);
        }

        
    }
}
