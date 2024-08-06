using RegistroPacientes.Controller.UserAdministration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPacientes.View.UserAdministration
{
    public partial class FrmAddUpdateUser : Form
    {
        public FrmAddUpdateUser(int procedure)
        {
            InitializeComponent();
            ControllerAddUpdateUser control = new ControllerAddUpdateUser(this, procedure);
        }
        public FrmAddUpdateUser(int procedure, int personId, string firstName, string lastName, string email, string phoneNumber, string username, string role)
        {
            InitializeComponent();
            ControllerAddUpdateUser control = new ControllerAddUpdateUser(this, procedure, personId ,firstName, lastName, email, phoneNumber, username, role);
        }
    }
}
