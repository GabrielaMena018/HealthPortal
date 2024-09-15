using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using HealthPortal.Model.DTO;
using HealthPortal.Helper;

namespace HealthPortal.Model.DAO
{
    internal class DAOPasswordManagement : DTOPasswordManagement
    {
        SqlCommand command = new SqlCommand();
        public bool VerifyCurrentUserPassword(string password)
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @param1 AND [contraseña] = @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", CurrentUserData.Username);
                cmd.Parameters.AddWithValue("param2", password);
                if (cmd.ExecuteScalar() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                CommonMethods.HandleError("EC_201");
                return false;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleError("EC_201");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool UpdatePassword()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spCambiarContraseña] @param1, @param2, @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Password);
                cmd.Parameters.AddWithValue("param2", Username);
                cmd.Parameters.AddWithValue("param3", false);
                if (cmd.ExecuteNonQuery() == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                CommonMethods.HandleError("EC_302");
                return false;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleError("EC_302");
                return false;
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
                CommonMethods.HandleError("EC_202");
                return null;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleError("EC_202");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool TemporaryPasswordAssignation()
        {
            try
            {
                command.Connection = getConnection();
                string query = "UPDATE [Institución].[tbUsuarios] SET [contraseña] = @param1, [contraseñaTemporal] = @param2 WHERE [usuario] = @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Password);
                cmd.Parameters.AddWithValue("param2", true);
                cmd.Parameters.AddWithValue("param3", Username);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                CommonMethods.HandleError("EC_301");
                return false;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleError("EC_301");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool VerifyCredentials()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewInformacionLogin] WHERE [usuario] = @username AND [contraseña] = @password AND [estadoUsuario] = @userStatus AND [idRol] = @roleID";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);
                cmd.Parameters.AddWithValue("userStatus", true);
                cmd.Parameters.AddWithValue("roleID", 1);
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
                CommonMethods.HandleError("EC_203");
                return false;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleError("EC_203");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}