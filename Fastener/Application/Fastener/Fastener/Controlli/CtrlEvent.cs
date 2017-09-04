using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;

namespace Fastener.Controlli
{
    public partial class CtrlEvent : UserControl
    {
        public CtrlEvent()
        {
            InitializeComponent();

            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now;

            tipo_Manutenzione_T_ViewTableAdapter.Fill(dsEvents.Tipo_Manutenzione_T_View, Program.language_);
            tipo_Reparto_T_ViewTableAdapter.Fill(dsEvents.Tipo_Reparto_T_View, Program.language_);
            tipoRepartoTViewBindingSource.Filter = Program.FilterTipoRep();
            man_Ana_Stato_RecordTableAdapter.Fill(dsEvents.Man_Ana_Stato_Record);
            man_Ana_UTETableAdapter.Fill(dsEvents.Man_Ana_UTE);

            DateTime dt = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                8,
                0,
                0);

            ctrlDateTimePicker_start.WriteTs(dt);
            ctrlDateTimePicker_end.WriteTs(dt.AddHours(8));

            PerformSearch();

            Utility.formatDataGrid(dbDataGridView_teste, true);
            Utility.formatDataGrid(dbDataGridView_righe, true);

            ctrlDateTimePicker_start.FontColor = Color.White;
            ctrlDateTimePicker_end.FontColor = Color.White;
            ctrlPlantSelector.FontColor = Color.White;

            ChangeMode(Mode.INSERT);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            dsEvents.EventiRighe.Clear();
            eventiTestaTableAdapter.Fill(dsEvents.EventiTesta, Program.language_, dateTimePicker_start.Value, dateTimePicker_end.Value);
        }

        private void dbDataGridView_teste_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_teste.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_teste.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsEvents.EventiTestaRow row = drv.Row as DataSet.dsEvents.EventiTestaRow;
                    RefreshDatagridRighe(row.EventKey);

                    comboBox_man.SelectedValue = row.TipoManKey;
                    comboBox_rep.SelectedValue = row.TipoRepKey;
                    textBox_contratto.Text = row.EventContractNumber;
                    comboBox_ute.SelectedValue = row.UTEKey;
                    comboBox_stato_rec.SelectedValue = row.StatoRecKey;
                    textBox_descr.Text = row.EventDescription;
                    textBox_note.Text = row.EventRemark;

                    DateTime start = new DateTime(
                        row.dt_start_date.Year,
                        row.dt_start_date.Month,
                        row.dt_start_date.Day,
                        row.start_hour,
                        row.start_minute,
                        0);

                    DateTime end = new DateTime(
                        row.dt_end_date.Year,
                        row.dt_end_date.Month,
                        row.dt_end_date.Day,
                        row.end_hour,
                        row.end_minute,
                        0);

                    ctrlDateTimePicker_start.WriteTs(start);
                    ctrlDateTimePicker_end.WriteTs(end);

                    ChangeMode(Mode.UPDATE);
                }
            }
        }

        private void RefreshDatagridRighe(int EventKey)
        {
            eventiRigheTableAdapter.Fill(dsEvents.EventiRighe, EventKey, Program.language_);

            textBox_remaining.Text = string.Empty;
            int count = 0;
            for (int i = 0; i < dbDataGridView_righe.Rows.Count; i++)
            {
                DataRowView drv = dbDataGridView_righe.Rows[i].DataBoundItem as DataRowView;
                DataSet.dsEvents.EventiRigheRow row = drv.Row as DataSet.dsEvents.EventiRigheRow;
                count += row.DriverPerc;
            }

            textBox_remaining.Text = (100 - count).ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int event_key = -1;

            try
            {
                if (mode == Mode.INSERT)
                {
                    event_key = (int)eventiTestaTableAdapter.InsertQuery(
                        textBox_descr.Text,
                        (int)comboBox_rep.SelectedValue,
                        (int)comboBox_man.SelectedValue,
                        Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
                        Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
                        Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
                        Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()),
                        textBox_contratto.Text,
                        textBox_note.Text,
                        (int)comboBox_ute.SelectedValue,
                        (int)comboBox_stato_rec.SelectedValue,
                        ctrlDateTimePicker_start.ReadTs(),
                        ctrlDateTimePicker_end.ReadTs());
                    ChangeMode(Mode.UPDATE);
                }
                else if (mode == Mode.UPDATE)
                {

                    int eventkey = -1;

                    if (dbDataGridView_teste.SelectedRows.Count > 0)
                    {
                        DataRowView drv = dbDataGridView_teste.SelectedRows[0].DataBoundItem as DataRowView;
                        if (drv != null)
                        {
                            DataSet.dsEvents.EventiTestaRow row = drv.Row as DataSet.dsEvents.EventiTestaRow;
                            eventkey = row.EventKey;
                        }
                    }

                    eventiTestaTableAdapter.UpdateQuery(
                        textBox_descr.Text,
                        (int)comboBox_rep.SelectedValue,
                        (int)comboBox_man.SelectedValue,
                        Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
                        Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
                        Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
                        Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()),
                        textBox_contratto.Text,
                        textBox_note.Text,
                        (int)comboBox_ute.SelectedValue,
                        (int)comboBox_stato_rec.SelectedValue,
                        ctrlDateTimePicker_start.ReadTs(),
                        ctrlDateTimePicker_end.ReadTs(),
                        eventkey);
                }
                if (ctrlDateTimePicker_start.ReadTs() < dateTimePicker_start.Value)
                    dateTimePicker_start.Value = ctrlDateTimePicker_start.ReadTs();
                if (ctrlDateTimePicker_end.ReadTs() > dateTimePicker_end.Value)
                    dateTimePicker_end.Value = ctrlDateTimePicker_end.ReadTs();

                PerformSearch();
                if (event_key != -1)
                    SelectEvent(event_key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectEvent(int event_key)
        {
            for (int i = 0; i < dbDataGridView_teste.Rows.Count; i++)
            {
                DataSet.dsEvents.EventiTestaRow row = (dbDataGridView_teste.Rows[i].DataBoundItem as DataRowView).Row as DataSet.dsEvents.EventiTestaRow;
                if (row.EventKey == event_key)
                    dbDataGridView_teste.Rows[i].Selected = true;
                else
                    dbDataGridView_teste.Rows[i].Selected = false;
            }            
        }

        enum Mode
        {
            INSERT,
            UPDATE
        }

        Mode mode = Mode.INSERT;

        private void ChangeMode(Mode value)
        {
            mode = value;
            if (mode == Mode.INSERT)
                button_save.Text = Properties.MessageLocalization.event_save_button_text_insert;
            else
                button_save.Text = Properties.MessageLocalization.event_save_button_text_modify;
        }

    
        private void button_new_event_Click(object sender, EventArgs e)
        {
            textBox_contratto.Text = string.Empty;
            textBox_descr.Text = string.Empty;
            textBox_note.Text = string.Empty;
            comboBox_man.SelectedValue = dsEvents.Tipo_Manutenzione_T_View[0].TipoManKey;
            comboBox_rep.SelectedValue = dsEvents.Tipo_Reparto_T_View[0].TipoRepKey;
            comboBox_ute.SelectedValue = Program.CurrentUser.Key;
            comboBox_stato_rec.SelectedValue = dsEvents.Man_Ana_Stato_Record[0].StatoRecKey;

            ChangeMode(Mode.INSERT);
        }

        private void button_modifica_righe_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_righe.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_righe.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    try
                    {
                        DataSet.dsEvents.EventiRigheRow row = drv.Row as DataSet.dsEvents.EventiRigheRow;
                        eventiRigheTableAdapter.UpdateQuery(
                            (int)ctrlPlantSelector.SelectedImpianto(),
                            (int)ctrlPlantSelector.SelectedMacchina(),
                            ctrlPlantSelector.SelectedComponente(),
                            ctrlPlantSelector.SelectedSCM_1(),
                            ctrlPlantSelector.SelectedSCM_2(),
                            ctrlPlantSelector.SelectedSCM_3(),
                            int.Parse(textBox_driver.Text),
                           row.EventRowKey);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void button_aggiungi_righe_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_teste.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_teste.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    try
                    {
                        DataSet.dsEvents.EventiTestaRow row = drv.Row as DataSet.dsEvents.EventiTestaRow;
                        if (int.Parse(textBox_remaining.Text) < int.Parse(textBox_driver.Text))
                        {
                            MessageBox.Show(Properties.MessageLocalization.events_driver_perc_exceeds);
                            return;
                        }
                        eventiRigheTableAdapter.InsertQuery(
                            row.EventKey,
                            (int)ctrlPlantSelector.SelectedImpianto(),
                            (int)ctrlPlantSelector.SelectedMacchina(),
                            ctrlPlantSelector.SelectedComponente(),
                            ctrlPlantSelector.SelectedSCM_1(),
                            ctrlPlantSelector.SelectedSCM_2(),
                            ctrlPlantSelector.SelectedSCM_3(),
                            int.Parse(textBox_driver.Text)
                           );

                        RefreshDatagridRighe(row.EventKey);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void dbDataGridView_righe_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_righe.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_righe.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsEvents.EventiRigheRow row = drv.Row as DataSet.dsEvents.EventiRigheRow;
                    textBox_driver.Text = row.DriverPerc.ToString();

                    int? null_value = null;

                    ctrlPlantSelector.PerformSelection(
                        row.IMPKey,
                        row.MACKey,
                        row.IsCOMKeyNull() ? null_value : row.COMKey,
                        row.IsSCM_1KeyNull() ? null_value : row.SCM_1Key,
                        row.IsSCM_2KeyNull() ? null_value : row.SCM_2Key,
                        row.IsSCM_3KeyNull() ? null_value : row.SCM_3Key);
                }
            }
        }

        private void cancellaRecordSelezionatiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int EventKey = 0;
                using (TransactionScope scp = new TransactionScope())
                {
                    foreach (DataGridViewRow r in dbDataGridView_righe.SelectedRows)
                    {
                        DataSet.dsEvents.EventiRigheRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsEvents.EventiRigheRow;
                        EventKey = row.EventKey;
                        eventiRigheTableAdapter.DeleteQuery(row.EventRowKey);
                    }

                    scp.Complete();
                }

                if (EventKey != 0)
                    RefreshDatagridRighe(EventKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dbDataGridView_righe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_righe, contextMenuStrip_righe, e);
        }

        private void cancellaRecordSelezionatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scp = new TransactionScope())
                {
                    foreach (DataGridViewRow r in dbDataGridView_teste.SelectedRows)                        
                    {
                        DataSet.dsEvents.EventiTestaRow row = (r.DataBoundItem as DataRowView).Row as DataSet.dsEvents.EventiTestaRow;
                        new DataSet.dsActivitiesTableAdapters.Man_Act_EveTableAdapter().DeleteByEvent(row.EventKey);
                        eventiRigheTableAdapter.DeleteByEventKey(row.EventKey);
                        eventiTestaTableAdapter.DeleteQuery(row.EventKey);
                    }
                    scp.Complete();
                }

                PerformSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.MessageLocalization.event_cannot_cancel);//ex.ToString());
            }
        }

        private void dbDataGridView_teste_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_teste, contextMenuStrip_teste, e);
        }

        private void copiaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbDataGridView_teste.SelectedRows.Count != 1)
            {
                MessageBox.Show(Properties.MessageLocalization.event_copy_too_many_rows);
                return;
            }

            try
            {
                using (System.Transactions.TransactionScope scp = new TransactionScope())
                {
                    DataSet.dsEvents.EventiTestaRow row = (dbDataGridView_teste.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsEvents.EventiTestaRow;
                    int new_event_key = (int)eventiTestaTableAdapter.CloneEvent(row.EventKey);
                    eventiRigheTableAdapter.CloneEventRows(new_event_key, row.EventKey);

                    scp.Complete();
                }

                PerformSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
