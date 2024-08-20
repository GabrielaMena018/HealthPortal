using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HealthPortal.Model
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                //string server = "DESKTOP-QR03KRF";
                string server = "LAPTOP-KC01ESS7\\SQLEXPRESS";
                //string server = "FAMILIAPORTILLO\\SQLEXPRESS";
                string database = "HealthPortal";
                //SqlConnection conexion = new SqlConnection("Server =" + server +
                //                                                 "; DataBase = " + database +
                //                                                 "; Integrated Security = true");
                SqlConnection conexion = new SqlConnection($"Server = {server}; Database = {database}; uid = sa ; " +
                                                                                                  $"pwd = tato1234");
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-400 No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
