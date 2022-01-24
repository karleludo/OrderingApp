using OrderingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class frmOrderPage : Form
    {
        private List<controlCartItem> _shoppingCart = new List<controlCartItem>();
        private readonly DataTable _allProductsForView = GlobalConfig.Connection.ProductViewGetAll();

        private string _customerName;
        
        public frmOrderPage()
        {
            InitializeComponent();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            frmCustNamePrompt customerPrompt = new frmCustNamePrompt();
            if (customerPrompt.ShowDialog() == DialogResult.OK)
            {
                _customerName = customerPrompt.CustName;
            }
            else 
            {
                this.Close();
                frmStartPage start = new frmStartPage();
                start.Show();
            }
            GenerateProductCards();

            lblGreetings.Text = $"Hello, {_customerName}, please select the items you want to purchase.";

        }
        private void GenerateProductCards()
        {
            flpProductShelf.Controls.Clear();
            DataTable dt = new DataTable();
            dt = _allProductsForView;
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    controlProductCard[] prodCards = new controlProductCard[dt.Rows.Count];
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                
                                prodCards[i] = new controlProductCard();
                                prodCards[i].ProductId = (int)row["ProductId"];
                                prodCards[i].ProductHeader = row["Name"].ToString();
                                prodCards[i].ProductDescription = row["Description"].ToString();
                                byte[] tempImage = (byte[])(row["ImageByte"]);
                                prodCards[i].Icon = byteArrayToImage(tempImage);
                                prodCards[i].ProductPrice = (double)row["Price"];
                                prodCards[i].ProductCategoryId = (int)row["CategoryId"];

                                if (((bool)row["inStock"]) == false)
                                {
                                    prodCards[i].Visible = false;
                                }
                                flpProductShelf.Controls.Add(prodCards[i]);
                                
                                prodCards[i].AddToCartEvent += new EventHandler(AddToCart_Click);

                            }

                        }

                    }
                }
            }
            else 
            {
                MessageBox.Show("There are no available items.");
            }
        }
        
        protected void AddToCart_Click(object sender, EventArgs e)
        {
            controlProductCard objProd = (controlProductCard)sender;
            controlCartItem cartItem = new controlCartItem();

            //cartItem.ProductQuantity += 1;
            cartItem.ProductId = objProd.ProductId;
            cartItem.ProductHeader = objProd.ProductHeader;
            cartItem.Icon = objProd.Icon;
            cartItem.ProductUnitPrice = objProd.ProductPrice;
            cartItem.ProductQuantity = 1;
            double getter = cartItem.ProductSubtotalPrice;
            //cartItem.SetSubtotalText();
            //cartItem.ProductSubtotalPrice = cartItem.ProductUnitPrice;

            controlCartItem result = _shoppingCart.Find(x => x.ProductId == objProd.ProductId);

            if (result!=null)
            {
                
                result.ProductQuantity += 1;
            }
            else 
            {
                
                _shoppingCart.Add(cartItem);
                cartItem.incQuantityEvent += new EventHandler(increase_Click);
                cartItem.decQuantityEvent += new EventHandler(decrease_Click);
                cartItem.removeItemEvent += new EventHandler(removeCartItem_Click);
                cartItem.quantityChanged += new EventHandler(cartItemQuantityChanged);
            }
            RenderShoppingCart();


        }
        private void increase_Click(object sender, EventArgs e) 
        {
            controlCartItem cartItem = (controlCartItem)sender;
            cartItem.ProductQuantity +=1;
            RenderShoppingCart();
        }
        private void decrease_Click(object sender, EventArgs e)
        {
            controlCartItem cartItem = (controlCartItem)sender;
            if (cartItem.ProductQuantity <= 1)
            {
                _shoppingCart.Remove(cartItem);
                flpShoppingCart.Controls.Remove(cartItem);
            }
            else 
            {
                cartItem.ProductQuantity -= 1;
            }
            RenderShoppingCart();
        }
        
        private void removeCartItem_Click(object sender, EventArgs e)
        {
            controlCartItem cartItem = (controlCartItem)sender;
            _shoppingCart.Remove(cartItem);
            flpShoppingCart.Controls.Remove(cartItem);
            RenderShoppingCart();
        }
        private void RenderShoppingCart() 
        {
            foreach(controlCartItem item in _shoppingCart)
            {
                item.SetSubtotalText();
                flpShoppingCart.Controls.Add(item);
                item.EnableControls();
                
            }
            setPricingValues();
            
        }
        private void cartItemQuantityChanged(object sender, EventArgs e) 
        {
            controlCartItem cartItem = (controlCartItem)sender;
            int quantity = cartItem.ProductQuantity;
            double price = cartItem.ProductUnitPrice;
            cartItem.SetSubtotalText();

            //cartItem.ProductSubtotalPrice = quantity * price;


            setPricingValues();

        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //instantiate checkout form
            if (ValidateCart())
            {
                frmCheckout checkout = new frmCheckout();

                //pass the value of CustomerName
                checkout._currentCustomerName = _customerName;

                //pass the value of shopping cart, convert to OrderLineModel
                List<OrderLineModel> checkoutItems = new List<OrderLineModel>();

                //pass the value of shopping cart to same container variable name;
                checkout._currentShoppingCart = _shoppingCart;
                foreach (controlCartItem item in _shoppingCart)
                {
                    OrderLineModel modelItem = new OrderLineModel();
                    modelItem.ProductId = item.ProductId;
                    modelItem.OrderQuantity = item.ProductQuantity;
                    checkoutItems.Add(modelItem);
                }

                checkout._currentOrderLineList = checkoutItems;
                setPricingValues();
                //pass the value of the total price

                this.Hide();
                checkout.ShowDialog(this);
                RenderShoppingCart();
            }
            else 
            {
                MessageBox.Show("There are no items in your Shopping cart.");
                
            }
            
            

        }
        private void setPricingValues() 
        {
            double temp = 0; ;
            foreach (controlCartItem item in _shoppingCart)
            {
                temp += item.ProductSubtotalPrice;
            }

            double discount = 0;
            double tax = 0;

            double discountDeducted = temp * discount;

            double discountedPrice = temp - discountDeducted;
            double taxAdded = discountedPrice * tax;


            double total =  discountedPrice + taxAdded;

            
            //set label.Text
            lblSubtotalValue.Text = temp.ToString();

            lblDiscountShow.Text = (discount*100).ToString()+"%";
            lblDiscountValue.Text = discountDeducted.ToString();

            lblTaxShow.Text = (tax*100).ToString()+"%";
            lblTaxValue.Text = taxAdded.ToString();
            lblTotalValue.Text = total.ToString();
            
            //TODO - probably assign these to global variables;
            //TODO - assign these to property values so I don't have to recompute on the checkout form
        }
        private bool ValidateCart()
        {
            if (flpShoppingCart.Controls.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
