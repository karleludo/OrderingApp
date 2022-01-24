
namespace OrderingApp
{
    partial class frmReceipt
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.rvReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(300, 466);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(176, 74);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pnlViewer
            // 
            this.pnlViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewer.Controls.Add(this.rvReceipt);
            this.pnlViewer.Location = new System.Drawing.Point(1, 3);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(774, 457);
            this.pnlViewer.TabIndex = 1;
            // 
            // rvReceipt
            // 
            this.rvReceipt.AutoScroll = true;
            this.rvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvReceipt.LocalReport.ReportEmbeddedResource = "OrderingApp.TransactionReport.rdlc";
            this.rvReceipt.Location = new System.Drawing.Point(0, 0);
            this.rvReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.rvReceipt.Name = "rvReceipt";
            this.rvReceipt.ServerReport.BearerToken = null;
            this.rvReceipt.Size = new System.Drawing.Size(774, 457);
            this.rvReceipt.TabIndex = 0;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 552);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.btnAccept);
            this.MinimumSize = new System.Drawing.Size(775, 0);
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.pnlViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnlViewer;
        private Microsoft.Reporting.WinForms.ReportViewer rvReceipt;
    }
}