using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using HealthPortal.View.UserAdministration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Model.DAO
{
    internal class DAOUserAdministration : DTOUserAdministration
    {
        readonly SqlCommand command = new SqlCommand();
        CommonMethods commonMethods = new CommonMethods();
        public DataSet GetColumnNames()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Usuarios].[tbRegistros]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "tbRegistros");
                return ds;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataSet GetUserInfo()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewPersonas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataSet GetSortedUserInfo(string column)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewPersonas] ORDER BY [{column}]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataSet SearchDesiredUserInfo(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewPersonas] WHERE Nombres LIKE '%{search}%' OR Apellidos LIKE '%{search}%' or [Correo Electrónico] LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewPersonas");
                return ds;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataSet GetRoles()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Usuarios].[tbRoles]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "tbRoles");
                return ds;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public int RegisterUser(string temporaryPassword, string email)
        {
            try
            {
                command.Connection = getConnection();
                string queryUsuarios = "INSERT INTO [Usuarios].[tbUsuarios] (usuario, contraseña, estadoUsuario, intentosUsuario, contraseñaTemporal, idRol) VALUES (@param1, @param2, @param3, @param4, @param5, @param6)";
                SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, command.Connection);
                cmdUsuarios.Parameters.AddWithValue("param1", Usuario);
                cmdUsuarios.Parameters.AddWithValue("param2", Contrasena);
                cmdUsuarios.Parameters.AddWithValue("param3", EstadoUsuario);
                cmdUsuarios.Parameters.AddWithValue("param4", IntentosUsuario);
                cmdUsuarios.Parameters.AddWithValue("param5", true);
                cmdUsuarios.Parameters.AddWithValue("param6", IdRol);
                int result = cmdUsuarios.ExecuteNonQuery();
                if (result == 1)
                {
                    string queryPersonas = "INSERT INTO [Usuarios].[tbPersonas] (nombrePersona, apellidoPersona, correoPersona, telefonoPersona, usuario) VALUES (@param1, @param2, @param3, @param4, @param5)";
                    SqlCommand cmdPersonas = new SqlCommand(queryPersonas, command.Connection);
                    cmdPersonas.Parameters.AddWithValue("param1", NombrePersona);
                    cmdPersonas.Parameters.AddWithValue("param2", ApellidoPersona);
                    cmdPersonas.Parameters.AddWithValue("param3", CorreoPersona);
                    cmdPersonas.Parameters.AddWithValue("param4", TelefonoPersona);
                    cmdPersonas.Parameters.AddWithValue("param5", Usuario);
                    result = cmdPersonas.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return result;
                    }
                    else
                    {
                        string queryDelete = "DELETE FROM [Usuarios].[tbUsuarios] WHERE usuario = @param1";
                        SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                        cmdDelete.Parameters.AddWithValue("param1", Usuario);
                        cmdDelete.ExecuteNonQuery();
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public int UpdateUserInfo()
        {
            try
            {
                command.Connection = getConnection();
                string queryPersonas = "UPDATE [Usuarios].[tbPersonas] SET nombrePersona = @param1, apellidoPersona = @param2, correoPersona = @param3, telefonoPersona = @param4 WHERE idPersona = @param5";
                SqlCommand cmdPersonas = new SqlCommand(queryPersonas, command.Connection);
                cmdPersonas.Parameters.AddWithValue("param1", NombrePersona);
                cmdPersonas.Parameters.AddWithValue("param2", ApellidoPersona);
                cmdPersonas.Parameters.AddWithValue("param3", CorreoPersona);
                cmdPersonas.Parameters.AddWithValue("param4", TelefonoPersona);
                cmdPersonas.Parameters.AddWithValue("param5", IdPersona);
                int result = cmdPersonas.ExecuteNonQuery();
                if (result == 1)
                {
                    string queryUsuarios = "UPDATE [Usuarios].[tbUsuarios] SET idRol = @param1 WHERE usuario = @param2";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, command.Connection);
                    cmdUsuarios.Parameters.AddWithValue("param1", IdRol);
                    cmdUsuarios.Parameters.AddWithValue("param2", Usuario);
                    result = cmdUsuarios.ExecuteNonQuery();
                    if (result == 1) { result = 2; }
                }
                return result;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public int DeleteUser()
        {
            try
            {
                command.Connection = getConnection();
                string queryIdPersona = "DELETE FROM [Usuarios].[tbPersonas] WHERE idPersona = @param1";
                SqlCommand cmdIdPersona = new SqlCommand(queryIdPersona, command.Connection);
                cmdIdPersona.Parameters.AddWithValue("param1", IdPersona);
                string queryUsuario = "DELETE FROM [Usuarios].[tbUsuarios] WHERE usuario = @param2";
                SqlCommand cmdUsuario = new SqlCommand(queryUsuario, command.Connection);
                cmdUsuario.Parameters.AddWithValue("param2", Usuario);
                int result = ((cmdIdPersona.ExecuteNonQuery() + cmdUsuario.ExecuteNonQuery()) / 2);
                return result;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
