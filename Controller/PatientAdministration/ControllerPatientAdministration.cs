using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HealthPortal.Model.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.View.PatientAdministration;
using HealthPortal.Helper;
using HealthPortal.View.SectionAdministration;
using CustomControls;
using System.Drawing;

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPatientAdministration
    {
        FrmPatientAdministration frmPatientAdministration;
        int expandedFormWidth = 1370;
        int collapsedFormWidth = 1240;
        public ControllerPatientAdministration(FrmPatientAdministration view)
        {
            frmPatientAdministration = view;
            frmPatientAdministration.Load += new EventHandler(InitialLoad);
            frmPatientAdministration.Resize += new EventHandler(ResizeControls);

            frmPatientAdministration.btnNew.Click += new EventHandler(NewStudentPatient);

            frmPatientAdministration.cmsUpdate.Click += new EventHandler(UpdatePatient);

            frmPatientAdministration.cmsView.Click += new EventHandler(ViewPatientFile);

            frmPatientAdministration.cmsDelete.Click += new EventHandler(DeletePatient);

            frmPatientAdministration.btnSearch.Click += new EventHandler(SearchPatient);
            frmPatientAdministration.btnFilter.Click += new EventHandler(SearchPatientByDate);
            frmPatientAdministration.cmbSpecialty.SelectedIndexChanged += new EventHandler(SearchPatientBySpecialty);
            frmPatientAdministration.cmbGrade.SelectedIndexChanged += new EventHandler(SearchByGrade);
            frmPatientAdministration.cmbRole.SelectedIndexChanged += new EventHandler(SearchByRole);

            frmPatientAdministration.btnShowAll.Click += new EventHandler(LoadPatientData);
            frmPatientAdministration.cmsShowAll.Click += new EventHandler(LoadPatientData);

            frmPatientAdministration.btnFilter.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnNew.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnSearch.MouseEnter += new EventHandler(MouseEnterTextButton);
            frmPatientAdministration.btnShowAll.MouseEnter += new EventHandler(MouseEnterTextButton);

            frmPatientAdministration.btnFilter.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnNew.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnSearch.MouseLeave += new EventHandler(MouseLeaveTextButton);
            frmPatientAdministration.btnShowAll.MouseLeave += new EventHandler(MouseLeaveTextButton);

            //frmPatientAdministration.btnPDF.Click += new EventHandler(VisitReport);
            frmPatientAdministration.dtpVisitDate.Value = DateTime.Now;
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
        private void ResizeControls(object sender, EventArgs e)
        {
            if (frmPatientAdministration.Width == expandedFormWidth)
            {
                frmPatientAdministration.panelCustom2.Width = 908;
                frmPatientAdministration.btnShowAll.Visible = true;
                frmPatientAdministration.cmsShowAll.Visible = false;
            }
            else if (frmPatientAdministration.Width == collapsedFormWidth)
            {
                frmPatientAdministration.panelCustom2.Width = 778;
                frmPatientAdministration.btnShowAll.Visible = false;
                frmPatientAdministration.cmsShowAll.Visible = true;
            }
            frmPatientAdministration.dgvPatientInfo.Dock = DockStyle.Fill;
            frmPatientAdministration.Refresh();
        }

        //private void VisitReport(object sender, EventArgs e)
        //{
        //    FrmReportGeneralPatient frmAddUpdatePatient = new FrmReportGeneralPatient();
        //    frmAddUpdatePatient.ShowDialog();
        //}

        private void CheckUserAccessLevel()
        {
            if (CurrentUserData.RoleId == 4 && CurrentUserData.RoleId == 5)
            {
                frmPatientAdministration.cmsDelete.Enabled = false;
                frmPatientAdministration.cmsUpdate.Enabled = false;
            }
        }
        private void SearchByGrade(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbGrade.Text;
            DataSet ds = dao.SearchPatientGrade(search);
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchByRole(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbRole.Text;
            DataSet ds = dao.SearchPatientRole(search);
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatientBySpecialty(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.cmbSpecialty.Text;
            DataSet ds = dao.SearchPatientSpecialty(search);
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatientByDate(object sender, EventArgs e)
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            DateTime searchDate = frmPatientAdministration.dtpVisitDate.Value.Date;
            DataSet ds = dao.SearchPatientDate(searchDate);
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void SearchPatient(object sender, EventArgs e)
        {
            RefreshPatientData();
            DAOPatientAdministration dao = new DAOPatientAdministration();
            string search = frmPatientAdministration.txtSearch.Texts;
            DataSet ds = dao.SearchPatient(search);
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
        }
        private void ViewPatientFile(object sender, EventArgs e)
        {
            int pos = frmPatientAdministration.dgvPatientInfo.CurrentRow.Index;
            int IdPatient;
            string PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, housVisit, nameMedication, Observations;
            DateTime DateVisit;

            IdPatient = int.Parse(frmPatientAdministration.dgvPatientInfo[0, pos].Value.ToString());
            PatientName = frmPatientAdministration.dgvPatientInfo[1, pos].Value.ToString();
            PatientLastName = frmPatientAdministration.dgvPatientInfo[2, pos].Value.ToString();
            TypePerson = frmPatientAdministration.dgvPatientInfo[3, pos].Value.ToString();
            Code = frmPatientAdministration.dgvPatientInfo[4, pos].Value.ToString();
            technicalGroup = frmPatientAdministration.dgvPatientInfo[5, pos].Value.ToString();
            Grade = frmPatientAdministration.dgvPatientInfo[6, pos].Value.ToString();
            sectionAcademic = frmPatientAdministration.dgvPatientInfo[7, pos].Value.ToString();
            Specialty = frmPatientAdministration.dgvPatientInfo[8, pos].Value.ToString();
            DateVisit = DateTime.Parse(frmPatientAdministration.dgvPatientInfo[9, pos].Value.ToString());
            housVisit = frmPatientAdministration.dgvPatientInfo[10, pos].Value.ToString();
            nameMedication = frmPatientAdministration.dgvPatientInfo[11, pos].Value.ToString();
            Observations = frmPatientAdministration.dgvPatientInfo[12, pos].Value.ToString();

            FrmAddUpdatePatient frmAddUpdatePatient = new FrmAddUpdatePatient(3, IdPatient, PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, DateVisit, housVisit, nameMedication, Observations);
            frmAddUpdatePatient.ShowDialog();
            RefreshPatientData();
        }
        private void InitialLoad(object sender, EventArgs e)
        {
            CheckUserAccessLevel();
            DAOPatientAdministration dao = new DAOPatientAdministration();

            DataSet ds = dao.FillCombo("tbEspecialidades", "Secciones");
            frmPatientAdministration.cmbSpecialty.DataSource = ds.Tables["tbEspecialidades"];
            frmPatientAdministration.cmbSpecialty.ValueMember = "idEspecialidad";
            frmPatientAdministration.cmbSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = dao.FillCombo("tbGrados", "Secciones");
            frmPatientAdministration.cmbGrade.DataSource = dsGradosRegistros.Tables["tbGrados"];
            frmPatientAdministration.cmbGrade.ValueMember = "idGrado";
            frmPatientAdministration.cmbGrade.DisplayMember = "grado";

            DataSet dsRol = dao.FillCombo("tbTipoPersona", "Pacientes");
            frmPatientAdministration.cmbRole.DataSource = dsRol.Tables["tbTipoPersona"];
            frmPatientAdministration.cmbRole.ValueMember = "idTipoPersona";
            frmPatientAdministration.cmbRole.DisplayMember = "tipoPersona";

            RefreshPatientData();
        }
        public void NewStudentPatient(object sender, EventArgs e)
        {
            FrmAddUpdatePatient frmAddUpdatePatient = new FrmAddUpdatePatient(1);
            frmAddUpdatePatient.ShowDialog();
            RefreshPatientData();
        }
        public void RefreshPatientData()
        {
            DAOPatientAdministration dao = new DAOPatientAdministration();
            DataSet ds = dao.RetrieveDgvInfo();
            frmPatientAdministration.dgvPatientInfo.DataSource = ds.Tables["viewAdminPacientes"];
            frmPatientAdministration.dgvPatientInfo.Columns[0].HeaderText = "ID";
            frmPatientAdministration.dgvPatientInfo.Columns[0].Width = 32;
            frmPatientAdministration.dgvPatientInfo.Columns[1].HeaderText = "Nombre";
            frmPatientAdministration.dgvPatientInfo.Columns[2].HeaderText = "Apellidos";
            frmPatientAdministration.dgvPatientInfo.Columns[3].HeaderText = "Tipo Persona";
            frmPatientAdministration.dgvPatientInfo.Columns[4].HeaderText = "Código";
            frmPatientAdministration.dgvPatientInfo.Columns[5].Visible = false;
            frmPatientAdministration.dgvPatientInfo.Columns[6].HeaderText = "Grado";
            frmPatientAdministration.dgvPatientInfo.Columns[7].HeaderText = "Sección";
            frmPatientAdministration.dgvPatientInfo.Columns[8].HeaderText = "Especialidad";
            frmPatientAdministration.dgvPatientInfo.Columns[9].HeaderText = "Fecha de visita";
            frmPatientAdministration.dgvPatientInfo.Columns[10].HeaderText = "Hora de visita";
            frmPatientAdministration.dgvPatientInfo.Columns[11].Visible = false;
            frmPatientAdministration.dgvPatientInfo.Columns[12].Visible = false;
            frmPatientAdministration.dgvPatientInfo.Columns[13].Visible = false;
        }
        private void LoadPatientData(object sender, EventArgs e)
        {
            RefreshPatientData();
        }
        private void UpdatePatient(object sender, EventArgs e)
        {

            int pos = frmPatientAdministration.dgvPatientInfo.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(frmPatientAdministration.dgvPatientInfo[0, pos].Value.ToString());
            nombrePaciente = frmPatientAdministration.dgvPatientInfo[1, pos].Value.ToString();
            apellidoPaciente = frmPatientAdministration.dgvPatientInfo[2, pos].Value.ToString();
            TipoPersona = frmPatientAdministration.dgvPatientInfo[3, pos].Value.ToString();
            codigo = frmPatientAdministration.dgvPatientInfo[4, pos].Value.ToString();
            grupoTecnico = frmPatientAdministration.dgvPatientInfo[5, pos].Value.ToString();
            grado = frmPatientAdministration.dgvPatientInfo[6, pos].Value.ToString();
            seccionAcademica = frmPatientAdministration.dgvPatientInfo[7, pos].Value.ToString();
            Especialidad = frmPatientAdministration.dgvPatientInfo[8, pos].Value.ToString();
            FechaVisita = DateTime.Parse(frmPatientAdministration.dgvPatientInfo[9, pos].Value.ToString());
            horaVisita = frmPatientAdministration.dgvPatientInfo[10, pos].Value.ToString();
            nombreMedicamento = frmPatientAdministration.dgvPatientInfo[11, pos].Value.ToString();
            Observaciones = frmPatientAdministration.dgvPatientInfo[12, pos].Value.ToString();

            FrmAddUpdatePatient openFrom = new FrmAddUpdatePatient(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefreshPatientData();


        }

        //Mandar información del data grid para empezar el proceso de llenar el formulario del maestro

        //DELETE

        //Eliminar paciente que sean estudiantes
        private void DeletePatient(object sender, EventArgs e)
        {
            int pos = frmPatientAdministration.dgvPatientInfo.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {frmPatientAdministration.dgvPatientInfo[1, pos].Value.ToString()} {frmPatientAdministration.dgvPatientInfo[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPatientAdministration dao = new DAOPatientAdministration();
                dao.IdVisit = int.Parse(frmPatientAdministration.dgvPatientInfo[0, pos].Value.ToString());
                int ValorRetornado = dao.DeleteVisit();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPatientData();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}