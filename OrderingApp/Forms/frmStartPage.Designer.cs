
namespace OrderingApp
{
    partial class frmStartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartPage));
            this.pnlMainHeader = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOrderingApp = new System.Windows.Forms.Label();
            this.btnCta = new System.Windows.Forms.Button();
            this.linkAdminPage = new System.Windows.Forms.LinkLabel();
            this.pbPageHero = new System.Windows.Forms.PictureBox();
            this.pnlMainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPageHero)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainHeader
            // 
            this.pnlMainHeader.BackColor = System.Drawing.Color.Gold;
            this.pnlMainHeader.Controls.Add(this.lblDescription);
            this.pnlMainHeader.Controls.Add(this.lblOrderingApp);
            this.pnlMainHeader.Location = new System.Drawing.Point(414, 0);
            this.pnlMainHeader.Name = "pnlMainHeader";
            this.pnlMainHeader.Size = new System.Drawing.Size(386, 310);
            this.pnlMainHeader.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(63, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(270, 177);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOrderingApp
            // 
            this.lblOrderingApp.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderingApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderingApp.Location = new System.Drawing.Point(3, 0);
            this.lblOrderingApp.Name = "lblOrderingApp";
            this.lblOrderingApp.Size = new System.Drawing.Size(380, 103);
            this.lblOrderingApp.TabIndex = 0;
            this.lblOrderingApp.Text = "OrderingApp";
            this.lblOrderingApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCta
            // 
            this.btnCta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCta.Location = new System.Drawing.Point(414, 316);
            this.btnCta.Name = "btnCta";
            this.btnCta.Size = new System.Drawing.Size(383, 64);
            this.btnCta.TabIndex = 2;
            this.btnCta.Text = "Order Now!";
            this.btnCta.UseVisualStyleBackColor = true;
            this.btnCta.Click += new System.EventHandler(this.btnCta_Click);
            // 
            // linkAdminPage
            // 
            this.linkAdminPage.AutoSize = true;
            this.linkAdminPage.LinkColor = System.Drawing.Color.Gold;
            this.linkAdminPage.Location = new System.Drawing.Point(721, 562);
            this.linkAdminPage.Name = "linkAdminPage";
            this.linkAdminPage.Size = new System.Drawing.Size(67, 13);
            this.linkAdminPage.TabIndex = 3;
            this.linkAdminPage.TabStop = true;
            this.linkAdminPage.Text = "Administrator";
            this.linkAdminPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdminPage_LinkClicked);
            // 
            // pbPageHero
            // 
            this.pbPageHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPageHero.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPageHero.Image = ((System.Drawing.Image)(resources.GetObject("pbPageHero.Image")));
            this.pbPageHero.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPageHero.InitialImage")));
            this.pbPageHero.Location = new System.Drawing.Point(0, 0);
            this.pbPageHero.Name = "pbPageHero";
            this.pbPageHero.Size = new System.Drawing.Size(411, 584);
            this.pbPageHero.TabIndex = 0;
            this.pbPageHero.TabStop = false;
            // 
            // frmStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.linkAdminPage);
            this.Controls.Add(this.btnCta);
            this.Controls.Add(this.pnlMainHeader);
            this.Controls.Add(this.pbPageHero);
            this.Name = "frmStartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordering App";
            this.pnlMainHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPageHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPageHero;
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOrderingApp;
        private System.Windows.Forms.Button btnCta;
        private System.Windows.Forms.LinkLabel linkAdminPage;
    }
}