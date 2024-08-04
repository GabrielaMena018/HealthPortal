using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Model.DTO;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Windows.Input;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegistroPacientes.Model.DAO
{
    class DAOAdminPatience : DTOAdminPatience
    {
        int respuesta;
        int RespuestaUpdate;
        int RespuestaDelete;
        int respuestaSearch;
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

        //INSERT

        //Registrar Paciente
        public int PatientRegistration()
        {

            try
            {
                Command.Connection = getConnection();
                GetGradeIdSection();
                //Insertar datos en la tabala de paciente
                string queryPatient = "INSERT INTO  tbPacientes VALUES (@nombrePaciente, @apellidoPaciente, @codigo, @IdGrado_Seccion, @IdTipoPersona)";
                SqlCommand cmdInsertPatient = new SqlCommand(queryPatient, Command.Connection);
                //Insertar o darle valor a los parametros
                cmdInsertPatient.Parameters.AddWithValue("nombrePaciente", Name);
                cmdInsertPatient.Parameters.AddWithValue("apellidoPaciente", LastName);
                cmdInsertPatient.Parameters.AddWithValue("codigo", Code);
                cmdInsertPatient.Parameters.AddWithValue("IdGrado_Seccion", IdGradeSection);
                cmdInsertPatient.Parameters.AddWithValue("IdTipoPersona", Rol);
                respuesta = cmdInsertPatient.ExecuteNonQuery();
                if (respuesta == 1)
                {

                    GetIdPatient();
                    if (respuesta == 1)
                    {
                        AddVisit();
                        if (respuesta == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    RollBack(); 
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                RollBack();
                //Codificación de errores: esta sale del catch EC = error critico, EC_001 = no se pudo ingresar al paciente
                MessageBox.Show($"EC_001{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                Command.Connection.Close();
            }
        }
        //Registrra Visitas
        public int AddVisit()
        {
            try
            {
                string queryVisita = "INSERT INTO tbVisitas Values(@IdPaciente, @FechaVisita,@HoraVisita,@IdMedicamento, @Observaciones)";
                SqlCommand cmdVisita = new SqlCommand(queryVisita, Command.Connection);
                cmdVisita.Parameters.AddWithValue("IdPaciente", IdPaciente);
                cmdVisita.Parameters.AddWithValue("FechaVisita", Date);
                cmdVisita.Parameters.AddWithValue("HoraVisita", Time);
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

        //Obtener

        //Este metodo sirve para obtener el Id de Cada paciente
        public int GetIdPatient()
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
        public int GetGradeIdSection()
        {
            //buscar grados
            //Hacer una seleccion filtrada
            string queryGradoSeccion = "SELECT IdGrado_Seccion FROM tbGrado_Seccion WHERE GrupoTecnico = @GrupoTecnico AND IdGrado = @IdGrado AND IdSeccionAcademica = @IdSeccionAcademica AND IdEspecialidad = @IdEspecialidad";
            SqlCommand cmdGradoSeccion = new SqlCommand(queryGradoSeccion, Command.Connection);
            //Parametros
            cmdGradoSeccion.Parameters.AddWithValue("GrupoTecnico", GroupTechnical);
            cmdGradoSeccion.Parameters.AddWithValue("IdGrado", Grade);
            cmdGradoSeccion.Parameters.AddWithValue("IdSeccionAcademica", SeccionAcademica);
            cmdGradoSeccion.Parameters.AddWithValue("IdEspecialidad", Specialty);
            SqlDataReader consulta = cmdGradoSeccion.ExecuteReader();

            while (consulta.Read())
            {
                IdGradeSection = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();
            return IdGradeSection;
        }
        //Este metodo sirve para ingresar la visita

        //Administrar o llenar Data Grid View

        //Esta sirve para dministrar el registro o la grid view de los estudiantes
        public DataSet AdminPatient()
        {
            try
            {
                Command.Connection = getConnection();
                string queryAdminPatient = "SELECT * FROM ViewAdminPatient";
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

        //UPDATE

        //Sirve para actuzlaizar los datos del paciente
        public int UpdatePatient()
        {
            try
            {
                Command.Connection = getConnection();
                GetGradeIdSection();
                // Update en tbPacientes
                string queryUpdatePatient = "UPDATE tbPacientes SET " +
                                            "nombrePaciente = @param1, " +
                                            "apellidoPaciente = @param2, " +
                                            "codigo = @param3, " +
                                            "IdGrado_Seccion = @param4, " +
                                            "IdTipoPersona = @param5 " +
                                            "WHERE IdPaciente = @param6"
                                            ;
                SqlCommand cmdUpdatePatient = new SqlCommand(queryUpdatePatient, Command.Connection);
                cmdUpdatePatient.Parameters.AddWithValue("param1", Name);
                cmdUpdatePatient.Parameters.AddWithValue("param2", LastName);
                cmdUpdatePatient.Parameters.AddWithValue("param3", Code);
                cmdUpdatePatient.Parameters.AddWithValue("param4", IdGradeSection);
                cmdUpdatePatient.Parameters.AddWithValue("param5", Rol);
                cmdUpdatePatient.Parameters.AddWithValue("param6", IdPaciente);
                RespuestaUpdate = cmdUpdatePatient.ExecuteNonQuery();
                //Update en la tbEstudiantes o en la tbPersonalInstitucion dpeendiendo el rol que se le asigno al paciente
                if (RespuestaUpdate >= 1)
                {
                    UpdateVisit();
                    if (RespuestaUpdate == 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return -1;
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
        //El metodo UpdateVisit sirve para actuzalizar Los datos de la visita
        public int UpdateVisit()
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
                cmdUpdateVisita.Parameters.AddWithValue("param1", Date);
                cmdUpdateVisita.Parameters.AddWithValue("param2", Time);
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
        //DELETE

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
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_006{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally { Command.Connection.Close(); }

        }
        //eliminar registro de la tabla estudiantes

        //Eliminar registro de la tabla visita
        public int DeleteVisit()
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

        //Eliminar el registro del paciente
        public int DeleteRegistrationPatient()
        {
            try
            {
                DeleteVisit();
                if (RespuestaDelete == 1)
                {
                    DeletePatient();
                    if (RespuestaDelete == 1)
                    {
                        return 1;

                    }
                    else
                    {
                        return -1;
                    }
                }
                else { return -1; }

            }
            catch (SqlException ex)
            {
                //EC_009 = No se pudo eliminar la información del paciente
                MessageBox.Show($"EC_009{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally { getConnection().Close(); }


        }

        //SEARCH

        //Buscar coincidencias en pacinete
        public DataSet SearchPatient(string search)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewAdminPatient " +
                               $"WHERE IdPaciente LIKE '%{search}%' " +
                               $"OR nombrePaciente LIKE '%{search}%' " +
                               $"OR apellidoPaciente LIKE '%{search}%' " +
                               $"OR TipoPersona LIKE '%{search}%' " +
                               $"OR codigo LIKE '%{search}%'" +
                               $"OR GrupoTecnico LIKE '%{search}%' " +
                               $"OR Grado LIKE '%{search}%'" +
                               $"OR SeccionAcademica LIKE '%{search}%' " +
                               $"OR Especialidad LIKE '%{search}%' " +
                               $"OR HoraVisita LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.Parameters.AddWithValue("param2", search);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
                Command.Connection.Close();
            }
        }

        //Buscar por date
        public DataSet SearchPatientDate(DateTime searchDate)
        {
            try
            {
                string fecha = searchDate.Date.ToString();
                Command.Connection = getConnection();
                string query = "SELECT * FROM  ViewAdminPatient WHERE FechaVisita = @FechaVisita";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("FechaVisita", searchDate);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
                Command.Connection.Close();
            }
        }

        //Buscar por specialty
        public DataSet SearchPatientSpecialty(string search)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewAdminPatient " +
                               $"WHERE Especialidad LIKE '%{search}%' ";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.Parameters.AddWithValue("param2", search);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
                Command.Connection.Close();
            }
        }

        //Buscar por grade
        public DataSet SearchPatientGrade(string search)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewAdminPatient " +
                               $"WHERE Grado LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.Parameters.AddWithValue("param1", search);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
                Command.Connection.Close();
            }
        }

        //Buscar por tipo de persona
        public DataSet SearchPatientRol(string search)
        {
            try
            {
                Command.Connection = getConnection();
                string query = $"SELECT * FROM ViewAdminPatient " +
                               $"WHERE TipoPersona LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //cmd.Parameters.AddWithValue("param1", column);
                cmd.Parameters.AddWithValue("param1", search);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "ViewAdminPatient");
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
                Command.Connection.Close();
            }
        }

        //Este metodo funciona para saber si ya existe un paciente ingresado con ese code
        public int existcode() 
        {
            try
            {
                Command.Connection = getConnection();
                string queryExist = "SELECT COUNT(1) FROM viewFiltrarCodigo WHERE codigo = @param1";
                SqlCommand cmd = new SqlCommand(queryExist, Command.Connection);
                cmd.Parameters.AddWithValue("param1", Code);
                SqlDataReader consulta = cmd.ExecuteReader();

                while (consulta.Read())
                {
                    respuestaSearch = consulta.GetInt32(0);
                    // Suponiendo que IdGrado_Seccion está en el índice 0
                }
                consulta.Close();

                if (respuestaSearch >= 1)
                {
                    return 1;
                }
                else if (respuestaSearch == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }
            finally
            {
                getConnection().Close();
            }

        }

        //Buscar por code
        public string[] SearchCode()
        {
            try
            {
               int respuesta = existcode();
                if (respuesta == 1)
                {
                    string[] datos = new string[8];
                    Command.Connection = getConnection();
                    string query = "SELECT * FROM viewFiltrarCodigo WHERE codigo = @param1";
                    SqlCommand cmd = new SqlCommand(query, Command.Connection);
                    cmd.Parameters.AddWithValue("param1", Code);

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        datos[0] = rd.GetString(0);
                        datos[1] = rd.GetString(1);
                        datos[2] = rd.GetString(2);
                        datos[3] = rd.GetString(3);
                        datos[4] = rd.GetString(4);
                        datos[5] = rd.GetString(5);
                        datos[6] = rd.GetString(6);
                        datos[7] = rd.GetString(7);

                    }
                    return datos;
                }
                else
                {
                    return null;
                }
                
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return null;
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
 
            }
            finally
            {
                getConnection().Close();
            }

        }

        public void RollBack()
        {
            //Eliminar el usuario ingresado
            string query = "DELETE FROM tbPacientes WHERE IdPaciente = @param1";
            SqlCommand cmddel = new SqlCommand(query, Command.Connection);
            cmddel.Parameters.AddWithValue("Param1", IdPaciente);
            int retorno = cmddel.ExecuteNonQuery();
        }
    }
}
        
    



