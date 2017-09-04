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
    public partial class DaySelector : PopUpForm
    {
        public int ret_value = 0;
        public DaySelector()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ret_value = Convert.ToInt32(this.comboBox_Giorno.SelectedValue);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
        }

        private void DaySelector_Load(object sender, EventArgs e)
        {
            List<int> days = new List<int>();
            for (int i = 1; i <= 31; i++)
            {
                days.Add(i);
            }

            this.comboBox_Giorno.DataSource = days;
            this.comboBox_Giorno.SelectedIndex = 0;
        }
    }
}
