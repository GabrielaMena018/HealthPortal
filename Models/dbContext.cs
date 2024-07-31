using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPacientes.Models
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                //string server = "DESKTOP-QR03KRF";
                string server = "LAPTOP-KC01ESS7\\SQLEXPRESS";
                string database = "HealthPortal";
                //SqlConnection conexion = new SqlConnection("Server =" + server +
                //                                               "; DataBase = " + database +
                //                                             "; Integrated Security = true");
                SqlConnection conexion = new SqlConnection($"server = {server}; database = {database}; uid = sa ; pwd = tato1234");
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
