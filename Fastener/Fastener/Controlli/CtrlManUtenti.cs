using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.Controlli
{
    public partial class CtrlManUtenti : UserControl
    {
        public CtrlManUtenti()
        {
            InitializeComponent();

            FillComboboxUtenti();
            man_Ana_Tipo_RepartoTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Reparto);
            man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
            man_Ana_LANTableAdapter.Fill(dsMaintenance.Man_Ana_LAN);
            man_Ana_AZITableAdapter.Fill(dsMaintenance.Man_Ana_AZI);
            man_Ana_Tipo_UtenteTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Utente);
            cA_Ana_CDRTableAdapter.Fill(dsMaintenance.CA_Ana_CDR);
            cA_Ana_TipologiaUtenteTableAdapter.Fill(dsMaintenance.CA_Ana_TipologiaUtente);

            richiedentiTableAdapter.Fill(dsPurchaseOrder.Richiedenti);
            cdRTableAdapter.Fill(dsPurchaseOrder.CdR);

            FillDatiUtente();

            Utility.formatDataGrid(dbDataGridView_rep_disp, true);
            Utility.formatDataGrid(dbDataGridView_rep_ass, true);
            Utility.formatDataGrid(dbDataGridView_p_cdr, true);
            Utility.formatDataGrid(dbDataGridView_p_rich, true);
            Utility.formatDataGrid(dbDataGridView_p_ass, true, false, true);

            comboBox_tipo_utente.Enabled = Program.CurrentUser.GetPermission("MAN_CHNG_CAT_UTE");            
        }

        private void FillComboboxUtenti()
        {
            man_Ana_UTETableAdapter.Fill(dsMaintenance.Man_Ana_UTE);
            FillDatiUtente();
        }

        string utente_selezionato = "";
        private void FillDatiUtente()
        {
            if (comboBox_utente.SelectedValue != null)
            {
                DataSet.dsMaintenance.Man_Ana_UTEDataTable d_ute = new DataSet.dsMaintenance.Man_Ana_UTEDataTable();
                man_Ana_UTETableAdapter.FillBy(d_ute, (int)comboBox_utente.SelectedValue);
                textBox_login.Text = d_ute[0].UTELogin;
                textBox_nome.Text = d_ute[0].UTEName;
                textBox_nome_dominio.Text = d_ute[0].UTEDomainName;
                comboBox_tipo_utente.SelectedValue = d_ute[0].TipoUteKey;
                comboBox_stato_record.SelectedValue = d_ute[0].StatoRecKey;
                comboBox_azienda.SelectedValue = d_ute[0].AZIKey;
                comboBox_lingua.SelectedValue = d_ute[0].LANKey;
                if (!d_ute[0].IsTipoUteCA_KeyNull())
                {
                    comboBox_tipo_utente_CA.SelectedValue = d_ute[0].TipoUteCA_Key;
                }
                else
                {
                    comboBox_tipo_utente_CA.SelectedValue = 5;
                }
                if (!d_ute[0].IsCDRKeyNull())
                {
                    comboBox_Centro_Di_Responsabilità.SelectedValue = d_ute[0].CDRKey;
                }
                else
                {
                    comboBox_Centro_Di_Responsabilità.SelectedValue = "UNK";
                }
                utente_selezionato = d_ute[0].UTELogin;
                RefreshUtentiReparti();
                RefreshOrdiniAcqVisiblity();
            }
        }

        private void RefreshOrdiniAcqVisiblity()
        {
            ordiniAcq_VisibilityTableAdapter.Fill(dsPurchaseOrder.OrdiniAcq_Visibility, utente_selezionato);
        }

        private void RefreshUtentiReparti()
        {
            if (comboBox_utente.SelectedValue != null)
            {
                utenti_RepartiTableAdapter.Fill(dsMaintenance.Utenti_Reparti, (int)comboBox_utente.SelectedValue);
            }
        }

        bool new_user = false;
        private void button_new_user_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "** NEW LOGIN **";
            textBox_nome.Text = "** NEW NAME **";
            textBox_nome_dominio.Text = "** NEW NAME **";
            comboBox_lingua.SelectedValue = 1;
            comboBox_azienda.SelectedValue = 1;
            comboBox_stato_record.SelectedValue = 1;
            comboBox_tipo_utente.SelectedValue = 4;
            comboBox_tipo_utente_CA.SelectedValue = 5;
            comboBox_Centro_Di_Responsabilità.SelectedValue = "UNK";

            textBox_nome_dominio.BackColor = Color.LightGoldenrodYellow;
            textBox_nome_dominio.ForeColor = Color.Firebrick;
            textBox_login.BackColor = Color.LightGoldenrodYellow;
            textBox_login.ForeColor = Color.Firebrick;
            textBox_nome.ForeColor = Color.Firebrick;
            textBox_nome.BackColor = Color.LightGoldenrodYellow;

            dbDataGridView_rep_ass.Visible = false;
            dbDataGridView_rep_disp.Visible = false;

            button_reset_password.Enabled = false;

            new_user = true;
            textBox_login.ReadOnly = false;

            textBox_login.Focus();
            textBox_login.Select();

            comboBox_tipo_utente.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (new_user)
                {
                    man_Ana_UTETableAdapter.Insert(
                        textBox_login.Text,
                        textBox_nome.Text,
                        Properties.Settings.Default.DEFAULT_PASSWORD,
                        textBox_nome_dominio.Text,
                        (int)comboBox_lingua.SelectedValue,
                        (int)comboBox_tipo_utente.SelectedValue,
                        (int)comboBox_azienda.SelectedValue,
                        (int)comboBox_stato_record.SelectedValue,
                        (int)comboBox_tipo_utente_CA.SelectedValue,
                        comboBox_Centro_Di_Responsabilità.SelectedValue.ToString());

                    FillComboboxUtenti();
                }
                else
                {
                    man_Ana_UTETableAdapter.UpdateUtente(
                        textBox_nome.Text,
                        textBox_nome_dominio.Text,
                        (int)comboBox_lingua.SelectedValue,
                        (int)comboBox_tipo_utente.SelectedValue,
                        (int)comboBox_azienda.SelectedValue,
                        (int)comboBox_stato_record.SelectedValue,
                        (int)comboBox_tipo_utente_CA.SelectedValue,
                        comboBox_Centro_Di_Responsabilità.SelectedValue.ToString(),
                        (int)comboBox_utente.SelectedValue);
                }

                textBox_nome_dominio.BackColor = Color.White;
                textBox_nome_dominio.ForeColor = Color.Black;
                textBox_login.BackColor = Color.White;
                textBox_nome.BackColor = Color.White;
                textBox_nome.ForeColor = Color.Black;
                textBox_login.ForeColor = Color.Black;

                dbDataGridView_rep_ass.Visible = true;
                dbDataGridView_rep_disp.Visible = true;

                button_reset_password.Enabled = true;

                new_user = false;
                textBox_login.ReadOnly = true;

                comboBox_tipo_utente.Enabled = Program.CurrentUser.GetPermission("MAN_CHNG_CAT_UTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox_utente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatiUtente();
        }

        private void button_reset_password_Click(object sender, EventArgs e)
        {
            if (comboBox_utente.SelectedValue != null)
            {
                man_Ana_UTETableAdapter.UpdatePassword(Properties.Settings.Default.DEFAULT_PASSWORD, (int)comboBox_utente.SelectedValue);
            }
        }

        private void dbDataGridView_rep_disp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (comboBox_utente.SelectedValue != null)
            {
                if (dbDataGridView_rep_disp.SelectedRows.Count > 0)
                {
                    DataRowView drv = dbDataGridView_rep_disp.SelectedRows[0].DataBoundItem as DataRowView;
                    if (drv != null)
                    {
                        DataSet.dsMaintenance.Man_Ana_Tipo_RepartoRow row = drv.Row as DataSet.dsMaintenance.Man_Ana_Tipo_RepartoRow;
                        utenti_RepartiTableAdapter.AddRelationship((int)comboBox_utente.SelectedValue, row.TipoRepKey, 1);
                        RefreshUtentiReparti();
                    }
                }
            }
        }

        private void dbDataGridView_rep_ass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dbDataGridView_rep_ass.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_rep_ass.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsMaintenance.Utenti_RepartiRow row = drv.Row as DataSet.dsMaintenance.Utenti_RepartiRow;
                    utenti_RepartiTableAdapter.RemoveRelationship((int)comboBox_utente.SelectedValue, row.TipoRepKey);
                    RefreshUtentiReparti();
                }
            }
        }

        private void comboBox_tipo_utente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_tipo_utente.SelectedValue != null)
            {
                if (
                    (int)comboBox_tipo_utente.SelectedValue == 1 &&
                    !Program.CurrentUser.GetPermission("CAN_CREATE_SUPERUSER")
                    )
                {
                    MessageBox.Show(Properties.MessageLocalization.ana_cannot_create_superuser);
                    comboBox_tipo_utente.SelectedValue = 2;
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbDataGridView_p_cdr.SelectedRows.Count == 1 && dbDataGridView_p_rich.SelectedRows.Count == 1)
                {
                    DataSet.dsPurchaseOrder.RichiedentiRow r_rich = (dbDataGridView_p_rich.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsPurchaseOrder.RichiedentiRow;
                    DataSet.dsPurchaseOrder.CdRRow r_cdr = (dbDataGridView_p_cdr.SelectedRows[0].DataBoundItem as DataRowView).Row as DataSet.dsPurchaseOrder.CdRRow;

                    DataSet.dsPurchaseOrderTableAdapters.OrdiniAcq_VisibilityTableAdapter adp = new DataSet.dsPurchaseOrderTableAdapters.OrdiniAcq_VisibilityTableAdapter();

                    adp.DeleteQuery(utente_selezionato, r_cdr.respons, r_rich.richiedente);
                    adp.InsertQuery(utente_selezionato, r_cdr.respons, r_rich.richiedente, checkBox_p_valori.Checked);

                    RefreshOrdiniAcqVisiblity();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dbDataGridView_p_ass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dbDataGridView_p_ass.SelectedRows.Count > 0)
            {
                DataRowView drv = dbDataGridView_p_ass.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    DataSet.dsPurchaseOrder.OrdiniAcq_VisibilityRow row = drv.Row as DataSet.dsPurchaseOrder.OrdiniAcq_VisibilityRow;
                    new DataSet.dsPurchaseOrderTableAdapters.OrdiniAcq_VisibilityTableAdapter().DeleteQuery(row.Utente, row.CdrAbilitato, row.UtenteAbilitato);
                    RefreshOrdiniAcqVisiblity();
                }
            }
        }
    }
}
