
namespace OrderingApp
{
    partial class frmOrderPage
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
            this.flpProductShelf = new System.Windows.Forms.FlowLayoutPanel();
            this.flpShoppingCart = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblCartHeader = new System.Windows.Forms.Label();
            this.lblCartSummaryHeader = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblSummaryCurSign = new System.Windows.Forms.Label();
            this.lblDiscountShow = new System.Windows.Forms.Label();
            this.lblTaxShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductShelf
            // 
            this.flpProductShelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpProductShelf.AutoScroll = true;
            this.flpProductShelf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpProductShelf.Location = new System.Drawing.Point(11, 88);
            this.flpProductShelf.Margin = new System.Windows.Forms.Padding(5);
            this.flpProductShelf.MinimumSize = new System.Drawing.Size(1000, 699);
            this.flpProductShelf.Name = "flpProductShelf";
            this.flpProductShelf.Padding = new System.Windows.Forms.Padding(3);
            this.flpProductShelf.Size = new System.Drawing.Size(1000, 753);
            this.flpProductShelf.TabIndex = 0;
            // 
            // flpShoppingCart
            // 
            this.flpShoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpShoppingCart.AutoScroll = true;
            this.flpShoppingCart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpShoppingCart.Location = new System.Drawing.Point(1019, 121);
            this.flpShoppingCart.MinimumSize = new System.Drawing.Size(425, 500);
            this.flpShoppingCart.Name = "flpShoppingCart";
            this.flpShoppingCart.Size = new System.Drawing.Size(425, 500);
            this.flpShoppingCart.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.Location = new System.Drawing.Point(1019, 789);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(424, 54);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblCartHeader
            // 
            this.lblCartHeader.AutoSize = true;
            this.lblCartHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartHeader.Location = new System.Drawing.Point(1021, 88);
            this.lblCartHeader.Name = "lblCartHeader";
            this.lblCartHeader.Size = new System.Drawing.Size(156, 30);
            this.lblCartHeader.TabIndex = 3;
            this.lblCartHeader.Text = "Shopping Cart";
            // 
            // lblCartSummaryHeader
            // 
            this.lblCartSummaryHeader.AutoSize = true;
            this.lblCartSummaryHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartSummaryHeader.Location = new System.Drawing.Point(1021, 624);
            this.lblCartSummaryHeader.Name = "lblCartSummaryHeader";
            this.lblCartSummaryHeader.Size = new System.Drawing.Size(141, 25);
            this.lblCartSummaryHeader.TabIndex = 4;
            this.lblCartSummaryHeader.Text = "Cart Summary";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(1022, 668);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(80, 21);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValue.Location = new System.Drawing.Point(1368, 668);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(67, 21);
            this.lblSubtotalValue.TabIndex = 6;
            this.lblSubtotalValue.Text = "0";
            this.lblSubtotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1022, 743);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total: ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTax.Location = new System.Drawing.Point(1022, 710);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(37, 21);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(1022, 689);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(82, 21);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discount: ";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(1368, 689);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(67, 21);
            this.lblDiscountValue.TabIndex = 10;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxValue.Location = new System.Drawing.Point(1368, 710);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(67, 21);
            this.lblTaxValue.TabIndex = 11;
            this.lblTaxValue.Text = "0";
            this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(1368, 743);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(67, 21);
            this.lblTotalValue.TabIndex = 12;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSummaryCurSign
            // 
            this.lblSummaryCurSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryCurSign.AutoSize = true;
            this.lblSummaryCurSign.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryCurSign.Location = new System.Drawing.Point(1338, 740);
            this.lblSummaryCurSign.Name = "lblSummaryCurSign";
            this.lblSummaryCurSign.Size = new System.Drawing.Size(24, 25);
            this.lblSummaryCurSign.TabIndex = 13;
            this.lblSummaryCurSign.Text = "P";
            // 
            // lblDiscountShow
            // 
            this.lblDiscountShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountShow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiscountShow.Location = new System.Drawing.Point(1110, 689);
            this.lblDiscountShow.Name = "lblDiscountShow";
            this.lblDiscountShow.Size = new System.Drawing.Size(67, 21);
            this.lblDiscountShow.TabIndex = 15;
            this.lblDiscountShow.Text = "0";
            this.lblDiscountShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxShow
            // 
            this.lblTaxShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxShow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTaxShow.Location = new System.Drawing.Point(1110, 710);
            this.lblTaxShow.Name = "lblTaxShow";
            this.lblTaxShow.Size = new System.Drawing.Size(67, 21);
            this.lblTaxShow.TabIndex = 16;
            this.lblTaxShow.Text = "0";
            this.lblTaxShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1241, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1241, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1241, 743);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Gold;
            this.pnlHeader.Controls.Add(this.lblGreetings);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1431, 68);
            this.pnlHeader.TabIndex = 20;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGreetings.Location = new System.Drawing.Point(3, 27);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(192, 32);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "placeholder text";
            // 
            // frmOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 855);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTaxShow);
            this.Controls.Add(this.lblDiscountShow);
            this.Controls.Add(this.lblSummaryCurSign);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTaxValue);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.flpShoppingCart);
            this.Controls.Add(this.lblCartSummaryHeader);
            this.Controls.Add(this.lblCartHeader);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.flpProductShelf);
            this.MinimumSize = new System.Drawing.Size(1443, 894);
            this.Name = "frmOrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductShelf;
        private System.Windows.Forms.FlowLayoutPanel flpShoppingCart;
        private System.Windows.Forms.Button btnCheckout;
        
        private System.Windows.Forms.Label lblCartHeader;
        private System.Windows.Forms.Label lblCartSummaryHeader;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblSummaryCurSign;
        private System.Windows.Forms.Label lblDiscountShow;
        private System.Windows.Forms.Label lblTaxShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblGreetings;
    }
}