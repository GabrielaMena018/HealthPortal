﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.PatientAdministration;

namespace HealthPortal.View.PatientAdministration
{
    public partial class FrmAddRole : Form
    {
        public FrmAddRole(int action)
        {
            InitializeComponent();
            ControllerAddRole control = new ControllerAddRole(this, action);
        }

        public FrmAddRole(int action, int id, string role)
        {
            InitializeComponent();
            ControllerAddRole control = new ControllerAddRole(this, action, id, role);
        }
    }
}
