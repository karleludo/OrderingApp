using System;
using System.Windows.Forms;

namespace OrderingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Initialize the database connections
            GlobalConfig.InitializeConnections();

            Application.Run(new frmStartPage());

            //Application.Run(new frmProductDashboard());
            //Application.Run(new frmOrderPage());
        }
    }
}
