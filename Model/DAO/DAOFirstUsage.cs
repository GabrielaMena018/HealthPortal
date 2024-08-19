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
        public int RegisterFirstUser()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spRegistrarPrimerUsuario] @param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Username);
                cmd.Parameters.AddWithValue("param2", Password);
                cmd.Parameters.AddWithValue("param3", true);
                cmd.Parameters.AddWithValue("param4", 0);
                cmd.Parameters.AddWithValue("param5", false);
                cmd.Parameters.AddWithValue("param6", 1);
                cmd.Parameters.AddWithValue("param7", Name);
                cmd.Parameters.AddWithValue("param8", LastName);
                cmd.Parameters.AddWithValue("param9", Email);
                cmd.Parameters.AddWithValue("param10", Phone);
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
