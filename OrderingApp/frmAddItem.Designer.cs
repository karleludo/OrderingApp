
namespace OrderingApp
{
    partial class frmAddItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblFormHeader;
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.pnlItemDetails = new System.Windows.Forms.Panel();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemDetailsHeader = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderingAppDBSQLmanageProductCategory = new OrderingApp.OrderingAppDBSQLmanageProductCategory();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbUploadImage = new System.Windows.Forms.GroupBox();
            this.lblImageFileExtension = new System.Windows.Forms.Label();
            this.tbImageNewName = new System.Windows.Forms.TextBox();
            this.lblRenameImage = new System.Windows.Forms.Label();
            this.lblUploadStatus = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.tbImageLocation = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter = new OrderingApp.OrderingAppDBSQLmanageProductCategoryTableAdapters.CategoryTableAdapter();
            lblFormHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.pnlItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppDBSQLmanageProductCategory)).BeginInit();
            this.gbUploadImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            lblFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            lblFormHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFormHeader.Location = new System.Drawing.Point(0, 0);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new System.Drawing.Size(834, 40);
            lblFormHeader.TabIndex = 1;
            lblFormHeader.Text = "Add an Item";
            lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProductImage
            // 
            this.picProductImage.ErrorImage = global::OrderingApp.Properties.Resources.imageDefault;
            this.picProductImage.Image = global::OrderingApp.Properties.Resources.imageDefault;
            this.picProductImage.InitialImage = global::OrderingApp.Properties.Resources.imageDefault;
            this.picProductImage.Location = new System.Drawing.Point(12, 43);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(300, 420);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 0;
            this.picProductImage.TabStop = false;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescription.Location = new System.Drawing.Point(8, 118);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(136, 21);
            this.lblItemDescription.TabIndex = 3;
            this.lblItemDescription.Text = "Item Description:";
            // 
            // pnlItemDetails
            // 
            this.pnlItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemDetails.Controls.Add(this.tbItemDescription);
            this.pnlItemDetails.Controls.Add(this.lblItemDetailsHeader);
            this.pnlItemDetails.Controls.Add(this.cmbItemCategory);
            this.pnlItemDetails.Controls.Add(this.lblItemDescription);
            this.pnlItemDetails.Controls.Add(this.lblItemName);
            this.pnlItemDetails.Controls.Add(this.lblItemCategory);
            this.pnlItemDetails.Controls.Add(this.tbItemName);
            this.pnlItemDetails.Location = new System.Drawing.Point(318, 43);
            this.pnlItemDetails.Name = "pnlItemDetails";
            this.pnlItemDetails.Size = new System.Drawing.Size(506, 420);
            this.pnlItemDetails.TabIndex = 5;
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemDescription.Location = new System.Drawing.Point(150, 117);
            this.tbItemDescription.Multiline = true;
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(352, 158);
            this.tbItemDescription.TabIndex = 5;
            // 
            // lblItemDetailsHeader
            // 
            this.lblItemDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemDetailsHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblItemDetailsHeader.Name = "lblItemDetailsHeader";
            this.lblItemDetailsHeader.Size = new System.Drawing.Size(506, 32);
            this.lblItemDetailsHeader.TabIndex = 4;
            this.lblItemDetailsHeader.Text = "Item Details";
            this.lblItemDetailsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemCategory.DataSource = this.categoryBindingSource;
            this.cmbItemCategory.DisplayMember = "CategoryName";
            this.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemCategory.Location = new System.Drawing.Point(150, 82);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(352, 29);
            this.cmbItemCategory.TabIndex = 3;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.orderingAppDBSQLmanageProductCategory;
            // 
            // orderingAppDBSQLmanageProductCategory
            // 
            this.orderingAppDBSQLmanageProductCategory.DataSetName = "OrderingAppDBSQLmanageProductCategory";
            this.orderingAppDBSQLmanageProductCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(52, 50);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(92, 21);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item name:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.Location = new System.Drawing.Point(24, 85);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(120, 21);
            this.lblItemCategory.TabIndex = 2;
            this.lblItemCategory.Text = "Item Category:";
            // 
            // tbItemName
            // 
            this.tbItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(150, 47);
            this.tbItemName.MaxLength = 50;
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(352, 29);
            this.tbItemName.TabIndex = 1;
            this.tbItemName.WordWrap = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(318, 469);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(319, 54);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(643, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 54);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbUploadImage
            // 
            this.gbUploadImage.Controls.Add(this.lblImageFileExtension);
            this.gbUploadImage.Controls.Add(this.tbImageNewName);
            this.gbUploadImage.Controls.Add(this.lblRenameImage);
            this.gbUploadImage.Controls.Add(this.lblUploadStatus);
            this.gbUploadImage.Controls.Add(this.btnBrowseImage);
            this.gbUploadImage.Controls.Add(this.tbImageLocation);
            this.gbUploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUploadImage.Location = new System.Drawing.Point(12, 469);
            this.gbUploadImage.Name = "gbUploadImage";
            this.gbUploadImage.Size = new System.Drawing.Size(300, 200);
            this.gbUploadImage.TabIndex = 9;
            this.gbUploadImage.TabStop = false;
            this.gbUploadImage.Text = "Image";
            // 
            // lblImageFileExtension
            // 
            this.lblImageFileExtension.AutoSize = true;
            this.lblImageFileExtension.Location = new System.Drawing.Point(198, 100);
            this.lblImageFileExtension.Name = "lblImageFileExtension";
            this.lblImageFileExtension.Size = new System.Drawing.Size(50, 25);
            this.lblImageFileExtension.TabIndex = 14;
            this.lblImageFileExtension.Text = ".png";
            // 
            // tbImageNewName
            // 
            this.tbImageNewName.Location = new System.Drawing.Point(7, 92);
            this.tbImageNewName.Name = "tbImageNewName";
            this.tbImageNewName.Size = new System.Drawing.Size(190, 33);
            this.tbImageNewName.TabIndex = 13;
            // 
            // lblRenameImage
            // 
            this.lblRenameImage.AutoSize = true;
            this.lblRenameImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenameImage.Location = new System.Drawing.Point(2, 68);
            this.lblRenameImage.Name = "lblRenameImage";
            this.lblRenameImage.Size = new System.Drawing.Size(118, 21);
            this.lblRenameImage.TabIndex = 12;
            this.lblRenameImage.Text = "Rename image";
            // 
            // lblUploadStatus
            // 
            this.lblUploadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUploadStatus.AutoSize = true;
            this.lblUploadStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadStatus.Location = new System.Drawing.Point(6, 148);
            this.lblUploadStatus.Name = "lblUploadStatus";
            this.lblUploadStatus.Size = new System.Drawing.Size(217, 21);
            this.lblUploadStatus.TabIndex = 11;
            this.lblUploadStatus.Text = "Image convertion status Label";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Location = new System.Drawing.Point(203, 32);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(91, 33);
            this.btnBrowseImage.TabIndex = 10;
            this.btnBrowseImage.Text = "browse";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // tbImageLocation
            // 
            this.tbImageLocation.Location = new System.Drawing.Point(7, 32);
            this.tbImageLocation.Name = "tbImageLocation";
            this.tbImageLocation.Size = new System.Drawing.Size(190, 33);
            this.tbImageLocation.TabIndex = 9;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 681);
            this.Controls.Add(this.gbUploadImage);
            this.Controls.Add(this.picProductImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(lblFormHeader);
            this.Controls.Add(this.pnlItemDetails);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(850, 720);
            this.Name = "frmAddItem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an item";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.pnlItemDetails.ResumeLayout(false);
            this.pnlItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppDBSQLmanageProductCategory)).EndInit();
            this.gbUploadImage.ResumeLayout(false);
            this.gbUploadImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Panel pnlItemDetails;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lblItemDetailsHeader;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbUploadImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox tbImageLocation;
        private System.Windows.Forms.Label lblUploadStatus;
        private System.Windows.Forms.Label lblImageFileExtension;
        private System.Windows.Forms.TextBox tbImageNewName;
        private System.Windows.Forms.Label lblRenameImage;
        private OrderingAppDBSQLmanageProductCategory orderingAppDBSQLmanageProductCategory;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private OrderingAppDBSQLmanageProductCategoryTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}

