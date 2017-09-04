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
    public partial class CtrlManAziende : UserControl
    {
        public CtrlManAziende()
        {
            InitializeComponent();

            man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
            man_Ana_Tipo_RepartoTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Reparto);

            Init_AZI();
            Init_AZI_REP();
            Init_Tip_Ore();
            Init_Tip_Ore_AZI();            
        }

        private void Init_AZI()
        {
            man_Ana_AZITableAdapter.Fill(dsMaintenance.Man_Ana_AZI);
            Utility.formatDataGrid(dbDataGridView_AZI, true);
        }

        private void Init_AZI_REP()
        {
            if (dbDataGridView_AZI.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;
                    man_Ana_AZI_REPTableAdapter.Fill(dsMaintenance.Man_Ana_AZI_REP, r_azi.AZIKey);
                }
            }
            Utility.formatDataGrid(dbDataGridView_AZI_REP, true);
        }

        private void Init_Tip_Ore()
        {           
            man_Ana_Tip_OraTableAdapter.Fill(dsMaintenance.Man_Ana_Tip_Ora);
            Utility.formatDataGrid(dbDataGridView_tipo_ore, true);
        }

        private void Init_Tip_Ore_AZI()
        {
            if (dbDataGridView_AZI.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;
                    man_Tip_Ore_AZITableAdapter.Fill(dsMaintenance.Man_Tip_Ore_AZI, r_azi.AZIKey);
                }
            }
            Utility.formatDataGrid(dbDataGridView_tipo_ore_ass, true);
        }

        private void button_refresh_AZI_Click(object sender, EventArgs e)
        {
            Init_AZI();
        }

        private void dbDataGridView_AZI_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_AZI, true, true);
        }

        private void button_save_AZI_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_AZI, true);
            manAnaAZIBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_AZIRow r in dsMaintenance.Man_Ana_AZI.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        if (r.IsAZIDisableTimeReportLimitNull())
                            r.AZIDisableTimeReportLimit = false;
                        if (r.IsStatoRecKeyNull())
                        {
                            r.StatoRecKey = 1;
                        }
                        if (string.IsNullOrEmpty(r.AZIName))
                        {
                            MessageBox.Show("Un'azienda non può ssere nulla");
                            r.RejectChanges();
                        }
                    }

                    man_Ana_AZITableAdapter.Update(r);
                }

                scp.Complete();
            }
            Init_AZI();
        }

        private void dbDataGridView_AZI_SelectionChanged(object sender, EventArgs e)
        {
            Init_AZI_REP();
            Init_Tip_Ore_AZI();
        }

        private void button_refresh_AZI_REP_Click(object sender, EventArgs e)
        {
            Init_AZI_REP();
        }

        private void dbDataGridView_AZI_REP_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_AZI_REP, true, true);
        }

        private void button_save_AZI_REP_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_AZI_REP, true);
            manAnaAZIREPBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_AZI_REPRow r in dsMaintenance.Man_Ana_AZI_REP.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        if (r.IsStatoRecKeyNull())
                        {
                            r.StatoRecKey = 1;
                        }
                        DataRowView drv = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;

                        DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;
                        r.AZIKey = r_azi.AZIKey;
                    }
                    man_Ana_AZI_REPTableAdapter.Update(r);
                }

                scp.Complete();
            }
            Init_AZI_REP();
        }

        private void dbDataGridView_AZI_REP_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView drv_azi = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;

            DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv_azi.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;

            DataRowView drv_azi_rep = dbDataGridView_AZI_REP.CurrentCell.OwningRow.DataBoundItem as DataRowView;

            DataSet.dsMaintenance.Man_Ana_AZI_REPRow r = drv_azi_rep.Row as DataSet.dsMaintenance.Man_Ana_AZI_REPRow;
            r.AZIKey = r_azi.AZIKey;
        }

        private void button_save_tipologie_ore_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_ore, true);
            manAnaTipOraBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_Tip_OraRow r in dsMaintenance.Man_Ana_Tip_Ora.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        if (r.IsStatoRecKeyNull())
                        {
                            r.StatoRecKey = 1;
                        }
                        DataRowView drv = dbDataGridView_tipo_ore.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                    }
                    man_Ana_Tip_OraTableAdapter.Update(r);
                }

                scp.Complete();
            }
            Init_Tip_Ore();
        }

        private void button_undo_tipologie_ore_Click(object sender, EventArgs e)
        {
            Init_Tip_Ore();
        }

        private void button_save_ass_tipologie_ore_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_tipo_ore_ass, true);
            manTipOreAZIBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Tip_Ore_AZIRow r in dsMaintenance.Man_Tip_Ore_AZI.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        if (r.IsStatoRecKeyNull())
                        {
                            r.StatoRecKey = 1;
                        }
                        DataRowView drv = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;

                        DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;
                        r.AZIKey = r_azi.AZIKey;
                    }
                    man_Ana_AZI_REPTableAdapter.Update(r);
                }

                scp.Complete();
            }
            Init_Tip_Ore_AZI();
        }

        private void button_undo_ass_tipologie_ore_Click(object sender, EventArgs e)
        {
            Init_Tip_Ore_AZI();
        }       

        private void button_associa_Click(object sender, EventArgs e)
        {
            try
            {
                //Utility.formatDataGrid(dbDataGridView_tipo_ore_ass, true);
                manTipOreAZIBindingSource.EndEdit();

                DataRowView drv_tip = dbDataGridView_tipo_ore.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                DataSet.dsMaintenance.Man_Ana_Tip_OraRow r_tip = drv_tip.Row as DataSet.dsMaintenance.Man_Ana_Tip_OraRow;

                DataRowView drv = dbDataGridView_AZI.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                DataSet.dsMaintenance.Man_Ana_AZIRow r_azi = drv.Row as DataSet.dsMaintenance.Man_Ana_AZIRow;

                man_Tip_Ore_AZITableAdapter.InsertRelationship(r_tip.TipOreKey, r_azi.AZIKey);

                Init_Tip_Ore_AZI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dbDataGridView_tipo_ore_ass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {               
                DataRowView drv = dbDataGridView_tipo_ore_ass.CurrentCell.OwningRow.DataBoundItem as DataRowView;
                DataSet.dsMaintenance.Man_Tip_Ore_AZIRow r_tip = drv.Row as DataSet.dsMaintenance.Man_Tip_Ore_AZIRow;
                
                man_Tip_Ore_AZITableAdapter.DeleteRelationship(r_tip.TipoOreKey, r_tip.AZIKey);

                Init_Tip_Ore_AZI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}