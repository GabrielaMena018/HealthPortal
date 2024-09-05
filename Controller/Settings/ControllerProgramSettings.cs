using HealthPortal.Model.DAO;
using HealthPortal.View.SectionAdministration;
using HealthPortal.View.Settings;
using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CustomPanel;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerProgramSettings
    {
        FrmProgramSettings frmProgramSettings;
        int expandedFormWidth = 1090;
        Size expandedGrpSize = new Size(923, 219);
        Size collapsedGrpSize = new Size(793, 219);
        Size expandedPnlSize = new Size(986, 528);
        Size collapsedPnlSize = new Size(856, 528);
        Point expandedBtnLocation = new Point(667, 16);
        Point collapsedBtnLocation = new Point(537, 16);

        /// <summary>
        ///     Método constructor de la clase, contiene los eventos y le asigna el valor del argumento al
        ///     objeto previamente creado de tipo FrmProgramSettings
        /// </summary>
        /// <param name="view"></param>
        public ControllerProgramSettings(FrmProgramSettings view)
        {
            frmProgramSettings = view;
            frmProgramSettings.Load += new EventHandler(InitialLoad);
            frmProgramSettings.Resize += new EventHandler(ResizeControls);

            frmProgramSettings.btnAddSecurityQuestion.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmProgramSettings.btnAddSecurityQuestion.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmProgramSettings.btnAddSecurityQuestion.Click += new EventHandler(AddSecurityQuestion);
        }
        private void AddSecurityQuestion(object sender, EventArgs e)
        {
            FrmAddUpdateSecurityQuestion frmAddUpdateSecurityQuestion = new FrmAddUpdateSecurityQuestion();
            frmAddUpdateSecurityQuestion.ShowDialog();
            FillQuestionsDgv();
        }
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmProgramSettings.Width == expandedFormWidth)
            {
                frmProgramSettings.panel2.Size = expandedPnlSize;
                frmProgramSettings.grpSecurityQuestions.Size = expandedGrpSize;
                frmProgramSettings.btnAddSecurityQuestion.Location = expandedBtnLocation;
            }
            else
            {
                frmProgramSettings.panel2.Size = collapsedPnlSize;
                frmProgramSettings.grpSecurityQuestions.Size = collapsedGrpSize;
                frmProgramSettings.btnAddSecurityQuestion.Location = collapsedBtnLocation;
            }
            frmProgramSettings.Refresh();
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
            btn.BackColor = Color.FromArgb(255, 183, 3);
            btn.ForeColor = Color.FromArgb(31, 43, 91);
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckSecurityQuestionsState();
            FillQuestionsDgv();
        }
        private void CheckSecurityQuestionsState()
        {
            DAOSettings dao = new DAOSettings();
            if (dao.CheckSecurityQuestions())
            {
                frmProgramSettings.lblInfo.Text = "Método disponible";
            }
            else
            {
                frmProgramSettings.lblInfo.Text = "No hay preguntas, método no disponible";
            }
        }
        private void FillQuestionsDgv()
        {
            DAOSettings dao = new DAOSettings();
            DataSet ds = dao.RetrieveSecurityQuestions();
            frmProgramSettings.dgvSecurityQuestions.DataSource = ds.Tables["viewPreguntasDeSeguridad"];
            CheckSecurityQuestionsState();
            SetDataGridViewColumnSize();
        }
        private void SetDataGridViewColumnSize()
        {
            frmProgramSettings.dgvSecurityQuestions.Columns[0].Width = 102;
        }
    }
}
