using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace BookQuote
{
    public class SqliteAccess
    { 
        public static AdminFeeSetting LoadAdminFees()
        {
            //open database connection and close once using block finish execution
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var adminfees = cnn.Query<AdminFeeSetting>("select * from AdminFeeSetting Where ID=0", new DynamicParameters());
                return (AdminFeeSetting)adminfees;
            }

        }

        public static void SaveAdminFees(AdminFeeSetting adminfeesetting)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) {

            }
        }
        private static string LoadConnectionString(string id = "Default")
        {//pass in default connection string
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
