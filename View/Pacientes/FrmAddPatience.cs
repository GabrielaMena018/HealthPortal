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
        public FrmAddPatience()
        {
            InitializeComponent();
            ControllerAddPatience Control = new ControllerAddPatience(this);
        }

        private void FrmAddPatience_Load(object sender, EventArgs e)
        {

        }
    }
}
