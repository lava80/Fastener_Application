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
    public partial class CtrlManPermessi : UserControl
    {
        public CtrlManPermessi()
        {
            InitializeComponent();

            RefreskMask();

            Utility.formatDataGrid(dbDataGridView_permessi, true);
            Utility.formatDataGrid(dbDataGridView_cat_ute_per, true);
            Utility.formatDataGrid(dbDataGridView_cat_ute, true);
        }

        private void RefreskMask()
        {
            man_Ana_Tipo_UtenteTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Utente);
            man_Ana_PermessiTableAdapter.Fill(dsMaintenance.Man_Ana_Permessi);

            RefreshTipoUtentiPermessi();
        }

        private void dbDataGridView_cat_ute_per_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dbDataGridView_cat_ute_per.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_cat_ute_per.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.TipoUtente_PermessiRow row = drv.Row as DataSet.dsMaintenance.TipoUtente_PermessiRow;
                    tipoUtente_PermessiTableAdapter.DeleteQuery(row.TipoUtenteKey, row.PermessiKey);

                    RefreshTipoUtentiPermessi();
                }
            }
        }

        private void RefreshTipoUtentiPermessi()
        {
            if (dbDataGridView_cat_ute.SelectedRows.Count>0)
            {
                DataRowView drv = dbDataGridView_cat_ute.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Man_Ana_Tipo_UtenteRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_Tipo_UtenteRow;
                    tipoUtente_PermessiTableAdapter.Fill(dsMaintenance.TipoUtente_Permessi, row.TipoUteKey);
                }
            }
        }

        private void dbDataGridView_cat_ute_SelectionChanged(object sender, EventArgs e)
        {
            RefreshTipoUtentiPermessi();
        }

        private void button_new_per_Click(object sender, EventArgs e)
        {
            textBox_per_descr.ReadOnly = false;
            textBox_per_name.ReadOnly = false;
            textBox_famiglia.ReadOnly = false;
            textBox_per_name.Text = "** NUOVO PERMESSO **";
            textBox_per_descr.Text = "** DESCRIZIONE **";
            textBox_famiglia.Text = "** FAMIGLIA PERMESSO **";
            textBox_per_name.Focus();
            textBox_per_name.Select();

            button_save_per.Enabled = true;
        }

        private void button_save_per_Click(object sender, EventArgs e)
        {
            try
            {
                man_Ana_PermessiTableAdapter.Insert(textBox_per_name.Text, textBox_per_descr.Text, textBox_famiglia.Text);
                man_Ana_PermessiTableAdapter.Fill(dsMaintenance.Man_Ana_Permessi);
                textBox_per_descr.ReadOnly = true;
                textBox_famiglia.ReadOnly = true;
                textBox_per_name.ReadOnly = true;
                button_save_per.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dbDataGridView_permessi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dbDataGridView_cat_ute.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_cat_ute.SelectedRows[0].DataBoundItem as DataRowView;
                    if (drv != null)
                    {
                        DataSet.dsMaintenance.Man_Ana_Tipo_UtenteRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_Tipo_UtenteRow;

                        if (dbDataGridView_permessi.SelectedRows.Count > 0)
                        {
                            DataRowView drv_per = dbDataGridView_permessi.SelectedRows[0].DataBoundItem as DataRowView;

                            if (drv_per != null)
                            {
                                DataSet.dsMaintenance.Man_Ana_PermessiRow row_per = drv_per.Row as DataSet.dsMaintenance.Man_Ana_PermessiRow;

                                tipoUtente_PermessiTableAdapter.InsertQuery(row.TipoUteKey, row_per.PermessiKey);
                                RefreshTipoUtentiPermessi();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dbDataGridView_cat_ute_per_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbDataGridView_permessi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.PerformCorrectRightClick(dbDataGridView_permessi, contextMenuStrip_permessi, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dbDataGridView_permessi.SelectedRows)
                {
                    DataSet.dsMaintenance.Man_Ana_PermessiRow r = (row.DataBoundItem as DataRowView).Row as DataSet.dsMaintenance.Man_Ana_PermessiRow;

                    using (TransactionScope scp = new TransactionScope())
                    {
                        new DataSet.dsMaintenanceTableAdapters.TipoUtente_PermessiTableAdapter().DeletePermessi(r.PermessiKey);
                        man_Ana_PermessiTableAdapter.DeleteQuery(r.PermessiKey);
                        scp.Complete();
                    }
                }
                RefreskMask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
