using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace ClassLib.DataAccess
{
        public static class SQLConn
        {
            public static string GetConnectionString(String ConnectionName = "RemoteConnection")
            {
                return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
            }

            public static int SaveData<T>(string sql, T data)
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    return cnn.Execute(sql, data);
                }

            }

        }
}
