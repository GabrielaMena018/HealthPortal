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

namespace RegistroPacientes.View.Ineventario
{
    public partial class FrmAdminInventary : Form
    {
        public FrmAdminInventary()
        {
            InitializeComponent();
            Controller.Registro_Inventario.ControllerAdminInventory objAdminUser = new Controller.Registro_Inventario.ControllerAdminInventory(this);
        }

    }
}
