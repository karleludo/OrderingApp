using OrderingApp.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace OrderingApp
{

    public partial class frmProductDashboard : Form
    {
        private int _selectedRowId;

        private int _currentStockAmount;

        private string _currentImagePath;

        private bool imageChanged = false;


        private byte[] NewimageByteArray;
        public frmProductDashboard()
        {
            InitializeComponent();



        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItemForm = new frmAddItem();
            addItemForm.Show();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderingAppProducts.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.orderingAppProducts.Product);


        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            //disable controls in EDIT PRODUCT
            DisableForm();
            //revert to previous values(unedited)
            PopulateForm();


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //TODO - validate edit form

            ProductModel Product = new ProductModel();

            Product = GetValuesFromForm();

            GlobalConfig.Connection.UpdateProduct(Product);

            MessageBox.Show("Product successfully updated");

            this.productTableAdapter.Fill(this.orderingAppProducts.Product);
            refreshGridView();
            setStockAmount();

        }

        private ProductModel GetValuesFromForm()
        {
            ProductModel prod = new ProductModel();

            prod.ProductId = this._selectedRowId;
            prod.ProductName = tbEditProductName.Text;
            prod.ProductDescription = rtbEditProductDescription.Text;
            if (imageChanged)
            {
                prod.ProductImageByte = this.NewimageByteArray;
            }
            prod.ProductStockQuantity = Convert.ToInt32(this._currentStockAmount);

            prod.ProductinStock = isInStock();
            prod.ProductPrice = Convert.ToDouble(tbPrice.Text);

            return prod;
        }

        private int isInStock()
        {
            if (cbInStock.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void refreshGridView()
        {

            dgvItemView.Update();
            dgvItemView.Refresh();
            panelDataView.Update();

        }
        private void btnEditSelectedItem_Click(object sender, EventArgs e)
        {
            //change color to focus edit panel(change this to appropriate color)
            panelEditItem.BackColor = Color.AliceBlue;

            //set edit form textbox ReadOnly = false
            tbEditProductName.ReadOnly = false;
            rtbEditProductDescription.ReadOnly = false;


            //enable "change image button", "save changes button" and "cancel button" (maybe relocate change this to when textbox/rtb is changed)
            btnChangeImage.Enabled = true;
            btnSaveChanges.Enabled = true;
            btnCancelChanges.Enabled = true;
            btnDeleteSelectedItem.Enabled = true;

            gbEditPrice.Enabled = true;
            gbAvailability.Enabled = true;

            //tbStockAmount.ReadOnly = false;
            nudModifyValue.ReadOnly = false;

            tbPrice.ReadOnly = false;
        }

        private void PopulateForm()
        {

            if (dgvItemView.SelectedRows.Count > 0)
            {
                // bindingsource indexes
                // 0 - Id (primary)
                // 1 - ProductName (string)
                // 2 - ProductDescription (string)
                // 3 - Category (foreign key)
                // 4 - Stock Quantity (smallint)
                // 5 - inStock (bit)
                // 6 - imageByte (byteArray)
                // 7 - Price (float)

                int selectedrowindex = dgvItemView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItemView.Rows[selectedrowindex];

                _selectedRowId = Convert.ToInt32(selectedRow.Cells[0].Value);

                byte[] tempImage = (byte[])(selectedRow.Cells[6].Value);
                Image selectedRowImage = byteArrayToImage(tempImage);
                pBoxProductImage.Image = selectedRowImage;


                lblSelectedItemId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                tbEditProductName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                rtbEditProductDescription.Text = Convert.ToString(selectedRow.Cells[2].Value);
                _currentStockAmount = Convert.ToInt32(selectedRow.Cells[4].Value);
                tbStockAmount.Text = _currentStockAmount.ToString();

                //if inStock flag
                if (Convert.ToBoolean(selectedRow.Cells[5].Value))
                {
                    cbInStock.Checked = true;
                }
                else
                {
                    cbInStock.Checked = false;
                }

                tbPrice.Text = Convert.ToString(selectedRow.Cells[7].Value);

            }

        }

        private void dgvItemView_SelectionChanged(object sender, EventArgs e)
        {
            imageChanged = false;
            refreshGridView();
            PopulateForm();
            DisableForm();
        }
        private void DisableForm()
        {

            panelEditItem.BackColor = Color.Silver;


            tbEditProductName.ReadOnly = true;
            rtbEditProductDescription.ReadOnly = true;

            btnChangeImage.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnCancelChanges.Enabled = false;
            btnDeleteSelectedItem.Enabled = false;

            gbAvailability.Enabled = false;
            gbEditPrice.Enabled = false;
            lblImageStatus.Visible = false;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            ProductModel prod = new ProductModel();
            prod.ProductId = this._selectedRowId;
            GlobalConfig.Connection.DeleteProduct(prod);

            this.productTableAdapter.Fill(this.orderingAppProducts.Product);

            MessageBox.Show("Item successfully deleted.");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmAdminDashboard_Load(sender, e);
            refreshGridView();
        }


        private void setStockAmount()
        {
            tbStockAmount.Text = _currentStockAmount.ToString();
        }



        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int modValue;
            modValue = Convert.ToInt32(nudModifyValue.Value);
            _currentStockAmount = _currentStockAmount + modValue;
            setStockAmount();
        }

        private void btnDecreaseStock_Click(object sender, EventArgs e)
        {

            //TODO - fix this, stock amount changes on add decrease click
            int modValue;
            modValue = Convert.ToInt32(nudModifyValue.Value);

            if (_currentStockAmount <= modValue)
            {
                _currentStockAmount = 0;
            }
            else
            {
                _currentStockAmount = _currentStockAmount - modValue;

            }
            setStockAmount();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image files (*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF | " + "All files (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    _currentImagePath = openFile.FileName;
                    pBoxProductImage.Image = new Bitmap(openFile.FileName);

                    imageChanged = true;
                    lblImageStatus.Visible = true;

                }

                if (imageChanged)
                {
                    lblImageStatus.Text = "new image selected";

                    try
                    {
                        Image img = Image.FromFile(_currentImagePath);
                        NewimageByteArray = imageToByteArray(img);

                        lblImageStatus.ForeColor = System.Drawing.Color.Green;
                        lblImageStatus.Text = "coversion success";

                    }
                    //catch potential image convert errors
                    catch (ArgumentException err)
                    {
                        lblImageStatus.ForeColor = System.Drawing.Color.Red;
                        lblImageStatus.Text = "Failed to convert image!" + err.ToString();
                    }
                    finally
                    {
                        lblImageStatus.BackColor = System.Drawing.Color.Transparent;
                    }
                }
            }
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        private void tbStockAmount_TextChanged(object sender, EventArgs e)
        {

            setStockAmount();
            refreshGridView();
        }
    }
}
