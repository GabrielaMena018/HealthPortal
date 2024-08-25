using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Model.DAO;
using HealthPortal.View.FirstUsage;
using HealthPortal.View.Login;
using System.Drawing;
using System.IO;

namespace HealthPortal.Helper
{
    internal class CommonMethods
    {
        static bool dragging = false;
        static Point dragCursorPoint, dragFormPoint;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public static void DetermineInitialForm()
        {
            DAOLogin daoLogin = new DAOLogin();
            if (daoLogin.GetAmountOfUsers() == 0)
            {
                if (daoLogin.GetInstitutionInfo() == 0)
                {
                    Application.Run(new FrmInstitutionCreation());
                }
                else
                {
                    Application.Run(new FrmFirstUserCreation());
                }
            }
            else
            {
                Application.Run(new FrmLogin());
            }
        }
        public string ComputeSha256Hash(string rawData)
        {
            // Crear una instancia de SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computar el hash - devuelve un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convertir byte array a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string GenerateRandomPassword()
        {
            const string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?@#$%^&*";
            StringBuilder password = new StringBuilder();
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] data = new byte[8];
            rng.GetBytes(data);
            foreach (byte a in data)
            {
                password.Append(validCharacters[a % validCharacters.Length]);
            }
            return password.ToString();
        }
        public static bool IsPasswordValid(string password)
        {
            const string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?@#$%^&*";
            foreach (char a in password)
            {
                if (!validCharacters.Contains(a))
                {
                    return false;
                }
            }
            return true;
        }
        public bool SendVerificationEmail(string email, string confirmationCode)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "ausw xphf aobi nemd"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Confirmación de Correo",
                    Body = $"¡Ha sido registrado como usuario en HealthPortal! El código de confirmación que deberá utilizar para confirmar su contraseña es: '{confirmationCode}'.",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Correo de confirmación de cuenta enviado exitosamente.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar. Error: {ex.Message}", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool SendEmail(string temporaryPassword, string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "ausw xphf aobi nemd"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Contraseña Temporal",
                    Body = $"¡Ha sido registrado como usuario en HealthPortal! La contraseña que deberá utilizar para inciar sesión es: '{temporaryPassword}'. Claro está que, por motivos de seguridad, es indispensable que, al iniciar sesión por primera vez, se asegure de cambiar la contraseña.",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Contraseña temporal enviada al usuario a través de su correo electrónico de manera exitosa.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar. Error: {ex.Message}", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool SendRecoveryEmail(string temporaryPassword, string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential($"healthportal.noreply@gmail.com", "ausw xphf aobi nemd"),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("healthportal.noreply@gmail.com"),
                    Subject = "Contraseña Temporal",
                    Body = $"Al parecer ha olvidado su contraseña para iniciar sesión en HealthPortal. La contraseña que deberá utilizar para inciar sesión es: '{temporaryPassword}'. Claro está que, por motivos de seguridad, es indispensable que, al iniciar sesión con esta nueva contraseña, se asegure de cambiar la contraseña a una de su elección. Además, ¡asegúrese de recordarla esta vez!",
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
                MessageBox.Show($"Contraseña temporal enviada al usuario a través de su correo electrónico de manera exitosa.", "Correo enviado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al enviar el correo. Revise el correo ingresado y vuelva a intentar. Error: {ex.Message}", "Error al enviar el correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public void DisposeOfCurrentUserData()
        {
            CurrentUserData.Username = string.Empty;
            CurrentUserData.Status = false;
            CurrentUserData.FullName = string.Empty;
            CurrentUserData.Password = string.Empty;
            CurrentUserData.RoleId = 0;
            CurrentUserData.TemporaryPassword = false;
            CurrentUserData.Email = string.Empty;
        }
        static public void FormMouseDown(object sender)
        {
            Form frm = sender as Form;
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = frm.Location;
            frm.Cursor = Cursors.Hand;
        }
        static public void FormMouseMove(object sender)
        {
            Form frm = sender as Form;
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                frm.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        static public void FormMouseUp(object sender)
        {
            Form frm = sender as Form;
            dragging = false;
            frm.Cursor = Cursors.Default;
        }
        static public byte[] ImageToByteArray(Image img)
        {
            if (img != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
            return null;
        }
        static public Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream memoryStream = new MemoryStream(byteArray);
                return Image.FromStream(memoryStream);
            }
            return null;
        }
    }
}