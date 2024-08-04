using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Model.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;



namespace RegistroPacientes.Controlador
{
    internal class ControllerAdminPatience
    {
        FrmAdminPatience objAdminPatience;


        //Constructor
        public ControllerAdminPatience(FrmAdminPatience Vista)
        {
            objAdminPatience = Vista;
            objAdminPatience.btnNew.Click += new EventHandler(newstudentpatient);
            objAdminPatience.Load += new EventHandler(InitialCharge);
            objAdminPatience.cmsActualizar.Click += new EventHandler(UpdatePatient);
            objAdminPatience.cmsVer.Click += new EventHandler(ViewPatientFile);
            objAdminPatience.cmsEliminar.Click += new EventHandler(DeletePatient);
            objAdminPatience.BtnBuscar.Click += new EventHandler(SearchPatient);
            objAdminPatience.txtSearch.MouseEnter += new EventHandler(ClearTxt);
            objAdminPatience.txtSearch.MouseLeave += new EventHandler(TextTxt);
            objAdminPatience.BtnFiltrar.Click += new EventHandler(SearchPatientDate);
            objAdminPatience.CmbSpecialty.SelectedIndexChanged += new EventHandler(SearchEspecialidad);
            objAdminPatience.CmbGrade.SelectedIndexChanged += new EventHandler(SearchGrado);
            objAdminPatience.cmbRol.SelectedIndexChanged += new EventHandler(SearchRol);
            objAdminPatience.BtnView.Click += new EventHandler(RefreshDataStudent);
            objAdminPatience.PickFechaVisita.Value = DateTime.Now;

        }

        //SEARCH

        //Buscar por grados
        private void SearchGrado(object sender, EventArgs e)
        {
            DAOAdminPatience daoSearchPatientEspecialidad = new DAOAdminPatience();
            string search = objAdminPatience.CmbGrade.Text;
            DataSet ds = daoSearchPatientEspecialidad.SearchPatientGrade(search);
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }

        //Buscar por tipo persona
        private void SearchRol(object sender, EventArgs e)
        {
            DAOAdminPatience daoSearchPatientEspecialidad = new DAOAdminPatience();
            string search = objAdminPatience.cmbRol.Text;
            DataSet ds = daoSearchPatientEspecialidad.SearchPatientRol(search);
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }

        //BUscar por specialty
        private void SearchEspecialidad(object sender, EventArgs e)
        {
            DAOAdminPatience daoSearchPatientEspecialidad = new DAOAdminPatience();
            string search = objAdminPatience.CmbSpecialty.Text;
            DataSet ds = daoSearchPatientEspecialidad.SearchPatientSpecialty(search);
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }

        //Buscar por date
        private void SearchPatientDate(object sender, EventArgs e)
        {
            DAOAdminPatience daoSearchPatientDate = new DAOAdminPatience();
            DateTime searchDate = objAdminPatience.PickFechaVisita.Value.Date;
            DataSet ds = daoSearchPatientDate.SearchPatientDate(searchDate);
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }

        //Buscar paciente
        private void SearchPatient(object sender, EventArgs e)
        {
                RefrescarDataPaciente();
                DAOAdminPatience daoSearchPatient = new DAOAdminPatience();
                string search = objAdminPatience.txtSearch.Texts;
                DataSet ds = daoSearchPatient.SearchPatient(search);
                objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }

        private void TextTxt(object sender, EventArgs e)
        {
            if (objAdminPatience.txtSearch.Texts == "")
            {
                objAdminPatience.txtSearch.Texts = "Búscar";
            }
        }

        private void ClearTxt(object sender, EventArgs e)
        {
            if (objAdminPatience.txtSearch.Texts == "Búscar")
            {
                objAdminPatience.txtSearch.Clear();
            }
            if (objAdminPatience.txtSearch.Texts == "")
            {
                RefrescarDataPaciente();
            }
        }


        //VIEW

        //Mandar a recolectar de cada columna del data grid la información del paciente que pertenece al personal de la institución y mandarlo a la vista FrmAddPatience


        //Mandar a recolectar de cada columna del data grid la información del estudiante y mandarlo a la vista FrmAddPatience
        private void ViewPatientFile(object sender, EventArgs e)
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int IdPatient;
            string PatientName, PatientLastName, TypePerson, Code, groupTechnical, Grade, sectionAcademic, Specialty, housVisit, nameMedication, Observations;
            DateTime DateVisit;

            IdPatient = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            PatientName = objAdminPatience.GridViewPatient[1, pos].Value.ToString();
            PatientLastName = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            TypePerson = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            Code = objAdminPatience.GridViewPatient[4, pos].Value.ToString();
            groupTechnical = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            Grade = objAdminPatience.GridViewPatient[6, pos].Value.ToString();
            sectionAcademic = objAdminPatience.GridViewPatient[7, pos].Value.ToString();
            Specialty = objAdminPatience.GridViewPatient[8, pos].Value.ToString();
            DateVisit = DateTime.Parse(objAdminPatience.GridViewPatient[9, pos].Value.ToString());
            housVisit = objAdminPatience.GridViewPatient[10, pos].Value.ToString();
            nameMedication = objAdminPatience.GridViewPatient[11, pos].Value.ToString();
            Observations = objAdminPatience.GridViewPatient[12, pos].Value.ToString();

            FrmAddPatience openFrom = new FrmAddPatience(3, IdPatient, PatientName, PatientLastName, TypePerson, Code, groupTechnical, Grade, sectionAcademic, Specialty, DateVisit, housVisit, nameMedication, Observations);
            openFrom.ShowDialog();
            RefrescarDataPaciente();
        }

        //INITIAL CHARGE

        //Esta es la carga inicial la cual se encarga de llenar los combobox
        private void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            

            DataSet dsEspRegistro = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox tbRole
            objAdminPatience.CmbSpecialty.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            objAdminPatience.CmbSpecialty.ValueMember = "IdEspecialidad";
            objAdminPatience.CmbSpecialty.DisplayMember = "Especialidad";

            DataSet dsGradosRegistros = objAdmin.LlenarCombo("tbGrados");
            //Llenar combobox tbGrados
            objAdminPatience.CmbGrade.DataSource = dsGradosRegistros.Tables["tbGrados"];
            objAdminPatience.CmbGrade.ValueMember = "IdGrado";
            objAdminPatience.CmbGrade.DisplayMember = "Grado";

            DataSet dsRol = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            objAdminPatience.cmbRol.DataSource = dsRol.Tables["tbTipoPersona"];
            objAdminPatience.cmbRol.ValueMember = "IdTipoPersona";
            objAdminPatience.cmbRol.DisplayMember = "TipoPersona";

            RefrescarDataPaciente();


        }

        //NEW

        //Sirve para abrir la vista addPatient para poder agregar un nuevo paciente
        public void newstudentpatient(object sender, EventArgs e)
        {
            FrmAddPatience openForm = new FrmAddPatience(1);
            openForm.ShowDialog();
            RefrescarDataPaciente();
        }

        //REFRESH

        //Con este metodo se puede ver la información de la vista ViewAdminPatientque llena el datGrid de de los estudiantes
        public void RefrescarDataPaciente()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminPatient();
            //Llenar DataGridView
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
            objAdminPatience.GridViewPatient.Columns[0].HeaderText = "ID";
            objAdminPatience.GridViewPatient.Columns[0].Width = 35;
            objAdminPatience.GridViewPatient.Columns[1].HeaderText = "Name";
            objAdminPatience.GridViewPatient.Columns[1].Width = 145;
            objAdminPatience.GridViewPatient.Columns[2].HeaderText = "LastName";
            objAdminPatience.GridViewPatient.Columns[2].Width = 145;
            objAdminPatience.GridViewPatient.Columns[3].HeaderText = "Tipo Persona";
            objAdminPatience.GridViewPatient.Columns[3].Width = 80;
            objAdminPatience.GridViewPatient.Columns[4].HeaderText = "Código";
            objAdminPatience.GridViewPatient.Columns[5].Visible = false;
            objAdminPatience.GridViewPatient.Columns[6].HeaderText = "Grade ";
            objAdminPatience.GridViewPatient.Columns[6].Width = 70;
            objAdminPatience.GridViewPatient.Columns[7].HeaderText = "Sección";
            objAdminPatience.GridViewPatient.Columns[7].Width = 63;
            objAdminPatience.GridViewPatient.Columns[6].Width = 70;
            objAdminPatience.GridViewPatient.Columns[8].HeaderText = "Specialty";
            objAdminPatience.GridViewPatient.Columns[8].Width = 175;
            objAdminPatience.GridViewPatient.Columns[9].HeaderText = "Date de visita";
            objAdminPatience.GridViewPatient.Columns[9].Width = 80;
            objAdminPatience.GridViewPatient.Columns[10].HeaderText = "Time de visita";
            objAdminPatience.GridViewPatient.Columns[10].Width = 70;
            objAdminPatience.GridViewPatient.Columns[11].Visible = false;
            objAdminPatience.GridViewPatient.Columns[12].Visible = false;



        }

        private void RefreshDataStudent(object sender, EventArgs e)
        {
            RefrescarDataPaciente();
        }

        //UPDATE

        //Mandar la información del data grid para empezar el proceso de update y llenado de formulario de los estudiantes
        private void UpdatePatient(object sender, EventArgs e)
        {

            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.GridViewPatient[1, pos].Value.ToString();
            apellidoPaciente = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            codigo = objAdminPatience.GridViewPatient[4, pos].Value.ToString();
            grupoTecnico = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            grado = objAdminPatience.GridViewPatient[6, pos].Value.ToString();
            seccionAcademica = objAdminPatience.GridViewPatient[7, pos].Value.ToString();
            Especialidad = objAdminPatience.GridViewPatient[8, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objAdminPatience.GridViewPatient[9, pos].Value.ToString());
            horaVisita = objAdminPatience.GridViewPatient[10, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.GridViewPatient[11, pos].Value.ToString();
            Observaciones = objAdminPatience.GridViewPatient[12, pos].Value.ToString();

            FrmAddPatience openFrom = new FrmAddPatience(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefrescarDataPaciente();


        }

        //Mandar información del data grid para empezar el proceso de llenar el formulario del maestro

        //DELETE

        //Eliminar paciente que sean estudiantes
        private void DeletePatient(object sender, EventArgs e)
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {objAdminPatience.GridViewPatient[1, pos].Value.ToString()} {objAdminPatience.GridViewPatient[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminPatience daoDelete = new DAOAdminPatience();
                daoDelete.IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
                int ValorRetornado = daoDelete.DeleteRegistrationPatient();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDataPaciente();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Metodo para eliminar pacientes del personal de la institucionm
        
    }
}
