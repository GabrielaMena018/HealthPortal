using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomPanel;
using HealthPortal.Model.DAO;
using HealthPortal.Helper;
using HealthPortal.Model.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerFirstUserCreation
    {
        FrmFirstUserCreation objFirstUserCreation;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerFirstUserCreation(FrmFirstUserCreation view)
        {
            objFirstUserCreation = view;

            // El diccionario "imageMapping" declarado previamente se inicializa con los valores correspondientes para posteriormente ser utilizado en los eventos .Enter y .Leave de los botones
            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            // Evento de carga del formulario, se oculta automáticamente la contraseña
            objFirstUserCreation.Load += new EventHandler(HidePassword);

            // Eventos para mover el formulario
            objFirstUserCreation.MouseDown += new MouseEventHandler(FormMouseDown);
            objFirstUserCreation.MouseMove += new MouseEventHandler(FormMouseMove);
            objFirstUserCreation.MouseUp += new MouseEventHandler(FormMouseUp);

            // Eventos .Enter de los textbox; se verifica si la propiedad .Texts de los textbox corresponde a lo que viene siendo el texto "placeholder", y si sí lo es, se vacían
            objFirstUserCreation.txtName.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtLastName.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtEmail.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtPhoneNumber.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtUsername.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtPassword.Enter += new EventHandler(EnterTextBox);
            objFirstUserCreation.txtConfirmPassword.Enter += new EventHandler(EnterTextBox);

            // Eventos .Leave de los textbox; se verifica si al salir del textbox la propiedad .Texts contiene un string vacío "", y si sí es un string vacío, se le coloca el texto "placeholder"
            objFirstUserCreation.txtName.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtLastName.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtEmail.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtPhoneNumber.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtUsername.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtPassword.Leave += new EventHandler(LeaveTextBox);
            objFirstUserCreation.txtConfirmPassword.Leave += new EventHandler(LeaveTextBox);

            // Eventos .Click para ocultar / mostrar la contraseña
            objFirstUserCreation.btnHidePassword.Click += new EventHandler(ShowPassword);
            objFirstUserCreation.btnShowPassword.Click += new EventHandler(HidePassword);

            // Eventos .Enter de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseEnterPictureButton y MouseEnterTextButton, respectivamente)
            objFirstUserCreation.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            objFirstUserCreation.btnHidePassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            objFirstUserCreation.btnShowPassword.MouseEnter += new EventHandler(MouseEnterPictureButton);
            objFirstUserCreation.btnRegisterFirstUser.MouseEnter += new EventHandler(MouseEnterTextButton);

            // Eventos .Leave de los botones, haciéndose la distinción entre los botones que son únicamente imágenes y los que son únicamente texto (MouseLeavePictureButton y MouseLeaveTextButton, respectivamente)
            objFirstUserCreation.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);
            objFirstUserCreation.btnHidePassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            objFirstUserCreation.btnShowPassword.MouseLeave += new EventHandler(MouseLeavePictureButton);
            objFirstUserCreation.btnRegisterFirstUser.MouseLeave += new EventHandler(MouseLeaveTextButton);

            // Evento .Click que inicia el proceso de registro del primer usuario
            objFirstUserCreation.btnRegisterFirstUser.Click += new EventHandler(AttemptFirstUserRegistration);

            // Evento .Click que lo único que hace es cerrar el programa xd
            objFirstUserCreation.btnExit.Click += new EventHandler(ExitApplication);
        }
        private void FormMouseDown(object sender, EventArgs e)
        {
            CommonMethods.FormMouseDown(sender);
        }
        private void FormMouseMove(object sender, EventArgs e)
        {
            CommonMethods.FormMouseMove(sender);
        }
        private void FormMouseUp(object sender, EventArgs e)
        {
            CommonMethods.FormMouseUp(sender);
        }

        /// <summary>
        ///     La propiedad .PasswordChar de los textbox Password y ConfirmPassword pasa a ser FALSE,
        ///     esto quiere decir que el texto será visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPassword(object sender, EventArgs e)
        {
            objFirstUserCreation.txtPassword.PasswordChar = false;
            objFirstUserCreation.txtConfirmPassword.PasswordChar = false;
            objFirstUserCreation.btnHidePassword.Visible = false;
            objFirstUserCreation.btnShowPassword.Visible = true;
        }
        /// <summary>
        ///     La propiedad .PasswordChar de los textbox Password y ConfirmPassword pasa a ser TRUE,
        ///     esto quiere decir que el texto estará oculto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HidePassword(object sender, EventArgs e)
        {
            if (!objFirstUserCreation.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                objFirstUserCreation.txtPassword.PasswordChar = true;
                objFirstUserCreation.btnShowPassword.Visible = false;
                objFirstUserCreation.btnHidePassword.Visible = true;
                if (!objFirstUserCreation.txtConfirmPassword.Texts.Trim().Equals("Confirmar contraseña"))
                {
                    objFirstUserCreation.txtConfirmPassword.PasswordChar = true;
                }
            }
        }
        private void EnterTextBox(object sender, EventArgs e)
        {
            BorderRadiusTXT txt = sender as BorderRadiusTXT;
            if (txt != null)
            {
                if (txt.Texts.Trim() == GetPlaceholderText(txt))
                {
                    txt.Clear();
                    txt.ForeColor = Color.FromArgb(31, 43, 91);
                }
            }
        }
        private void LeaveTextBox(object sender, EventArgs e)
        {
            BorderRadiusTXT txt = sender as BorderRadiusTXT;
            if (txt != null)
            {
                if (string.IsNullOrEmpty(txt.Texts))
                {
                    txt.Texts = GetPlaceholderText(txt);
                    txt.ForeColor = Color.FromArgb(142, 202, 230);
                }
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MouseEnterTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveTextButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(142, 202, 230);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void MouseEnterPictureButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
            }
        }
        /// <summary>
        ///     Proceso de registro del primer usuario del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttemptFirstUserRegistration(object sender, EventArgs e)
        {
            // Se verifica que ninguno de los textbox esté vacío
            if (!(objFirstUserCreation.txtLastName.Texts.Trim() == "" || objFirstUserCreation.txtLastName.Texts.Trim() == "" || objFirstUserCreation.txtEmail.Texts.Trim() == "" || objFirstUserCreation.txtPhoneNumber.Texts.Trim() == "" || objFirstUserCreation.txtUsername.Texts.Trim() == "" || objFirstUserCreation.txtPassword.Texts.Trim() == "" || objFirstUserCreation.txtConfirmPassword.Texts.Trim() == ""))
            {
                // Se verifica que estos dos métodos retornen TRUE
                if (VerifyPasswordSimilarity() == true && ValidateEmail() == true)
                {
                    DAOFirstUsage daoFirstUsage = new DAOFirstUsage();
                    CommonMethods commonMethods = new CommonMethods();
                    // A los atributos del DTO, por medio del DAO, se les asignan los contenidos de los textbox
                    daoFirstUsage.Name = objFirstUserCreation.txtName.Texts.Trim();
                    daoFirstUsage.LastName = objFirstUserCreation.txtLastName.Texts.Trim();
                    daoFirstUsage.Email = objFirstUserCreation.txtEmail.Texts.Trim();
                    daoFirstUsage.Phone = objFirstUserCreation.txtPhoneNumber.Texts.Trim();
                    daoFirstUsage.Username = objFirstUserCreation.txtUsername.Texts.Trim();

                    // Excepto a la contraseña, esa tiene el paso extra de la encriptación con SHA256
                    daoFirstUsage.Password = commonMethods.ComputeSha256Hash(objFirstUserCreation.txtPassword.Texts.Trim());

                    // Se evalúa que se haya logrado la inserción a la tabla tbUsuarios y tbPersonas
                    if (daoFirstUsage.RegisterFirstUser() == 2)
                    {
                        // Se genera una contraseña aleatoria, aunque en este caso particular cumplirá la función de código de confirmación del correo ingresado
                        string confirmationCode = commonMethods.GenerateRandomPassword();
                        MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Se evalua si el correo logró ser enviado
                        if (commonMethods.SendVerificationEmail(daoFirstUsage.Email, confirmationCode) == false)
                        {
                            // Si no se envió, se recupera el ID de este primer usuario y posteriormente se elimina el registro, pues es de suma importancia que el correo sí exista
                            daoFirstUsage.PersonID = daoFirstUsage.GetMaxID();
                            daoFirstUsage.DeleteUser();
                        }
                        else
                        {
                            // Si el correo se envió de manera exitosa, se oculta el formulario actual y se muestra el formulario en el que se tendrá que ingresar el código de confirmación recién generado
                            FrmEmailVerification objEmailVerification = new FrmEmailVerification(confirmationCode);
                            objFirstUserCreation.Hide();
                            objEmailVerification.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos no han podido ser registrados.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        ///     Se verifica que el texto que contiene txtPassword y txtConfirmPassword sean lo mismo
        /// </summary>
        /// <returns></returns>
        private bool VerifyPasswordSimilarity()
        {
            if (objFirstUserCreation.txtPassword.Texts.Trim() == objFirstUserCreation.txtConfirmPassword.Texts.Trim())
            {
                if (CommonMethods.IsPasswordValid(objFirstUserCreation.txtPassword.Texts.Trim()))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("¡Ups! Parece que la contraseña contiene uno o más caracteres no aceptados. Los caracteres aceptados para contraseñas son: abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?@#$%^&*", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Verifique que ambas contraseñas ingresadas coincidan e intente de nuevo.", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        bool ValidateEmail()
        {
            string email = objFirstUserCreation.txtEmail.Texts.Trim();

            // Se verifica que el correo ingresado contenga el carácter '@'
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Formato de correo invalido; por favor verifique que el correo que ha ingresado contenga @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se retorna FALSE porque obviamente no es un correo válido
                return false;
            }
            // Se inicializa un array con los dominios permitidos
            string[] allowedDomains = { "gmail.com", "ricaldone.edu.sv" };

            // Se extrae el dominio del correo ingresado, creando un Substring que le sigue al carácter '@'. El +1 es para que el Substring comience en el siguiente carácter, entonces el Substring es, por ejemplo, "gmail.com" en lugar de "@gmail.com"
            string extention = email.Substring(email.LastIndexOf('@') + 1);

            // Se evalua si el array de dominios permitidos contiene el dominio ingresado por el usuario
            if (!allowedDomains.Contains(extention))
            {
                // Si no lo contiene pues se envía un mensaje de error y se retorna FALSE
                MessageBox.Show("Dominio del correo es invalido, el sistema unicamente admite dominios 'gmail.com' y 'ricaldone.edu.sv'.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Si la condición no se cumple quiere decir que el array si contiene la extensión, por lo que el correo es, en su totalidad, válido. Se retorna TRUE
            return true;
        }
        string GetPlaceholderText(BorderRadiusTXT txt)
        {
            if (txt == objFirstUserCreation.txtName) return "Nombres";
            if (txt == objFirstUserCreation.txtLastName) return "Apellidos";
            if (txt == objFirstUserCreation.txtEmail) return "Correo Electrónico";
            if (txt == objFirstUserCreation.txtPhoneNumber) return "Número de Teléfono";
            if (txt == objFirstUserCreation.txtUsername) return "Usuario";
            if (txt == objFirstUserCreation.txtPassword) return "Contraseña";
            if (txt == objFirstUserCreation.txtConfirmPassword) return "Confirmar contraseña";
            return string.Empty;
        }
    }
}
