using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fastener.BaseClasses;
using System.Transactions;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using Fastener.Dialog;

namespace Fastener.Controlli
{
    public partial class CtrlDataEntryContainer : UserControl
    {
        public CtrlDataEntryContainer()
        {
            InitializeComponent();

            DataSet.dsActivities.ActMinStartDateNoReportDataTable d_min = new DataSet.dsActivities.ActMinStartDateNoReportDataTable();
            new DataSet.dsActivitiesTableAdapters.ActMinStartDateNoReportTableAdapter().Fill(d_min, Program.CurrentUser.Key);

            if (d_min.Count > 0)
                dateTimePicker_from.Value = d_min[0].MinStartDate;
            else
                dateTimePicker_from.Value = DateTime.Today;

            dateTimePicker_to.Value = DateTime.Today;

            tipoRepartoTableAdapter.Fill(dsActivities.TipoReparto, Program.language_, Program.CurrentUser.Key);
            FillAziende();
            FillUtenti();

            Utility.formatDataGrid(dbDataGridView_activities, true);
            Utility.formatDataGrid(dbDataGridView_rapportini, true);

            comboBox_azienda.Enabled = Program.CurrentUser.GetPermission("ACT_MOD_AZI");
            comboBox_tipo_rep.Enabled = Program.CurrentUser.GetPermission("ACT_MOD_TIP_REP");
            comboBox_utenti.Enabled = Program.CurrentUser.GetPermission("ACT_MOD_UTE");

            comboBox_azienda.SelectedValue = Program.CurrentUser.Azienda;
            comboBox_tipo_rep.SelectedValue = Program.CurrentUser.DefaultReparto;
            comboBox_utenti.SelectedValue = Program.CurrentUser.Key;

            toolbarButtonOriz_activity.Visible = Program.CurrentUser.GetPermission("ACT_INSERT");
            toolbarButtonOriz_mod_act.Visible = Program.CurrentUser.GetPermission("ACT_MODIFY");
            toolbarButtonOriz_events.Visible = Program.CurrentUser.GetPermission("ACT_INSERT_EVT");

            pictureBox_reports.Visible = Program.CurrentUser.GetPermission("ACT_VIEW_REPORT_SERVER");

            if (!Program.CurrentUser.GetPermission("ACT_SHOW_WITH_REPORTS"))
            {
                ReportKey.Visible = false;
                Icon.Visible = false;
                activitiesBindingSource.Filter = "ReportKey is null";
            }

            if (!Program.CurrentUser.GetPermission("ACT_REPORT_GENERATE"))
                generaRapportinoToolStripMenuItem.Visible = false;

            if (!Program.CurrentUser.GetPermission("ACT_REPORT_FORCE"))
                associaARapportinoToolStripMenuItem.Visible = false;

            if (!Program.CurrentUser.GetPermission("ACT_REPORT_CANCEL"))
                rimuoviDaRapportinoToolStripMenuItem.Visible = false;

            pictureBox_excel_import.Visible = Program.CurrentUser.GetPermission("ACT_EXCEL_IMPORT");
            invioMailToolStripMenuItem.Visible = Program.CurrentUser.GetPermission("ACT_REPORT_SEND");

            validaRapportinoToolStripMenuItem.Visible = Program.CurrentUser.GetPermission("ACT_REPORT_VALIDATE");
            rimuoviValidazioneToolStripMenuItem.Visible = Program.CurrentUser.GetPermission("ACT_REPORT_VALIDATE");

            FillDatagrid();
            FillRapportini();

            BuildContextMenu();
        }

        private class ReportMenuItem : ToolStripMenuItem
        {
            public string name_ = "";
            public string report_server_ = "";
            public string report_path_ = "";

            public ReportMenuItem(
                string name,
                string report_server,
                string report_path)
            {
                name_ = name;
                report_server_ = report_server;
                report_path_ = report_path;

                base.Text = name;

                Click += ReportMenuItem_Click;
            }

            void ReportMenuItem_Click(object sender, EventArgs e)
            {
                frmServerReport f = new frmServerReport(report_server_, report_path_);
                f.ShowDialog();
            }
        }

        private void BuildContextMenu()
        {
            DataSet.dsServerReports.Man_ServerReportsDataTable d = new DataSet.dsServerReports.Man_ServerReportsDataTable();
            new DataSet.dsServerReportsTableAdapters.Man_ServerReportsTableAdapter().Fill(d, "CtrlDataEntryContainer");

            ToolStripMenuItem current = null;
            foreach (DataSet.dsServerReports.Man_ServerReportsRow row in d.Rows)
            {
                if (!row.Enabled)
                    continue;

                if (current == null || row.MenuEntry != current.Text)
                {
                    current = new ToolStripMenuItem(row.MenuEntry);
                    contextMenuStrip1.Items.Add(current);
                }

                current.DropDownItems.Add(new ReportMenuItem(row.Nome, row.ReportServer, row.ReportServerPath));
            }
        }

        private void FillRapportini()
        {
            if (comboBox_utenti.SelectedValue != null)
                man_ReportsTableAdapter.Fill(dsActivities.Man_Reports, dateTimePicker_from.Value, dateTimePicker_to.Value, (int)comboBox_utenti.SelectedValue);
        }

        private void FillAziende()
        {
            if (comboBox_tipo_rep.SelectedValue != null)
            {
                aziendeTableAdapter.Fill(dsActivities.Aziende, (int)comboBox_tipo_rep.SelectedValue);
            }
        }

        private void FillDatagrid()
        {
            if (comboBox_utenti.SelectedValue != null)
            {
                label_selected_hours.Text = "00:00";
                label_visualized_hours.Text = "00:00";
                try
                {
                    activitiesTableAdapter.Fill(dsActivities.Activities,
                        Program.DateToInt(dateTimePicker_from),
                        Program.DateToInt(dateTimePicker_to),
                        (int)comboBox_utenti.SelectedValue,
                        Program.language_);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox_utenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagrid();
            FillRapportini();
        }

        private void comboBox_tipo_rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAziende();
            if (ctrlActivity != null)
            {
                ctrlActivity.TipoRepartoChanged();
            }
        }

        private void FillUtenti()
        {
            if (comboBox_tipo_rep.SelectedValue != null && comboBox_azienda.SelectedValue != null)
            {
                utentiTableAdapter.Fill(dsActivities.Utenti, (int)comboBox_tipo_rep.SelectedValue, (int)comboBox_azienda.SelectedValue);
            }
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            FillDatagrid();
            FillRapportini();
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            FillDatagrid();
            FillRapportini();
        }

        bool activity_shown = false;
        private CtrlActivity ctrlActivity = null;
        public void toolbarButtonOriz_activity_Click(object sender, EventArgs e)
        {
            activity_shown = !activity_shown;
            if (activity_shown)
            {
                HideActivityModify();
                HideEventInsert();
                ShowActivityInsert();
            }
            else
            {
                HideActivityInsert();
            }
        }

        private void HideActivityInsert()
        {
            dbPanel_main.AutoSize = true;
            dbPanel_main.Size = new System.Drawing.Size(600, 1);
            dbPanel_main.Controls.Clear();
            ctrlActivity = null;
            if (activity_shown)
                activity_shown = false;
        }

        private void HideEventInsert()
        {
            dbPanel_main.AutoSize = true;
            dbPanel_main.Size = new System.Drawing.Size(600, 1);
            dbPanel_main.Controls.Clear();
            ctrlActivityEvent = null;
            if (activity_evt)
                activity_evt = false;
        }

        private void ShowActivityInsert()
        {
            //event_shown = false;
            dbPanel_main.AutoSize = false;
            dbPanel_main.Size = new System.Drawing.Size(600, 470);
            ctrlActivity = new CtrlActivity(comboBox_tipo_rep, comboBox_utenti, comboBox_azienda);
            ctrlActivity.SubmitEvent += new EventHandler(c_SubmitEvent);
            Program.LoadControl(dbPanel_main, ctrlActivity);
        }

        private void ShowEventInsert()
        {
            //event_shown = false;
            dbPanel_main.AutoSize = false;
            dbPanel_main.Size = new System.Drawing.Size(600, 470);
            ctrlActivityEvent = new CtrlActivityEvent(comboBox_tipo_rep, comboBox_utenti, comboBox_azienda);
            ctrlActivityEvent.SubmitEvent += new EventHandler(c_SubmitEvent);
            Program.LoadControl(dbPanel_main, ctrlActivityEvent);
        }

        void c_SubmitEvent(object sender, EventArgs e)
        {
            ActivitySubmitEventArgs ev = e as ActivitySubmitEventArgs;
            if (ev.StartDate < dateTimePicker_from.Value)
                dateTimePicker_from.Value = ev.StartDate;
            if (ev.EndDate > dateTimePicker_to.Value)
                dateTimePicker_to.Value = ev.EndDate;

            FillDatagrid();
        }

        bool component_detail_visible = false;
        private void button_show_details_Click(object sender, EventArgs e)
        {
            component_detail_visible = !component_detail_visible;

            if (component_detail_visible)
            {
                DEC_componente.Visible = true;
                DEC_scm1.Visible = true;
                DEC_scm2.Visible = true;
                DEC_scm3.Visible = true;
            }
            else
            {
                DEC_componente.Visible = false;
                DEC_scm1.Visible = false;
                DEC_scm2.Visible = false;
                DEC_scm3.Visible = false;
            }
        }

        private void cancellaAttivitàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                DialogResult.Yes ==
                MessageBox.Show(Properties.MessageLocalization.activity_confirm_bulk_delete,
                Properties.MessageLocalization.activity_confirm,
                MessageBoxButtons.YesNo)
                )
            {
                try
                {
                    using (System.Transactions.TransactionScope scp = new System.Transactions.TransactionScope())
                    {
                        DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter adapter = new DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter();

                        foreach (DataGridViewRow row in dbDataGridView_activities.SelectedRows)
                        {
                            DataRowView drv = row.DataBoundItem as DataRowView;
                            DataSet.dsActivities.ActivitiesRow r_act = drv.Row as DataSet.dsActivities.ActivitiesRow;

                            if (r_act.IsActEveGroupIdNull())
                            {
                                activitiesTableAdapter.DeleteActivity(r_act.ActivityKey);
                            }
                            else
                            {
                                activitiesTableAdapter.DeleteByActEveGroupId(r_act.ActEveGroupId);
                                adapter.DeleteByActEveGroupId(r_act.ActEveGroupId);
                            }
                        }
                        scp.Complete();
                    }

                    FillDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dbDataGridView_activities_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_activities, ms_activitiy_recam, e);
        }

        private void dbDataGridView_activities_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            long total_sec = 0;

            dbDataGridView_activities.Columns["Icon"].DefaultCellStyle.NullValue = null;

            for (int i = 0; i < dbDataGridView_activities.RowCount; i++)
            {
                DataRowView drv = dbDataGridView_activities.Rows[i].DataBoundItem as DataRowView;
                DataSet.dsActivities.ActivitiesRow row = drv.Row as DataSet.dsActivities.ActivitiesRow;

                total_sec += row.ActivityElapsedSeconds;

                TimeSpan ts = new TimeSpan((long)row.ActivityElapsedSeconds * 10000000);
                dbDataGridView_activities.Rows[i].Cells["Span"].Value =
                    ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00");

                if (!row.IsReportKeyNull())
                {
                    //System.Drawing.Image img = Properties.Resources.Report_Editor;
                    dbDataGridView_activities.Rows[i].Cells["Icon"].Value = (object)Properties.Resources.Report_Editor;
                    dbDataGridView_activities.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                    dbDataGridView_activities.Rows[i].DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                }
                else
                {
                    dbDataGridView_activities.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dbDataGridView_activities.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }

            TimeSpan t = new TimeSpan(total_sec * 10000000);
            label_visualized_hours.Text = (t.Days * 24 + t.Hours).ToString("00") + ":" + t.Minutes.ToString("00");
        }

        private void comboBox_azienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUtenti();
        }

        bool activity_mod_shown = false;
        private CtrlActivity ctrlActivityMod = null;
        public void toolbarButtonOriz_mod_act_Click(object sender, EventArgs e)
        {
            activity_mod_shown = !activity_mod_shown;
            if (activity_mod_shown)
            {
                HideActivityInsert();
                HideEventInsert();
                ShowActivityModify();
            }
            else
            {
                HideActivityModify();
            }
        }

        private void HideActivityModify()
        {
            dbPanel_main.AutoSize = true;
            dbPanel_main.Size = new System.Drawing.Size(600, 1);
            dbPanel_main.Controls.Clear();
            ctrlActivityMod = null;
            if (activity_mod_shown)
                activity_mod_shown = false;
        }

        private void ShowActivityModify()
        {
            //event_shown = false;
            dbPanel_main.AutoSize = false;
            dbPanel_main.Size = new System.Drawing.Size(600, 470);
            ctrlActivityMod = new CtrlActivity(comboBox_tipo_rep, comboBox_utenti, comboBox_azienda, CtrlActivity.Type.MODIFY);
            ctrlActivityMod.SubmitEvent += new EventHandler(c_SubmitEvent);
            Program.LoadControl(dbPanel_main, ctrlActivityMod);

            if (dbDataGridView_activities.SelectedRows.Count > 0)
            {
                DataSet.dsActivities.ActivitiesRow row = (dbDataGridView_activities.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                ctrlActivityMod.PerformSelection(row);
            }
        }

        private void dbDataGridView_activities_SelectionChanged(object sender, EventArgs e)
        {
            if (ctrlActivityMod != null && dbDataGridView_activities.SelectedRows.Count > 0)
            {
                DataSet.dsActivities.ActivitiesRow row = (dbDataGridView_activities.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                ctrlActivityMod.PerformSelection(row);
            }

            long tot_sel_sec = 0;
            for (int i = 0; i < dbDataGridView_activities.SelectedRows.Count; i++)
            {
                DataSet.dsActivities.ActivitiesRow row = (dbDataGridView_activities.SelectedRows[i].DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                tot_sel_sec += row.ActivityElapsedSeconds;
            }

            TimeSpan t = new TimeSpan(tot_sel_sec * 10000000);
            label_selected_hours.Text = (t.Days * 24 + t.Hours).ToString("00") + ":" + t.Minutes.ToString("00");
        }

        bool activity_evt = false;
        CtrlActivityEvent ctrlActivityEvent = null;
        private void toolbarButtonOriz_events_Click(object sender, EventArgs e)
        {
            activity_evt = !activity_evt;
            if (activity_evt)
            {
                HideActivityInsert();
                HideActivityModify();
                ShowEventInsert();
            }
            else
            {
                HideEventInsert();
            }
        }

        private void generaRapportinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                long total_sec = 0;
                foreach (DataGridViewRow row in dbDataGridView_activities.SelectedRows)
                {
                    DataSet.dsActivities.ActivitiesRow r = (row.DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                    total_sec += r.ActivityElapsedSeconds;
                }
                                
                DataSet.dsMaintenance.Man_Ana_AZIDataTable azienda = new DataSet.dsMaintenance.Man_Ana_AZIDataTable();
                new DataSet.dsMaintenanceTableAdapters.Man_Ana_AZITableAdapter().FillBy(azienda, (int)comboBox_azienda.SelectedValue);

                if (!azienda[0].AZIDisableTimeReportLimit)
                {
                    if (total_sec >= 12 * 60 * 60)
                    {
                        if (total_sec < 24 * 60 * 60)
                        {
                            if (MessageBox.Show(
                                    Properties.MessageLocalization.activity_report_many_hours_confirm,
                                    Properties.MessageLocalization.activity_confirm,
                                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Properties.MessageLocalization.activity_report_too_many_hours);
                            return;
                        }
                    }
                }

                int report_key = -1;
                using (TransactionScope scp = new TransactionScope())
                {

                    if (comboBox_utenti.SelectedValue != null && dbDataGridView_activities.SelectedRows.Count > 0)
                    {
                        report_key = (int)new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().InsertQuery(
                            (int)comboBox_utenti.SelectedValue,
                            Program.CurrentUser.Nome, (int)comboBox_tipo_rep.SelectedValue);

                        foreach (DataGridViewRow row in dbDataGridView_activities.SelectedRows)
                        {
                            DataSet.dsActivities.ActivitiesRow r = (row.DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                            if (r.IsActEveGroupIdNull())
                            {
                                activitiesTableAdapter.UpdateReportKey(report_key, r.ActivityKey);
                            }
                            else
                            {
                                activitiesTableAdapter.UpdateReportKey_ActEve(report_key, r.ActEveGroupId);
                            }
                        }

                        new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().UpdateDataRiferimento(report_key);
                    }
                    scp.Complete();

                    //MessageBox.Show(Properties.MessageLocalization.activity_report_generated + " " + report_key.ToString());    
                }
                StoricizzaRapportino(report_key);

                Program.RefreshActNoReport();
                FillDatagrid();

                FillRapportini();

                frmRapportino f = new frmRapportino();
                f.SetReportKey(report_key);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                try
                {
                    List<int> report_To_Archive = new List<int>();

                    int report_key = int.Parse(toolStripTextBox1.Text);
                    report_To_Archive.Add(report_key);

                    using (TransactionScope scp = new TransactionScope())
                    {

                        DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter act_eve_adapter = new DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter();
                        foreach (DataGridViewRow row in dbDataGridView_activities.SelectedRows)
                        {
                            DataSet.dsActivities.ActivitiesRow r = (row.DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;
                            if (r.IsActEveGroupIdNull())
                            {
                                activitiesTableAdapter.UpdateReportKey(report_key, r.ActivityKey);
                            }
                            else
                            {
                                DataSet.dsActivities.Man_Act_EveDataTable d = new DataSet.dsActivities.Man_Act_EveDataTable();
                                act_eve_adapter.FillByActEveGroupId(d, r.ActEveGroupId);
                                foreach (DataSet.dsActivities.Man_Act_EveRow ae_row in d.Rows)
                                {
                                    activitiesTableAdapter.UpdateReportKey(report_key, ae_row.ActivityKey);
                                }
                            }

                            if (!r.IsReportKeyNull())
                            {
                                if (!report_To_Archive.Contains(r.ReportKey))
                                {
                                    report_To_Archive.Add(r.ReportKey);
                                }
                            }
                        }
                        new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().UpdateDataRiferimento(report_key);
                        scp.Complete();
                    }

                    foreach (int repKey in report_To_Archive)
                    {
                        StoricizzaRapportino(repKey);
                    }

                    Program.RefreshActNoReport();
                    FillDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void StoricizzaRapportino(int report_key)
        {
            DataSet.dsReport.ReportHistoryDataTable d = new DataSet.dsReport.ReportHistoryDataTable();
            DataSet.dsReportTableAdapters.ReportHistoryTableAdapter adapter = new DataSet.dsReportTableAdapters.ReportHistoryTableAdapter();

            DataSet.dsReport.ReportHistory_ExtendedDataTable dex = new DataSet.dsReport.ReportHistory_ExtendedDataTable();
            DataSet.dsReportTableAdapters.ReportHistory_ExtendedTableAdapter adapter_ex = new DataSet.dsReportTableAdapters.ReportHistory_ExtendedTableAdapter();

            using (System.Transactions.TransactionScope scp = new TransactionScope())
            {
                adapter.Fill(d, report_key);

                foreach (DataSet.dsReport.ReportHistoryRow row in d.Rows)
                {
                    string com_name = "";
                    if (!row.IsCOMNameNull())
                        com_name = row.COMName;

                    string scm_name = "";
                    if (!row.IsSCNNameNull())
                        scm_name = row.SCNName;

                    string qua_desc = "";
                    if (!row.IsAZIReportQualityDescNull())
                        qua_desc = row.AZIReportQualityDesc;

                    int? com_key = null;
                    if (!row.IsCOMKeyNull())
                        com_key = row.COMKey;

                    int? mac_key = null;
                    if (!row.IsMACKeyNull())
                        mac_key = row.MACKey;

                    int? imp_key = null;
                    if (!row.IsIMPKeyNull())
                        imp_key = row.IMPKey;

                    int? scm_1_key = null;
                    if (!row.IsSCMKeyNull())
                        scm_1_key = row.SCMKey;

                    int? scm_2_key = null;
                    if (!row.IsSCM_2_KeyNull())
                        scm_2_key = row.SCM_2_Key;

                    int? scm_3_key = null;
                    if (!row.IsSCM_3_keyNull())
                        scm_3_key = row.SCM_3_key;

                    int act_eve_key = 0;
                    if (!row.IsActEveKeyNull())
                        act_eve_key = row.ActEveKey;

                    int activityKey = 0;
                    if (act_eve_key == 0)
                    {
                        activityKey = row.ActivityKey;                        
                    }

                    string cdc_name = row.CDCName;

                    string cdr_reporting = "";
                    if (!row.IsCDR_ReportingNull())
                        cdr_reporting = row.CDR_Reporting;

                    string conto_coge = "";
                    if (!row.IsContoCogeNull())
                        conto_coge = row.ContoCoge;

                    string cdc_sbo = "";
                    if (!row.IsCDC_SBONull())
                        cdc_sbo = row.CDC_SBO; 

                    adapter.Storicizza(
                        row.ArchiveTimestamp,
                        row.ReportKey,
                        row.Elapsed,
                        row.ActivityElapsedSeconds,
                        row.StartDate,
                        row.EndDate,
                        row.EndHMS,
                        row.StartHMS,
                        row.AZIName,
                        row.AZIKey,
                        row.UTEName,
                        row.IMPName,
                        row.MACName,
                        com_name,
                        scm_name,
                        row.ActivityRemark,
                        qua_desc,
                        row.UTEKey,
                        imp_key,
                        mac_key,
                        com_key,
                        scm_1_key,
                        scm_2_key,
                        scm_3_key,
                        row.EventDescription,
                        row.EventContractNumber,
                        row.DataRiferimento,
                        row.Sottocomponenti,
                        row.TipOreName,
                        activityKey,
                        act_eve_key,
                        cdc_name,
                        cdr_reporting,
                        conto_coge,
                        cdc_sbo);
                }                

                adapter_ex.Fill(dex, report_key);

                foreach (DataSet.dsReport.ReportHistory_ExtendedRow row in dex.Rows)
                {
                    string com_name = "";
                    if (!row.IsCOMNameNull())
                        com_name = row.COMName;

                    string scm_name = "";
                    if (!row.IsSCNNameNull())
                        scm_name = row.SCNName;

                    string qua_desc = "";
                    if (!row.IsAZIReportQualityDescNull())
                        qua_desc = row.AZIReportQualityDesc;

                    int? com_key = null;
                    if (!row.IsCOMKeyNull())
                        com_key = row.COMKey;

                    int? mac_key = null;
                    if (!row.IsMACKeyNull())
                        mac_key = row.MACKey;

                    int? imp_key = null;
                    if (!row.IsIMPKeyNull())
                        imp_key = row.IMPKey;

                    int? scm_1_key = null;
                    if (!row.IsSCMKeyNull())
                        scm_1_key = row.SCMKey;

                    int? scm_2_key = null;
                    if (!row.IsSCM_2_KeyNull())
                        scm_2_key = row.SCM_2_Key;

                    int? scm_3_key = null;
                    if (!row.IsSCM_3_keyNull())
                        scm_3_key = row.SCM_3_key;

                    int? act_eve_key = null;
                    if (!row.IsActEveKeyNull())
                        act_eve_key = row.ActEveKey;

                    string cdc_name = row.CDCName;

                    string cdr_reporting = "";
                    if (!row.IsCDR_ReportingNull())
                        cdr_reporting = row.CDR_Reporting;

                    string conto_coge = "";
                    if (!row.IsContoCogeNull())
                        conto_coge = row.ContoCoge;

                    string cdc_sbo = "";
                    if (!row.IsCDC_SBONull())
                        cdc_sbo = row.CDC_SBO; 

                    adapter_ex.Storicizza(
                        row.ArchiveTimestamp,
                        row.ReportKey,
                        row.Elapsed,
                        row.ActivityElapsedSeconds,
                        row.StartDate,
                        row.EndDate,
                        row.EndHMS,
                        row.StartHMS,
                        row.AZIName,
                        row.AZIKey,
                        row.UTEName,
                        row.IMPName,
                        row.MACName,
                        com_name,
                        scm_name,
                        row.ActivityRemark,
                        qua_desc,
                        row.UTEKey,
                        imp_key,
                        mac_key,
                        com_key,
                        scm_1_key,
                        scm_2_key,
                        scm_3_key,
                        row.EventDescription,
                        row.EventContractNumber,
                        row.DataRiferimento,
                        row.Sottocomponenti,
                        row.TipOreName,
                        row.ActivityKey,
                        act_eve_key,
                        cdc_name,
                        cdr_reporting,
                        conto_coge,
                        cdc_sbo
                        );
                }

                scp.Complete();
            }
        }

        private void rimuoviDaRapportinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> report_To_Archive = new List<int>();

                using (TransactionScope scp = new TransactionScope())
                {
                    DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter act_eve_adapter = new DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter();
                    foreach (DataGridViewRow row in dbDataGridView_activities.SelectedRows)
                    {
                        DataSet.dsActivities.ActivitiesRow r = (row.DataBoundItem as DataRowView).Row as DataSet.dsActivities.ActivitiesRow;


                        if (r.IsActEveGroupIdNull())
                        {
                            activitiesTableAdapter.UpdateReportKey(null, r.ActivityKey);
                        }
                        else
                        {
                            DataSet.dsActivities.Man_Act_EveDataTable d = new DataSet.dsActivities.Man_Act_EveDataTable();
                            act_eve_adapter.FillByActEveGroupId(d, r.ActEveGroupId);
                            foreach (DataSet.dsActivities.Man_Act_EveRow ae_row in d.Rows)
                            {
                                activitiesTableAdapter.UpdateReportKey(null, ae_row.ActivityKey);
                            }
                        }

                        if (!r.IsReportKeyNull())
                        {
                            new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().UpdateDataRiferimento(r.ReportKey);
                            if (!report_To_Archive.Contains(r.ReportKey))
                            {
                                report_To_Archive.Add(r.ReportKey);
                            }
                        }

                    }

                    scp.Complete();
                }

                foreach (int repKey in report_To_Archive)
                {
                    StoricizzaRapportino(repKey);
                }

                Program.RefreshActNoReport();
                FillDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dbDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataSet.dsActivities.Man_ReportsRow row = (dbDataGridView_rapportini.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;
                frmRapportino f = new frmRapportino();
                f.SetReportKey(row.ReportKey);
                f.ShowDialog();
            }
        }

        private void pictureBox_reports_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dbDataGridView_rapportini_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_rapportini, contextMenuStrip_reports, e);
        }

        private void visualizzaRapportinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_rapportini.SelectedRows.Count > 0)
            {
                DataSet.dsActivities.Man_ReportsRow row = (dbDataGridView_rapportini.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;
                frmRapportino f = new frmRapportino();
                f.SetReportKey(row.ReportKey);
                f.ShowDialog();
            }
        }

        private void validaRapportinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_rapportini.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dbDataGridView_rapportini.SelectedRows)
                {
                    DataSet.dsActivities.Man_ReportsRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;
                    new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().ValidaRapportino(Program.CurrentUser.Login, row.ReportKey);
                }
                FillRapportini();
            }
        }

        private void rimuoviValidazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_rapportini.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dbDataGridView_rapportini.SelectedRows)
                {
                    DataSet.dsActivities.Man_ReportsRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;
                    new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().RimuoviValidazione(Program.CurrentUser.Login, row.ReportKey);
                }
                FillRapportini();
            }
        }

        private void dbDataGridView_rapportini_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dbDataGridView_rapportini.Columns["SendIcon"].DefaultCellStyle.NullValue = null;

            for (int i = 0; i < dbDataGridView_rapportini.RowCount; i++)
            {
                DataRowView drv = dbDataGridView_rapportini.Rows[i].DataBoundItem as DataRowView;
                DataSet.dsActivities.Man_ReportsRow row = drv.Row as DataSet.dsActivities.Man_ReportsRow;

                if (row.ReportSendMail_req)
                    dbDataGridView_rapportini.Rows[i].Cells["SendIcon"].Value = (object)Properties.Resources.SendReq;
                else if (row.ReportSendMail_done)
                    dbDataGridView_rapportini.Rows[i].Cells["SendIcon"].Value = (object)Properties.Resources.SendDone;
                else
                    dbDataGridView_rapportini.Rows[i].Cells["SendIcon"].Value = null;

                if (!row.IsReportStatusDescriptionNull())
                {
                    if (row.ReportStatusDescription == "VALIDATO")
                    {
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                    }
                    else if (row.ReportStatusDescription == "NON VALIDO")
                    {
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGray;
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                    }
                    else
                    {
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        dbDataGridView_rapportini.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }
            }
        }

        private void richiediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_rapportini.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dbDataGridView_rapportini.SelectedRows)
                {
                    DataSet.dsActivities.Man_ReportsRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;

                    if (row.ReportSendMail_done)
                    {
                        if (MessageBox.Show(Properties.MessageLocalization.reports_resend + row.ReportKey.ToString(), Properties.MessageLocalization.activity_confirm, MessageBoxButtons.YesNo) == DialogResult.No)
                            continue;
                    }
                    new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().RequestEmailSending(row.ReportKey);
                }
                FillRapportini();
            }
        }

        private void rimuoviRichiestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_rapportini.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dbDataGridView_rapportini.SelectedRows)
                {
                    DataSet.dsActivities.Man_ReportsRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsActivities.Man_ReportsRow;

                    if (row.ReportSendMail_done)
                        continue;

                    new DataSet.dsReportTableAdapters.Man_ReportsTableAdapter().RemoveEmailSendingRequest(row.ReportKey);
                }
                FillRapportini();
            }
        }

        private void pictureBox_excel_import_Click(object sender, EventArgs e)
        {
                try
                {
                    //Fastener.DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter activitiesTableAdapterExcel = new Fastener.DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter();
                    DateTime ora_inserimento = DateTime.Now;
                    OpenFileDialog ofd = openSelectFileDialog();

                    if (!ofd.FileName.Equals(string.Empty))
                    {
                        string file_path = ofd.FileName;
                        int standard_beginning_hour = 8;

                        string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=" + file_path + ";" +
                                "Mode=Read;Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
                        OleDbConnection conn = new OleDbConnection(ConnString);
                        OleDbDataAdapter SheetAdapterMese = new OleDbDataAdapter("select * from [Mese$]", conn);
                        System.Data.DataTable excelMese = new System.Data.DataTable();
                        SheetAdapterMese.Fill(excelMese);
                        excelMese.TableName = "MeseData";
                        DateTime date_mese = Convert.ToDateTime(excelMese.Rows[0]["Mese"]);

                        if (MessageBox.Show("Confermare importazione periodo \"" + date_mese.ToString("y") + "\"?", "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            System.Data.DataTable excelData = new System.Data.DataTable();
                            for (int i = 1; i <= 35; i++)
                            {
                                OleDbDataAdapter SheetAdapter = new OleDbDataAdapter("select * from [" + i.ToString().PadLeft(2, '0') + "$]", conn);
                                try
                                {
                                    SheetAdapter.Fill(excelData);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Foglio " + i.ToString().PadLeft(2, '0') + " non trovato.");
                                }
                            }
                            excelData.TableName = "ExcelData";

                            int from_day = 0;
                            DaySelector dsel = new DaySelector();
                            if (dsel.ShowDialog() == DialogResult.OK)
                            {
                                from_day = dsel.ret_value;
                            }
                            else
                            {
                                MessageBox.Show("Importazione Annullata.");
                                return;
                            }

                            decimal sum_hours = 0;
                            for (int day = from_day; day <= 31; day++)
                            {
                                Dictionary<int, DateTime> dictionary = new Dictionary<int, DateTime>();

                                foreach (DataRow dr in excelData.Rows)
                                {
                                    if (dr["Utente"].ToString().Length > 1 && Convert.ToInt32(dr["num_fastener"]) > 0)
                                    {
                                        int MacchinaID = Convert.ToInt32(dr["num_fastener"]);
                                        //Console.WriteLine("Data: " + date_mese.ToShortDateString() + "  - Area: " + dr["Area_ID"].ToString() + "  - Utente: " + dr["Utente"].ToString() + " - num_fastener: " + dr["num_fastener"].ToString() + " - valore: " + dr["15"].ToString());
                                        int impiantoID = (from macchine in dsActivities.Man_Ana_MAC
                                                          join cdc in dsActivities.Man_Ana_CDC on macchine.CDCKey equals cdc.CDCKey
                                                          join scheda in dsActivities.Man_Ana_SCHEDA on cdc.SchedaKey equals scheda.SCHEDAKey
                                                          where macchine.MACKey == MacchinaID
                                                          select scheda.IMPKey).Single();
                                        int UtenteID = (from utente in dsActivities.Man_Ana_UTE
                                                        where utente.UTELogin.Equals("cromes" + dr["Utente"].ToString())
                                                        select utente.UTEKey).Single();

                                        if (!dictionary.ContainsKey(UtenteID))
                                        {
                                            dictionary.Add(UtenteID, date_mese.AddDays(day - 1).AddHours(standard_beginning_hour));
                                        }


                                        if (dr[day.ToString()].ToString().Trim().Length > 0)
                                        {
                                            decimal hours_worked = Convert.ToDecimal(dr[day.ToString()].ToString().Replace(',', '.'));
                                            sum_hours += hours_worked;
                                            var timpeSpan = TimeSpan.FromHours(Convert.ToDouble(hours_worked));
                                            int hh_worked = timpeSpan.Hours;
                                            int min_worked = timpeSpan.Minutes;
                                            //Console.WriteLine("user ID: " + Convert.ToInt32(man_Ana_UTETableAdapter.GetUserIDQuery("cromes" + dr["Utente"].ToString())));
                                            DateTime date_start = dictionary[UtenteID];
                                            DateTime date_end = date_start.AddHours(hh_worked).AddMinutes(min_worked);
                                            dictionary[UtenteID] = date_end;

                                            Fastener.DataSet.dsActivities.Man_ActivitiesRow new_row = (Fastener.DataSet.dsActivities.Man_ActivitiesRow)dsActivities.Man_Activities.NewRow();
                                            new_row.ActivityStartDate = date_start;
                                            new_row.ActivityStartDateId = Program.DateToInt(date_start);
                                            new_row.ActivityEndDate = date_end;
                                            new_row.ActivityEndDateId = Program.DateToInt(date_end);
                                            new_row.ActivityStartHMSId = Program.HmsToInt(date_start);
                                            new_row.ActivityEndHMSId = Program.HmsToInt(date_end);
                                            new_row.ActivityElapsedSeconds = (int)(date_end - date_start).TotalSeconds;
                                            new_row.ActivityRemark = string.Empty;
                                            new_row.UTEKey = UtenteID;
                                            new_row.TipoManKey = 4;
                                            new_row.TipoRepKey = 3;
                                            new_row.IMPKey = impiantoID;
                                            new_row.MACKey = MacchinaID;
                                            new_row.StatoRecKey = 1;
                                            new_row.username = Program.CurrentUser.Login;
                                            new_row.timestamp = ora_inserimento;
                                            new_row.TipoOreKey = 1;
                                            new_row.Importato = true;
                                            dsActivities.Man_Activities.Rows.Add(new_row);
                                        }
                                    }
                                }
                            }
                            man_ActivitiesTableAdapter.Update(dsActivities.Man_Activities);
                            MessageBox.Show("Importazione file completata.\r\nTotale ore importate: " + sum_hours, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Importazione Annullata.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Importazione Annullata.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private static OpenFileDialog openSelectFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleziona File Excel da Importare";
            ofd.Filter = "Excel 2010 files (*.xlsx)|*.xlsx";//|Excel files (*.xls)|*.xls";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.ShowDialog();
            return ofd;
        }

        private void CtrlDataEntryContainer_Load(object sender, EventArgs e)
        {
            this.man_Ana_UTETableAdapter.Fill(this.dsActivities.Man_Ana_UTE);
            this.man_Ana_SCHEDATableAdapter.Fill(this.dsActivities.Man_Ana_SCHEDA);
            this.man_Ana_CDCTableAdapter.Fill(this.dsActivities.Man_Ana_CDC);
            this.man_Ana_MACTableAdapter.Fill(this.dsActivities.Man_Ana_MAC);                      
        }
    }
}
