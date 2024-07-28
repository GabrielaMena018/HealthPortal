using RegistroPacientes.Models.DAO;
using RegistroPacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.View.Login;
using RegistroPacientes.Controller.Login;
using RegistroPacientes.Controller.Helper;
using RegistroPacientes.View.Dashboard;
using System.Data.SqlClient;

namespace RegistroPacientes.Controller.Login
{
    internal class ControllerLogin
    {

            //Objeto de la vista ViewLogin
            FrmLogin ObjLogin;

            /// <summary>
            /// Constructor de la clase ControllerLogin que inicia los eventos de la vista
            /// </summary>
            /// <param name="Vista"></param>
            public ControllerLogin(FrmLogin Vista)
            {
                ObjLogin = Vista;
                ObjLogin.btnLogin.Click += new EventHandler(DataAccess);
                //Eventos para txtUsername
                ObjLogin.boxUsername.Enter += new EventHandler(EnterUsername);
                ObjLogin.txtusername.Leave += new EventHandler(LeaveUsername);
                //Eventos para txtPassword
                ObjLogin.BoxPassword.Enter += new EventHandler(EnterPassword);
                ObjLogin.txtpassword.Leave += new EventHandler(LeavePassword);
                //Eventos de Probar Conexión
                ObjLogin.BoxPassword.Click += new EventHandler(ShowPassword);
                ObjLogin.BoxPassword.Click += new EventHandler(HidePassword);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DataAccess(object sender, EventArgs e)
            {
                //Creando objeto de la clase DAOLogin
                DAOLogin DAOData = new DAOLogin();
                Commonclases common = new Commonclases();
                //Utilizando el objeto DAO para invocar a los metodos getter y setter del DTO
                DAOData.Username = ObjLogin.boxUsername.Text;
                //string cadenaencriptada = common.ComputeSha256Hash(ObjLogin.txtPassword.Text);
                //MessageBox.Show($"{cadenaencriptada}");
                DAOData.Password = ObjLogin.BoxPassword.Text;
                //Invocando al método Login contenido en el DAO
                bool answer = DAOData.ValidarLogin();
                //MessageBox.Show("" + answer);
                //Se evalúa el valor de la variable answer
                //if (answer == true)
               // {
                 //   ObjLogin.Hide();
                   // FrmDashboard viewDashboard = new FrmDashboard(ObjLogin.boxUsername.Text);
            //        viewDashboard.Show();
            
            //    }
              //  else
                //{
                  //  MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                    
            {
            }
        }

            /// <summary>
            /// Evento se ejecuta cuando se entra o se sale al txtUsername.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EnterUsername(object sender, EventArgs e)
            {
                if (ObjLogin.boxUsername.Text.Trim().Equals("Usuario"))
                {
                    ObjLogin.boxUsername.Clear();
                    ObjLogin.txtusername.Visible = true;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void LeaveUsername(object sender, EventArgs e)
            {
                if (ObjLogin.boxUsername.Text.Trim().Equals(""))
                {
                    ObjLogin.boxUsername.Text = "Usuario";
                    ObjLogin.txtusername.Visible = false;
                }
            }

            /// <summary>
            /// Evento ejecutado cuando el elemento activo es el elemento txtPassword
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EnterPassword(object sender, EventArgs e)
            {
                if (ObjLogin.BoxPassword.Text.Trim().Equals("Contraseña"))
                {
                    ObjLogin.BoxPassword.Clear();
                    ObjLogin.txtpassword.Visible = true;
                    //ObjLogin.txtPassword.PasswordChar = '*';
                   
                }
            }

            /// <summary>
            /// Evento ejecutado cuando elemento txtPassword deja de ser el foco
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void LeavePassword(object sender, EventArgs e)
            {
                if (ObjLogin.BoxPassword.Text.Trim().Equals(""))
                {
                    ObjLogin.BoxPassword.Visible = false;
                    ObjLogin.txtpassword.Text = "Contraseña";
              
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void QuitApplication(object sender, EventArgs e)
            {
                Application.Exit();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void TestConnection(object sender, EventArgs e)
            {
                //Se hace referencia a la clase dbContext y su método getConnection y se evalúa
                // si el retorno es nulo o no, en caso de ser nulo se mostrará el primer mensaje
                //de lo contrario se mostrará el código del segmento else.
                if (dbContext.getConnection() == null)
                {
                    MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            /// <summary>
            /// El evento KeyEnter detecta cuando la tecla enter es presionada y realizará una
            /// determinada acción.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void KeyEnter(object sender, EventArgs e)
            {

            }

            private void ShowPassword(object sender, EventArgs e)
            {
                ObjLogin.BoxPassword.UseSystemPasswordChar = false;
                ObjLogin.lockpic.Visible = false;
                ObjLogin.hidepass.Visible = true;
            }

            private void HidePassword(object sender, EventArgs e)
            {
                ObjLogin.BoxPassword.UseSystemPasswordChar = true;
                ObjLogin.lockpic.Visible = true;
                ObjLogin.hidepass.Visible = false;
            }             
        }
    }
  

