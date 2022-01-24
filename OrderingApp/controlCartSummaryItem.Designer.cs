
namespace OrderingApp
{
    partial class controlCartSummaryItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblQtyValue = new System.Windows.Forms.Label();
            this.lblCurSign = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(182, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQty.Location = new System.Drawing.Point(238, 9);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(42, 21);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "Qty: ";
            // 
            // lblQtyValue
            // 
            this.lblQtyValue.AutoSize = true;
            this.lblQtyValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyValue.Location = new System.Drawing.Point(286, 9);
            this.lblQtyValue.Name = "lblQtyValue";
            this.lblQtyValue.Size = new System.Drawing.Size(22, 21);
            this.lblQtyValue.TabIndex = 2;
            this.lblQtyValue.Text = "Q";
            // 
            // lblCurSign
            // 
            this.lblCurSign.AutoSize = true;
            this.lblCurSign.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurSign.Location = new System.Drawing.Point(346, 9);
            this.lblCurSign.Name = "lblCurSign";
            this.lblCurSign.Size = new System.Drawing.Size(19, 21);
            this.lblCurSign.TabIndex = 3;
            this.lblCurSign.Text = "P";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtotalValue.Location = new System.Drawing.Point(371, 9);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(58, 21);
            this.lblSubtotalValue.TabIndex = 4;
            this.lblSubtotalValue.Text = "000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "---";
            // 
            // controlCartSummaryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblCurSign);
            this.Controls.Add(this.lblQtyValue);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblName);
            this.Name = "controlCartSummaryItem";
            this.Size = new System.Drawing.Size(450, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblQtyValue;
        private System.Windows.Forms.Label lblCurSign;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label label1;
    }
}
