using RegistroPacientes.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPacientes.Controlador
{
     class ControllerAddPatience
    {
        FrmAddPatience ObjAddPatience;
        int accion;
        private string TipoPersona;
        public ControllerAddPatience( FrmAddPatience Vista) 
        {
            ObjAddPatience = Vista;
            this.accion = accion;
            verificarAccion();
            ObjAddPatience.Load += new EventHandler(InitialCharge);

            ObjAddPatience.btnAgregarPaciente.Click += new EventHandler(NewPatience);
            ObjAddPatience.CmbRol.SelectedIndexChanged += new EventHandler(CmbRole_SelectChange);
           

        }

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAddPatience.btnAgregarPaciente.Enabled = true;
                ObjAddPatience.BtnActuzalizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAddPatience.btnAgregarPaciente.Enabled = false;
                ObjAddPatience.btnAgregarPaciente.Enabled = true;
           
            }
        }

        private void NewPatience(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOAdminPatience daoInsertPatient = new DAOAdminPatience();

            //Inserccion de datos de la tabla paciente
            daoInsertPatient.Nombre = ObjAddPatience.TxtNombrePaciente.Texts;
            daoInsertPatient.Apellido = ObjAddPatience.TxtApellidoPaciente.Texts;
            daoInsertPatient.Rol = (int)ObjAddPatience.CmbRol.SelectedValue;

            if(ObjAddPatience.CmbRol.SelectedIndex == 0) 
            {
                //Insercion datos tabla grado seccion
                daoInsertPatient.Especialidad = (int)ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue;
                daoInsertPatient.GrupoTecnico = ObjAddPatience.txtGrupo.Texts;
                daoInsertPatient.Grado = (int)ObjAddPatience.CmBGradoRegistro.SelectedValue;
                daoInsertPatient.SeccionAcademica = (int)ObjAddPatience.CmbSeccionRegistro.SelectedValue;


                //Insercion de datos tbEstudiantes
                daoInsertPatient.Codigo = ObjAddPatience.TxtCodigoPaciente.Texts;
            }
            else 
            {
                daoInsertPatient.Documento = ObjAddPatience.mksDocumento.Text;
                daoInsertPatient.IdArea = (int)ObjAddPatience.CmbAreaPersonal.SelectedValue;
            }
            

            //Insercion de datos tbVisitas
            daoInsertPatient.Fecha = ObjAddPatience.PickFechaRegistro.Value.Date;
            daoInsertPatient.Hora = ObjAddPatience.PickHoraRegistro.Value.ToString("HH:mm");
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

        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            ObjAddPatience.CmbRol.DataSource = dsRol.Tables["tbTipoPersona"];
            ObjAddPatience.CmbRol.ValueMember = "IdTipoPersona";
            ObjAddPatience.CmbRol.DisplayMember = "TipoPerona";


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

            //Llenar combox Area de tarbajo tbAreaPersonal
            DataSet dsAreaPersonalRegistros = objAdmin.LlenarCombo("tbAreaPersonal");
            ObjAddPatience.CmbAreaPersonal.DataSource = dsAreaPersonalRegistros.Tables["tbAreaPersonal"];
            ObjAddPatience.CmbAreaPersonal.ValueMember = "IdArea";
            ObjAddPatience.CmbAreaPersonal.DisplayMember = "TipoArea";


            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                ObjAddPatience.CmbRol.Text = TipoPersona;
            }
        }


        public void CmbRole_SelectChange(object sender, EventArgs e) 
        {
            if (ObjAddPatience.CmbRol.SelectedIndex == 0)
            {
                ObjAddPatience.groupStudent.Visible = true;
            }
            else 
            {
                ObjAddPatience.groupPersonalInstitucion.Visible = true;
                ObjAddPatience.groupStudent.Visible = false;
            }
        }

      
        

    }
}
