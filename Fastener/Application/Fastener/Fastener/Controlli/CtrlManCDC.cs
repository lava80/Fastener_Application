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
    public partial class CtrlManCDC : UserControl
    {
        public CtrlManCDC()
        {
            InitializeComponent();

            man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
            InitCDC();
        }

        private void InitCDC()
        {
            Utility.formatDataGrid(dbDataGridView_CDC, true);
            //man_Ana_CDCTableAdapter.Fill(dsMaintenance.Man_Ana_CDC);
        }

        private void button_refresh_CDC_Click(object sender, EventArgs e)
        {
            InitCDC();
        }

        private void dbDataGridView_CDC_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_CDC, true, true);
        }

        private void button_save_CDC_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_CDC, true);
            manAnaCDCBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.Man_Ana_CDCRow r in dsMaintenance.Man_Ana_CDC.GetChanges().Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        if (r.IsStatoRecKeyNull())
                        {
                            r.StatoRecKey = 1;
                        }
                        if (string.IsNullOrEmpty(r.CDCName))
                        {
                            MessageBox.Show("Un centro di costo non può ssere nullo");
                            r.RejectChanges();
                        }
                    }
                    
                    man_Ana_CDCTableAdapter.Update(r);
                }

                scp.Complete();
            }
            InitCDC();
        }
    }
}
