using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model.DAO
{
    internal class DAOSettings : DTOSettings
    {
        readonly SqlCommand command = new SqlCommand();
        public bool RegisterQuestion()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Institución].[tbPreguntas] VALUES (@question)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("question", Question);
                return cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_002");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool CheckSecurityQuestions()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM [Institución].[tbPreguntas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return (int)cmd.ExecuteScalar() > 0 ? true : false;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSecurityQuestions()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewPreguntasDeSeguridad]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPreguntasDeSeguridad");
                return ds;
            }
            catch (SqlException)
            {
                CommonMethods.HandleError("EC_005");
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
