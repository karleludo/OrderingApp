
namespace OrderingApp
{
    partial class frmCheckout
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.flpShoppingCart = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTaxShow = new System.Windows.Forms.Label();
            this.lblDiscountShow = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSummaryCurSign = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flpCartSummary = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 62);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(274, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Your Shopping Cart:";
            // 
            // flpShoppingCart
            // 
            this.flpShoppingCart.AutoScroll = true;
            this.flpShoppingCart.Location = new System.Drawing.Point(19, 102);
            this.flpShoppingCart.Name = "flpShoppingCart";
            this.flpShoppingCart.Size = new System.Drawing.Size(400, 680);
            this.flpShoppingCart.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "+";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "-";
            // 
            // lblTaxShow
            // 
            this.lblTaxShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxShow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTaxShow.Location = new System.Drawing.Point(509, 567);
            this.lblTaxShow.Name = "lblTaxShow";
            this.lblTaxShow.Size = new System.Drawing.Size(35, 21);
            this.lblTaxShow.TabIndex = 30;
            this.lblTaxShow.Text = "0";
            this.lblTaxShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscountShow
            // 
            this.lblDiscountShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountShow.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiscountShow.Location = new System.Drawing.Point(509, 546);
            this.lblDiscountShow.Name = "lblDiscountShow";
            this.lblDiscountShow.Size = new System.Drawing.Size(35, 21);
            this.lblDiscountShow.TabIndex = 29;
            this.lblDiscountShow.Text = "0";
            this.lblDiscountShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxValue.Location = new System.Drawing.Point(831, 568);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(67, 21);
            this.lblTaxValue.TabIndex = 26;
            this.lblTaxValue.Text = "0";
            this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(831, 547);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(67, 21);
            this.lblDiscountValue.TabIndex = 25;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(421, 546);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(82, 21);
            this.lblDiscount.TabIndex = 24;
            this.lblDiscount.Text = "Discount: ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTax.Location = new System.Drawing.Point(421, 567);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(37, 21);
            this.lblTax.TabIndex = 23;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalValue.Location = new System.Drawing.Point(831, 526);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(67, 21);
            this.lblSubtotalValue.TabIndex = 21;
            this.lblSubtotalValue.Text = "0";
            this.lblSubtotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(421, 525);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(80, 21);
            this.lblSubtotal.TabIndex = 20;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shopping Cart Summary";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(593, 616);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(316, 65);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Checkout";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.Color.Gold;
            this.lblGreetings.Location = new System.Drawing.Point(14, 32);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(107, 30);
            this.lblGreetings.TabIndex = 5;
            this.lblGreetings.Text = "Greetings";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "=";
            // 
            // lblSummaryCurSign
            // 
            this.lblSummaryCurSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryCurSign.AutoSize = true;
            this.lblSummaryCurSign.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryCurSign.Location = new System.Drawing.Point(801, 589);
            this.lblSummaryCurSign.Name = "lblSummaryCurSign";
            this.lblSummaryCurSign.Size = new System.Drawing.Size(24, 25);
            this.lblSummaryCurSign.TabIndex = 28;
            this.lblSummaryCurSign.Text = "P";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(831, 592);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(67, 21);
            this.lblTotalValue.TabIndex = 27;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(421, 592);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 21);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(698, 687);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 58);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flpCartSummary
            // 
            this.flpCartSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCartSummary.AutoScroll = true;
            this.flpCartSummary.Location = new System.Drawing.Point(430, 135);
            this.flpCartSummary.Name = "flpCartSummary";
            this.flpCartSummary.Size = new System.Drawing.Size(478, 388);
            this.flpCartSummary.TabIndex = 34;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 789);
            this.Controls.Add(this.flpCartSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTaxShow);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.lblDiscountShow);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTaxValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblSummaryCurSign);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.flpShoppingCart);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTotal);
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flpShoppingCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTaxShow;
        private System.Windows.Forms.Label lblDiscountShow;
        private System.Windows.Forms.Label lblSummaryCurSign;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flpCartSummary;
        private System.Windows.Forms.BindingSource OrderBindingSource;
    }
}