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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public int RegisterUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spRegistrarUsuario] @param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Usuario);
                cmd.Parameters.AddWithValue("param2", Contrasena);
                cmd.Parameters.AddWithValue("param3", EstadoUsuario);
                cmd.Parameters.AddWithValue("param4", IntentosUsuario);
                cmd.Parameters.AddWithValue("param5", true);
                cmd.Parameters.AddWithValue("param6", IdRol);
                cmd.Parameters.AddWithValue("param7", NombrePersona);
                cmd.Parameters.AddWithValue("param8", ApellidoPersona);
                cmd.Parameters.AddWithValue("param9", CorreoPersona);
                cmd.Parameters.AddWithValue("param10", TelefonoPersona);
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
                    string query = "UPDATE [Usuarios].[tbUsuarios] SET idRol = @param1 WHERE usuario = @param2";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("param1", IdRol);
                    cmd.Parameters.AddWithValue("param2", Usuario);
                    result = cmd.ExecuteNonQuery();
                    if (result == 1) { result = 2; }
                }
                return result;
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
        public int DeleteUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarUsuario] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdPersona);
                cmd.Parameters.AddWithValue("param2", Usuario);
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
        public int GetMaxID()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT MAX(idPersona) FROM [Usuarios].[tbPersonas]";
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
                MessageBox.Show($"{ex.Message} EC-402 No se pudo eliminar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public bool ReestablishUserPassword(string username)
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spCambiarContraseña] @param1, @param2, @param3";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Contrasena);
                cmd.Parameters.AddWithValue("param2", username);
                cmd.Parameters.AddWithValue("param3", true);
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
