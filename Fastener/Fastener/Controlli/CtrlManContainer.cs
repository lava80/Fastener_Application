using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.Controlli
{
    public partial class CtrlManContainer : UserControl
    {
        public CtrlManContainer()
        {
            InitializeComponent();
        }
        
        private void toolbarButtonOriz_sistema_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_SYSTEM"))
                Program.LoadControl<CtrlManSistema>(dbPanel_main);
        }

        private void toolbarButtonOriz_CDC_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_CDC"))
                Program.LoadControl<CtrlManCDC>(dbPanel_main);   
        }

        private void toolbarButtonOriz_impianti_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_PLANT"))
                Program.LoadControl<CtrlManImpianti>(dbPanel_main); 
        }

        private void toolbarButtonOriz_aziende_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_AZIENDE"))
                Program.LoadControl<CtrlManAziende>(dbPanel_main);
        }

        private void toolbarButtonOriz_traduzioni_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_SYSTEM"))
                Program.LoadControl<CtrlTranslations>(dbPanel_main);
        }

        private void toolbarButtonOriz_utenti_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_UTENTI"))
                Program.LoadControl<CtrlManUtenti>(dbPanel_main);
        }

        private void toolbarButtonOriz_permessi_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_PERMISSIONS"))
                Program.LoadControl<CtrlManPermessi>(dbPanel_main);

        }

        private void toolbarButtonOriz_purchase_Click(object sender, EventArgs e)
        {

        }

        private void toolbarButtonOriz_CA_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_CA") && (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore || Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Amministratore))
                Program.LoadControl<CtrlManCA>(dbPanel_main); 
        }
    }
}
