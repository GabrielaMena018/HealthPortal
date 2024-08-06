//*3*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Model.DTO;

namespace RegistroPacientes.Model.DAO
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
                int respuesta = cmd.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int InsertSecion() 
        {
            try
            {
                command.Connection = getConnection();
                string querySeccion = "EXEC spIngresarSeccion @GrupoTecnico, @IdGrado, @IdEspecialidad, @IdSeccionAcademica";
                SqlCommand cmdInsertSeccion = new SqlCommand(querySeccion, command.Connection);
                cmdInsertSeccion.Parameters.AddWithValue("@GrupoTecnico", GrupoTecnico);
                cmdInsertSeccion.Parameters.AddWithValue("@IdGrado", IdGrado);
                cmdInsertSeccion.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                cmdInsertSeccion.Parameters.AddWithValue("@IdSeccionAcademica", IdSeccionAcademica);
                int respuesta = cmdInsertSeccion.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int UpdateEspecialidad()
        {
            try
            {
                command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spUpdateEspecialidad @IdEspecialidad, @nombreEspecialidad";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                cmdInsertEspecialidad.Parameters.AddWithValue("@nombreEspecialidad", Especialidad);
                int respuesta = cmdInsertEspecialidad.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int UpdateSeccionAcademica()
        {
            try
            {
                command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spUpdateSeccionAcademica @IdSeccionAcademica, @SeccionAcademica";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdSeccionAcademica", IdSeccionAcademica);
                cmdInsertEspecialidad.Parameters.AddWithValue("@SeccionAcademica", SeccionAcademica);
                int respuesta = cmdInsertEspecialidad.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int UpdateSeccion() 
        {
            try
            {
                command.Connection = getConnection();
                string querySeccion = "EXEC  spUpdateSeccion @IdSeccion, @GrupoTecnico, @IdGrado,@IdEspecialidad, @IdSeccionAcademica";
                SqlCommand cmdInsertSeccion = new SqlCommand(querySeccion, command.Connection);
                cmdInsertSeccion.Parameters.AddWithValue("@IdSeccion", IdSeccion);
                cmdInsertSeccion.Parameters.AddWithValue("@GrupoTecnico", GrupoTecnico);
                cmdInsertSeccion.Parameters.AddWithValue("@IdGrado", IdGrado);
                cmdInsertSeccion.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                cmdInsertSeccion.Parameters.AddWithValue("@IdSeccionAcademica", IdSeccionAcademica);
                int respuesta = cmdInsertSeccion.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int DeleteSeccionAcademica() 
        {
            try
            {
                command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spDeleteSeccionAcademica @IdSeccionAcademica";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdSeccionAcademica", IdSeccionAcademica);
                int respuesta = cmdInsertEspecialidad.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int DeleteEspecialidad() 
        {
            try
            {
                command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spDeleteEspecialidad @IdEspecialidad";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                int respuesta = cmdInsertEspecialidad.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public int DeleteSeccion()
        {
            try
            {
                command.Connection = getConnection();
                string querySeccion = "EXEC  spDeleteSeccion @IdSeccion";
                SqlCommand cmdDeleteSeccion = new SqlCommand(querySeccion, command.Connection);
                cmdDeleteSeccion.Parameters.AddWithValue("@IdSeccion", IdSeccion);
                int respuesta = cmdDeleteSeccion.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    return 1;
                }
                else { return 0; }
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
        public DataSet AdminGrade()
        {
            try
            {
                command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM [Vistas].[viewGradoSeccion]";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, command.Connection);
                cmdAdminGrade.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminGrade);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewGradoSeccion");
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
        public DataSet AdminEspecialidades()
        {
            try
            {
                command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM [Vistas].[viewEspecialidades]";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, command.Connection);
                cmdAdminGrade.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminGrade);
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
        public DataSet AdminSeccionesAcademicas()
        {
            try
            {
                command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM [Vistas].[viewSeccionesAcademicas]";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, command.Connection);
                cmdAdminGrade.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminGrade);
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
    }
}


