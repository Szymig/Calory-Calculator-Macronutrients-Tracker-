using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaloryCalculatorLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Connection to data
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databaseType">Type of databes with will be used by application</param>
        public static void InitializeConnection(DatabaseType databaseType)
        {
            SQLConnection con = new SQLConnection();
            Connection = con;
        }

        /// <summary>
        /// Gets the dataase connection string using Configuration Manager
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Database connection string</returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
