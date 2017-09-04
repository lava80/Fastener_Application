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

namespace Fastener.Controlli
{
    public partial class CtrlActivityEvent : UserControl
    {
        public event EventHandler SubmitEvent;

        private ComboBox comboBox_tipo_reparto_ = null;
        private ComboBox comboBox_utente_ = null;
        private ComboBox combobox_azienda_ = null;

        public CtrlActivityEvent(ComboBox tipo_reparto, ComboBox utente, ComboBox azienda)
        {
            InitializeComponent();

            comboBox_tipo_reparto_ = tipo_reparto;
            comboBox_utente_ = utente;
            combobox_azienda_ = azienda;

            InitializeMask();

            //label_end_date.ForeColor = Color.White;
            //label_tipo_man.ForeColor = Color.White;
            //label_start_date.ForeColor = Color.White;
            ctrlDateTimePicker_end.FontColor = Color.White;
            ctrlDateTimePicker_start.FontColor = Color.White;
            //dbPanel_main.BackgroundImage = Properties.Resources.activity_layout_2;
            //button_save.Text = Properties.MessageLocalization.activity_button_save;

            Utility.formatDataGrid(dbDataGridView_events, true);
        }
        
        private void InitializeMask()
        {
            //if (ctrlDateTimePicker_start.ValueChanged != null)
                ctrlDateTimePicker_start.ValueChanged -= ctrlDateTimePicker_start_ValueChanged;
            //if (ctrlDateTimePicker_start.ValueChanged)
                ctrlDateTimePicker_end.ValueChanged -= ctrlDateTimePicker_end_ValueChanged;

            if (combobox_azienda_.SelectedValue != null)
                tipoOreTableAdapter.Fill(dsActivities.TipoOre, (int)combobox_azienda_.SelectedValue);

            DataSet.dsActivities.LastHHMMDataTable d_hms = new DataSet.dsActivities.LastHHMMDataTable();
            new DataSet.dsActivitiesTableAdapters.LastHHMMTableAdapter().Fill(d_hms, (int)comboBox_utente_.SelectedValue);

            if (d_hms.Count > 0)
            {
                DateTime d = new DateTime(
                   d_hms[0].LastDateTime.Year,
                    d_hms[0].LastDateTime.Month,
                    d_hms[0].LastDateTime.Day,
                    d_hms[0].HMSHour24,
                    d_hms[0].HMSMinute,
                    0);
                ctrlDateTimePicker_start.WriteTs(d);
                ctrlDateTimePicker_end.WriteTs(d.AddMinutes(CtrlDateTimePicker.forward));
            }

            else
            {
                DateTime d = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    8,
                    0,
                    0);
                ctrlDateTimePicker_start.WriteTs(d);
                ctrlDateTimePicker_end.WriteTs(d.AddMinutes(15));                
            }

            tipo_Manutenzione_T_ViewTableAdapter.Fill(dsActivities.Tipo_Manutenzione_T_View, Program.language_);

            ctrlDateTimePicker_start.ValueChanged += new EventHandler(ctrlDateTimePicker_start_ValueChanged);
            ctrlDateTimePicker_end.ValueChanged += new EventHandler(ctrlDateTimePicker_end_ValueChanged);

            RefreshEvents();
        }

        private void RefreshEvents()
        {
            eventiTestaTableAdapter.Fill(
                dsEvents.EventiTesta, Program.language_,
                ctrlDateTimePicker_start.ReadTs(), ctrlDateTimePicker_end.ReadTs());

            eventiTestaBindingSource.Filter = Program.FilterTipoRep();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string err = "";
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
            {
                err += Properties.MessageLocalization.activity_ts_mismatch + System.Environment.NewLine;
            }

            DataSet.dsActivities.OverlappingActivitiesDataTable d_overlap = new DataSet.dsActivities.OverlappingActivitiesDataTable();
            //new DataSet.dsActivitiesTableAdapters.OverlappingActivitiesTableAdapter().Fill(
            //    d_overlap,
            //    (int)comboBox_utente_.SelectedValue, -1,
            //    Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
            //    Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
            //    Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
            //    Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()));

            new DataSet.dsActivitiesTableAdapters.OverlappingActivitiesTableAdapter().Fill(
                d_overlap,
                (int)comboBox_utente_.SelectedValue, -1,
                ctrlDateTimePicker_start.ReadTs(),
                ctrlDateTimePicker_end.ReadTs());

            if (d_overlap.Count > 0)
            {
                err += Properties.MessageLocalization.activity_overlap + System.Environment.NewLine;
            }

            if (ctrlDateTimePicker_start.ReadTs().Minute % 15 != 0 || ctrlDateTimePicker_end.ReadTs().Minute % 15 != 0)
            {
                err += Properties.MessageLocalization.activity_wrong_min_range + System.Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            else
            {
                try
                {
                    if (dbDataGridView_events.SelectedRows.Count > 0)
                    {
                        DataSet.dsEvents.EventiTestaRow ev_testa_row = (dbDataGridView_events.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsEvents.EventiTestaRow;
                        DataSet.dsEvents.EventiRigheDataTable eventi_righe = new DataSet.dsEvents.EventiRigheDataTable();
                        new DataSet.dsEventsTableAdapters.EventiRigheTableAdapter().Fill(eventi_righe, ev_testa_row.EventKey, Program.language_);
                        DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter act_adapter = new DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter();
                        DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter act_evt_adapter = new DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter();

                        long tot_sec = (long)(ctrlDateTimePicker_end.ReadTs() - ctrlDateTimePicker_start.ReadTs()).TotalSeconds;
                        DateTime dt_prg = ctrlDateTimePicker_start.ReadTs();

                        DataSet.dsActivities.MaxActEveGroupDataTable d_max = new DataSet.dsActivities.MaxActEveGroupDataTable();
                        new DataSet.dsActivitiesTableAdapters.MaxActEveGroupTableAdapter().Fill(d_max);

                        int act_event_group_id = (d_max[0].IsMaxActEveGroupIdNull() ? 0 : d_max[0].MaxActEveGroupId) + 1;
                        using (TransactionScope scp = new TransactionScope())
                        {
                            foreach (DataSet.dsEvents.EventiRigheRow ev_righe_row in eventi_righe.Rows)
                            {
                                int? COMKey = null;
                                int? SCM_1_Key = null;
                                int? SCM_2_Key = null;
                                int? SCM_3_Key = null;

                                if (!ev_righe_row.IsCOMKeyNull())
                                    COMKey = ev_righe_row.COMKey;
                                if (!ev_righe_row.IsSCM_1KeyNull())
                                    SCM_1_Key = ev_righe_row.SCM_1Key;
                                if (!ev_righe_row.IsSCM_2KeyNull())
                                    SCM_2_Key = ev_righe_row.SCM_2Key;
                                if (!ev_righe_row.IsSCM_3KeyNull())
                                    SCM_3_Key = ev_righe_row.SCM_3Key;

                                DateTime dt_next = dt_prg.AddSeconds(tot_sec * ev_righe_row.DriverPerc / 100);
                                int ActivityKey = (int)act_adapter.InsertActivity(
                                    Program.DateToInt(dt_prg),
                                    Program.DateToInt(dt_next),
                                    Program.HmsToInt(dt_prg),
                                    Program.HmsToInt(dt_next),
                                    (int)(dt_next - dt_prg).TotalSeconds,
                                    string.Empty,
                                    (int)comboBox_utente_.SelectedValue,
                                    ev_testa_row.TipoManKey,
                                    (int)comboBox_tipo_reparto_.SelectedValue,
                                    null,
                                    ev_righe_row.IMPKey,
                                    ev_righe_row.MACKey,
                                    COMKey,
                                    SCM_1_Key,
                                    SCM_2_Key,
                                    SCM_3_Key,
                                    Program.CurrentUser.Login,
                                    dt_prg,
                                    dt_next,
                                    (int)comboBox_tipo_ore.SelectedValue,
                                    null);
                                dt_prg = dt_next;
                                int ActEveKey = (int)act_evt_adapter.InsertQuery(ActivityKey, ev_testa_row.EventKey, act_event_group_id);

                                act_adapter.UpdateActEveKey(ActEveKey, ActivityKey);
                            }
                            scp.Complete();
                        }
                    }
                    
                    ActivitySubmitEventArgs ev = new ActivitySubmitEventArgs(ctrlDateTimePicker_start.ReadTs(), ctrlDateTimePicker_end.ReadTs());
                    InitializeMask();
                    Program.RefreshActNoReport();
                    SubmitEvent(this, ev);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    
        private void ctrlDateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
            ctrlDateTimePicker_end.ValueChanged -= ctrlDateTimePicker_end_ValueChanged;
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
            {
                ctrlDateTimePicker_end.WriteTs(ctrlDateTimePicker_start.ReadTs().AddMinutes(CtrlDateTimePicker.forward));
            }

            RefreshEvents();

            ctrlDateTimePicker_end.ValueChanged += new EventHandler(ctrlDateTimePicker_end_ValueChanged);
        }

        private void ctrlDateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            ctrlDateTimePicker_start.ValueChanged -= ctrlDateTimePicker_start_ValueChanged;
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
                ctrlDateTimePicker_start.WriteTs(ctrlDateTimePicker_end.ReadTs().AddMinutes(-CtrlDateTimePicker.backward));

            RefreshEvents();

            ctrlDateTimePicker_start.ValueChanged += new EventHandler(ctrlDateTimePicker_start_ValueChanged);
        }
    }
}
