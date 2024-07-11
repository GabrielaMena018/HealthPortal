using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Models.DTO;

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

        public int RegistrarVisita() 
        {
            try 
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                string query = "INSERT INTO tbPacientes(nombrePaciente, apellidoPaciente, IdTipoPersona) VALUES (@nombrePaciente, @apellidoPaciente, @IdTipoPersona)";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd.Parameters.AddWithValue("nombrePaciente", NombrePaciente);
                cmd.Parameters.AddWithValue("apellidoPaciente",ApellidoPaciente );
                cmd.Parameters.AddWithValue("IdTipoRol", IdTipoPersona1);
              
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                int respuesta = cmd.ExecuteNonQuery();
                
                if (respuesta ==1) 
                {
                    string query1 = "INSERT INTO tbEstudiantes(codigo idEspecialidad, IdGrado,IdSeccion) VALUES (@codigo, @idEspecialidad, @IdGrado, IdSeccion)";
                    SqlCommand cmd1 = new SqlCommand(query1, Command.Connection);

                    cmd1.Parameters.AddWithValue("codigo", Codigo);
                    cmd1.Parameters.AddWithValue("idEspecialidad", IdEspecialidad);
                    cmd1.Parameters.AddWithValue("IdGrado", idGrado);
                    cmd1.Parameters.AddWithValue("IdSeccion", idSeccion);
                    respuesta = cmd1.ExecuteNonQuery();
                    return respuesta;

                }
                else 
                {
                    return 0;
                }
            }

            catch (Exception)
            {
                return -1;
            }finally
            {
                Command.Connection.Close();
            }
        }
    }
}
