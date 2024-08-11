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

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerFirstUserCreation
    {
        FrmFirstUserCreation objFirstUserCreation;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        public ControllerFirstUserCreation(FrmFirstUserCreation view)
        {
            objFirstUserCreation = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnShowPassword", Tuple.Create(Resources.show, Resources.hoverShow) },
                { "btnHidePassword", Tuple.Create(Resources.hide, Resources.hoverHide) },
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            objFirstUserCreation.Load += new EventHandler(HidePassword);
            objFirstUserCreation.txtName.Enter += new EventHandler(EnterTxtName);
            objFirstUserCreation.txtName.Leave += new EventHandler(LeaveTxtName);
            objFirstUserCreation.txtLastName.Enter += new EventHandler(EnterTxtLastName);
            objFirstUserCreation.txtLastName.Leave += new EventHandler(LeaveTxtLastName);
            objFirstUserCreation.txtEmail.Enter += new EventHandler(EnterTxtEmail);
            objFirstUserCreation.txtEmail.Leave += new EventHandler(LeaveTxtEmail);
            objFirstUserCreation.txtPhoneNumber.Enter += new EventHandler(EnterTxtPhoneNumber);
            objFirstUserCreation.txtPhoneNumber.Leave += new EventHandler(LeaveTxtPhoneNumber);
            objFirstUserCreation.txtUsername.Enter += new EventHandler(EnterTxtUsername);
            objFirstUserCreation.txtUsername.Leave += new EventHandler(LeaveTxtUsername);
            objFirstUserCreation.txtPassword.Enter += new EventHandler(EnterTxtPassword);
            objFirstUserCreation.txtPassword.Leave += new EventHandler(LeaveTxtPassword);
            objFirstUserCreation.txtConfirmPassword.Enter += new EventHandler(EnterTxtConfirmPassword);
            objFirstUserCreation.txtConfirmPassword.Leave += new EventHandler(LeaveTxtConfirmPassword);
            objFirstUserCreation.btnExit.Click += new EventHandler(ExitApplication);
            objFirstUserCreation.btnHidePassword.Click += new EventHandler(ShowPassword);
            objFirstUserCreation.btnShowPassword.Click += new EventHandler(HidePassword);
            objFirstUserCreation.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            objFirstUserCreation.btnHidePassword.MouseEnter += new EventHandler(MouseEnterControl);
            objFirstUserCreation.btnShowPassword.MouseEnter += new EventHandler(MouseEnterControl);
            objFirstUserCreation.btnRegisterFirstUser.MouseEnter += new EventHandler(MouseEnterButton);
            objFirstUserCreation.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);
            objFirstUserCreation.btnHidePassword.MouseLeave += new EventHandler(MouseLeaveControl);
            objFirstUserCreation.btnShowPassword.MouseLeave += new EventHandler(MouseLeaveControl);
            objFirstUserCreation.btnRegisterFirstUser.MouseLeave += new EventHandler(MouseLeaveButton);
            objFirstUserCreation.btnRegisterFirstUser.Click += new EventHandler(AttemptFirstUserRegistration);
        }
        private void ShowPassword(object sender, EventArgs e)
        {
            objFirstUserCreation.txtPassword.PasswordChar = false;
            objFirstUserCreation.txtConfirmPassword.PasswordChar = false;
            objFirstUserCreation.btnHidePassword.Visible = false;
            objFirstUserCreation.btnShowPassword.Visible = true;
        }
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
        private void EnterTxtName(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtName.Texts.Trim().Equals("Nombres"))
            {
                objFirstUserCreation.txtName.Clear();
                objFirstUserCreation.txtName.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtName(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtName.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtName.Texts = "Nombres";
                objFirstUserCreation.txtName.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtLastName(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtLastName.Texts.Trim().Equals("Apellidos"))
            {
                objFirstUserCreation.txtLastName.Clear();
                objFirstUserCreation.txtLastName.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtLastName(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtLastName.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtLastName.Texts = "Apellidos";
                objFirstUserCreation.txtLastName.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtEmail(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtEmail.Texts.Trim().Equals("Correo Electrónico"))
            {
                objFirstUserCreation.txtEmail.Clear();
                objFirstUserCreation.txtEmail.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtEmail(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtEmail.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtEmail.Texts = "Correo Electrónico";
                objFirstUserCreation.txtEmail.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtPhoneNumber(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtPhoneNumber.Texts.Trim().Equals("Número de Teléfono"))
            {
                objFirstUserCreation.txtPhoneNumber.Clear();
                objFirstUserCreation.txtPhoneNumber.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtPhoneNumber(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtPhoneNumber.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtPhoneNumber.Texts = "Número de Teléfono";
                objFirstUserCreation.txtPhoneNumber.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtUsername(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtUsername.Texts.Trim().Equals("Usuario"))
            {
                objFirstUserCreation.txtUsername.Clear();
                objFirstUserCreation.txtUsername.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtUsername(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtUsername.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtUsername.Texts = "Usuario";
                objFirstUserCreation.txtUsername.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void EnterTxtPassword(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtPassword.Texts.Trim().Equals("Contraseña"))
            {
                objFirstUserCreation.txtPassword.Clear();
                objFirstUserCreation.txtPassword.ForeColor = Color.FromArgb(31, 43, 91);
                HidePassword(sender, e);
            }
        }
        private void LeaveTxtPassword(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtPassword.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtPassword.Texts = "Contraseña";
                objFirstUserCreation.txtPassword.ForeColor = Color.FromArgb(142, 202, 230);
                ShowPassword(sender, e);
            }
        }
        private void EnterTxtConfirmPassword(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtConfirmPassword.Texts.Trim().Equals("Confirmar contraseña"))
            {
                objFirstUserCreation.txtConfirmPassword.Clear();
                objFirstUserCreation.txtConfirmPassword.ForeColor = Color.FromArgb(31, 43, 91);
                HidePassword(sender, e);
            }
        }
        private void LeaveTxtConfirmPassword(object sender, EventArgs e)
        {
            if (objFirstUserCreation.txtConfirmPassword.Texts.Trim().Equals(""))
            {
                objFirstUserCreation.txtConfirmPassword.Texts = "Confirmar contraseña";
                objFirstUserCreation.txtConfirmPassword.ForeColor = Color.FromArgb(142, 202, 230);
                ShowPassword(sender, e);
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MouseEnterButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(31, 43, 91);
            btn.ForeColor = Color.White;
        }
        private void MouseLeaveButton(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            btn.BackColor = Color.FromArgb(142, 202, 230);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void MouseEnterControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.BackgroundImage = imageMapping[btn.Name].Item2;
            }
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.BackgroundImage = imageMapping[btn.Name].Item1;
            }
        }
        private void AttemptFirstUserRegistration(object sender, EventArgs e)
        {
            if (!(objFirstUserCreation.txtLastName.Texts.Trim() == "" || objFirstUserCreation.txtLastName.Texts.Trim() == "" || objFirstUserCreation.txtEmail.Texts.Trim() == "" || objFirstUserCreation.txtPhoneNumber.Texts.Trim() == "" || objFirstUserCreation.txtUsername.Texts.Trim() == "" || objFirstUserCreation.txtPassword.Texts.Trim() == "" || objFirstUserCreation.txtConfirmPassword.Texts.Trim() == ""))
            {
                if (VerifyPasswordSimilarity() == true && ValidateEmail() == true)
                {
                    DAOFirstUsage daoFirstUsage = new DAOFirstUsage();
                    CommonMethods commonMethods = new CommonMethods();
                    daoFirstUsage.Name = objFirstUserCreation.txtName.Texts.Trim();
                    daoFirstUsage.LastName = objFirstUserCreation.txtLastName.Texts.Trim();
                    daoFirstUsage.Email = objFirstUserCreation.txtEmail.Texts.Trim();
                    daoFirstUsage.Phone = objFirstUserCreation.txtPhoneNumber.Texts.Trim();
                    daoFirstUsage.Username = objFirstUserCreation.txtUsername.Texts.Trim();
                    daoFirstUsage.Password = commonMethods.ComputeSha256Hash(objFirstUserCreation.txtPassword.Texts.Trim());
                    if (daoFirstUsage.RegisterFirstUser() == 2)
                    {
                        string confirmationCode = commonMethods.GenerateRandomPassword();
                        MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (commonMethods.SendVerificationEmail(daoFirstUsage.Email, confirmationCode) == false)
                        {
                            daoFirstUsage.PersonID = daoFirstUsage.GetMaxID();
                            daoFirstUsage.DeleteUser();
                        }
                        else
                        {
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
        bool ValidateEmail()
        {
            string email = objFirstUserCreation.txtEmail.Texts.Trim();
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Formato de correo invalido; por favor verifique que el correo que ha ingresado contenga @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string[] allowedDomains = { "gmail.com", "ricaldone.edu.sv" };
            string extention = email.Substring(email.LastIndexOf('@') + 1);
            if (!allowedDomains.Contains(extention))
            {
                MessageBox.Show("Dominio del correo es invalido, el sistema unicamente admite dominios 'gmail.com' y 'ricaldone.edu.sv'.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
