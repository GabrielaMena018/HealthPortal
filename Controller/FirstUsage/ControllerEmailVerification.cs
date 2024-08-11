using CustomPanel;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.FirstUsage;
using HealthPortal.View.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.FirstUsage
{
    internal class ControllerEmailVerification
    {
        FrmEmailVerification objEmailVerification;
        string confirmationCode;
        public ControllerEmailVerification(FrmEmailVerification view, string confirmationCode)
        {
            objEmailVerification = view;
            this.confirmationCode = confirmationCode;

            objEmailVerification.txtConfirmationCode.Enter += new EventHandler(EnterTxtConfirmationCode);
            objEmailVerification.txtConfirmationCode.Leave += new EventHandler(LeaveTxtConfirmationCode);
            objEmailVerification.picExit.MouseEnter += new EventHandler(MouseEnterControl);
            objEmailVerification.picExit.MouseLeave += new EventHandler(MouseLeaveControl);
            objEmailVerification.btnConfirmEmail.MouseEnter += new EventHandler(MouseEnterButton);
            objEmailVerification.btnConfirmEmail.MouseLeave += new EventHandler(MouseLeaveButton);
            objEmailVerification.picExit.Click += new EventHandler(ExitForm);
            objEmailVerification.btnConfirmEmail.Click += new EventHandler(CompareConfirmationCode);
        }
        private void EnterTxtConfirmationCode(object sender, EventArgs e)
        {
            if (objEmailVerification.txtConfirmationCode.Texts.Trim().Equals("Código de Confirmación"))
            {
                objEmailVerification.txtConfirmationCode.Clear();
                objEmailVerification.txtConfirmationCode.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtConfirmationCode(object sender, EventArgs e)
        {
            if (objEmailVerification.txtConfirmationCode.Texts.Trim().Equals(""))
            {
                objEmailVerification.txtConfirmationCode.Texts = "Código de Confirmación";
                objEmailVerification.txtConfirmationCode.ForeColor = Color.FromArgb(142, 202, 230);
            }
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
            PictureBox pic = sender as PictureBox;
            pic.Image = Resources.hoverQuit;
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = Resources.quit;
        }
        private void ExitForm(object sender, EventArgs e)
        {
            DAOFirstUsage daoFirstUsage = new DAOFirstUsage();
            DialogResult result = MessageBox.Show("¿Seguro que desea abandonar el proceso de creación del primer usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                daoFirstUsage.DeleteUser();
                MessageBox.Show("Entendido. Registro de primer usuario eliminado.", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void CompareConfirmationCode(object sender, EventArgs e)
        {
            if (confirmationCode == objEmailVerification.txtConfirmationCode.Texts.Trim())
            {
                MessageBox.Show("Correo confirmado de manera exitosa. Registro de primer usuario finalizado exitosamente. De nuevo, ¡bienvenid@ a HealthPortal!", "Correo confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objEmailVerification.Hide();
                objEmailVerification.Dispose();
                FrmLogin objLogin = new FrmLogin();
                objLogin.Show();
            }
            else
            {
                MessageBox.Show("El código de confirmación ingresado no coincide con el que ha sido enviado a su correo. Asegúrese de haberlo ingresado de manera correcta y vuelva a intentarlo.", "Código incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
