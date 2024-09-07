using CustomPanel;
using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Properties;
using HealthPortal.View.Login;
using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerAddUpdateSecurityQuestion
    {
        FrmAddUpdateSecurityQuestion frmAddUpdateSecurityQuestion;
        public ControllerAddUpdateSecurityQuestion(FrmAddUpdateSecurityQuestion view)
        {
            frmAddUpdateSecurityQuestion = view;

            frmAddUpdateSecurityQuestion.MouseDown += new MouseEventHandler(CommonMethods.FormMouseDown);
            frmAddUpdateSecurityQuestion.MouseMove += new MouseEventHandler(CommonMethods.FormMouseMove);
            frmAddUpdateSecurityQuestion.MouseUp += new MouseEventHandler(CommonMethods.FormMouseUp);

            frmAddUpdateSecurityQuestion.txtQuestion.Enter += new EventHandler(EnterTxtQuestion);
            frmAddUpdateSecurityQuestion.txtQuestion.Leave += new EventHandler(LeaveTxtQuestion);

            frmAddUpdateSecurityQuestion.btnExit.MouseEnter += new EventHandler(MouseEnterControl);
            frmAddUpdateSecurityQuestion.btnExit.MouseLeave += new EventHandler(MouseLeaveControl);

            frmAddUpdateSecurityQuestion.btnConfirmQuestion.MouseEnter += new EventHandler(MouseEnterButton);
            frmAddUpdateSecurityQuestion.btnConfirmQuestion.MouseLeave += new EventHandler(MouseLeaveButton);

            frmAddUpdateSecurityQuestion.btnExit.Click += new EventHandler(ExitForm);
            frmAddUpdateSecurityQuestion.btnConfirmQuestion.Click += new EventHandler(RegisterQuestion);
        }
        private void RegisterQuestion(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim()) || frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim() == "Pregunta")
            {
                DAOSettings dao = new DAOSettings();
                dao.Question = frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim();
                if (dao.RegisterQuestion())
                {
                    MessageBox.Show("Pregunta de seguridad registrada exitosamente.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmAddUpdateSecurityQuestion.Hide();
                frmAddUpdateSecurityQuestion.Dispose();
            }
        }
        private void EnterTxtQuestion(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim().Equals("Pregunta"))
            {
                frmAddUpdateSecurityQuestion.txtQuestion.Clear();
                frmAddUpdateSecurityQuestion.txtQuestion.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void LeaveTxtQuestion(object sender, EventArgs e)
        {
            if (frmAddUpdateSecurityQuestion.txtQuestion.Texts.Trim().Equals(""))
            {
                frmAddUpdateSecurityQuestion.txtQuestion.Texts = "Pregunta";
                frmAddUpdateSecurityQuestion.txtQuestion.ForeColor = Color.FromArgb(142, 202, 230);
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
            Button btn = sender as Button;
            btn.Image = Resources.hoverQuit;
        }
        private void MouseLeaveControl(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Resources.quit;
        }
        private void ExitForm(object sender, EventArgs e)
        {
            frmAddUpdateSecurityQuestion.Close();
            frmAddUpdateSecurityQuestion.Dispose();
        }
    }
}
