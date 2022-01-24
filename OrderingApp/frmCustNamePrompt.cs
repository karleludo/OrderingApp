using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class frmCustNamePrompt : Form
    {
        public frmCustNamePrompt()
        {
            InitializeComponent();
        }

        private void frmCustNamePrompt_Load(object sender, EventArgs e)
        {
           
        }
        public string CustName { get; private set; }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isValidTextBox()) 
            {
                this.CustName = tbCustName.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            
            Close();
        }
        private bool isValidTextBox() 
        {
            if (tbCustName.Text.Length <= 0)
            {
                return false;
            }
            else
            {
                btnAccept.Enabled = true;
                return true;
            }
        }

        private void tbCustName_TextChanged(object sender, EventArgs e)
        {
            isValidTextBox();
        }
    }
}
