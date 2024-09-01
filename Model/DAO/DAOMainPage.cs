using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace HealthPortal.Model.DAO
{
    internal class DAOMainPage : DTOMainPage
    {
        SqlCommand command = new SqlCommand();
        public string GetInstitutionName()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT nombreInstitución FROM [Institución].[tbInstitución]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return (string)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
