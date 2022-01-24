using OrderingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class frmAddItem : Form
    {
       

        private bool fileImageSelected = false;
        private string currentImagePath;
        private byte[] _imageByteArray;
        
        public frmAddItem()
        {
            InitializeComponent();
            
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ProductModel model = new ProductModel();
                model.ProductName = tbItemName.Text;
                model.ProductDescription = tbItemDescription.Text;
                model.ProductCategoryId = cmbItemCategory.SelectedIndex+1;
                model.ProductImageByte = _imageByteArray;

                GlobalConfig.Connection.CreateProduct(model);

                MessageBox.Show("Item added Successfully");

            }
            else
            {
                MessageBox.Show("You need to fill all the fields.");
            }

        }
        
        private bool ValidateForm() 
        {
            bool output = true;

            if (tbItemName.Text.Length == 0) 
            {
                output = false;
            }

            if (cmbItemCategory.SelectedIndex == -1)
            {
                output = false;
            }

            if (tbItemDescription.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image files (*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF | " + "All files (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = openFile.FileName;
                    tbImageLocation.Text = openFile.FileName;
                    picProductImage.Image = new Bitmap(openFile.FileName);
                    tbImageNewName.Text = Path.GetFileNameWithoutExtension(openFile.FileName);
                    lblImageFileExtension.Text = Path.GetExtension(openFile.FileName);
                    fileImageSelected = true;
                }
            }
            if (fileImageSelected)
            {
                if (tbImageNewName.Text.Length == 0)
                {
                    lblUploadStatus.ForeColor = System.Drawing.Color.Red;
                    lblUploadStatus.Text = "Please input a file name for the image.";

                }
                else
                {
                    try
                    {              
                        Image img = Image.FromFile(currentImagePath);
                        _imageByteArray = imageToByteArray(img);

                        lblUploadStatus.ForeColor = System.Drawing.Color.Green;
                        lblUploadStatus.Text = "Image coverted successfully!";
                    }
                    //catch potential image convert errors
                    catch (ArgumentException err)
                    {
                        lblUploadStatus.ForeColor = System.Drawing.Color.Red;
                        lblUploadStatus.Text = "Failed to convert image!" + err.ToString();
                    }
                    finally
                    {
                        lblUploadStatus.BackColor = System.Drawing.Color.Transparent;
                    }
                }

            }
            else
            {
                lblUploadStatus.BackColor = System.Drawing.Color.DarkGray;
                lblUploadStatus.ForeColor = System.Drawing.Color.Yellow;
                lblUploadStatus.Text = "There's no image selected.";
            }
        }
        // TODO - migrate this function to product class
        // also optimize this
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        // TODO - migrate this function to product class
        // also optimize this
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

       
        private void frmAddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderingAppDBSQLmanageProductCategory.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.orderingAppDBSQLmanageProductCategory.Category);

        }
    }
}
