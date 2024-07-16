using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controlador;

namespace RegistroPacientes
{
    public partial class FrmAddPatience : Form
    {
        public FrmAddPatience(int accion)
        {
            InitializeComponent();
            ControllerAddPatience objAddPatience = new ControllerAddPatience(this, accion);
        }

        public FrmAddPatience(int accion, int Id, string nombrePaciente, string apellidoPaciente, string rol, DateTime fechaVisita, string horaVisita, string docuemnto)
        {
            InitializeComponent();
            ControllerAddPatience objAddUser = new ControllerAddPatience(this, accion, Id, nombrePaciente, apellidoPaciente, rol, fechaVisita, horaVisita, docuemnto);
        }
        

    }
}
