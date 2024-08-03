using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
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

        public FrmAddPatience(int accion, int IdPaciente, string nombrePaciente, string apellidoPaciente, string TipoPersona, string codigo, string grupoTecnico, string grado, string seccionAcademica, string Especialidad, DateTime FechaVisita, string horaVisita, string nombreMedicamento, string Observaciones)
        {
            InitializeComponent();
            ControllerAddPatience objAddPatience = new ControllerAddPatience(this,  accion, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
        }


    }
}
