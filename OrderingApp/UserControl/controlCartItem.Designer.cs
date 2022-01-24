
namespace OrderingApp
{
    partial class controlCartItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecreaseQuantity = new System.Windows.Forms.Button();
            this.btnIncreaseQuantity = new System.Windows.Forms.Button();
            this.lblProductHeader = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductTotalPrice = new System.Windows.Forms.Label();
            this.btnRemoveCartItem = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecreaseQuantity
            // 
            this.btnDecreaseQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseQuantity.Location = new System.Drawing.Point(247, 41);
            this.btnDecreaseQuantity.Name = "btnDecreaseQuantity";
            this.btnDecreaseQuantity.Size = new System.Drawing.Size(33, 23);
            this.btnDecreaseQuantity.TabIndex = 1;
            this.btnDecreaseQuantity.Text = "-";
            this.btnDecreaseQuantity.UseVisualStyleBackColor = true;
            this.btnDecreaseQuantity.Click += new System.EventHandler(this.btnDecreaseQuantity_Click);
            // 
            // btnIncreaseQuantity
            // 
            this.btnIncreaseQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseQuantity.Location = new System.Drawing.Point(319, 41);
            this.btnIncreaseQuantity.Name = "btnIncreaseQuantity";
            this.btnIncreaseQuantity.Size = new System.Drawing.Size(33, 23);
            this.btnIncreaseQuantity.TabIndex = 2;
            this.btnIncreaseQuantity.Text = "+";
            this.btnIncreaseQuantity.UseVisualStyleBackColor = true;
            this.btnIncreaseQuantity.Click += new System.EventHandler(this.btnIncreaseQuantity_Click);
            // 
            // lblProductHeader
            // 
            this.lblProductHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductHeader.Location = new System.Drawing.Point(124, 14);
            this.lblProductHeader.Name = "lblProductHeader";
            this.lblProductHeader.Size = new System.Drawing.Size(269, 20);
            this.lblProductHeader.TabIndex = 3;
            this.lblProductHeader.Text = "Product Header";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductQuantity.Location = new System.Drawing.Point(128, 38);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(69, 27);
            this.tbProductQuantity.TabIndex = 4;
            this.tbProductQuantity.TextChanged += new System.EventHandler(this.textbox_quantityChanged);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProductImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbProductImage.Location = new System.Drawing.Point(0, 0);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(118, 117);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            // 
            // lblProductTotalPrice
            // 
            this.lblProductTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductTotalPrice.AutoSize = true;
            this.lblProductTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTotalPrice.Location = new System.Drawing.Point(303, 84);
            this.lblProductTotalPrice.Name = "lblProductTotalPrice";
            this.lblProductTotalPrice.Size = new System.Drawing.Size(90, 25);
            this.lblProductTotalPrice.TabIndex = 5;
            this.lblProductTotalPrice.Text = "XXXX.XX";
            this.lblProductTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRemoveCartItem
            // 
            this.btnRemoveCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCartItem.Location = new System.Drawing.Point(368, 4);
            this.btnRemoveCartItem.Name = "btnRemoveCartItem";
            this.btnRemoveCartItem.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveCartItem.TabIndex = 6;
            this.btnRemoveCartItem.Text = "x";
            this.btnRemoveCartItem.UseVisualStyleBackColor = true;
            this.btnRemoveCartItem.Click += new System.EventHandler(this.btnRemoveCartItem_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(285, 84);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(24, 25);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "P";
            // 
            // controlCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnRemoveCartItem);
            this.Controls.Add(this.lblProductTotalPrice);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.lblProductHeader);
            this.Controls.Add(this.btnIncreaseQuantity);
            this.Controls.Add(this.btnDecreaseQuantity);
            this.Controls.Add(this.pbProductImage);
            this.Name = "controlCartItem";
            this.Size = new System.Drawing.Size(396, 117);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button btnDecreaseQuantity;
        private System.Windows.Forms.Button btnIncreaseQuantity;
        private System.Windows.Forms.Label lblProductHeader;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.Label lblProductTotalPrice;
        private System.Windows.Forms.Button btnRemoveCartItem;
        private System.Windows.Forms.Label lblCurrency;
    }
}
