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
    public partial class CtrlTranslations : UserControl
    {
        public CtrlTranslations()
        {
            InitializeComponent();

            man_Ana_LANTableAdapter.Fill(dsMaintenance.Man_Ana_LAN);
            manAnaLANBindingSource.Filter = "LANKey <> 1";
            FillDatagridTranslations();
        }

        private void comboBox_lingue_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagridTranslations();
        }

        private void FillDatagridTranslations()
        {
            if (comboBox_lingue.SelectedValue != null)
            {
                translationsTableAdapter.Fill(dsMaintenance.Translations, (int)comboBox_lingue.SelectedValue);
                Utility.formatDataGrid(dbDataGridView_translations, true);
            }
        }

        private void button_undo_AZI_REP_Click(object sender, EventArgs e)
        {
            FillDatagridTranslations();
        }

        private void button_save_AZI_REP_Click(object sender, EventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_translations, true);
            translationsBindingSource.EndEdit();

            using (TransactionScope scp = new TransactionScope())
            {
                foreach (DataSet.dsMaintenance.TranslationsRow r in dsMaintenance.Translations.GetChanges().Rows)
                {
                    translationsTableAdapter.Upsert(
                        (int)comboBox_lingue.SelectedValue,
                        r.TranslationUID,
                        r.translation);
                }

                scp.Complete();
            }
            FillDatagridTranslations();
        }

        private void dbDataGridView_translations_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Utility.formatDataGrid(dbDataGridView_translations, true, true);
        }
    }
}
