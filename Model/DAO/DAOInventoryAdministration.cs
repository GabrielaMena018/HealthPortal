using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller.Dashboard;
using RegistroPacientes.Model.DTO;

namespace RegistroPacientes.Model.DAO
{
    internal class DAOInventoryAdministration : DTOInventoryAdministration
    {
        readonly SqlCommand command = new SqlCommand();
        //public int GetInfoCombo()
        //{
        //    FillCombo();
        //    return 1;
        //}

        public DataSet FillCombo()
        {
            try
            {
                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM [Medicamentos].[tbCategoriaMedicamento]";
                SqlCommand cmdInventory = new SqlCommand(query, command.Connection);
                cmdInventory.ExecuteNonQuery();
                SqlDataAdapter adpInventory = new SqlDataAdapter(cmdInventory);
                DataSet ds = new DataSet();
                adpInventory.Fill(ds, "tbCategoriaMedicamento");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Registrar usuario corresponde al primer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>

        public int RegisterMedicine()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarMedicamento] @param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreMedicamento);
                cmd.Parameters.AddWithValue("param2", Descripcion);
                cmd.Parameters.AddWithValue("param3", IdCategoria);
                cmd.Parameters.AddWithValue("param4", FechaVencimiento);
                cmd.Parameters.AddWithValue("param5", Ingreso);
                cmd.Parameters.AddWithValue("param6", Salida);
                cmd.Parameters.AddWithValue("param7", IdMedicamento);
                cmd.Parameters.AddWithValue("param8", Existencia);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Leer usuario corresponde al segundo mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public DataSet GetInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewMedicamento]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewMedicamento");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Actualzar usuario corresponde al tercer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public int UpdateInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarMedicamento] @param1, @param2, @param3, @param4, @param5, @param6, @param7";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreMedicamento);
                cmd.Parameters.AddWithValue("param2", Descripcion);
                cmd.Parameters.AddWithValue("param3", FechaVencimiento);
                cmd.Parameters.AddWithValue("param4", IdMedicamento);
                cmd.Parameters.AddWithValue("param5", Ingreso);
                cmd.Parameters.AddWithValue("param6", Salida);
                cmd.Parameters.AddWithValue("param7", Existencia);
                int returnedValue = cmd.ExecuteNonQuery();
                return returnedValue;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Eliminar usuario corresponde al cuarto mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>
        public int DeleteInventory()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarMedicamento] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdEntradaSalida);
                cmd.Parameters.AddWithValue("param2", IdMedicamento);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet SearchMedicineInventory(string search)
        {
            try
            {
                MessageBox.Show(search);
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewMedicamento] WHERE [Nombre del Medicamento] LIKE '%{search}%' OR [Categoría del Medicamento] LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewMedicamento");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
