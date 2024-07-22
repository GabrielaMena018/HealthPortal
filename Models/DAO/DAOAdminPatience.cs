using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Models.DTO;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Windows.Input;
using System.Diagnostics.Eventing.Reader;

namespace RegistroPacientes.Models.DAO
{
     class DAOAdminPatience : DTOAdminPatience
    {
        int respuesta;
        int RespuestaUpdate;
        int RespuestaDelete;
        readonly SqlCommand Command = new SqlCommand();
        //Llenar los comboBox
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

        //Registrrar Paciente
        public int PatientRegistration() 
        {
            
            try
            {
                Command.Connection = getConnection();
                //Insertar datos en la tabala de paciente
                string queryPatient = "INSERT INTO  tbPacientes VALUES (@nombrePaciente, @apellidoPaciente, @IdTipoPersona)";
                SqlCommand cmdInsertPatient = new SqlCommand(queryPatient, Command.Connection);
                //Insertar o darle valor a los parametros
                cmdInsertPatient.Parameters.AddWithValue("nombrePaciente", Nombre);
                cmdInsertPatient.Parameters.AddWithValue("apellidoPaciente", Apellido);
                cmdInsertPatient.Parameters.AddWithValue("IdTipoPersona", Rol);
                respuesta = cmdInsertPatient.ExecuteNonQuery();
                if (respuesta == 1)
                {

                    ObtenerIdPatient();
                    if (Rol == 1)
                    {
                        ObtenerIdGradoSeccion();
                        //Insertar estudiante
                        string queryStudent = "INSERT INTO tbEstudiantes VALUES  (@IdPaciente, @codigo, @IdGrado_Seccion)";
                        SqlCommand cmdStudent = new SqlCommand(queryStudent, Command.Connection);
                        cmdStudent.Parameters.AddWithValue("IdPaciente", IdPaciente);
                        cmdStudent.Parameters.AddWithValue("codigo", Codigo);
                        cmdStudent.Parameters.AddWithValue("IdGrado_Seccion", IdGradoSeccion);
                        respuesta = cmdStudent.ExecuteNonQuery();
                        if (respuesta == 1)
                        {
                            AgregarVisita();
                            if (respuesta == 1)
                            {
                                return 1;
                            }
                            else { return 0; }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    { 
                        //Insertar Personal de la Isntitución
                        string queryPersonal = "INSERT INTO tbPersonalInstitucion VALUES (@IdPaciente,@IdArea,@Documento)";
                        SqlCommand cmdPersonal = new SqlCommand(queryPersonal, Command.Connection);
                        cmdPersonal.Parameters.AddWithValue("IdPaciente", IdPaciente);
                        cmdPersonal.Parameters.AddWithValue("IdArea", IdArea);
                        cmdPersonal.Parameters.AddWithValue("Documento", Documento);
                        respuesta = cmdPersonal.ExecuteNonQuery();
                        if (respuesta == 1)
                        {
                            AgregarVisita();
                            if (respuesta ==1)
                            {
                                return 1;
                            }
                            else { return 0; }
                        }
                        else
                        {
                            return 0;
                        }
                       
                    }
                }
                else  
                {
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                //Codificación de errores: esta sale del catch EC = error critico, EC_001 = no se pudo ingresar al paciente
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                Command.Connection.Close();
            }
        }
        //Este metodo sirve para obtener el Id de Cada paciente
        public int ObtenerIdPatient() 
        {
            string queryIdPatient = "Select MAX (IdPaciente) FROM tbPacientes";
            SqlCommand cmdIdpatient = new SqlCommand(queryIdPatient, Command.Connection);
            SqlDataReader consulta = cmdIdpatient.ExecuteReader();

            while (consulta.Read())
            {
                IdPaciente = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPaciente;
        }
        //Este metodo sirve para onbtener el ID del Grado_seccion para ocuparlo como llave foranea
        public int ObtenerIdGradoSeccion() 
        {
            //buscar grados
            //Hacer una seleccion filtrada
            string queryGradoSeccion = "SELECT IdGrado_Seccion FROM tbGrado_Seccion WHERE GrupoTecnico = @GrupoTecnico AND IdGrado = @IdGrado AND IdSeccionAcademica = @IdSeccionAcademica AND IdEspecialidad = @IdEspecialidad";
            SqlCommand cmdGradoSeccion = new SqlCommand(queryGradoSeccion, Command.Connection);
            //Parametros
            cmdGradoSeccion.Parameters.AddWithValue("GrupoTecnico", GrupoTecnico);
            cmdGradoSeccion.Parameters.AddWithValue("IdGrado", Grado);
            cmdGradoSeccion.Parameters.AddWithValue("IdSeccionAcademica", SeccionAcademica);
            cmdGradoSeccion.Parameters.AddWithValue("IdEspecialidad", Especialidad);
            SqlDataReader consulta = cmdGradoSeccion.ExecuteReader();

            while (consulta.Read())
            {
                IdGradoSeccion = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();
            return IdGradoSeccion;
        }
        //Este metodo sirve para ingresar la visita
        public int AgregarVisita() 
        {
            try
            {
                string queryVisita = "INSERT INTO tbVisitas Values(@IdPaciente, @FechaVisita,@HoraVisita,@IdMedicamento, @Observaciones)";
                SqlCommand cmdVisita = new SqlCommand(queryVisita, Command.Connection);
                cmdVisita.Parameters.AddWithValue("IdPaciente", IdPaciente);
                cmdVisita.Parameters.AddWithValue("FechaVisita", Fecha);
                cmdVisita.Parameters.AddWithValue("HoraVisita", Hora);
                cmdVisita.Parameters.AddWithValue("IdMedicamento", Medicamento);
                cmdVisita.Parameters.AddWithValue("Observaciones", Observacion);
                respuesta = cmdVisita.ExecuteNonQuery();
                return respuesta;
            }
            catch (SqlException ex)
            {
                //EC_002 = no se pudo agregar la visita
                MessageBox.Show($"EC_002{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

           
           
        }
        //El metodo UpdateVisita sirve para actuzalizar Los datos de la visita
        public int UpdateVisita() 
        {
            try
            {
                string queryUpdateVisita = "UPDATE tbVisitas SET " +
                                            "FechaVisita = @param1, " +
                                            "HoraVisita = @param2, " +
                                            "IdMedicamento = @param3, " +
                                             "Observaciones = @param4 " +
                                            "WHERE IdPaciente = @param5";
                SqlCommand cmdUpdateVisita = new SqlCommand(queryUpdateVisita, Command.Connection);
                cmdUpdateVisita.Parameters.AddWithValue("param1", Fecha);
                cmdUpdateVisita.Parameters.AddWithValue("param2", Hora);
                cmdUpdateVisita.Parameters.AddWithValue("param3", Medicamento);
                cmdUpdateVisita.Parameters.AddWithValue("param4", Observacion);
                cmdUpdateVisita.Parameters.AddWithValue("param5", IdPaciente);
                RespuestaUpdate = cmdUpdateVisita.ExecuteNonQuery();
                return RespuestaUpdate;

            }
            catch (SqlException ex)
            {
                //EC_003 = No se pudo actualizar la información del apartado o tabla visita
                MessageBox.Show($"EC_003{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally 
            {
                Command.Connection.Close();
            }
           
        }
        //Esta sirve para dministrar el registro o la grid view de los estudiantes
        public DataSet AdminPatient() 
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminPatient = "SELECT * FROM ViewUpdateEstudiantes";
                SqlCommand cmdAdminPatient = new SqlCommand(queryAdminPatient, Command.Connection);
                cmdAdminPatient.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminPatient);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
        //Esta sirve para dministrar el registro o la grid view de los estudiantes
        public DataSet AdminPatientPersonalInstitucion()
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminPatient = "SELECT * FROM ViewPersonalInstitucion";
                SqlCommand cmdAdminPatient = new SqlCommand(queryAdminPatient, Command.Connection);
                cmdAdminPatient.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminPatient);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewPersonalInstitucion");
                return ds;
            }
            catch (SqlException ex)
            {
                //EC_005 No se pudo seleccionar la vista ViewPersonalIntitucion
                MessageBox.Show($"EC_005{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                getConnection().Close();
            }

        }
        //Sirve para actuzlaizar los datos del paciente
        public int UpdatePatient() 
        {
            try 
            {
                Command.Connection = getConnection();
                // Update en tbPacientes
                string queryUpdatePatient = "UPDATE tbPacientes SET " +
                                            "nombrePaciente = @param1, " +
                                            "apellidoPaciente = @param2, " +
                                            "IdTipoPersona = @param3 " +
                                            "WHERE IdPaciente = @param4"
                                            ;
                SqlCommand cmdUpdatePatient = new SqlCommand(queryUpdatePatient, Command.Connection);
                cmdUpdatePatient.Parameters.AddWithValue("param1", Nombre);
                cmdUpdatePatient.Parameters.AddWithValue("param2", Apellido);
                cmdUpdatePatient.Parameters.AddWithValue("param3", Rol);
                cmdUpdatePatient.Parameters.AddWithValue("param4", IdPaciente);
                RespuestaUpdate = cmdUpdatePatient.ExecuteNonQuery();
                //Update en la tbEstudiantes o en la tbPersonalInstitucion dpeendiendo el rol que se le asigno al paciente
                if (RespuestaUpdate >= 1)
                {
                    if (Rol == 1)
                    {
                        ObtenerIdGradoSeccion();
                        string queryUpdateEstudiante = "UPDATE tbEstudiantes SET" +
                                                       "codigo = @param5, " +
                                                       "IdGrado_Seccion = @param6 " +
                                                       "WHERE IdPaciente = @param7";
                        SqlCommand cmdUpdateEstudiante = new SqlCommand(queryUpdateEstudiante, Command.Connection);
                        cmdUpdatePatient.Parameters.AddWithValue("param5", Codigo);
                        cmdUpdatePatient.Parameters.AddWithValue("param6", IdGradoSeccion);
                        cmdUpdatePatient.Parameters.AddWithValue("param7", IdPaciente);
                        RespuestaUpdate = cmdUpdatePatient.ExecuteNonQuery();
                        if (RespuestaUpdate >= 1)
                        {
                            UpdateVisita();
                            if (RespuestaUpdate >= 1)
                            {
                                return 2;
                            }
                            else if( RespuestaUpdate <= 0) 
                            {
                                return 1;
                            }
                            else { return 0; }
                            
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (RespuestaUpdate <= 0)
                    {
                        return 1;
                    }
                    //Sino
                    else
                    {
                        string queryUpdatePersonalInstitucion = "UPDATE tbPersonalInstitucion SET " +
                                                                "Documento = @param1, " +
                                                                "IdArea = @param2 " +
                                                                "WHERE IdPaciente = @param3";
                        SqlCommand cmdUpdatePersonal = new SqlCommand(queryUpdatePersonalInstitucion, Command.Connection);
                        cmdUpdatePersonal.Parameters.AddWithValue("param1", Documento);
                        cmdUpdatePersonal.Parameters.AddWithValue("param2", IdArea);
                        cmdUpdatePersonal.Parameters.AddWithValue("param3", IdPaciente);
                        RespuestaUpdate = cmdUpdatePersonal.ExecuteNonQuery();
                        if (RespuestaUpdate == 1)
                        {
                            UpdateVisita();
                            if (RespuestaUpdate == 1)
                            {
                                return 2;
                            }
                            else if (RespuestaUpdate <= 0)
                            {
                                return 1;
                            }
                            else { return 0; }
                        }
                        else
                        {
                            return 0;
                        }
                        
                    }
                }
                
                return 0;
            }
            catch (SqlException Ex)
            {
                //EC_006 No se pudo actuzalizar el registro del paciente
                MessageBox.Show($"EC_006{Ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally 
            {
                Command.Connection.Close();
            }
            
                                        
        }
        //Eliminar la tabla de pacientes para asi eliminar el registro de este
        public int DeletePatient() 
        {
            try
            {
                Command.Connection = getConnection();
                string query = "DELETE tbPacientes WHERE IdPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, Command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPaciente);
                RespuestaDelete = cmdDelete.ExecuteNonQuery();
                return RespuestaDelete;
            }
            catch (Exception)
            {

                return -1;
            }
            finally { Command.Connection.Close(); } 
            
        }
        //eliminar registro de la tabla estudiantes
        public int DeleteStudent() 
        {
            try
            {
                Command.Connection = getConnection();
                string query = "DELETE tbEstudiantes WHERE IdPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, Command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPaciente);
                RespuestaDelete = cmdDelete.ExecuteNonQuery();
                return RespuestaDelete;
            }
            catch (SqlException ex)
            {
                //EC_007 = No se pudo eleiminar la información del estudiante
                MessageBox.Show($"EC_007{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
            
        }
        //Eliminar registro de la tabla visita
        public int DeleteVisitas() 
        {
            try
            {
                Command.Connection = getConnection();
                string query = "DELETE tbVisitas WHERE IdPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, Command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPaciente);
                RespuestaDelete = cmdDelete.ExecuteNonQuery();
                return RespuestaDelete;
            }
            catch (SqlException ex)
            {
                //EC_008 = No se pudo eleiminar la información de la visita que el paciente realizo
                MessageBox.Show($"EC_008{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }

        }
        //Eliminar el registro del paciente que viene del area personal
        public int DeletePersonal() 
        {
            try
            {
                Command.Connection = getConnection();
                string query = "DELETE tbPersonalInstitucion WHERE IdPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, Command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPaciente);
                RespuestaDelete = cmdDelete.ExecuteNonQuery();
                return RespuestaDelete;
            }
            catch (SqlException ex)
            {
                //EC_010 = No se pudo eliminar la información del personal de la institución
                MessageBox.Show($"EC_010{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }
        //Eliminar el registro del paciente
        public int DeleteRegistroPatient() 
        {
            try
            {
                if (Rol == 1)
                {

                    DeleteStudent();
                    if (RespuestaDelete == 1)
                    {
                        DeleteVisitas();
                        if (RespuestaDelete == 1)
                        {
                            DeletePatient();
                            if (RespuestaDelete == 1) 
                            {
                                return 1;
                            }
                            else { return -1; } 
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else { return -1; }
                }
                else 
                {
                    DeletePersonal();
                    if (RespuestaDelete == 1)
                    {
                        DeleteVisitas();
                        if (RespuestaDelete == 1)
                        {
                            DeletePatient();
                            if (RespuestaDelete == 1)
                            {
                                return 1;
                            }
                            else { return -1; }
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else { return -1; }
                }
            }
            catch (SqlException ex)
            {
                //EC_009 = No se pudo eliminar la información del paciente
                MessageBox.Show($"EC_009{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally { getConnection().Close(); }
            
                
            }
            
        }
        
    }



