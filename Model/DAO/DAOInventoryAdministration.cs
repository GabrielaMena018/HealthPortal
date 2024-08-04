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
        public int GetInfoCombo()
        {
            FillCombo();
            return 1;
        }

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
                DataSet dsInventory = new DataSet();
                adpInventory.Fill(dsInventory, "tbCategoriaMedicamento");
                return dsInventory;

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

        /// <summary>
        /// Registrar usuario corresponde al primer mantenimiento del CRUD
        /// Inserción de datos a la base de datos
        /// </summary>
        /// <returns></returns>

        public int RegistrarInventario()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarMedicamento] @param1, @param2, @param3, @param4";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", NombreMedicamento);
                cmd.Parameters.AddWithValue("param2", Descripcion);
                cmd.Parameters.AddWithValue("param3", IdCategoria);
                cmd.Parameters.AddWithValue("param4", FechaVencimiento);
                int respuesta = cmd.ExecuteNonQuery();
                GetIdMedicine();
                if (respuesta == 1)
                {
                    string query2 = "EXEC [ProcedimientosAlmacenados].[spRegistrarEntradaSalidaMedicamento] @param1, @param2, @param3, @param4";
                    SqlCommand cmd2 = new SqlCommand(query2, command.Connection);
                    cmd2.Parameters.AddWithValue("param1", Ingreso);
                    cmd2.Parameters.AddWithValue("param2", Salida);
                    cmd2.Parameters.AddWithValue("param3", IdMedicamento);
                    cmd2.Parameters.AddWithValue("param4", Existencia);
                    respuesta = cmd2.ExecuteNonQuery();
                    return respuesta;
                }
                else
                {
                    string query3 = "DELETE FROM [Medicamentos].[tbMedicamentos] WHERE idMedicamento = @param1";
                    SqlCommand cmd3 = new SqlCommand(query3, command.Connection);
                    cmd3.Parameters.AddWithValue("param1", IdMedicamento);
                    cmd3.ExecuteNonQuery();
                    return 0;
                }

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

        public void GetIdMedicine()
        {
            string query = "SELECT MAX (idMedicamento) FROM [Medicamentos].[tbMedicamentos]";
            SqlCommand cmd = new SqlCommand(query, command.Connection);
            SqlDataReader info = cmd.ExecuteReader();
            while (info.Read())
            {
                IdMedicamento = info.GetInt32(0);
            }
            info.Close();
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
            catch (Exception)
            {

                return null;
            }
            finally
            {
                getConnection().Close();
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
                MessageBox.Show("" + IdMedicamento);
                command.Connection = getConnection();
                string query = "UPDATE tbMedicamentos SET" +
                                " nombreMedicamento = @nombreMedicamento," +
                                " descripcionMedicamento = @descripcionMedicamento," +
                                " fechaVencimiento = @fechaVencimiento " +
                                "WHERE IdMedicamento = @IdMedicamento ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.Parameters.AddWithValue("nombreMedicamento", NombreMedicamento);
                cmd.Parameters.AddWithValue("descripcionMedicamento", Descripcion);
                cmd.Parameters.AddWithValue("fechaVencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("IdMedicamento", IdMedicamento);

                int respuesta = cmd.ExecuteNonQuery();

                if (respuesta == 1)
                {
                    //Si el valor es 1 procede a actualizar la información de salida y entrada

                    string query2 = "UPDATE tbEntradasSalidasMedicamentos SET " +
                                    "fechaEntradaSalida = @fechaEntradaSalida," +
                                    "horaEntradaSalida = @horaEntradaSalida," +
                                    "cantidadMedicamento = @cantidadMedicamento " +
                                    "WHERE IdMedicamento = @IdMedicamento";
                    SqlCommand cmd2 = new SqlCommand(query2, command.Connection);
                    cmd2.Parameters.AddWithValue("fechaEntradaSalida", Ingreso);
                    cmd2.Parameters.AddWithValue("horaEntradaSalida", Salida);
                    cmd2.Parameters.AddWithValue("cantidadMedicamento", CantidadMedicamento);
                    cmd2.Parameters.AddWithValue("IdMedicamento", IdMedicamento);
                    respuesta = cmd2.ExecuteNonQuery();
                    respuesta = 2;
                }
                return respuesta;
            }
            catch (Exception)
            {
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
                string queryDelete = "DELETE tbEntradasSalidasMedicamentos WHERE IdEntradaSalida = @Param1";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("@Param1", IdEntradaSalida);
                int returnedDeleteValue = cmdDelete.ExecuteNonQuery();
                if (returnedDeleteValue == 1)
                {
                    command.Connection = getConnection();
                    string query = "DELETE tbMedicamentos WHERE IdMedicamento = @Param2";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("@Param2", IdMedicamento);
                    int respuesta = cmd.ExecuteNonQuery();
                    return respuesta;
                }
                else
                {
                    return 0;
                }
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
    }
}
