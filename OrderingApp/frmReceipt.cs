using OrderingApp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace OrderingApp
{
    public partial class frmReceipt : Form
    {

        OrderModel _orders;
        DataTable _list;
        BindingSource _OrderLineViewBS = new BindingSource();
        
        public frmReceipt(OrderModel orders, DataTable list, BindingSource tempo)
        {
            _orders = orders;
            _list = list;
            _OrderLineViewBS = tempo;
            InitializeComponent();
            
            //generate receipt from database query

            //print receipt, either a picture or a text file
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

            LoadReport();
            
        }

        private void LoadReport() 
        {
            ReportDataSource source = new ReportDataSource("OrderLineViewSP", _list);
            this.rvReceipt.LocalReport.DataSources.Clear();
            this.rvReceipt.LocalReport.DataSources.Add(source);
            this.rvReceipt.RefreshReport();

            _orders.OrderDate = _orders.OrderDate.ToLocalTime();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Order_OrderId", _orders.OrderId.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Order_CustomerName", _orders.CustomerName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Order_OrderDate", _orders.OrderDate.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("OrderTotalPrice", _orders.OrderTotalPrice.ToString()),

            };
            this.rvReceipt.LocalReport.SetParameters(p);
            this.rvReceipt.RefreshReport();
            rvReceipt.SetDisplayMode(DisplayMode.PrintLayout);
            rvReceipt.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmStartPage startpage = new frmStartPage();
            startpage.Show();
        }
    }
}
