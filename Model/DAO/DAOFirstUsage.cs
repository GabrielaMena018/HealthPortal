using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model.DAO
{
    internal class DAOFirstUsage : DTOFirstUsage
    {
        SqlCommand command = new SqlCommand();
        public int RegisterInstitution()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO [Institución].[tbInstitución] VALUES (@institutionName, @institutionAddress, @institutionLogo, @institutionLocation)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("institutionName", InstitutionName);
                cmd.Parameters.AddWithValue("institutionAddress", InstitutionAddress);
                cmd.Parameters.AddWithValue("institutionLogo", InstitutionLogo);
                cmd.Parameters.AddWithValue("institutionLocation", InstitutionLocation);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int RegisterFirstUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spRegistrarUsuario] @username, @password, @token, @userStatus, @userAttempts, @temporaryPassword, @rememberCredentials, @roleId, @institutionId, @name, @lastName, @email, @phoneNumber";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("token", Token);
                cmd.Parameters.AddWithValue("userStatus", true);
                cmd.Parameters.AddWithValue("userAttempts", 0);
                cmd.Parameters.AddWithValue("temporaryPassword", false);
                cmd.Parameters.AddWithValue("rememberCredentials", false);
                cmd.Parameters.AddWithValue("roleId", 1);
                cmd.Parameters.AddWithValue("institutionId", 0);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("lastName", LastName);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("phoneNumber", Phone);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int GetMaxID()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT MAX(idPersona) FROM [Institución].[tbPersonas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-402 No se obtener la información necesaria de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarUsuario] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", PersonID);
                cmd.Parameters.AddWithValue("param2", Username);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-402 No se pudo eliminar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
