﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthPortal.Model.DTO;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Windows.Input;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthPortal.Model.DAO
{
    class DAOPatientAdministration : DTOPatientAdministration
    {
        int respuesta;
        int RespuestaUpdate;
        int RespuestaDelete;
        int respuestaSearch;
        readonly SqlCommand command = new SqlCommand();

        //Llenar los comboBox
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
                getConnection().Close();
            }
        }

        //INSERT

        //Registrar Paciente
        public int PatientRegistration()
        {

            try
            {
                command.Connection = getConnection();
                GetGradeIdSection();
                //Insertar datos en la tabala de paciente
                string queryPatient = "INSERT INTO [Pacientes].[tbPacientes] VALUES (@nombrePaciente, @apellidoPaciente, @codigo, @IdGradoSeccion, @IdTipoPersona)";
                SqlCommand cmdInsertPatient = new SqlCommand(queryPatient, command.Connection);
                //Insertar o darle valor a los parametros
                cmdInsertPatient.Parameters.AddWithValue("nombrePaciente", Name);
                cmdInsertPatient.Parameters.AddWithValue("apellidoPaciente", LastName);
                cmdInsertPatient.Parameters.AddWithValue("codigo", Code);
                cmdInsertPatient.Parameters.AddWithValue("IdGradoSeccion", IdGradeSection);
                cmdInsertPatient.Parameters.AddWithValue("IdTipoPersona", Role);
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
                            RollBack();
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
                command.Connection.Close();
            }
        }
        //Registrra Visitas
        public int AddVisit()
        {
            try
            {
                string queryVisita = "INSERT INTO [Visitas].[tbVisitas] Values(@idPaciente,@fechaVisita,@horaVisita,@idMedicamento,@observaciones, @idPersona)";
                SqlCommand cmdVisita = new SqlCommand(queryVisita, command.Connection);
                cmdVisita.Parameters.AddWithValue("idPaciente", IdPatient);
                cmdVisita.Parameters.AddWithValue("fechaVisita", Date);
                cmdVisita.Parameters.AddWithValue("horaVisita", Time);
                cmdVisita.Parameters.AddWithValue("idMedicamento", Medicine);
                cmdVisita.Parameters.AddWithValue("observaciones", Observation);
                cmdVisita.Parameters.AddWithValue("idPersona", IdPersona);
                respuesta = cmdVisita.ExecuteNonQuery();
                return respuesta;
            }
            catch (SqlException ex)
            {
                //EC_002 = no se pudo agregar la visita
                MessageBox.Show($"EC_002{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta = -1;
            }



        }
        //Insertar unicamente la visita
        public int InsertVisit()
        {
            GetCodeIdPatient();
            AddVisit();
            if (respuesta == 1)
            {
                return 1;
            }
            else if (respuesta == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }


        }

        //Obtener

        //Este metodo sirve para obtener el Id de Cada paciente
        public int GetIdPatient()
        {
            string queryIdPatient = "Select MAX (idPaciente) FROM [Pacientes].[tbPacientes]";
            SqlCommand cmdIdpatient = new SqlCommand(queryIdPatient, command.Connection);
            SqlDataReader consulta = cmdIdpatient.ExecuteReader();

            while (consulta.Read())
            {
                IdPatient = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPatient;
        }
        //Este metodo sirve para onbtener el ID del Grado_seccion para ocuparlo como llave foranea
        public void GetGradeIdSection()
        {
            //buscar grados
            //Hacer una seleccion filtrada
            string queryGradoSeccion = "SELECT idGradoSeccion FROM [Secciones].[tbGradoSeccion] WHERE grupoTecnico = @GrupoTecnico AND idGrado = @IdGrado AND idSeccionAcademica = @IdSeccionAcademica AND idEspecialidad = @IdEspecialidad";
            SqlCommand cmdGradoSeccion = new SqlCommand(queryGradoSeccion, command.Connection);
            //Parametros
            cmdGradoSeccion.Parameters.AddWithValue("GrupoTecnico", TechnicalGroup);
            cmdGradoSeccion.Parameters.AddWithValue("IdGrado", Grade);
            cmdGradoSeccion.Parameters.AddWithValue("IdSeccionAcademica", AcademicSection);
            cmdGradoSeccion.Parameters.AddWithValue("IdEspecialidad", Specialty);
            SqlDataReader consulta = cmdGradoSeccion.ExecuteReader();

            while (consulta.Read())
            {
                IdGradeSection = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();
        }
        //Este metodo es para obtener el IdPatient por medio del codigo del paciente
        public int GetCodeIdPatient()
        {
            command.Connection = getConnection();
            string QueryIdPatient = "SELECT idPaciente FROM [Pacientes].[tbPacientes] WHERE codigo = @param1";
            SqlCommand cmdIdPatient = new SqlCommand(QueryIdPatient, command.Connection);
            cmdIdPatient.Parameters.AddWithValue("param1", Code);
            SqlDataReader consulta = cmdIdPatient.ExecuteReader();

            while (consulta.Read())
            {
                IdPatient = consulta.GetInt32(0); // Suponiendo que IdGrado_Seccion está en el índice 0
            }
            consulta.Close();

            return IdPatient;
        }

        //Administrar o llenar Data Grid View

        //Esta sirve para dministrar el registro o la grid view de los estudiantes
        public DataSet AdminPatient()
        {
            try
            {
                command.Connection = getConnection();
                string queryAdminPatient = "SELECT * FROM [Vistas].[viewAdminPacientes]";
                SqlCommand cmdAdminPatient = new SqlCommand(queryAdminPatient, command.Connection);
                cmdAdminPatient.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdAdminPatient);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection = getConnection();
                GetGradeIdSection();
                // Update en tbPacientes
                string queryUpdatePatient = "UPDATE [Pacientes].[tbPacientes] SET " +
                                            "nombrePaciente = @param1, " +
                                            "apellidoPaciente = @param2, " +
                                            "codigo = @param3, " +
                                            "idGradoSeccion = @param4, " +
                                            "idTipoPersona = @param5 " +
                                            "WHERE idPaciente = @param6"
                                            ;
                SqlCommand cmdUpdatePatient = new SqlCommand(queryUpdatePatient, command.Connection);
                cmdUpdatePatient.Parameters.AddWithValue("param1", Name);
                cmdUpdatePatient.Parameters.AddWithValue("param2", LastName);
                cmdUpdatePatient.Parameters.AddWithValue("param3", Code);
                cmdUpdatePatient.Parameters.AddWithValue("param4", IdGradeSection);
                cmdUpdatePatient.Parameters.AddWithValue("param5", Role);
                cmdUpdatePatient.Parameters.AddWithValue("param6", IdPatient);
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
                command.Connection.Close();
            }


        }
        //El metodo UpdateVisit sirve para actuzalizar Los datos de la visita
        public int UpdateVisit()
        {
            try
            {
                string queryUpdateVisita = "UPDATE [Visitas].[tbVisitas] SET " +
                                            "FechaVisita = @param1, " +
                                            "HoraVisita = @param2, " +
                                            "IdMedicamento = @param3, " +
                                             "Observaciones = @param4 " +
                                            "WHERE idPaciente = @param5";
                SqlCommand cmdUpdateVisita = new SqlCommand(queryUpdateVisita, command.Connection);
                cmdUpdateVisita.Parameters.AddWithValue("param1", Date);
                cmdUpdateVisita.Parameters.AddWithValue("param2", Time);
                cmdUpdateVisita.Parameters.AddWithValue("param3", Medicine);
                cmdUpdateVisita.Parameters.AddWithValue("param4", Observation);
                cmdUpdateVisita.Parameters.AddWithValue("param5", IdPatient);
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
                command.Connection.Close();
            }

        }
        //DELETE

        //Eliminar la tabla de pacientes para asi eliminar el registro de este
        public int DeletePatient()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Pacientes].[tbPacientes] WHERE idPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPatient);
                RespuestaDelete = cmdDelete.ExecuteNonQuery();
                return RespuestaDelete;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"EC_006{ex.Message}", "Error critico ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally { command.Connection.Close(); }

        }
        //eliminar registro de la tabla estudiantes

        //Eliminar registro de la tabla visita
        public int DeleteVisit()
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM [Visitas].[tbVisitas] WHERE idPaciente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdPatient);
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
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE idPaciente LIKE '%{search}%' " +
                               $"OR nombrePaciente LIKE '%{search}%' " +
                               $"OR apellidoPaciente LIKE '%{search}%' " +
                               $"OR tipoPersona LIKE '%{search}%' " +
                               $"OR codigo LIKE '%{search}%'" +
                               $"OR grupoTecnico LIKE '%{search}%' " +
                               $"OR grado LIKE '%{search}%'" +
                               $"OR seccionAcademica LIKE '%{search}%' " +
                               $"OR especialidad LIKE '%{search}%' " +
                               $"OR horaVisita LIKE '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection.Close();
            }
        }

        //Buscar por date
        public DataSet SearchPatientDate(DateTime searchDate)
        {
            try
            {
                string fecha = searchDate.Date.ToString();
                MessageBox.Show(fecha);
                command.Connection = getConnection();
                string query = "SELECT * FROM [Vistas].[viewAdminPacientes] WHERE fechaVisita = @fechaVisita";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("fechaVisita", searchDate);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection.Close();
            }
        }

        //Buscar por specialty
        public DataSet SearchPatientSpecialty(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE especialidad LIKE '%{search}%' ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection.Close();
            }
        }

        //Buscar por grade
        public DataSet SearchPatientGrade(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE grado LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection.Close();
            }
        }

        //Buscar por tipo de persona
        public DataSet SearchPatientRole(string search)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM [Vistas].[viewAdminPacientes] " +
                               $"WHERE tipoPersona LIKE '%{search}%'  ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "viewAdminPacientes");
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
                command.Connection.Close();
            }
        }

        //Este metodo funciona para saber si ya existe un paciente ingresado con ese code
        public int existcode() 
        {
            try
            {
                command.Connection = getConnection();
                string queryExist = "SELECT COUNT(1) FROM [Vistas].[viewFiltrarCodigo] WHERE codigo = @param1";
                SqlCommand cmd = new SqlCommand(queryExist, command.Connection);
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
                    command.Connection = getConnection();
                    string query = "SELECT * FROM [Vistas].[viewFiltrarCodigo] WHERE codigo = @param1";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
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
            string query = "DELETE FROM [Pacientes].[tbPacientes] WHERE idPaciente = @param1";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("param1", IdPatient);
            int retorno = cmddel.ExecuteNonQuery();
        }
    }
}
        
    



