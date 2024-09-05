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

namespace HealthPortal.Controller.PatientAdministration
{
    internal class ControllerPatientAdministration
    {
        FrmPatientAdministration objPatientAdministration;
        public ControllerPatientAdministration(FrmPatientAdministration view)
        {
            objPatientAdministration = view;
            //objPatientAdministration.btnPrint.Click += new EventHandler(NewStudentPatient);
            objPatientAdministration.Load += new EventHandler(InitialCharge);
            objPatientAdministration.cmsActualizar.Click += new EventHandler(UpdatePatient);
            objPatientAdministration.cmsVer.Click += new EventHandler(ViewPatientFile);
            objPatientAdministration.cmsEliminar.Click += new EventHandler(DeletePatient);
            objPatientAdministration.BtnBuscar.Click += new EventHandler(SearchPatient);
            objPatientAdministration.txtSearch.MouseEnter += new EventHandler(ClearTxt);
            objPatientAdministration.txtSearch.MouseLeave += new EventHandler(TextTxt);
            objPatientAdministration.BtnFiltrar.Click += new EventHandler(SearchPatientByDate);
            objPatientAdministration.CmbSpecialty.SelectedIndexChanged += new EventHandler(SearchPatientBySpecialty);
            objPatientAdministration.CmbGrade.SelectedIndexChanged += new EventHandler(SearchGrado);
            objPatientAdministration.cmbRol.SelectedIndexChanged += new EventHandler(SearchRole);
            objPatientAdministration.btnShowAll.Click += new EventHandler(RefreshStudentData);
            //objPatientAdministration.btnPDF.Click += new EventHandler(VisitReport);
            objPatientAdministration.PickFechaVisita.Value = DateTime.Now;

        }

        //private void VisitReport(object sender, EventArgs e)
        //{
        //    FrmReportGeneralPatient openForm = new FrmReportGeneralPatient();
        //    openForm.ShowDialog();
        //}

        private void CheckUserAccessLevel()
        {
            if (CurrentUserData.RoleId == 4 && CurrentUserData.RoleId == 5)
            {
                objPatientAdministration.cmsEliminar.Enabled = false;
                objPatientAdministration.cmsActualizar.Enabled = false;
            }
        }
        private void SearchGrado(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            string search = objPatientAdministration.CmbGrade.Text;
            DataSet ds = daoPatientAdministration.SearchPatientGrade(search);
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
        }

        //Buscar por tipo persona
        private void SearchRole(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            string search = objPatientAdministration.cmbRol.Text;
            DataSet ds = daoPatientAdministration.SearchPatientRole(search);
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
        }

        //BUscar por specialty
        private void SearchPatientBySpecialty(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            string search = objPatientAdministration.CmbSpecialty.Text;
            DataSet ds = daoPatientAdministration.SearchPatientSpecialty(search);
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
        }

        //Buscar por date
        private void SearchPatientByDate(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            DateTime searchDate = objPatientAdministration.PickFechaVisita.Value.Date;
            DataSet ds = daoPatientAdministration.SearchPatientDate(searchDate);
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
        }

        //Buscar paciente
        private void SearchPatient(object sender, EventArgs e)
        {
            RefreshPatientData();
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            string search = objPatientAdministration.txtSearch.Texts;
            DataSet ds = daoPatientAdministration.SearchPatient(search);
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
        }

        private void TextTxt(object sender, EventArgs e)
        {
            if (objPatientAdministration.txtSearch.Texts == "")
            {
                objPatientAdministration.txtSearch.Texts = "Buscar";
            }
        }

        private void ClearTxt(object sender, EventArgs e)
        {
            if (objPatientAdministration.txtSearch.Texts == "Buscar")
            {
                objPatientAdministration.txtSearch.Clear();
            }
            if (objPatientAdministration.txtSearch.Texts == "")
            {
                RefreshPatientData();
            }
        }
        //Mandar a recolectar de cada columna del data grid la información del paciente que pertenece al personal de la institución y mandarlo a la vista FrmAddPatience
        //Mandar a recolectar de cada columna del data grid la información del estudiante y mandarlo a la vista FrmAddPatience
        private void ViewPatientFile(object sender, EventArgs e)
        {
            int pos = objPatientAdministration.GridViewPatient.CurrentRow.Index;
            int IdPatient;
            string PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, housVisit, nameMedication, Observations;
            DateTime DateVisit;

            IdPatient = int.Parse(objPatientAdministration.GridViewPatient[0, pos].Value.ToString());
            PatientName = objPatientAdministration.GridViewPatient[1, pos].Value.ToString();
            PatientLastName = objPatientAdministration.GridViewPatient[2, pos].Value.ToString();
            TypePerson = objPatientAdministration.GridViewPatient[3, pos].Value.ToString();
            Code = objPatientAdministration.GridViewPatient[4, pos].Value.ToString();
            technicalGroup = objPatientAdministration.GridViewPatient[5, pos].Value.ToString();
            Grade = objPatientAdministration.GridViewPatient[6, pos].Value.ToString();
            sectionAcademic = objPatientAdministration.GridViewPatient[7, pos].Value.ToString();
            Specialty = objPatientAdministration.GridViewPatient[8, pos].Value.ToString();
            DateVisit = DateTime.Parse(objPatientAdministration.GridViewPatient[9, pos].Value.ToString());
            housVisit = objPatientAdministration.GridViewPatient[10, pos].Value.ToString();
            nameMedication = objPatientAdministration.GridViewPatient[11, pos].Value.ToString();
            Observations = objPatientAdministration.GridViewPatient[12, pos].Value.ToString();

            FrmAddUpdatePatient openForm = new FrmAddUpdatePatient(3, IdPatient, PatientName, PatientLastName, TypePerson, Code, technicalGroup, Grade, sectionAcademic, Specialty, DateVisit, housVisit, nameMedication, Observations);
            openForm.ShowDialog();
            RefreshPatientData();
        }
        //Esta es la carga inicial la cual se encarga de llenar los combobox
        private void InitialCharge(object sender, EventArgs e)
        {
            CheckUserAccessLevel();

            //Objeto de la clase DAOAdminUsuarios
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo

            DataSet ds = daoPatientAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox tbRole
            objPatientAdministration.CmbSpecialty.DataSource = ds.Tables["tbEspecialidades"];
            objPatientAdministration.CmbSpecialty.ValueMember = "idEspecialidad";
            objPatientAdministration.CmbSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = daoPatientAdministration.FillCombo("tbGrados", "Secciones");
            //Llenar combobox tbGrados
            objPatientAdministration.CmbGrade.DataSource = dsGradosRegistros.Tables["tbGrados"];
            objPatientAdministration.CmbGrade.ValueMember = "idGrado";
            objPatientAdministration.CmbGrade.DisplayMember = "grado";

            DataSet dsRol = daoPatientAdministration.FillCombo("tbTipoPersona", "Pacientes");
            //Llenar combobox tbRole
            objPatientAdministration.cmbRol.DataSource = dsRol.Tables["tbTipoPersona"];
            objPatientAdministration.cmbRol.ValueMember = "idTipoPersona";
            objPatientAdministration.cmbRol.DisplayMember = "tipoPersona";

            RefreshPatientData();
        }
        public void NewStudentPatient(object sender, EventArgs e)
        {
            FrmAddUpdatePatient openForm = new FrmAddUpdatePatient(1);
            openForm.ShowDialog();
            RefreshPatientData();
        }

        //REFRESH

        //Con este metodo se puede ver la información de la vista ViewAdminPatientque llena el datGrid de de los estudiantes
        public void RefreshPatientData()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = daoPatientAdministration.AdminPatient();
            //Llenar DataGridView
            objPatientAdministration.GridViewPatient.DataSource = ds.Tables["viewAdminPacientes"];
            objPatientAdministration.GridViewPatient.Columns[0].HeaderText = "ID";
            objPatientAdministration.GridViewPatient.Columns[0].Width = 35;
            objPatientAdministration.GridViewPatient.Columns[1].HeaderText = "Nombre";
            objPatientAdministration.GridViewPatient.Columns[1].Width = 145;
            objPatientAdministration.GridViewPatient.Columns[2].HeaderText = "Apellidos";
            objPatientAdministration.GridViewPatient.Columns[2].Width = 145;
            objPatientAdministration.GridViewPatient.Columns[3].HeaderText = "Tipo Persona";
            objPatientAdministration.GridViewPatient.Columns[3].Width = 80;
            objPatientAdministration.GridViewPatient.Columns[4].HeaderText = "Código";
            objPatientAdministration.GridViewPatient.Columns[5].Visible = false;
            objPatientAdministration.GridViewPatient.Columns[6].HeaderText = "Grade ";
            objPatientAdministration.GridViewPatient.Columns[6].Width = 70;
            objPatientAdministration.GridViewPatient.Columns[7].HeaderText = "Sección";
            objPatientAdministration.GridViewPatient.Columns[7].Width = 63;
            objPatientAdministration.GridViewPatient.Columns[6].Width = 70;
            objPatientAdministration.GridViewPatient.Columns[8].HeaderText = "Especialidad";
            objPatientAdministration.GridViewPatient.Columns[8].Width = 175;
            objPatientAdministration.GridViewPatient.Columns[9].HeaderText = "Fecha de visita";
            objPatientAdministration.GridViewPatient.Columns[9].Width = 80;
            objPatientAdministration.GridViewPatient.Columns[10].HeaderText = "Hora de visita";
            objPatientAdministration.GridViewPatient.Columns[10].Width = 70;
            objPatientAdministration.GridViewPatient.Columns[11].Visible = false;
            objPatientAdministration.GridViewPatient.Columns[12].Visible = false;
        }

        private void RefreshStudentData(object sender, EventArgs e)
        {
            RefreshPatientData();
        }

        //UPDATE

        //Mandar la información del data grid para empezar el proceso de update y llenado de formulario de los estudiantes
        private void UpdatePatient(object sender, EventArgs e)
        {

            int pos = objPatientAdministration.GridViewPatient.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objPatientAdministration.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objPatientAdministration.GridViewPatient[1, pos].Value.ToString();
            apellidoPaciente = objPatientAdministration.GridViewPatient[2, pos].Value.ToString();
            TipoPersona = objPatientAdministration.GridViewPatient[3, pos].Value.ToString();
            codigo = objPatientAdministration.GridViewPatient[4, pos].Value.ToString();
            grupoTecnico = objPatientAdministration.GridViewPatient[5, pos].Value.ToString();
            grado = objPatientAdministration.GridViewPatient[6, pos].Value.ToString();
            seccionAcademica = objPatientAdministration.GridViewPatient[7, pos].Value.ToString();
            Especialidad = objPatientAdministration.GridViewPatient[8, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objPatientAdministration.GridViewPatient[9, pos].Value.ToString());
            horaVisita = objPatientAdministration.GridViewPatient[10, pos].Value.ToString();
            nombreMedicamento = objPatientAdministration.GridViewPatient[11, pos].Value.ToString();
            Observaciones = objPatientAdministration.GridViewPatient[12, pos].Value.ToString();

            FrmAddUpdatePatient openFrom = new FrmAddUpdatePatient(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefreshPatientData();


        }

        //Mandar información del data grid para empezar el proceso de llenar el formulario del maestro

        //DELETE

        //Eliminar paciente que sean estudiantes
        private void DeletePatient(object sender, EventArgs e)
        {
            int pos = objPatientAdministration.GridViewPatient.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {objPatientAdministration.GridViewPatient[1, pos].Value.ToString()} {objPatientAdministration.GridViewPatient[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
                daoPatientAdministration.IdVisit = int.Parse(objPatientAdministration.GridViewPatient[0, pos].Value.ToString());
                int ValorRetornado = daoPatientAdministration.DeleteVisit();
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