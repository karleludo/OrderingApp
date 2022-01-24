using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingApp
{
    public static class GlobalConfig
    {
        public static DataAccess.IDataConnection Connection { get; private set; }
        public static void InitializeConnections() 
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;

        }
        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
