using HealthPortal.Helper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Model
{
    public class dbContext
    {
        private SqlConnection connection;
        private static bool connectionDetailsChanged = false;
        private static string server;
        private static string database;
        private static string user;
        private static string password;
        public void SetConnectionDetails(string server, string database, string user = null, string password = null)
        {
            dbContext.server = server;
            dbContext.database = database;
            dbContext.user = user;
            dbContext.password = password;
            dbContext.connectionDetailsChanged = true;
        }
        public SqlConnection getConnection()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    string connectionString;
                    if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password) && connectionDetailsChanged)
                    {
                        connectionString = $"Server={server};Database={database};User Id={user};Password={password};";
                    }
                    else if (connectionDetailsChanged)
                    {
                        connectionString = $"Server={server};Database={database};Integrated Security=True;";
                    }
                    else
                    {
                        // ESTO CAMBIAN PARA PONER LA DE SUS COMPUTADORAS, NO LAS DE ARRIBA
                        connectionString = $"Server = DESKTOP-QR03KRF ; Database = HealthPortal;Integrated Security = True;";
                    }
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                return connection;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_401");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
