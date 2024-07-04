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
        private int accion;
        private string TipoPersona;
        public ControllerAddPatience( FrmAddPatience Vista) 
        {
            ObjAddPatience = Vista;
            ObjAddPatience.Load += new EventHandler(InitialCharge);
            ObjAddPatience.btnAgregarPaciente.Click += new EventHandler(NewPatience);
           

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

            DataSet dsSeccionesRegistros = objAdmin.LlenarCombo("tbSecciones");
            //Llenar combobox tbGrados
            ObjAddPatience.CmbSeccionRegistro.DataSource = dsSeccionesRegistros.Tables["tbSecciones"];
            ObjAddPatience.CmbSeccionRegistro.ValueMember = "IdSeccion";
            ObjAddPatience.CmbSeccionRegistro.DisplayMember = "Seccion";

            
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                ObjAddPatience.CmbRol.Text = TipoPersona;
            }
        }
        public void NewPatience (object sender, EventArgs e) 
        {
            DAOAdminPatience daoAdmin = new DAOAdminPatience();

            //Datos del paciente
            daoAdmin.NombrePaciente = ObjAddPatience.TxtNombrePaciente.Texts.Trim();
            daoAdmin.ApellidoPaciente = ObjAddPatience.TxtApellidoPaciente.Texts.Trim();
            daoAdmin.IdPaciente = int.Parse(ObjAddPatience.CmbRol.SelectedValue.ToString());

            //Datos para estudiante
            daoAdmin.Codigo = ObjAddPatience.TxtCodigoPaciente.Texts.Trim();
            daoAdmin.IdSeccion = int.Parse(ObjAddPatience.CmbSeccionRegistro.SelectedValue.ToString());
            daoAdmin.IdEspecialidad = int.Parse(ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue.ToString());
            daoAdmin.IdGrado = int.Parse(ObjAddPatience.CmBGradoRegistro.SelectedValue.ToString());

            int valorRetornado = daoAdmin.RegistrarVisita();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido registrados exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser registrados",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
