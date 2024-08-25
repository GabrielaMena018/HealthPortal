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
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @username AND [contraseña] = @password AND [estadoUsuario] = @userStatus";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("userStatus", true);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CurrentUserData.Username = dr.GetString(0);
                    CurrentUserData.Password = dr.GetString(1);
                    CurrentUserData.Token = dr.GetString(2);
                    CurrentUserData.Status = dr.GetBoolean(3);
                    CurrentUserData.RoleId = dr.GetInt32(4);
                    CurrentUserData.FullName = dr.GetString(6);
                    CurrentUserData.TemporaryPassword = dr.GetBoolean(7);
                    CurrentUserData.Email = dr.GetString(8);
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
        public void TokenLogin()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @username AND [token] = @token AND [estadoUsuario] = @userStatus";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("token", Token);
                cmd.Parameters.AddWithValue("userStatus", true);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CurrentUserData.Username = dr.GetString(0);
                    CurrentUserData.Password = dr.GetString(1);
                    CurrentUserData.Token = dr.GetString(2);
                    CurrentUserData.Status = dr.GetBoolean(3);
                    CurrentUserData.RoleId = dr.GetInt32(4);
                    CurrentUserData.FullName = dr.GetString(6);
                    CurrentUserData.TemporaryPassword = dr.GetBoolean(7);
                    CurrentUserData.Email = dr.GetString(8);
                }
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
        public string ValidateToken()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT usuario FROM [Institución].[tbUsuarios] WHERE token = @token";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("token", Token);
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
        public bool ConfirmUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Institución].[tbUsuarios] WHERE usuario = @username";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                return cmd.ExecuteReader().HasRows;
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
                return (int)cmd.ExecuteScalar();
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
        public int GetInstitutionInfo()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM [Institución].[tbInstitución]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                return (int)cmd.ExecuteScalar();
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
        public bool RememberedCredentials()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT recordarCredenciales FROM [Institución].[tbUsuarios] WHERE usuario = @username";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                return (bool)cmd.ExecuteScalar();
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
    }
}
