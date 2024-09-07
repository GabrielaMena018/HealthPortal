using HealthPortal.Helper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                //MessageBox.Show($"{DTOdbContext.Server}, {DTOdbContext.Database}, {DTOdbContext.User}, {DTOdbContext.Password}");
                SqlConnection conexion = new SqlConnection($"Server = {DTOdbContext.Server}; DataBase = {DTOdbContext.Database}; User Id = {DTOdbContext.User}; Password = {DTOdbContext.Password}");
                conexion.Open();
                return conexion;
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
        public static SqlConnection testConnection(string server, string database, string user, string password)
        {
            try
            {
                SqlConnection connection = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {user}; Password = {password}");
                connection.Open();
                return connection;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_401");
                return null;
            }
        }
    }
}
