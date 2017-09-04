using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.Dialog
{
    public partial class Assegna_RichiesteLavorazioni : PopUpForm
    {
        public int ret_value = -1;
        public string ret_value_descriz = string.Empty;
        private string cdr_key;
        public Assegna_RichiesteLavorazioni(string CDRkey)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            cdr_key = CDRkey;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Esecutore.SelectedValue != null)
            {
                ret_value = Convert.ToInt32(this.comboBox_Esecutore.SelectedValue);
                ret_value_descriz = this.comboBox_Esecutore.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Nessun esecutore selezionato!");
            }
        }

        private void Assegna_RichiesteLavorazioni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRichiesteLavorazioni.Man_Ana_UTE' table. You can move, or remove it, as needed.
            this.man_Ana_UTETableAdapter.FillByCDR(this.dsRichiesteLavorazioni.Man_Ana_UTE, cdr_key);
            if (this.dsRichiesteLavorazioni.Man_Ana_UTE.Rows.Count > 0)
            {
                this.comboBox_Esecutore.SelectedIndex = 0;
            }
        }
    }
}
