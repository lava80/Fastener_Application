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
    public partial class CtrlManImpianti : UserControl
    {
        public CtrlManImpianti()
        {
            InitializeComponent();

            man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
            //man_Ana_CDCTableAdapter.Fill(dsMaintenance.Man_Ana_CDC);            
            man_Ana_Tipo_RepartoTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Reparto);
            cA_Ana_CDR_ReportingTableAdapter.Fill(dsMaintenance.CA_Ana_CDR_Reporting);
            cA_Ana_ContoCogeTableAdapter.Fill(dsMaintenance.CA_Ana_ContoCoge);

            dbDataGridView_area.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_imp.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_scheda.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_CA.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_mac.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_com.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            dbDataGridView_scm_1.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");
            dbDataGridView_scm_2.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");
            dbDataGridView_scm_3.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");

            contextMenuStrip_are.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_imp.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_Scheda.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_CA.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_mac.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_com.Enabled = Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            contextMenuStrip_scm_1.Enabled = Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");
            contextMenuStrip_scm_2.Enabled = Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");
            contextMenuStrip_scm_3.Enabled = Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");

            InitARE();
        }

        private DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter translations = new DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter();

        #region IMPIANTI
        private void dbDataGridView_imp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_imp, contextMenuStrip_imp, e);
        }

        private void button_undo_imp_Click(object sender, EventArgs e)
        {
            InitIMP();
        }

        private void InitIMP()
        {
            Utility.formatDataGrid(dbDataGridView_imp, true);

            dsMaintenance.Man_Ana_SCHEDA.Clear();
            dsMaintenance.Man_Ana_CDC.Clear();
            dsMaintenance.Man_Ana_MAC.Clear();
            dsMaintenance.Man_Ana_COM.Clear();
            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_area.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_area.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_ARERow r = drv.Row as DataSet.dsMaintenance.Man_Ana_ARERow;
                    man_Ana_IMPTableAdapter.Fill(dsMaintenance.Man_Ana_IMP, r.AREKey);
                }
            }
        }

        private void dbDataGridView_imp_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_imp, true, true);
        }

        private void button_save_imp_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_imp, true);
            manAnaIMPBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_IMP.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_IMPRow r in dsMaintenance.Man_Ana_IMP.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.IMPName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;
                            if (r.IsAREKeyNull())
                            {
                                DataRowView drv = dbDataGridView_area.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                DataSet.dsMaintenance.Man_Ana_ARERow rare = drv.Row as DataSet.dsMaintenance.Man_Ana_ARERow;
                                r.AREKey = rare.AREKey;
                            }
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.IMPName, r.TranslationUID);
                        }
                        man_Ana_IMPTableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitIMP();
        }

        private void dbDataGridView_imp_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_imp.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_SCHEDA.Clear();
                dsMaintenance.Man_Ana_CDC.Clear();
                dsMaintenance.Man_Ana_MAC.Clear();
                dsMaintenance.Man_Ana_COM.Clear();
                dsMaintenance.Man_Ana_SCM_1.Clear();
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitSCHEDA();
            }
        }

        #endregion

        #region MACCHINE
        private void dbDataGridView_mac_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_mac, contextMenuStrip_mac, e);
        }

        private void button_undo_mac_Click(object sender, EventArgs e)
        {
            InitMAC();
        }

        private void InitMAC()
        {
            Utility.formatDataGrid(dbDataGridView_mac, true);

            dsMaintenance.Man_Ana_COM.Clear();
            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_CA.SelectedRows.Count >0)
            {
                DataRowView drv = dbDataGridView_CA.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_CDCRow r = drv.Row as DataSet.dsMaintenance.Man_Ana_CDCRow;
                    man_Ana_MACTableAdapter.Fill(dsMaintenance.Man_Ana_MAC, r.CDCKey);
                }
            }
        }


        private void dbDataGridView_macCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_mac, true, true);
        }

        private void button_save_mac_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_mac, true);
            manAnaMACBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_MAC.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_MACRow r in dsMaintenance.Man_Ana_MAC.GetChanges().Rows)
                    {
                        try
                        {
                            if (r.RowState == DataRowState.Added)
                            {
                                r.TranslationUID = Guid.NewGuid().ToString();
                                translations.Insert(1, r.TranslationUID, r.MACName);
                                if (r.IsStatoRecKeyNull())
                                    r.StatoRecKey = 1;
                                if (r.IsCDCKeyNull())
                                {
                                    DataRowView drv = dbDataGridView_CA.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                    DataSet.dsMaintenance.Man_Ana_CDCRow rimp = drv.Row as DataSet.dsMaintenance.Man_Ana_CDCRow;
                                    r.CDCKey = rimp.CDCKey;
                                }
                            }
                            else if (r.RowState == DataRowState.Modified)
                            {
                                translations.UpdateDefaultTranslation(r.MACName, r.TranslationUID);
                            }
                            man_Ana_MACTableAdapter.Update(r);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nessun record da salvare!!!");
                }

                scp.Complete();
            }
            InitMAC();
        }
        
        private void dbDataGridView_mac_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_mac.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_SCM_1.Clear();
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitCOM();
            }
        }

        #endregion

        #region COMPONENTE
        private void dbDataGridView_com_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_com, contextMenuStrip_com, e);
        }

        private void button_undo_com_Click(object sender, EventArgs e)
        {
            InitCOM();
        }

        private void InitCOM()
        {
            Utility.formatDataGrid(dbDataGridView_com, true);

            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_mac.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_mac.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_MACRow r = drv.Row as DataSet.dsMaintenance.Man_Ana_MACRow;
                    man_Ana_COMTableAdapter.Fill(dsMaintenance.Man_Ana_COM, r.MACKey);
                }
            }
        }

        private void dbDataGridView_comCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_com, true, true);
        }

        private void button_save_com_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_mac, true);
            manAnaCOMBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_COM.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_COMRow r in dsMaintenance.Man_Ana_COM.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.COMName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;
                            if (r.IsMACKeyNull())
                            {
                                DataRowView drv = dbDataGridView_mac.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                DataSet.dsMaintenance.Man_Ana_MACRow rmac = drv.Row as DataSet.dsMaintenance.Man_Ana_MACRow;
                                r.MACKey = rmac.MACKey;
                            }
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.COMName, r.TranslationUID);
                        }
                        man_Ana_COMTableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitCOM();
        }

        private void dbDataGridView_com_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_com.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitSCM_1();
            }
        }

        #endregion

        #region SOTTO COMPONENTE 1
        private void dbDataGridView_scm_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_scm_1, contextMenuStrip_scm_1, e);
        }

        private void button_undo_scm_1_Click(object sender, EventArgs e)
        {
            InitSCM_1();
        }

        private void InitSCM_1()
        {
            Utility.formatDataGrid(dbDataGridView_scm_1, true);

            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_com.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_com.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_COMRow r = drv.Row as DataSet.dsMaintenance.Man_Ana_COMRow;
                    man_Ana_SCM_1TableAdapter.Fill(dsMaintenance.Man_Ana_SCM_1, r.COMKey);

                    if (!Program.CurrentUser.GetPermission("MAN_PLANT_SPECIFY_REP"))
                        manAnaSCM1BindingSource.Filter = Program.FilterTipoRep();

                    if (!Program.CurrentUser.GetPermission("MAN_PLANT_SPECIFY_REP"))
                        manAnaTipoRepartoBindingSource.Filter = Program.FilterTipoRep();
                }
            }
        }

        private void dbDataGridView_scm_1CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_1, true, true);
        }

        private void button_save_scm_1_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_1, true);
            manAnaSCM1BindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_SCM_1.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_SCM_1Row r in dsMaintenance.Man_Ana_SCM_1.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.SCNName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;
                            if (r.IsCOMKeyNull())
                            {
                                DataRowView drv = dbDataGridView_com.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                DataSet.dsMaintenance.Man_Ana_COMRow rcom = drv.Row as DataSet.dsMaintenance.Man_Ana_COMRow;
                                r.COMKey = rcom.COMKey;
                            }
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.SCNName, r.TranslationUID);
                        }
                        man_Ana_SCM_1TableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitSCM_1();
        }

        private void dbDataGridView_scm_1_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_scm_1.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitSCM_2();
            }
        }

        #endregion

        #region SOTTO COMPONENTE 2
        private void dbDataGridView_scm_2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_scm_2, contextMenuStrip_scm_2, e);
        }

        private void button_undo_scm_2_Click(object sender, EventArgs e)
        {
            InitSCM_2();
        }

        private void InitSCM_2()
        {
            Utility.formatDataGrid(dbDataGridView_scm_2, true);

            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_scm_1.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_scm_1.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_SCM_1Row r = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_1Row;
                    man_Ana_SCM_2TableAdapter.Fill(dsMaintenance.Man_Ana_SCM_2, r.SCMKey);

                    if (!Program.CurrentUser.GetPermission("MAN_PLANT_SPECIFY_REP"))
                        manAnaSCM2BindingSource.Filter = Program.FilterTipoRep();
                }
            }
        }

        private void dbDataGridView_scm_2CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_2, true, true);
        }

        private void button_save_scm_2_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_2, true);
            manAnaSCM2BindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_SCM_2.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_SCM_2Row r in dsMaintenance.Man_Ana_SCM_2.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.SCNName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;

                            DataRowView drv = dbDataGridView_scm_1.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                            DataSet.dsMaintenance.Man_Ana_SCM_1Row rscm1 = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_1Row;

                            if (r.IsSCM_1_KeyNull())
                                r.SCM_1_Key = rscm1.SCMKey;

                            r.TipoRepKey = rscm1.TipoRepKey;

                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.SCNName, r.TranslationUID);
                        }
                        man_Ana_SCM_2TableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitSCM_2();
        }

        private void dbDataGridView_scm_2_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_scm_2.SelectedRows.Count > 0)
            {
                InitSCM_3();
            }
        }

        #endregion

        #region SOTTO COMPONENTE 3
        private void dbDataGridView_scm_3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_scm_3, contextMenuStrip_scm_3, e);
        }

        private void button_undo_scm_3_Click(object sender, EventArgs e)
        {
            InitSCM_3();
        }

        private void InitSCM_3()
        {
            Utility.formatDataGrid(dbDataGridView_scm_3, true);
            if (dbDataGridView_scm_2.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_scm_2.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_SCM_2Row r = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_2Row;
                    man_Ana_SCM_3TableAdapter.Fill(dsMaintenance.Man_Ana_SCM_3, r.SCMKey);

                    if (!Program.CurrentUser.GetPermission("MAN_PLANT_SPECIFY_REP"))
                        manAnaSCM3BindingSource.Filter = Program.FilterTipoRep();
                }
            }
        }

        private void dbDataGridView_scm_3CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_3, true, true);
        }

        private void button_save_scm_3_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scm_3, true);
            manAnaSCM3BindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_SCM_3.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_SCM_3Row r in dsMaintenance.Man_Ana_SCM_3.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.SCNName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;

                            DataRowView drv = dbDataGridView_scm_2.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                            DataSet.dsMaintenance.Man_Ana_SCM_2Row rcom = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_2Row;

                            if (r.IsSCM_2_KeyNull())
                                r.SCM_2_Key = rcom.SCMKey;

                            r.TipoRepKey = rcom.TipoRepKey;
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.SCNName, r.TranslationUID);
                        }
                        man_Ana_SCM_3TableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitSCM_3();
        }        

        #endregion

        #region AREA
        private void dbDataGridView_area_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_area, contextMenuStrip_are, e);
        }

        private void button_save_area_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_area, true);
            manAnaAREBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_ARE.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_ARERow r in dsMaintenance.Man_Ana_ARE.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.AREName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.AREName, r.TranslationUID);
                        }
                        man_Ana_ARETableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitARE();
        }

        private void button_undo_area_Click(object sender, EventArgs e)
        {
            InitARE();
        }

        private void InitARE()
        {
            Utility.formatDataGrid(dbDataGridView_area, true);
            dsMaintenance.Man_Ana_IMP.Clear();
            dsMaintenance.Man_Ana_SCHEDA.Clear();
            dsMaintenance.Man_Ana_CDC.Clear();
            dsMaintenance.Man_Ana_MAC.Clear();
            dsMaintenance.Man_Ana_COM.Clear();
            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();
            man_Ana_ARETableAdapter.Fill(dsMaintenance.Man_Ana_ARE);
        }

        private void dbDataGridView_area_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_area, true, true);
        }

        private void dbDataGridView_area_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_area.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_IMP.Clear();
                dsMaintenance.Man_Ana_SCHEDA.Clear();
                dsMaintenance.Man_Ana_CDC.Clear();
                dsMaintenance.Man_Ana_MAC.Clear();
                dsMaintenance.Man_Ana_COM.Clear();
                dsMaintenance.Man_Ana_SCM_1.Clear();
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitIMP();
            }
        }

        #endregion

        #region SCHEDA
        private void dbDataGridView_scheda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_scheda, contextMenuStrip_Scheda, e);
        }

        private void button_undo_Scheda_Click(object sender, EventArgs e)
        {
            InitSCHEDA();
        }

        private void InitSCHEDA()
        {
            Utility.formatDataGrid(dbDataGridView_scheda, true);

            dsMaintenance.Man_Ana_CDC.Clear();
            dsMaintenance.Man_Ana_MAC.Clear();
            dsMaintenance.Man_Ana_COM.Clear();
            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_imp.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_imp.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_IMPRow r = drv.Row as DataSet.dsMaintenance.Man_Ana_IMPRow;
                    man_Ana_SCHEDATableAdapter.Fill(dsMaintenance.Man_Ana_SCHEDA, r.IMPKey);
                }
            }
        }

        private void dbDataGridView_scheda_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scheda, true, true);
        }

        private void button_save_Scheda_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_scheda, true);
            manAnaSCHEDABindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_SCHEDA.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_SCHEDARow r in dsMaintenance.Man_Ana_SCHEDA.GetChanges().Rows)
                    {
                        if (r.RowState == DataRowState.Added)
                        {
                            r.TranslationUID = Guid.NewGuid().ToString();
                            translations.Insert(1, r.TranslationUID, r.SchedaName);
                            if (r.IsStatoRecKeyNull())
                                r.StatoRecKey = 1;
                            if (r.IsIMPKeyNull())
                            {
                                DataRowView drv = dbDataGridView_imp.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                DataSet.dsMaintenance.Man_Ana_IMPRow rare = drv.Row as DataSet.dsMaintenance.Man_Ana_IMPRow;
                                r.IMPKey = rare.IMPKey;
                            }
                        }
                        else if (r.RowState == DataRowState.Modified)
                        {
                            translations.UpdateDefaultTranslation(r.SchedaName, r.TranslationUID);
                        }
                        man_Ana_SCHEDATableAdapter.Update(r);
                    }
                }

                scp.Complete();
            }
            InitSCHEDA();
        }

        private void dbDataGridView_scheda_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_scheda.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_CDC.Clear();
                dsMaintenance.Man_Ana_MAC.Clear();
                dsMaintenance.Man_Ana_COM.Clear();
                dsMaintenance.Man_Ana_SCM_1.Clear();
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitCA();
            }
        }

        #endregion

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_are,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_area.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_area.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_ARERow row = drv.Row as DataSet.dsMaintenance.Man_Ana_ARERow;
                    man_Ana_ARETableAdapter.Delete_ARE(row.AREKey);
                }
                InitARE();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_scm,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_scm_3.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_scm_3.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_SCM_3Row row = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_3Row;
                    man_Ana_SCM_3TableAdapter.Delete_SCM_3(row.SCMKey);
                }

                InitSCM_3();
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_imp,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_imp.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_imp.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_IMPRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_IMPRow;
                    man_Ana_IMPTableAdapter.Delete_IMP(row.IMPKey);
                }

                InitIMP();
            }
        }

        private void delete_mac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_mac,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_mac.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_mac.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_MACRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_MACRow;
                    man_Ana_MACTableAdapter.Delete_MAC(row.MACKey);
                }

                InitMAC();
            }
        }

        private void delete_com_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_com,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_com.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_com.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_COMRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_COMRow;
                    man_Ana_COMTableAdapter.Delete_COM(row.COMKey);
                }

                InitCOM();
            }
        }

        private void delete_scm_2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_scm,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_scm_2.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_scm_2.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_SCM_2Row row = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_2Row;
                    man_Ana_SCM_2TableAdapter.Delete_SCM_2(row.SCMKey);
                }

                InitSCM_2();
            }
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_scm,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_scm_1.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_scm_1.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_SCM_1Row row = drv.Row as DataSet.dsMaintenance.Man_Ana_SCM_1Row;
                    man_Ana_SCM_1TableAdapter.Delete_SCM_1(row.SCMKey);
                }

                InitSCM_1();
            }
        }

        private void delete_toolStrip_SCHEDA_MenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_scheda,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_scheda.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_scheda.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_SCHEDARow row = drv.Row as DataSet.dsMaintenance.Man_Ana_SCHEDARow;
                    man_Ana_SCHEDATableAdapter.Delete_SCHEDA(row.SCHEDAKey);
                }

                InitSCHEDA();
            }
        }

        #region CA
        private void button_undo_ca_Click(object sender, EventArgs e)
        {
            InitCA();
        }

        private void button_save_ca_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_CA, true);
            manAnaCDCBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                if (dsMaintenance.Man_Ana_CDC.GetChanges() != null)
                {
                    foreach (DataSet.dsMaintenance.Man_Ana_CDCRow r in dsMaintenance.Man_Ana_CDC.GetChanges().Rows)
                    {
                        try
                        {
                            if (r.RowState == DataRowState.Added)
                            {
                                r.TranslationUID = Guid.NewGuid().ToString();
                                translations.Insert(1, r.TranslationUID, r.CDCName);
                                if (r.IsStatoRecKeyNull())
                                    r.StatoRecKey = 1;
                                if (r.IsSchedaKeyNull())
                                {
                                    DataRowView drv = dbDataGridView_scheda.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                                    DataSet.dsMaintenance.Man_Ana_SCHEDARow rimp = drv.Row as DataSet.dsMaintenance.Man_Ana_SCHEDARow;
                                    r.SchedaKey = rimp.SCHEDAKey;
                                }
                            }
                            else if (r.RowState == DataRowState.Modified)
                            {
                                translations.UpdateDefaultTranslation(r.CDCName, r.TranslationUID);
                            }
                            man_Ana_CDCTableAdapter.Update(r);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nessun record da salvare!!!");
                }

                scp.Complete();
            }
            InitCA();
        }

        private void InitCA()
        {
            Utility.formatDataGrid(dbDataGridView_CA, true);

            dsMaintenance.Man_Ana_MAC.Clear();
            dsMaintenance.Man_Ana_COM.Clear();
            dsMaintenance.Man_Ana_SCM_1.Clear();
            dsMaintenance.Man_Ana_SCM_2.Clear();
            dsMaintenance.Man_Ana_SCM_3.Clear();

            if (dbDataGridView_scheda.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_scheda.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_SCHEDARow r = drv.Row as DataSet.dsMaintenance.Man_Ana_SCHEDARow;
                    man_Ana_CDCTableAdapter.Fill(dsMaintenance.Man_Ana_CDC, r.SCHEDAKey);
                }
            }
        }

        private void dbDataGridView_CA_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_CA, contextMenuStrip_CA, e);
        }

        private void dbDataGridView_CA_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_CA, true, true);
        }

        private void dbDataGridView_CA_SelectionChanged(object sender, EventArgs e)
        {
            if (dbDataGridView_CA.SelectedRows.Count > 0)
            {
                dsMaintenance.Man_Ana_MAC.Clear();
                dsMaintenance.Man_Ana_COM.Clear();
                dsMaintenance.Man_Ana_SCM_1.Clear();
                dsMaintenance.Man_Ana_SCM_2.Clear();
                dsMaintenance.Man_Ana_SCM_3.Clear();

                InitMAC();
            }
        }

        private void delete_CA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Properties.MessageLocalization.man_plant_delete_CA,
                Properties.MessageLocalization.man_plant_confirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbDataGridView_CA.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_CA.SelectedRows[0].DataBoundItem as DataRowView;
                    DataSet.dsMaintenance.Man_Ana_CDCRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_CDCRow;
                    man_Ana_CDCTableAdapter.Delete_CDC(row.CDCKey);
                }

                InitCA();
            }
        }

        #endregion         
        

    }
}
