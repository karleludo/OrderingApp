using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class controlCartItem : UserControl
    {
        public controlCartItem()
        {

            InitializeComponent();

        }

        private int _productId;
        private Image _icon;
        private string _productHeader;
        private int _productQuantity;
        private double _productSubtotalPrice;
        private double _productUnitPrice;
        public event EventHandler incQuantityEvent;
        public event EventHandler decQuantityEvent;
        public event EventHandler removeItemEvent;
        public event EventHandler quantityChanged;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; this.pbProductImage.Image = value; }
        }

        public string ProductHeader
        {
            get { return _productHeader; }
            set { _productHeader = value; this.lblProductHeader.Text = value; }
        }

        public int ProductQuantity
        {
            get { return _productQuantity; }
            set
            {
                if (value <= 0)
                {
                    _productQuantity = 0;
                }
                else
                {
                    _productQuantity = value;
                }

                tbProductQuantity.Text = value.ToString();
            }
        }

        public double ProductSubtotalPrice
        {
            get
            {
                SetSubtotalText();
                return _productSubtotalPrice = _productQuantity * _productUnitPrice;
            }
        }
        public void SetSubtotalText()
        {
            this.lblProductTotalPrice.Text = _productSubtotalPrice.ToString();
        }


        public double ProductUnitPrice
        {
            get { return _productUnitPrice; }
            set { _productUnitPrice = value; }
        }

        private void btnRemoveCartItem_Click(object sender, EventArgs e)
        {
            removeItemEvent?.Invoke(this, e);
            quantityChanged?.Invoke(this, e);
        }

        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            incQuantityEvent?.Invoke(this, e);
            quantityChanged?.Invoke(this, e);
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            decQuantityEvent?.Invoke(this, e);
            quantityChanged?.Invoke(this, e);
        }
        private void textbox_quantityChanged(object sender, EventArgs e)
        {
            quantityChanged?.Invoke(this, e);
        }
        public void DisableControls()
        {
            this.btnDecreaseQuantity.Visible = false;
            this.btnIncreaseQuantity.Visible = false;
            this.tbProductQuantity.Enabled = false;
            this.btnRemoveCartItem.Visible = false;
        }
        public void EnableControls()
        {
            this.btnDecreaseQuantity.Visible = true;
            this.btnIncreaseQuantity.Visible = true;
            this.tbProductQuantity.Enabled = true;
            this.btnRemoveCartItem.Visible = true;
        }

    }
}
