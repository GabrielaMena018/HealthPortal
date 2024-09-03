//*3*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DTO;

namespace HealthPortal.Model.DAO
{
    class DAOSectionAdministration : DTOSectionAdministration
    {
        readonly SqlCommand command = new SqlCommand();

        public DataSet FillCombo(string table, string schema)
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //En caso sea una consulta parametrizada se deberá respetar la sintaxis sobre como colocar parametros en la instrucción sql (REVISAR LOS DEMÁS MANTENIMIENTOS PARA VER COMO SE CREAN PARAMETROS Y SE LES DA VALORES).
                string query = $"SELECT * FROM {schema}.{table}";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron o encontraron, por lo general cuando es una consulta su valor puede ser 1 o mayor a 1.
                cmd.ExecuteNonQuery();
                //Se crea un objeto SqlDataAdapter para poder llenar el DataSet que posteriormente utilizaremos, además recibe el comando sql
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un DataSet que será el objeto de retorno del método
                DataSet ds = new DataSet();
                //Rellenamos el DataSet con los datos encontrados con el SqlDataAdapter, además, indicamos de donde provienen los datos
                adp.Fill(ds, $"{table}");
                //Retornamos el objeto DataSet
                return ds;
            }
            catch (Exception)
            {
                //Se retorna null si durate la ejecución del try ocurrió algún error
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                command.Connection.Close();
            }
        }

        //Insertar
        public int AddSpecialty()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarEspecialidad] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Especialidad);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int AddAcademicSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarSeccionAcademica] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", SeccionAcademica);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int AddSection() 
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spIngresarSeccion] @param1, @param2, @param3, @param4";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", GrupoTecnico);
                cmd.Parameters.AddWithValue("param2", IdGrado);
                cmd.Parameters.AddWithValue("param3", IdSeccionAcademica);
                cmd.Parameters.AddWithValue("param4", IdEspecialidad);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateSpecialty()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC  [ProcedimientosAlmacenados].[spUpdateEspecialidad] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", IdEspecialidad);
                cmd.Parameters.AddWithValue("@param2", Especialidad);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateAcademicSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarSeccionAcademica] @param1, @param2";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", IdSeccionAcademica);
                cmd.Parameters.AddWithValue("@param2", SeccionAcademica);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdateSection() 
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spActualizarSeccion] @param1, @param2, @param3, @param4, @param5";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@param1", IdSeccion);
                cmd.Parameters.AddWithValue("@param2", GrupoTecnico);
                cmd.Parameters.AddWithValue("@param3", IdGrado);
                cmd.Parameters.AddWithValue("@param4", IdEspecialidad);
                cmd.Parameters.AddWithValue("@param5", IdSeccionAcademica);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteAcademicSection() 
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarSeccionAcademica] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdSeccionAcademica);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteSpecialty() 
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarEspecialidad] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdEspecialidad);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int DeleteSection()
        {
            try
            {
                command.Connection = getConnection();
                string query = "EXEC [ProcedimientosAlmacenados].[spEliminarSeccion] @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdSeccion);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSectionData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewGradoSeccion]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewGradoSeccion");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_004{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveSpecialtyData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewEspecialidades]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewEspecialidades");
                return ds;
            }
            catch (SqlException ex)
            {
                //EC_004 = no se puso seleccionar la vista UpdateEstudiantes
                MessageBox.Show($"EC_004{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveAcademicSectionData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewSeccionesAcademicas]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewSeccionesAcademicas");
                return ds;
            }
            catch (SqlException ex)
            {
                //EC_004 = no se puso seleccionar la vista UpdateEstudiantes
                MessageBox.Show($"EC_004{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataSet RetrieveGradeData()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewGrados]";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewGrados");
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
    }
}


