using RegistroPacientes.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller.Dashboard;

namespace RegistroPacientes.Models.DAO
{
    internal class DAOAdminInventory : DTOAdminInventory
    {
        readonly SqlCommand command = new SqlCommand();
        

        public int ObtenerInfoCombos()
        {
            LlenarCombosInventario();
            return 1;
        }

        public DataSet LlenarCombosInventario()
        {
            try
            {
                //Se crea una conexion para garantizar que haya conexion con la base
                command.Connection = getConnection();
                string query = "SELECT * FROM tbCategoriaMedicamento";
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
                getConnection().Close();
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
                MessageBox.Show("Prueba1");
                command.Connection = getConnection();
                string query = "INSERT INTO tbMedicamentos(nombreMedicamento, descripcionMedicamento, FechaVencimiento, IdCategoriaMedicamento) VALUES (@nombreMedicamento, @descripcionMedicamento, @fechaVencimiento, @idCategoriaMedicamento)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("nombreMedicamento", NombreMedicamento);
                cmd.Parameters.AddWithValue("descripcionMedicamento", Descripcion);
                cmd.Parameters.AddWithValue("fechaVencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("idCategoriaMedicamento", IdCategoria);
                MessageBox.Show(Descripcion);
                int respuesta = cmd.ExecuteNonQuery();

                if (respuesta == 1)
                {
                    MessageBox.Show("Prueba");
                    ObtenerIdMedicamentos();
                    string query2 = "INSERT INTO tbEntradasSalidasMedicamentos(fechaEntradaSalida, horaEntradaSalida, cantidadMedicamento, IdMedicamento) VALUES (@fechaEntradaSalida, @horaEntradaSalida, @cantidadMedicamento, @idMedicamento)";
                    SqlCommand cmd2 = new SqlCommand(query2, command.Connection);
                    cmd2.Parameters.AddWithValue("fechaEntradaSalida", Ingreso);
                    cmd2.Parameters.AddWithValue("horaEntradaSalida", Salida);
                    cmd2.Parameters.AddWithValue("cantidadMedicamento", CantidadMedicamento);
                    cmd2.Parameters.AddWithValue("idMedicamento", IdMedicamento);
                    MessageBox.Show($"{Ingreso} {Salida} {CantidadMedicamento} {IdMedicamento}");
                    respuesta = cmd2.ExecuteNonQuery();
                    return respuesta;             
                }
                else
                {
                    //RollBack();
                    return 0;
                }                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            catch (Exception)
            {
                //RollBack();
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public void ObtenerIdMedicamentos()
        {
            string queryId = "SELECT MAX (IdMedicamento) FROM ViewMedicamento";
            SqlCommand cmdIdMedicment = new SqlCommand(queryId, command.Connection);
            SqlDataReader consulta = cmdIdMedicment.ExecuteReader();
            while (consulta.Read())
            {
                IdMedicamento = consulta.GetInt32(0);
            }
            consulta.Close();
        }

        //public void RollBack()
        //{
        //    string query = "DELETE FROM tbMedicamentos WHERE nombreMedicamento = @nombreMedicamento ";
        //    SqlCommand cmdDel = new SqlCommand(query,command.Connection);
        //    cmdDel.Parameters.AddWithValue();
        //    int retorno = cmdDel.ExecuteNonQuery();
        //}

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
                string query = "SELECT * FROM ViewMedicamento";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewMedicamento");
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
                command.Connection = getConnection();
                string query = "UPDATE tbMedicamentos SET" +
                                " nombreMedicamento = @nombreMedicamento," +
                                " descreipcionMedicamento = @nombreMedicamento," +
                                " fechaVencimiento = @nombreMedicamento " +
                                "WHERE IdMedicamento = @IdMedicamento ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.Parameters.AddWithValue("nombreMedicamento", NombreMedicamento);
                cmd.Parameters.AddWithValue("descrpcionMedicamento", Descripcion);
                cmd.Parameters.AddWithValue("fechaVencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("IdMedicamento", IdMedicamento);

                int respuesta = cmd.ExecuteNonQuery();

                if (respuesta == 1)
                {
                    //Si el valor es 1 procede a actualizar la información de salida y entrada

                    string query2 = "UPDATE tbEntradasSalidasMedicamentos SET" +
                                    "fechaEntradaSalida = @fechaEntradaSalida" +
                                    "horaEntradaSalida = @horaEntradaSalida" +
                                    "cantidadMedicamento = @cantidadMedicamento" +
                                    "WHERE IdMedicamento = @IdMedicamento";
                    SqlCommand cmd2 = new SqlCommand(query2, command.Connection);
                    cmd.Parameters.AddWithValue("fechaEntradaSalida", Ingreso);
                    cmd.Parameters.AddWithValue("horaEntradaSalida", Salida);
                    cmd.Parameters.AddWithValue("cantidadMedicamento", CantidadMedicamento);
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
                string query = "DELETE tbMedicamentos WHERE idMedicamento = @IdMedicamento";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("IdMedicamento", IdMedicamento);
                int respuesta = cmd.ExecuteNonQuery();
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
    }
}
