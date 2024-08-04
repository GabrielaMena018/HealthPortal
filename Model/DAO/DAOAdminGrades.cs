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

namespace RegistroPacientes.Models.DAO
{
    class DAOAdminGrades : DTOAdminGrade
    {
        readonly SqlCommand Command = new SqlCommand();

        public DataSet LlenarCombo(string table)
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //En caso sea una consulta parametrizada se deberá respetar la sintaxis sobre como colocar parametros en la instrucción sql (REVISAR LOS DEMÁS MANTENIMIENTOS PARA VER COMO SE CREAN PARAMETROS Y SE LES DA VALORES).
                string query = $"SELECT * FROM {table}";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
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
                getConnection().Close();
            }
        }

        //Insertar
        public int InsertEspecialidad()
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC spIngresarEspecialidad @nombreEspecialidad";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@nombreEspecialidad", Especialidad1);
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
            finally { getConnection().Close(); }

        }

        public int InsertSeccionAcdemica()
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC spIngresarSeccionAcademica @nombreSeccionAcademica";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@nombreSeccionAcademica", SeccionAcademica1);
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
            finally { getConnection().Close(); }
        }

        public int InsertSecion() 
        {
            try
            {
                Command.Connection = getConnection();
                string querySeccion = "EXEC spIngresarSeccion @GrupoTecnico, @IdGrado, @IdEspecialidad, @IdSeccionAcademica";
                SqlCommand cmdInsertSeccion = new SqlCommand(querySeccion, Command.Connection);
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
            finally { getConnection().Close(); }
        }

        //Actualizar
        public int UpdateEspecialidad()
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spUpdateEspecialidad @IdEspecialidad, @nombreEspecialidad";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                cmdInsertEspecialidad.Parameters.AddWithValue("@nombreEspecialidad", Especialidad1);
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
            finally { getConnection().Close(); }
        }

        public int UpdateSeccionAcademica()
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spUpdateSeccionAcademica @IdSeccionAcademica, @SeccionAcademica";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
                cmdInsertEspecialidad.Parameters.AddWithValue("@IdSeccionAcademica", IdSeccionAcademica);
                cmdInsertEspecialidad.Parameters.AddWithValue("@SeccionAcademica", SeccionAcademica1);
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
            finally { getConnection().Close(); }
        }

        public int UpdateSeccion() 
        {
            try
            {
                Command.Connection = getConnection();
                string querySeccion = "EXEC  spUpdateSeccion @IdSeccion, @GrupoTecnico, @IdGrado,@IdEspecialidad, @IdSeccionAcademica";
                SqlCommand cmdInsertSeccion = new SqlCommand(querySeccion, Command.Connection);
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
            finally { getConnection().Close(); }
        }

        //Eliminar
        public int DeleteSeccionAcademica() 
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spDeleteSeccionAcademica @IdSeccionAcademica";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
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
            finally { getConnection().Close(); }
        }

        public int DeleteEspecialidad() 
        {
            try
            {
                Command.Connection = getConnection();
                string queryEspecialidad = "EXEC  spDeleteEspecialidad @IdEspecialidad";
                SqlCommand cmdInsertEspecialidad = new SqlCommand(queryEspecialidad, Command.Connection);
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
            finally { getConnection().Close(); }
        }

        public int DeleteSeccion()
        {
            try
            {
                Command.Connection = getConnection();
                string querySeccion = "EXEC  spDeleteSeccion @IdSeccion";
                SqlCommand cmdDeleteSeccion = new SqlCommand(querySeccion, Command.Connection);
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
            finally { getConnection().Close(); }
        }

        //Mostrar en los data Grid
        public DataSet AdminGrade()
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM ViewGradoSeccion";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, Command.Connection);
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
                getConnection().Close();
            }

        }

        public DataSet AdminEspecialidades()
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM ViewEspecialidades";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, Command.Connection);
                cmdAdminGrade.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminGrade);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewEspecialidades");
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
                getConnection().Close();
            }
        }

        public DataSet AdminSeccionesAcademicas()
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminGrade = "SELECT * FROM ViewSeccionesAcademicas";
                SqlCommand cmdAdminGrade = new SqlCommand(queryAdminGrade, Command.Connection);
                cmdAdminGrade.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminGrade);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewSeccionesAcademicas");
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
                getConnection().Close();
            }


        }
    }

        
    

}


