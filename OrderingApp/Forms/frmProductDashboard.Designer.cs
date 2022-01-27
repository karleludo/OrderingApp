
namespace OrderingApp
{
    partial class frmProductDashboard
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelDataView = new System.Windows.Forms.Panel();
            this.dgvItemView = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImageByte = new System.Windows.Forms.DataGridViewImageColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderingAppProducts = new OrderingApp.OrderingAppProducts();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelEditItem = new System.Windows.Forms.Panel();
            this.lblAvailNote = new System.Windows.Forms.Label();
            this.gbAvailability = new System.Windows.Forms.GroupBox();
            this.nudModifyValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.cbInStock = new System.Windows.Forms.CheckBox();
            this.btnDecreaseStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbStockAmount = new System.Windows.Forms.TextBox();
            this.gbEditPrice = new System.Windows.Forms.GroupBox();
            this.lblCurSign = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblImageStatus = new System.Windows.Forms.Label();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.pBoxProductImage = new System.Windows.Forms.PictureBox();
            this.tbEditProductName = new System.Windows.Forms.TextBox();
            this.rtbEditProductDescription = new System.Windows.Forms.RichTextBox();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSelectedItemId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditSelectedItem = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.productTableAdapter = new OrderingApp.OrderingAppProductsTableAdapters.ProductTableAdapter();
            this.panelHeader.SuspendLayout();
            this.panelDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppProducts)).BeginInit();
            this.panelEditItem.SuspendLayout();
            this.gbAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyValue)).BeginInit();
            this.gbEditPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(704, 75);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(166, 46);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add an item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Goldenrod;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Location = new System.Drawing.Point(-1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1563, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHeader.Location = new System.Drawing.Point(13, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(205, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Product Manager";
            // 
            // panelDataView
            // 
            this.panelDataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDataView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDataView.Controls.Add(this.dgvItemView);
            this.panelDataView.Location = new System.Drawing.Point(12, 127);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(858, 833);
            this.panelDataView.TabIndex = 3;
            // 
            // dgvItemView
            // 
            this.dgvItemView.AllowUserToAddRows = false;
            this.dgvItemView.AllowUserToDeleteRows = false;
            this.dgvItemView.AutoGenerateColumns = false;
            this.dgvItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.inStock,
            this.ImageByte,
            this.Price});
            this.dgvItemView.DataSource = this.productBindingSource;
            this.dgvItemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemView.Location = new System.Drawing.Point(0, 0);
            this.dgvItemView.MultiSelect = false;
            this.dgvItemView.Name = "dgvItemView";
            this.dgvItemView.ReadOnly = true;
            this.dgvItemView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemView.Size = new System.Drawing.Size(858, 833);
            this.dgvItemView.TabIndex = 3;
            this.dgvItemView.SelectionChanged += new System.EventHandler(this.dgvItemView_SelectionChanged);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.DataPropertyName = "inStock";
            this.inStock.HeaderText = "inStock";
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // ImageByte
            // 
            this.ImageByte.DataPropertyName = "ImageByte";
            this.ImageByte.HeaderText = "ImageByte";
            this.ImageByte.Name = "ImageByte";
            this.ImageByte.ReadOnly = true;
            this.ImageByte.Visible = false;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "UnitPrice";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.orderingAppProducts;
            // 
            // orderingAppProducts
            // 
            this.orderingAppProducts.DataSetName = "OrderingAppProducts";
            this.orderingAppProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(600, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelEditItem
            // 
            this.panelEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditItem.BackColor = System.Drawing.Color.Silver;
            this.panelEditItem.Controls.Add(this.lblAvailNote);
            this.panelEditItem.Controls.Add(this.gbAvailability);
            this.panelEditItem.Controls.Add(this.gbEditPrice);
            this.panelEditItem.Controls.Add(this.lblImageStatus);
            this.panelEditItem.Controls.Add(this.btnChangeImage);
            this.panelEditItem.Controls.Add(this.pBoxProductImage);
            this.panelEditItem.Controls.Add(this.tbEditProductName);
            this.panelEditItem.Controls.Add(this.rtbEditProductDescription);
            this.panelEditItem.Controls.Add(this.lblProductDesc);
            this.panelEditItem.Controls.Add(this.lblProductName);
            this.panelEditItem.Controls.Add(this.lblSelectedItemId);
            this.panelEditItem.Controls.Add(this.lblProductId);
            this.panelEditItem.Controls.Add(this.label1);
            this.panelEditItem.Location = new System.Drawing.Point(877, 111);
            this.panelEditItem.Name = "panelEditItem";
            this.panelEditItem.Size = new System.Drawing.Size(629, 682);
            this.panelEditItem.TabIndex = 4;
            // 
            // lblAvailNote
            // 
            this.lblAvailNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailNote.Location = new System.Drawing.Point(419, 405);
            this.lblAvailNote.Name = "lblAvailNote";
            this.lblAvailNote.Size = new System.Drawing.Size(157, 161);
            this.lblAvailNote.TabIndex = 18;
            this.lblAvailNote.Text = "note: disabling the \r\n\"in Stock\" flag will make the item \"unavailable\" but the st" +
    "ock quantity remains.";
            // 
            // gbAvailability
            // 
            this.gbAvailability.Controls.Add(this.nudModifyValue);
            this.gbAvailability.Controls.Add(this.label7);
            this.gbAvailability.Controls.Add(this.lblStockAmount);
            this.gbAvailability.Controls.Add(this.cbInStock);
            this.gbAvailability.Controls.Add(this.btnDecreaseStock);
            this.gbAvailability.Controls.Add(this.btnAddStock);
            this.gbAvailability.Controls.Add(this.tbStockAmount);
            this.gbAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailability.Location = new System.Drawing.Point(9, 394);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(399, 172);
            this.gbAvailability.TabIndex = 17;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Availability";
            // 
            // nudModifyValue
            // 
            this.nudModifyValue.Location = new System.Drawing.Point(241, 102);
            this.nudModifyValue.Name = "nudModifyValue";
            this.nudModifyValue.Size = new System.Drawing.Size(120, 29);
            this.nudModifyValue.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "by";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(19, 39);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(118, 21);
            this.lblStockAmount.TabIndex = 17;
            this.lblStockAmount.Text = "Stock Amount:";
            // 
            // cbInStock
            // 
            this.cbInStock.AutoSize = true;
            this.cbInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInStock.Location = new System.Drawing.Point(271, 38);
            this.cbInStock.Name = "cbInStock";
            this.cbInStock.Size = new System.Drawing.Size(83, 25);
            this.cbInStock.TabIndex = 16;
            this.cbInStock.Text = "in Stock";
            this.cbInStock.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseStock
            // 
            this.btnDecreaseStock.Location = new System.Drawing.Point(96, 119);
            this.btnDecreaseStock.Name = "btnDecreaseStock";
            this.btnDecreaseStock.Size = new System.Drawing.Size(97, 39);
            this.btnDecreaseStock.TabIndex = 11;
            this.btnDecreaseStock.Text = "decrease";
            this.btnDecreaseStock.UseVisualStyleBackColor = true;
            this.btnDecreaseStock.Click += new System.EventHandler(this.btnDecreaseStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(96, 73);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(97, 40);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tbStockAmount
            // 
            this.tbStockAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockAmount.Location = new System.Drawing.Point(143, 28);
            this.tbStockAmount.MaxLength = 4;
            this.tbStockAmount.Name = "tbStockAmount";
            this.tbStockAmount.ReadOnly = true;
            this.tbStockAmount.Size = new System.Drawing.Size(100, 39);
            this.tbStockAmount.TabIndex = 9;
            this.tbStockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStockAmount.TextChanged += new System.EventHandler(this.tbStockAmount_TextChanged);
            // 
            // gbEditPrice
            // 
            this.gbEditPrice.Controls.Add(this.lblCurSign);
            this.gbEditPrice.Controls.Add(this.tbPrice);
            this.gbEditPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditPrice.Location = new System.Drawing.Point(9, 572);
            this.gbEditPrice.Name = "gbEditPrice";
            this.gbEditPrice.Size = new System.Drawing.Size(399, 95);
            this.gbEditPrice.TabIndex = 15;
            this.gbEditPrice.TabStop = false;
            this.gbEditPrice.Text = "Edit Price:";
            // 
            // lblCurSign
            // 
            this.lblCurSign.AutoSize = true;
            this.lblCurSign.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurSign.Location = new System.Drawing.Point(17, 37);
            this.lblCurSign.Name = "lblCurSign";
            this.lblCurSign.Size = new System.Drawing.Size(30, 32);
            this.lblCurSign.TabIndex = 1;
            this.lblCurSign.Text = "P";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(48, 37);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(313, 39);
            this.tbPrice.TabIndex = 0;
            // 
            // lblImageStatus
            // 
            this.lblImageStatus.AutoSize = true;
            this.lblImageStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageStatus.Location = new System.Drawing.Point(457, 71);
            this.lblImageStatus.Name = "lblImageStatus";
            this.lblImageStatus.Size = new System.Drawing.Size(130, 20);
            this.lblImageStatus.TabIndex = 11;
            this.lblImageStatus.Text = "image status label";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Enabled = false;
            this.btnChangeImage.Location = new System.Drawing.Point(250, 59);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(200, 39);
            this.btnChangeImage.TabIndex = 10;
            this.btnChangeImage.Text = "Change Product Image";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // pBoxProductImage
            // 
            this.pBoxProductImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pBoxProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxProductImage.ErrorImage = global::OrderingApp.Properties.Resources.imageDefault;
            this.pBoxProductImage.Image = global::OrderingApp.Properties.Resources.imageDefault;
            this.pBoxProductImage.InitialImage = global::OrderingApp.Properties.Resources.imageDefault;
            this.pBoxProductImage.Location = new System.Drawing.Point(9, 59);
            this.pBoxProductImage.Name = "pBoxProductImage";
            this.pBoxProductImage.Size = new System.Drawing.Size(227, 320);
            this.pBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxProductImage.TabIndex = 7;
            this.pBoxProductImage.TabStop = false;
            this.pBoxProductImage.WaitOnLoad = true;
            // 
            // tbEditProductName
            // 
            this.tbEditProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditProductName.Location = new System.Drawing.Point(250, 150);
            this.tbEditProductName.Name = "tbEditProductName";
            this.tbEditProductName.ReadOnly = true;
            this.tbEditProductName.Size = new System.Drawing.Size(369, 29);
            this.tbEditProductName.TabIndex = 6;
            // 
            // rtbEditProductDescription
            // 
            this.rtbEditProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditProductDescription.Location = new System.Drawing.Point(250, 215);
            this.rtbEditProductDescription.Name = "rtbEditProductDescription";
            this.rtbEditProductDescription.ReadOnly = true;
            this.rtbEditProductDescription.Size = new System.Drawing.Size(369, 164);
            this.rtbEditProductDescription.TabIndex = 5;
            this.rtbEditProductDescription.Text = "";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(246, 191);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(154, 21);
            this.lblProductDesc.TabIndex = 4;
            this.lblProductDesc.Text = "Product Description: ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(246, 126);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name: ";
            // 
            // lblSelectedItemId
            // 
            this.lblSelectedItemId.AutoSize = true;
            this.lblSelectedItemId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItemId.Location = new System.Drawing.Point(98, 36);
            this.lblSelectedItemId.Name = "lblSelectedItemId";
            this.lblSelectedItemId.Size = new System.Drawing.Size(21, 20);
            this.lblSelectedItemId.TabIndex = 2;
            this.lblSelectedItemId.Text = "...";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(5, 35);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(90, 21);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Product ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Product Details: ";
            // 
            // btnEditSelectedItem
            // 
            this.btnEditSelectedItem.Location = new System.Drawing.Point(877, 75);
            this.btnEditSelectedItem.Name = "btnEditSelectedItem";
            this.btnEditSelectedItem.Size = new System.Drawing.Size(252, 30);
            this.btnEditSelectedItem.TabIndex = 5;
            this.btnEditSelectedItem.Text = "Edit selected Item";
            this.btnEditSelectedItem.UseVisualStyleBackColor = true;
            this.btnEditSelectedItem.Click += new System.EventHandler(this.btnEditSelectedItem_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(1204, 799);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(302, 57);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelChanges.Enabled = false;
            this.btnCancelChanges.Location = new System.Drawing.Point(1321, 862);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(185, 42);
            this.btnCancelChanges.TabIndex = 7;
            this.btnCancelChanges.Text = "Cancel";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelectedItem.Enabled = false;
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(1047, 799);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(144, 57);
            this.btnDeleteSelectedItem.TabIndex = 8;
            this.btnDeleteSelectedItem.Text = "Delete selected Item";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.btnDeleteSelectedItem_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 972);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSelectedItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.panelDataView);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEditSelectedItem);
            this.Controls.Add(this.panelEditItem);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmProductDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Product Dashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppProducts)).EndInit();
            this.panelEditItem.ResumeLayout(false);
            this.panelEditItem.PerformLayout();
            this.gbAvailability.ResumeLayout(false);
            this.gbAvailability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyValue)).EndInit();
            this.gbEditPrice.ResumeLayout(false);
            this.gbEditPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelDataView;
        private System.Windows.Forms.DataGridView dgvItemView;
        private System.Windows.Forms.Panel panelEditItem;
        private System.Windows.Forms.TextBox tbEditProductName;
        private System.Windows.Forms.RichTextBox rtbEditProductDescription;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSelectedItemId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxProductImage;
        private System.Windows.Forms.Button btnEditSelectedItem;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.Label lblImageStatus;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnDeleteSelectedItem;
        private System.Windows.Forms.GroupBox gbEditPrice;
        private System.Windows.Forms.Label lblAvailNote;
        private System.Windows.Forms.GroupBox gbAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.CheckBox cbInStock;
        private System.Windows.Forms.Button btnDecreaseStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox tbStockAmount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown nudModifyValue;
        private System.Windows.Forms.Label lblCurSign;
        private System.Windows.Forms.TextBox tbPrice;
        private OrderingAppProducts orderingAppProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStock;
        private System.Windows.Forms.DataGridViewImageColumn ImageByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private OrderingAppProductsTableAdapters.ProductTableAdapter productTableAdapter;
    }
}