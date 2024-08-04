using RegistroPacientes.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegistroPacientes.Controlador
{
    class ControllerAddPatience
    {
        FrmAddPatience ObjAddPatience;
        int action;
        private string typeperson, Grade, specialty, AcademicSection, namemedication, TypeArea;
        

        public ControllerAddPatience(FrmAddPatience View, int Action)
        {
            ObjAddPatience = View;
            this.action = Action;
            //Verificar action
            verifyAccion();
            ObjAddPatience.Load += new EventHandler(InitialCharge);
            //agregar un nuevo paciente
            ObjAddPatience.btnAgregarPaciente.Click += new EventHandler(NewPatience);
            //Opcion del comboBox en este se puede cambiar si es uin estudiante o un alumno para mostrar los datos que se tienen que llenar
            ObjAddPatience.PickFechaRegistro.Value = DateTime.Now;
            ObjAddPatience.PickHoraRegistro.Value = DateTime.Now;
            ObjAddPatience.TxtCodigoPaciente.Leave += new EventHandler(LeaveCode); 
            
            
        }



        public ControllerAddPatience(FrmAddPatience View, int Action, int IdPatient, string PatientName, string PatientLastName, string TypePerson, string codigo, string grupoTecnico, string grade, string seccionAcademica, string Especialidad, DateTime VisitDate, string TimeVisit, string nombreMedicamento, string Observaciones)
        {
            ObjAddPatience = View;
            this.action = Action;
            this.typeperson = TypePerson;
            this.Grade = grade;
            this.AcademicSection = seccionAcademica;
            this.specialty = Especialidad;
            this.namemedication = nombreMedicamento;
            ObjAddPatience.Load += new EventHandler(InitialCharge);
            verifyAccion();
            ChargeValues(IdPatient, PatientName, PatientLastName, codigo, grupoTecnico,  VisitDate, TimeVisit,  Observaciones);
            ObjAddPatience.BtnActuzalizar.Click += new EventHandler(UpdatePatient);
            //Opcion del comboBox en este se puede cambiar si es uin estudiante o un alumno para mostrar los datos que se tienen que llenar

        }

        //Este metodo captura el evento cuando el txtCodigo pierde el focus para poder inicar la busqueda por medio de la coindidencia del Code
        private void LeaveCode(object sender, EventArgs e)
        {
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            objAdmin.Code = ObjAddPatience.TxtCodigoPaciente.Texts;
            string[] datos = new string[8];
            datos = objAdmin.SearchCode();
            if (datos != null)
            {
                ObjAddPatience.TxtNombrePaciente.Texts = datos[0];
                ObjAddPatience.TxtApellidoPaciente.Texts = datos[1];
                ObjAddPatience.TxtCodigoPaciente.Texts = datos[2];
                ObjAddPatience.txtGrupo.Texts = datos[3];
                ObjAddPatience.CmBGradoRegistro.Text = datos[4];
                ObjAddPatience.CmbEspecidalidadRegistro.Text = datos[5];
                ObjAddPatience.CmbSeccionRegistro.Text = datos[6];
                ObjAddPatience.CmbRol.Text = datos[7];
            }
            else if (datos == null)
            {
                ObjAddPatience.TxtNombrePaciente.Texts = ObjAddPatience.TxtNombrePaciente.Texts;
                ObjAddPatience.TxtApellidoPaciente.Texts = ObjAddPatience.TxtApellidoPaciente.Texts;
                ObjAddPatience.TxtCodigoPaciente.Texts = ObjAddPatience.TxtCodigoPaciente.Texts;
                ObjAddPatience.txtGrupo.Texts = ObjAddPatience.txtGrupo.Texts;
                ObjAddPatience.CmBGradoRegistro.Text = ObjAddPatience.CmBGradoRegistro.Text;
                ObjAddPatience.CmbEspecidalidadRegistro.Text = ObjAddPatience.CmbEspecidalidadRegistro.Text;
                ObjAddPatience.CmbSeccionRegistro.Text = ObjAddPatience.CmbSeccionRegistro.Text;
                ObjAddPatience.CmbRol.Text = ObjAddPatience.CmbRol.Text;
                MessageBox.Show("Paciente no resgistrado anteriormente", "Registro paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Metodo para actuzlaizar paciente
        public void UpdatePatient(object sender, EventArgs e)
        {
            DAOAdminPatience DaoUpdate = new DAOAdminPatience();
            DaoUpdate.IdPaciente = int.Parse(ObjAddPatience.txtId.Text.Trim());
            DaoUpdate.Name = ObjAddPatience.TxtNombrePaciente.Texts.Trim();
            DaoUpdate.LastName = ObjAddPatience.TxtApellidoPaciente.Texts.Trim();
            DaoUpdate.Rol = (int)ObjAddPatience.CmbRol.SelectedValue;
            DaoUpdate.Date = ObjAddPatience.PickFechaRegistro.Value;
            DaoUpdate.Time = ObjAddPatience.PickHoraRegistro.Value.ToString("HH:mm");
            DaoUpdate.Medicamento = (int)ObjAddPatience.CmbMedicamentoRegistro.SelectedValue;
            DaoUpdate.Observacion = ObjAddPatience.TxtObservaciones.Texts.Trim();

                //Actuzalizar Tabla Grade
                DaoUpdate.Specialty = (int)ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue;
                DaoUpdate.GroupTechnical = ObjAddPatience.txtGrupo.Texts;
                DaoUpdate.Grade = (int)ObjAddPatience.CmBGradoRegistro.SelectedValue;
                DaoUpdate.SeccionAcademica = (int)ObjAddPatience.CmbSeccionRegistro.SelectedValue;

                //Insercion de datos tbEstudiantes
                DaoUpdate.Code = ObjAddPatience.TxtCodigoPaciente.Texts;


            int valorRetornado = DaoUpdate.UpdatePatient();

            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //Verifica que acción se va a realizar
        public void verifyAccion()
        {
            if (action == 1)
            {
                ObjAddPatience.btnAgregarPaciente.Enabled = true;
                ObjAddPatience.BtnActuzalizar.Enabled = false;
                ObjAddPatience.BtnPdf.Enabled = false;
                ObjAddPatience.BtnPdf.BackColor = Color.Silver;
                ObjAddPatience.pic2.BackColor = Color.Silver;
                ObjAddPatience.BtnActuzalizar.BackColor = Color.Silver;
                ObjAddPatience.pictureBox1.BackColor = Color.Silver;
            }
            else if (action == 2)
            {
                ObjAddPatience.label1.Text = "Actualizar registro de paciente";
                ObjAddPatience.btnAgregarPaciente.Enabled = false;
                ObjAddPatience.BtnActuzalizar.Enabled = true;
                ObjAddPatience.BtnPdf.Enabled = false;
                ObjAddPatience.BtnPdf.BackColor = Color.Silver;
                ObjAddPatience.pic2.BackColor = Color.Silver;
                ObjAddPatience.btnAgregarPaciente.BackColor = Color.Silver;
                ObjAddPatience.pictureBox4.BackColor = Color.Silver;

            }
            else if(action == 3)
            {
                ObjAddPatience.label1.Text = "Ficha de paciente";
                ObjAddPatience.btnAgregarPaciente.Enabled = false;
                ObjAddPatience.btnAgregarPaciente.BackColor = Color.Silver;
                ObjAddPatience.BtnActuzalizar.Enabled = false;
                ObjAddPatience.BtnActuzalizar.BackColor = Color.Silver;
                ObjAddPatience.pictureBox1.BackColor = Color.Silver;
                ObjAddPatience.pictureBox4.BackColor = Color.Silver;
                ObjAddPatience.BtnPdf.Enabled = true;
                ObjAddPatience.TxtNombrePaciente.Enabled=false;
                ObjAddPatience.TxtNombrePaciente.BackColor = Color.WhiteSmoke;
                ObjAddPatience.TxtApellidoPaciente.Enabled = false;
                ObjAddPatience.TxtApellidoPaciente.BackColor = Color.WhiteSmoke;
                ObjAddPatience.CmbRol.Enabled=false;
                ObjAddPatience.TxtCodigoPaciente.Enabled = false;
                ObjAddPatience.TxtCodigoPaciente.BackColor= Color.WhiteSmoke;
                ObjAddPatience.CmbEspecidalidadRegistro.Enabled=false;
                ObjAddPatience.txtGrupo.Enabled=false;
                ObjAddPatience.txtGrupo.BackColor = Color.WhiteSmoke;
                ObjAddPatience.CmBGradoRegistro.Enabled=false;
                ObjAddPatience.CmbMedicamentoRegistro.Enabled=false;
                ObjAddPatience.TxtObservaciones.Enabled=false;
                ObjAddPatience.TxtObservaciones.BackColor= Color.WhiteSmoke;
                ObjAddPatience.PickFechaRegistro.Enabled=false;
                ObjAddPatience.PickHoraRegistro.Enabled=false;
                ObjAddPatience.CmbSeccionRegistro.Enabled=false;
            }
        }

        //Ingreso de nuevo paciente
        private void NewPatience(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOAdminPatience daoInsertPatient = new DAOAdminPatience();

            //Inserccion de datos de la tabla paciente
            daoInsertPatient.Name = ObjAddPatience.TxtNombrePaciente.Texts;
            daoInsertPatient.LastName = ObjAddPatience.TxtApellidoPaciente.Texts;
            daoInsertPatient.Rol = (int)ObjAddPatience.CmbRol.SelectedValue;

            //Insercion datos tabla grade seccion
                daoInsertPatient.Specialty = (int)ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue;
                daoInsertPatient.GroupTechnical = ObjAddPatience.txtGrupo.Texts;
                daoInsertPatient.Grade = (int)ObjAddPatience.CmBGradoRegistro.SelectedValue;
                daoInsertPatient.SeccionAcademica = (int)ObjAddPatience.CmbSeccionRegistro.SelectedValue;

                //Insercion de datos tbEstudiantes
                daoInsertPatient.Code = ObjAddPatience.TxtCodigoPaciente.Texts;

            //Insercion de datos tbVisitas
            daoInsertPatient.Date = ObjAddPatience.PickFechaRegistro.Value.Date;
            daoInsertPatient.Time = ObjAddPatience.PickHoraRegistro.Value.ToString("HH:mm");
            daoInsertPatient.Medicamento = (int)ObjAddPatience.CmbMedicamentoRegistro.SelectedValue;
            daoInsertPatient.Observacion = ObjAddPatience.TxtObservaciones.Texts;


            int retorno = daoInsertPatient.PatientRegistration();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //Carga Inicial
        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            ObjAddPatience.CmbRol.DataSource = dsRol.Tables["tbTipoPersona"];
            ObjAddPatience.CmbRol.ValueMember = "IdTipoPersona";
            ObjAddPatience.CmbRol.DisplayMember = "TipoPersona";


            DataSet dsEspRegistro = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox tbEspecialidades
            ObjAddPatience.CmbEspecidalidadRegistro.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            ObjAddPatience.CmbEspecidalidadRegistro.ValueMember = "IdEspecialidad";
            ObjAddPatience.CmbEspecidalidadRegistro.DisplayMember = "Especialidad";

            DataSet dsGradosRegistros = objAdmin.LlenarCombo("tbGrados");
            //Llenar combobox tbGrados
            ObjAddPatience.CmBGradoRegistro.DataSource = dsGradosRegistros.Tables["tbGrados"];
            ObjAddPatience.CmBGradoRegistro.ValueMember = "IdGrado";
            ObjAddPatience.CmBGradoRegistro.DisplayMember = "Grado";

            DataSet dsSeccionesRegistros = objAdmin.LlenarCombo("tbSeccionAcademica");
            //Llenar combobox tbSeccion
            ObjAddPatience.CmbSeccionRegistro.DataSource = dsSeccionesRegistros.Tables["tbSeccionAcademica"];
            ObjAddPatience.CmbSeccionRegistro.ValueMember = "IdSeccionAcademica";
            ObjAddPatience.CmbSeccionRegistro.DisplayMember = "SeccionAcademica";

            //Llenar combox tbMedicamento
            DataSet dsMedicamentoRegistros = objAdmin.LlenarCombo("tbMedicamentos");
            ObjAddPatience.CmbMedicamentoRegistro.DataSource = dsMedicamentoRegistros.Tables["tbMedicamentos"];
            ObjAddPatience.CmbMedicamentoRegistro.ValueMember = "IdMedicamento";
            ObjAddPatience.CmbMedicamentoRegistro.DisplayMember = "nombreMedicamento";




            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2 || action == 3)
            {
                ObjAddPatience.CmbRol.Text = typeperson;
                ObjAddPatience.CmBGradoRegistro.Text = Grade;
                ObjAddPatience.CmbSeccionRegistro.Text = AcademicSection;
                ObjAddPatience.CmbEspecidalidadRegistro.Text = specialty;
                ObjAddPatience.CmbMedicamentoRegistro.Text = namemedication;

            }
           
        }

        //Cargar Los datos del formulario de Estudiantes
        public void ChargeValues(int IdPatient, string PatientName, string PatientLastName,  string Code, string grupoTecnico,  DateTime DateVisit, string TimeVisit,  string Observaciones)
        {
            ObjAddPatience.txtId.Text = IdPatient.ToString();
            ObjAddPatience.TxtNombrePaciente.Texts = PatientName;
            ObjAddPatience.TxtApellidoPaciente.Texts = PatientLastName;
            ObjAddPatience.TxtCodigoPaciente.Texts = Code;
            ObjAddPatience.PickFechaRegistro.Value = DateVisit;
            ObjAddPatience.PickHoraRegistro.Text = TimeVisit;
            ObjAddPatience.txtGrupo.Texts = grupoTecnico;
            ObjAddPatience.TxtObservaciones.Texts = Observaciones;


        }




    }

}
