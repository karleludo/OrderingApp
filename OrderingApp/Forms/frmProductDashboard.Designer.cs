
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
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.orderingAppDBSQLmanageDataSet = new OrderingApp.OrderingAppDBSQLmanageDataSet();
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
            this.productTableAdapter = new OrderingApp.OrderingAppDBSQLmanageDataSetTableAdapters.ProductTableAdapter();
            this.btnEditSelectedItem = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.productTableDataset_NEW = new OrderingApp.ProductTableDataset_NEW();
            this.productTableAdapter2 = new OrderingApp.ProductTableDataset_NEWTableAdapters.ProductTableAdapter();
            this.productTableAdapter3 = new OrderingApp.OrderingAppProductsTableAdapters.ProductTableAdapter();
            this.panelHeader.SuspendLayout();
            this.panelDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppDBSQLmanageDataSet)).BeginInit();
            this.panelEditItem.SuspendLayout();
            this.gbAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyValue)).BeginInit();
            this.gbEditPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableDataset_NEW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(917, 6);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(221, 57);
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
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1997, 86);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHeader.Location = new System.Drawing.Point(17, 14);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panelDataView.Controls.Add(this.btnRefresh);
            this.panelDataView.Controls.Add(this.dgvItemView);
            this.panelDataView.Controls.Add(this.btnAddItem);
            this.panelDataView.Location = new System.Drawing.Point(17, 91);
            this.panelDataView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(1144, 1095);
            this.panelDataView.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(779, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 57);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvItemView
            // 
            this.dgvItemView.AllowUserToAddRows = false;
            this.dgvItemView.AllowUserToDeleteRows = false;
            this.dgvItemView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvItemView.Location = new System.Drawing.Point(7, 70);
            this.dgvItemView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItemView.MultiSelect = false;
            this.dgvItemView.Name = "dgvItemView";
            this.dgvItemView.ReadOnly = true;
            this.dgvItemView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemView.Size = new System.Drawing.Size(1132, 1022);
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
            // orderingAppDBSQLmanageDataSet
            // 
            this.orderingAppDBSQLmanageDataSet.DataSetName = "OrderingAppDBSQLmanageDataSet";
            this.orderingAppDBSQLmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panelEditItem.Location = new System.Drawing.Point(1169, 137);
            this.panelEditItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditItem.Name = "panelEditItem";
            this.panelEditItem.Size = new System.Drawing.Size(809, 839);
            this.panelEditItem.TabIndex = 4;
            // 
            // lblAvailNote
            // 
            this.lblAvailNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailNote.Location = new System.Drawing.Point(563, 498);
            this.lblAvailNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailNote.Name = "lblAvailNote";
            this.lblAvailNote.Size = new System.Drawing.Size(232, 198);
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
            this.gbAvailability.Location = new System.Drawing.Point(12, 485);
            this.gbAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAvailability.Size = new System.Drawing.Size(532, 212);
            this.gbAvailability.TabIndex = 17;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Availability";
            // 
            // nudModifyValue
            // 
            this.nudModifyValue.Location = new System.Drawing.Point(321, 126);
            this.nudModifyValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudModifyValue.Name = "nudModifyValue";
            this.nudModifyValue.Size = new System.Drawing.Size(160, 29);
            this.nudModifyValue.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "by";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(25, 48);
            this.lblStockAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(118, 21);
            this.lblStockAmount.TabIndex = 17;
            this.lblStockAmount.Text = "Stock Amount:";
            // 
            // cbInStock
            // 
            this.cbInStock.AutoSize = true;
            this.cbInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInStock.Location = new System.Drawing.Point(361, 47);
            this.cbInStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInStock.Name = "cbInStock";
            this.cbInStock.Size = new System.Drawing.Size(83, 25);
            this.cbInStock.TabIndex = 16;
            this.cbInStock.Text = "in Stock";
            this.cbInStock.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseStock
            // 
            this.btnDecreaseStock.Location = new System.Drawing.Point(128, 146);
            this.btnDecreaseStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecreaseStock.Name = "btnDecreaseStock";
            this.btnDecreaseStock.Size = new System.Drawing.Size(129, 48);
            this.btnDecreaseStock.TabIndex = 11;
            this.btnDecreaseStock.Text = "decrease";
            this.btnDecreaseStock.UseVisualStyleBackColor = true;
            this.btnDecreaseStock.Click += new System.EventHandler(this.btnDecreaseStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(128, 90);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(129, 49);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tbStockAmount
            // 
            this.tbStockAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockAmount.Location = new System.Drawing.Point(191, 34);
            this.tbStockAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStockAmount.MaxLength = 4;
            this.tbStockAmount.Name = "tbStockAmount";
            this.tbStockAmount.ReadOnly = true;
            this.tbStockAmount.Size = new System.Drawing.Size(132, 39);
            this.tbStockAmount.TabIndex = 9;
            this.tbStockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStockAmount.TextChanged += new System.EventHandler(this.tbStockAmount_TextChanged);
            // 
            // gbEditPrice
            // 
            this.gbEditPrice.Controls.Add(this.lblCurSign);
            this.gbEditPrice.Controls.Add(this.tbPrice);
            this.gbEditPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditPrice.Location = new System.Drawing.Point(12, 704);
            this.gbEditPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEditPrice.Name = "gbEditPrice";
            this.gbEditPrice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEditPrice.Size = new System.Drawing.Size(532, 117);
            this.gbEditPrice.TabIndex = 15;
            this.gbEditPrice.TabStop = false;
            this.gbEditPrice.Text = "Edit Price:";
            // 
            // lblCurSign
            // 
            this.lblCurSign.AutoSize = true;
            this.lblCurSign.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurSign.Location = new System.Drawing.Point(23, 46);
            this.lblCurSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurSign.Name = "lblCurSign";
            this.lblCurSign.Size = new System.Drawing.Size(30, 32);
            this.lblCurSign.TabIndex = 1;
            this.lblCurSign.Text = "P";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(64, 46);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(416, 39);
            this.tbPrice.TabIndex = 0;
            // 
            // lblImageStatus
            // 
            this.lblImageStatus.AutoSize = true;
            this.lblImageStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageStatus.Location = new System.Drawing.Point(609, 87);
            this.lblImageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageStatus.Name = "lblImageStatus";
            this.lblImageStatus.Size = new System.Drawing.Size(130, 20);
            this.lblImageStatus.TabIndex = 11;
            this.lblImageStatus.Text = "image status label";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Enabled = false;
            this.btnChangeImage.Location = new System.Drawing.Point(333, 73);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(267, 48);
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
            this.pBoxProductImage.Location = new System.Drawing.Point(12, 73);
            this.pBoxProductImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxProductImage.Name = "pBoxProductImage";
            this.pBoxProductImage.Size = new System.Drawing.Size(301, 393);
            this.pBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxProductImage.TabIndex = 7;
            this.pBoxProductImage.TabStop = false;
            this.pBoxProductImage.WaitOnLoad = true;
            // 
            // tbEditProductName
            // 
            this.tbEditProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditProductName.Location = new System.Drawing.Point(333, 185);
            this.tbEditProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEditProductName.Name = "tbEditProductName";
            this.tbEditProductName.ReadOnly = true;
            this.tbEditProductName.Size = new System.Drawing.Size(460, 29);
            this.tbEditProductName.TabIndex = 6;
            // 
            // rtbEditProductDescription
            // 
            this.rtbEditProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditProductDescription.Location = new System.Drawing.Point(333, 265);
            this.rtbEditProductDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbEditProductDescription.Name = "rtbEditProductDescription";
            this.rtbEditProductDescription.ReadOnly = true;
            this.rtbEditProductDescription.Size = new System.Drawing.Size(460, 201);
            this.rtbEditProductDescription.TabIndex = 5;
            this.rtbEditProductDescription.Text = "";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(328, 235);
            this.lblProductDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(154, 21);
            this.lblProductDesc.TabIndex = 4;
            this.lblProductDesc.Text = "Product Description: ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(328, 155);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name: ";
            // 
            // lblSelectedItemId
            // 
            this.lblSelectedItemId.AutoSize = true;
            this.lblSelectedItemId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItemId.Location = new System.Drawing.Point(131, 44);
            this.lblSelectedItemId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedItemId.Name = "lblSelectedItemId";
            this.lblSelectedItemId.Size = new System.Drawing.Size(21, 20);
            this.lblSelectedItemId.TabIndex = 2;
            this.lblSelectedItemId.Text = "...";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(7, 43);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(90, 21);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Product ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Product Details: ";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditSelectedItem
            // 
            this.btnEditSelectedItem.Location = new System.Drawing.Point(1169, 92);
            this.btnEditSelectedItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditSelectedItem.Name = "btnEditSelectedItem";
            this.btnEditSelectedItem.Size = new System.Drawing.Size(336, 37);
            this.btnEditSelectedItem.TabIndex = 5;
            this.btnEditSelectedItem.Text = "Edit selected Item";
            this.btnEditSelectedItem.UseVisualStyleBackColor = true;
            this.btnEditSelectedItem.Click += new System.EventHandler(this.btnEditSelectedItem_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(1576, 998);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(403, 70);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelChanges.Enabled = false;
            this.btnCancelChanges.Location = new System.Drawing.Point(1732, 1076);
            this.btnCancelChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(247, 52);
            this.btnCancelChanges.TabIndex = 7;
            this.btnCancelChanges.Text = "Cancel";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelectedItem.Enabled = false;
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(1376, 998);
            this.btnDeleteSelectedItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(192, 70);
            this.btnDeleteSelectedItem.TabIndex = 8;
            this.btnDeleteSelectedItem.Text = "Delete selected Item";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.btnDeleteSelectedItem_Click);
            // 
            // productTableDataset_NEW
            // 
            this.productTableDataset_NEW.DataSetName = "ProductTableDataset_NEW";
            this.productTableDataset_NEW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // productTableAdapter3
            // 
            this.productTableAdapter3.ClearBeforeFill = true;
            // 
            // frmProductDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnDeleteSelectedItem);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnEditSelectedItem);
            this.Controls.Add(this.panelEditItem);
            this.Controls.Add(this.panelDataView);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.orderingAppDBSQLmanageDataSet)).EndInit();
            this.panelEditItem.ResumeLayout(false);
            this.panelEditItem.PerformLayout();
            this.gbAvailability.ResumeLayout(false);
            this.gbAvailability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyValue)).EndInit();
            this.gbEditPrice.ResumeLayout(false);
            this.gbEditPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableDataset_NEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelDataView;
        private System.Windows.Forms.DataGridView dgvItemView;
        private System.Windows.Forms.Panel panelEditItem;
        private OrderingAppDBSQLmanageDataSet orderingAppDBSQLmanageDataSet;
        private OrderingAppDBSQLmanageDataSetTableAdapters.ProductTableAdapter productTableAdapter;
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
        private ProductTableDataset_NEW productTableDataset_NEW;
        private ProductTableDataset_NEWTableAdapters.ProductTableAdapter productTableAdapter2;
        private OrderingAppProducts orderingAppProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private OrderingAppProductsTableAdapters.ProductTableAdapter productTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStock;
        private System.Windows.Forms.DataGridViewImageColumn ImageByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}