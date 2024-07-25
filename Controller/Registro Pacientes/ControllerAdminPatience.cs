using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Models.DAO;
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
            objAdminPatience.btnNew.Click += new EventHandler(NewPatience);
            objAdminPatience.BtnNewPersonal.Click += new EventHandler(NewPatiencePersonal);
            objAdminPatience.Load += new EventHandler(InitialCharge);
            objAdminPatience.cmsActualizar.Click += new EventHandler(UpdatePatientEstudiantes);
            objAdminPatience.tabControl.SelectedIndexChanged += new EventHandler(RefrescarDataPersonal);
            objAdminPatience.cmsActualizarPersonal.Click += new EventHandler(UpdatePatientPersonal);
            objAdminPatience.cmsVer.Click += new EventHandler(VerFichaEstuddiantes);
            objAdminPatience.cmsVerPersonal.Click += new EventHandler(VerFichaPersonal);
            objAdminPatience.cmsEliminar.Click += new EventHandler(DeletePatientStudente);
            objAdminPatience.cmsEliminarPersonal.Click += new EventHandler(DeletePatientPersonal);
            objAdminPatience.PickFechaVisita.Value = DateTime.Now;
            objAdminPatience.GridViewPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            objAdminPatience.dataGridViewPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        //Mandar a recolectar de cada columna del data grid la información del paciente que pertenece al personal de la institución y mandarlo a la vista FrmAddPatience
        private void VerFichaPersonal(object sender, EventArgs e)
        {
            int pos = objAdminPatience.dataGridViewPersonal.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, documento, TipoArea, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.dataGridViewPersonal[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.dataGridViewPersonal[1, pos].Value.ToString();
            apellidoPaciente = objAdminPatience.dataGridViewPersonal[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.dataGridViewPersonal[3, pos].Value.ToString();
            documento = objAdminPatience.dataGridViewPersonal[4, pos].Value.ToString();
            TipoArea = objAdminPatience.dataGridViewPersonal[5, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objAdminPatience.dataGridViewPersonal[6, pos].Value.ToString());
            horaVisita = objAdminPatience.dataGridViewPersonal[7, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.dataGridViewPersonal[8, pos].Value.ToString();
            Observaciones = objAdminPatience.dataGridViewPersonal[9, pos].Value.ToString();


            FrmAddPatience openFrom = new FrmAddPatience(3, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, documento, TipoArea, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            objAdminPatience.dataGridViewPersonal.Dispose();
            RefrescarPersonal();
        }

        //Mandar a recolectar de cada columna del data grid la información del estudiante y mandarlo a la vista FrmAddPatience
        private void VerFichaEstuddiantes(object sender, EventArgs e)
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.GridViewPatient[1, pos].Value.ToString();
            apellidoPaciente = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            codigo = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            grupoTecnico = objAdminPatience.GridViewPatient[6, pos].Value.ToString();
            grado = objAdminPatience.GridViewPatient[7, pos].Value.ToString();
            seccionAcademica = objAdminPatience.GridViewPatient[8, pos].Value.ToString();
            Especialidad = objAdminPatience.GridViewPatient[9, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objAdminPatience.GridViewPatient[10, pos].Value.ToString());
            horaVisita = objAdminPatience.GridViewPatient[11, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.GridViewPatient[12, pos].Value.ToString();
            Observaciones = objAdminPatience.GridViewPatient[13, pos].Value.ToString();

            FrmAddPatience openFrom = new FrmAddPatience(3, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefrescarDataPaciente();
        }
        //Esta es la carga inicial la cual se encarga de llenar los combobox
        private void InitialCharge(object sender, EventArgs e)
        {
            RefrescarDataPaciente();
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsCategoria = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            objAdminPatience.CmbCategoria.DataSource = dsCategoria.Tables["tbTipoPersona"];
            objAdminPatience.CmbCategoria.ValueMember = "IdTipoPersona";
            objAdminPatience.CmbCategoria.DisplayMember = "TipoPerona";

            DataSet dsEspRegistro = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox tbRole
            objAdminPatience.CmbEspecialidad.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            objAdminPatience.CmbEspecialidad.ValueMember = "IdEspecialidad";
            objAdminPatience.CmbEspecialidad.DisplayMember = "Especialidad";

            DataSet dsGradosRegistros = objAdmin.LlenarCombo("tbGrados");
            //Llenar combobox tbGrados
            objAdminPatience.CmbGrado.DataSource = dsGradosRegistros.Tables["tbGrados"];
            objAdminPatience.CmbGrado.ValueMember = "IdGrado";
            objAdminPatience.CmbGrado.DisplayMember = "Grado";

            DataSet dsAreaPersonal = objAdmin.LlenarCombo("tbAreaPersonal");
            //Llenar combobox tbGrados
            objAdminPatience.cmbAreaPersonal.DataSource = dsAreaPersonal.Tables["tbAreaPersonal"];
            objAdminPatience.cmbAreaPersonal.ValueMember = "IdArea";
            objAdminPatience.cmbAreaPersonal.DisplayMember = "TipoArea";


        }

        //Sirve para abrir la vista addPatient para poder agregar un nuevo paciente
        public void NewPatience(object sender, EventArgs e)
        {
            FrmAddPatience openForm = new FrmAddPatience(1);
            openForm.ShowDialog();
            RefrescarDataPaciente();
        }
        public void NewPatiencePersonal(object sender, EventArgs e)
        {
            FrmAddPatience openForm = new FrmAddPatience(1);
            openForm.ShowDialog();
            RefrescarPersonal();
        }
        //Con este metodo se puede ver la información de la vista ViewAdminPatientque llena el datGrid de de los estudiantes
        public void RefrescarDataPaciente()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminPatient();
            //Llenar DataGridView
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
            objAdminPatience.GridViewPatient.Columns[0].HeaderText = "ID Paciente";
            objAdminPatience.GridViewPatient.Columns[0].Width = 65;
            objAdminPatience.GridViewPatient.Columns[1].HeaderText = "Nombre";
            objAdminPatience.GridViewPatient.Columns[1].Width = 170;
            objAdminPatience.GridViewPatient.Columns[2].HeaderText = "Apellido";
            objAdminPatience.GridViewPatient.Columns[2].Width = 170;
            objAdminPatience.GridViewPatient.Columns[3].Visible = false;
            objAdminPatience.GridViewPatient.Columns[4].Visible = false;
            objAdminPatience.GridViewPatient.Columns[5].HeaderText = "Código";
            objAdminPatience.GridViewPatient.Columns[6].Visible = false;
            objAdminPatience.GridViewPatient.Columns[7].Width = 70;
            objAdminPatience.GridViewPatient.Columns[8].Visible = false;
            objAdminPatience.GridViewPatient.Columns[9].Width = 180;
            objAdminPatience.GridViewPatient.Columns[10].HeaderText = "Fecha de visita";
            objAdminPatience.GridViewPatient.Columns[11].HeaderText = "Hora de visita";
            objAdminPatience.GridViewPatient.Columns[11].Width = 70;
            objAdminPatience.GridViewPatient.Columns[12].Visible = false;
            objAdminPatience.GridViewPatient.Columns[13].Visible = false;


        }
        //Con este metodo se puede ver la información de la vista ViewPersonalInstitucion que llena el datGrid de del personal de la institucion
        public void RefrescarDataPersonal(object sender, EventArgs e)
        {
            RefrescarPersonal();
        }
        public void RefrescarPersonal() 
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdminPersonal = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdminPersonal.AdminPatientPersonalInstitucion();
            //Llenar DataGridView
            objAdminPatience.dataGridViewPersonal.DataSource = ds.Tables["ViewPersonalInstitucion"];
            objAdminPatience.dataGridViewPersonal.Columns[0].HeaderText = "ID Paciente";
            objAdminPatience.dataGridViewPersonal.Columns[1].HeaderText = "Nombre";
            objAdminPatience.dataGridViewPersonal.Columns[1].Width = 170;
            objAdminPatience.dataGridViewPersonal.Columns[2].HeaderText = "Apellido";
            objAdminPatience.dataGridViewPersonal.Columns[2].Width = 170;
            objAdminPatience.dataGridViewPersonal.Columns[3].Visible = false;
            objAdminPatience.dataGridViewPersonal.Columns[4].HeaderText = "Documento";
            objAdminPatience.dataGridViewPersonal.Columns[4].Width = 120;
            objAdminPatience.dataGridViewPersonal.Columns[5].HeaderText = "Área del trabajador";
            objAdminPatience.dataGridViewPersonal.Columns[5].Width = 170;
            objAdminPatience.dataGridViewPersonal.Columns[6].HeaderText = "Fecha de Visita";
            objAdminPatience.dataGridViewPersonal.Columns[7].HeaderText = "Hora de Visita";
            objAdminPatience.dataGridViewPersonal.Columns[8].Visible = false;
            objAdminPatience.dataGridViewPersonal.Columns[9].Visible = false;
        }

        //MAndar la información del data grid para empezar el proceso de update y llenado de formulario de los estudiantes
        private void UpdatePatientEstudiantes(object sender, EventArgs e)
        {

            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.GridViewPatient[1, pos].Value.ToString();
            apellidoPaciente = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            codigo = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            grupoTecnico = objAdminPatience.GridViewPatient[6, pos].Value.ToString();
            grado = objAdminPatience.GridViewPatient[7, pos].Value.ToString();
            seccionAcademica = objAdminPatience.GridViewPatient[8, pos].Value.ToString();
            Especialidad = objAdminPatience.GridViewPatient[9, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objAdminPatience.GridViewPatient[10, pos].Value.ToString());
            horaVisita = objAdminPatience.GridViewPatient[11, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.GridViewPatient[12, pos].Value.ToString();
            Observaciones = objAdminPatience.GridViewPatient[13, pos].Value.ToString();

            FrmAddPatience openFrom = new FrmAddPatience(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefrescarDataPaciente();


        }
        //Mandar información del data grid para empezar el proceso de llenar el formulario del maestro
        private void UpdatePatientPersonal(object sender, EventArgs e)
        {
            int pos = objAdminPatience.dataGridViewPersonal.CurrentRow.Index;
            int IdPaciente;
            string nombrePaciente, apellidoPaciente, TipoPersona, documento, TipoArea, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.dataGridViewPersonal[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.dataGridViewPersonal[1, pos].Value.ToString();
            apellidoPaciente = objAdminPatience.dataGridViewPersonal[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.dataGridViewPersonal[3, pos].Value.ToString();
            documento = objAdminPatience.dataGridViewPersonal[4, pos].Value.ToString();
            TipoArea = objAdminPatience.dataGridViewPersonal[5, pos].Value.ToString();
            FechaVisita = DateTime.Parse(objAdminPatience.dataGridViewPersonal[6, pos].Value.ToString());
            horaVisita = objAdminPatience.dataGridViewPersonal[7, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.dataGridViewPersonal[8, pos].Value.ToString();
            Observaciones = objAdminPatience.dataGridViewPersonal[9, pos].Value.ToString();


            FrmAddPatience openFrom = new FrmAddPatience(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, documento, TipoArea, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefrescarPersonal();

        }
        //Eliminar paciente que sean estudiantes
        private void DeletePatientStudente(object sender, EventArgs e)
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {objAdminPatience.GridViewPatient[1, pos].Value.ToString()} {objAdminPatience.GridViewPatient[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminPatience daoDelete = new DAOAdminPatience();
                daoDelete.IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
                daoDelete.Rol = 1;
                int ValorRetornado = daoDelete.DeleteRegistroPatient();
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
        private void DeletePatientPersonal(object sender, EventArgs e)
        {
            int pos = objAdminPatience.dataGridViewPersonal.CurrentRow.Index;
            if (MessageBox.Show($"¿Esta seguro que desea elimar a:\n {objAdminPatience.dataGridViewPersonal[1, pos].Value.ToString()} {objAdminPatience.dataGridViewPersonal[2, pos].Value.ToString()}.\nConsidere que dicha acción no se podrá revertir.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminPatience daoDelete = new DAOAdminPatience();
                daoDelete.IdPaciente = int.Parse(objAdminPatience.dataGridViewPersonal[0, pos].Value.ToString());
                daoDelete.Rol = 2;
                int ValorRetornado = daoDelete.DeleteRegistroPatient();
                if (ValorRetornado == 1)
                {
                    MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarPersonal();
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
