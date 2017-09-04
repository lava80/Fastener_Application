using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fastener.Controlli;
using Fastener.BaseClasses;

namespace Fastener
{
    public partial class frmMain : PopUpForm
    {
        public frmMain()
        {
            InitializeComponent();
            MakeBorderless(dbPanel3, this);
            label_version.Text = "Version: " + Utility.GetAppVersion();
            label_language.Text = Program.language_;
            label_utente.Text = Program.CurrentUser.Nome;

            //prova modifica rlavarin80

            CultureManager.ApplicationUICulture = CultureManager.ApplicationUICulture;
            if (Program.CurrentUser.Categoria == (int)Constants.LoginLevel.Operatore)
            {
                CtrlDataEntryContainer c = new CtrlDataEntryContainer();
                c.toolbarButtonOriz_activity_Click(this, new EventArgs());
                Program.LoadControl(dbPanel_main, c);
            }

            toolbarButton_trackingAcq.Visible = Program.CurrentUser.GetPermission("VIEW_PURCHASE_ORDER");

            Program.frmMain_link = this;
            Program.RefreshActNoReport();
        }

        private void toolbarButton_data_entry_Click(object sender, EventArgs e)
        {
            Program.LoadControl<CtrlDataEntryContainer>(dbPanel_main);
        }

        private void toolbarButton_quit_Click(object sender, EventArgs e)
        {
            DataSet.dsActivities.ActMinStartDateNoReportDataTable d = new DataSet.dsActivities.ActMinStartDateNoReportDataTable();
            new DataSet.dsActivitiesTableAdapters.ActMinStartDateNoReportTableAdapter().Fill(d, Program.CurrentUser.Key);

            if (d.Count > 0)
            {
                if (MessageBox.Show(Properties.MessageLocalization.quit_even_if_act_no_report, Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Program.state_ = Program.PROGRAM_STATE.QUIT;
                    Close();
                }
            }
            else
            {
                Program.state_ = Program.PROGRAM_STATE.QUIT;
                Close();
            }
        }

        private void toolbarButton_maintenance_Click(object sender, EventArgs e)
        {
            Program.LoadControl<CtrlManContainer>(dbPanel_main);
        }

        private void toolbarButton_change_password_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("MAN_CAN_CHANGE_PASSWORD"))
            {
                Program.state_ = Program.PROGRAM_STATE.PASSWORD_CHANGE;
                Close();
            }
        }

        private void toolbarButton_back_to_login_Click(object sender, EventArgs e)
        {
            Program.state_ = Program.PROGRAM_STATE.LOGIN;
            Close();
        }

        bool maximized = false;
        private void button_max_restore_Click(object sender, EventArgs e)
        {
            maximized = !maximized;
            if (maximized)
            {
                button_max_restore.BackgroundImage = Properties.Resources.restore;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                button_max_restore.BackgroundImage = Properties.Resources.maximize;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void toolbarButton_eventi_man_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.GetPermission("EVT_DEFINITION"))
                Program.LoadControl<CtrlEvent>(dbPanel_main);
        }

        internal void ShowWarningActWithNoReport(bool show)
        {
            label_act_no_report.Text = Properties.MessageLocalization.activity_act_with_no_report;
            label_act_no_report.Visible = show;
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolbarButton_trackingAcq_Click(object sender, EventArgs e)
        {
            Program.LoadControl<CtrlPurchaseOrders>(dbPanel_main);
        }

        private void toolbarButton_RichiesteLavorazioni_Click(object sender, EventArgs e)
        {
            Program.LoadControl<CtrlRichiesteLavorazioni>(dbPanel_main);
        }

    }
}
