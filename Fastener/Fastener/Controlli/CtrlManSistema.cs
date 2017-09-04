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
    public partial class CtrlManSistema : UserControl
    {
        public CtrlManSistema()
        {
            InitializeComponent();

            InitTipoManutenzione();
            InitTipoUtenti();
            InitTipoReparti();
            InitStatoRecord();
            InitLingueSupportate();
        }

        private DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter translations = new DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter();

        #region TIPO MANUTENZIONI
        private void InitTipoManutenzione()
        {
            Utility.formatDataGrid(dbDataGridView_tipo_manutenzioni, true);
            man_Ana_Tipo_ManutenzioneTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Manutenzione);
        }

        

        private void button_save_tipo_manutenzione_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_manutenzioni, true);
            manAnaTipoManutenzioneBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_Tipo_ManutenzioneRow r in dsMaintenance.Man_Ana_Tipo_Manutenzione.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        r.TranslationUID = Guid.NewGuid().ToString();
                        translations.Insert(1, r.TranslationUID, r.TipoManName);
                    }
                    else if (r.RowState == DataRowState.Modified)
                    {
                        translations.UpdateDefaultTranslation(r.TipoManName, r.TranslationUID);                        
                    }
                    man_Ana_Tipo_ManutenzioneTableAdapter.Update(r);
                }
                
                scp.Complete();
            }
            InitTipoManutenzione();
        }

        private void button_refresh_tipo_manutenzione_Click(object sender, EventArgs e)
        {
            InitTipoManutenzione();
        }

        private void dbDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_manutenzioni, true, true);
        }
        #endregion

        #region TIPO UTENTE
        private void InitTipoUtenti()
        {
            Utility.formatDataGrid(dbDataGridView_tipo_utenti, true);
            man_Ana_Tipo_UtenteTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Utente);
        }

        private void button_undo_tipo_utenti_Click(object sender, EventArgs e)
        {
            InitTipoUtenti();
        }        

        private void button_save_tipo_utenti_Click(object sender, EventArgs e)
        {            
            Utility.formatDataGrid(dbDataGridView_tipo_utenti, true);
            manAnaTipoUtenteBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_Tipo_UtenteRow r in dsMaintenance.Man_Ana_Tipo_Utente.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        r.TranslationUID = Guid.NewGuid().ToString();
                        translations.Insert(1, r.TranslationUID, r.TipoUteName);
                    }
                    else if (r.RowState == DataRowState.Modified)
                    {
                        translations.UpdateDefaultTranslation(r.TipoUteName, r.TranslationUID);                        
                    }
                    man_Ana_Tipo_UtenteTableAdapter.Update(r);
                }

                scp.Complete();
            }
            InitTipoUtenti();
        }

        private void dbDataGridView_tipo_utenti_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_utenti, true, true);
        }

        #endregion

        #region TIPO REPARTI
        private void button_undo_tipo_reparti_Click(object sender, EventArgs e)
        {
            InitTipoReparti();
        }

        private void InitTipoReparti()
        {
            Utility.formatDataGrid(dbDataGridView_tipo_reparti, true);
            man_Ana_Tipo_RepartoTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Reparto);
            cA_Ana_CDR_ReportingTableAdapter.Fill(dsMaintenance.CA_Ana_CDR_Reporting);
        }        

        private void button_save_tipo_reparti_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_reparti, true);
            manAnaTipoRepartoBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_Tipo_RepartoRow r in dsMaintenance.Man_Ana_Tipo_Reparto.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        r.TranslationUID = Guid.NewGuid().ToString();
                        translations.Insert(1, r.TranslationUID, r.TipoRepName);
                    }
                    else if (r.RowState == DataRowState.Modified)
                    {
                        translations.UpdateDefaultTranslation(r.TipoRepName, r.TranslationUID);
                    }
                    man_Ana_Tipo_RepartoTableAdapter.Update(r);
                }

                scp.Complete();
            }
            InitTipoReparti();
        }

        private void dbDataGridView_tipo_reparti_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_reparti, true, true);
        }

        #endregion

        #region STATO RECORD
        private void InitStatoRecord()
        {
            Utility.formatDataGrid(dbDataGridView_stato_record, true);
            man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
        }

        private void dbDataGridView_stato_record_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_stato_record, true, true);
        }

        private void buttonsave_stato_record_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_stato_record, true);
            manAnaStatoRecordBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_Stato_RecordRow r in dsMaintenance.Man_Ana_Stato_Record.GetChanges().Rows)
                {                    
                    man_Ana_Stato_RecordTableAdapter.Update(r);
                }

                scp.Complete();
            }
            InitStatoRecord();
        }

        private void button_undo_stato_record_Click(object sender, EventArgs e)
        {
            InitStatoRecord();
        }


        #endregion

        #region LINGUAGGI SUPPORTATI
        private void dbDataGridView_lingue_supportate_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_lingue_supportate, true, true);
        }

        private void button_undo_lingue_supportate_Click(object sender, EventArgs e)
        {
            InitLingueSupportate();
        }

        private void InitLingueSupportate()
        {
            Utility.formatDataGrid(dbDataGridView_lingue_supportate, true);
            man_Ana_LANTableAdapter.Fill(dsMaintenance.Man_Ana_LAN);
        }

        private void buttonsave_lingue_supportate_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_lingue_supportate, true);
            manAnaLANBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_LAN_TRARow r in dsMaintenance.Man_Ana_LAN.GetChanges().Rows)
                {
                    man_Ana_LANTableAdapter.Update(r);
                }

                scp.Complete();
            }
            InitLingueSupportate();
        }

        #endregion
    }
}
