using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller;
using RegistroPacientes.Controller.Registro_Inventario;

namespace RegistroPacientes.View.Ineventario
{
    public partial class FrmAdminInventary : Form
    {
        public FrmAdminInventary()
        {
            InitializeComponent();
            ControllerAdminInventory objAdminInventory = new ControllerAdminInventory(this);
        }

    }
}
