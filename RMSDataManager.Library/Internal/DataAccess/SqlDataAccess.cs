using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RMSDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<TData> LoadData<TData, TParam>(string storedProcedure, TParam parameters, string connectionStringName)
        {
            var connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = connection.Query<TData>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }

        public TData LoadSingle<TData, TParam>(string storedProcedure, TParam parameters, string connectionStringName)
        {
            var connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = connection.QuerySingle<TData>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return data;
            }

        }

        public void SaveData<TParam>(string storedProcedure, TParam parameters, string connectionStringName)
        {
            var connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }

        }
    }
}
