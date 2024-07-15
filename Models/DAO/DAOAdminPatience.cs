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

namespace RegistroPacientes.Models.DAO
{
     class DAOAdminPatience : DTOAdminPatience
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
        int respuesta;

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
                //Codificación de errores: esta sale del catch EC = error critico
                MessageBox.Show($"EC_003{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }
            finally
            {
                Command.Connection.Close();
            }
        }

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
        public int AgregarVisita() 
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
                MessageBox.Show($"EC_003{ex.Message}", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally 
            {
                getConnection().Close();
            }
          
        }
    }


}
