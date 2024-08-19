using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;
using HealthPortal.Helper;

namespace HealthPortal.Model.DAO
{
    internal class DAOLogin : DTOLogin
    {
        SqlCommand command = new SqlCommand();
        public bool EvaluateLogin()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @param1 AND [contraseña] = @param2 AND [estadoUsuario] = @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Username);
                cmd.Parameters.AddWithValue("param2", Password);
                cmd.Parameters.AddWithValue("param3", true);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CurrentUserData.Username = dr.GetString(0);
                    CurrentUserData.Password = dr.GetString(1);
                    CurrentUserData.Status = dr.GetBoolean(2);
                    CurrentUserData.RoleId = dr.GetInt32(3);
                    CurrentUserData.FullName = dr.GetString(5);
                    CurrentUserData.TemporaryPassword = dr.GetBoolean(6);
                    CurrentUserData.Email = dr.GetString(7);
                    //CurrentUserData.IdPersona = dr.GetInt32(8);
                }
                return dr.HasRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int GetAmountOfUsers()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM [Vistas].[viewInformacionLogin]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                int totalUserAmount = (int)cmd.ExecuteScalar();
                return totalUserAmount;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public string VerifyEmail(string username)
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT [correoPersona] FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", username);
                return cmd.ExecuteScalar().ToString();

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
        public void TemporaryPasswordAssignation(string newPassword)
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Usuarios].[tbUsuarios] SET [contraseña] = @param1, [contraseñaTemporal] = @param2 WHERE [usuario] = @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", newPassword);
                cmd.Parameters.AddWithValue("param2", true);
                cmd.Parameters.AddWithValue("param3", Username);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} EC-401 No se pudieron obtener los datos necesarios de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Connection.Close();
            }
        }

    }
}
