using HealthPortal.View.MainPage;
using HealthPortal.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Controller.MainPage
{
    internal class ControllerMainPage
    {
        FrmMainPage frmMainPage;
        public ControllerMainPage(FrmMainPage view)
        {
            frmMainPage = view;
            frmMainPage.Load += new EventHandler(LoadInstitutionName);
            frmMainPage.timerDateTime.Tick += new EventHandler(Tick);
        }
        private void LoadInstitutionName(object sender, EventArgs e)
        {
            DAOMainPage dao = new DAOMainPage();
            frmMainPage.lblTitle.Text = $"Página Principal - {dao.GetInstitutionName()}";
        }
        private void Tick(object sender, EventArgs e)
        {
            frmMainPage.lblTime.Text = DateTime.Now.ToLongTimeString();
            frmMainPage.lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
