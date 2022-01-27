using System;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class frmStartPage : Form
    {
        public frmStartPage()
        {
            InitializeComponent();
            pbPageHero.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCta_Click(object sender, EventArgs e)
        {
            frmOrderPage orderpage = new frmOrderPage();
            orderpage.Show();
            this.Hide();
        }

        private void linkAdminPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProductDashboard dashboard = new frmProductDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnAdminPage_Click(object sender, EventArgs e)
        {
            frmProductDashboard productdashboard = new frmProductDashboard();
            productdashboard.Show();
            this.Hide();
        }
    }
}
