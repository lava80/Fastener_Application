using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fastener.DataSet.dsUTETableAdapters;


namespace Fastener
{
    public partial class frmPass : PopUpForm
    //public partial class frmPass : InterfaceForm
    {
        public frmPass()
        {
            InitializeComponent();            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (Man_Ana_UTETableAdapter adapter = new Man_Ana_UTETableAdapter())
            {
                using (DataSet.dsUTE.Man_Ana_UTEDataTable user = adapter.GetDataByLogin(Program.CurrentUser.Login))
                {
                    if (user.Rows.Count <= 0)
                        throw new UtenteNotFoundException(Program.CurrentUser.Nome);
                    else
                    {
                        DataSet.dsUTE.Man_Ana_UTERow row = (DataSet.dsUTE.Man_Ana_UTERow)user.Rows[0];

                        if (MD5.getMd5Hash(txtOldPassword.Text) != Utility.CheckNULL(row.UTEPassword, "").ToString().Trim())
                        {
                            MessageBox.Show(Properties.MessageLocalization.fmrLogin_PasswordNonValida, Properties.MessageLocalization.frmLogin_Errore, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPassword.Text = txtRepeatNewPassword.Text = txtOldPassword.Text = string.Empty;
                            txtOldPassword.Focus();
                            return;
                        }

                        if ((txtNewPassword.Text.Equals(txtRepeatNewPassword.Text)) && (txtNewPassword.Text.Length < 4))
                        {
                            MessageBox.Show(Properties.MessageLocalization.frmPass_PasswordCorta, Properties.MessageLocalization.frmLogin_Errore, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPassword.Text = txtRepeatNewPassword.Text = string.Empty;
                            txtNewPassword.Focus();
                            return;
                        }

                        if ((txtNewPassword.Text != txtRepeatNewPassword.Text) ||
                            ((txtNewPassword.Text.Equals(txtRepeatNewPassword.Text)) && (MD5.getMd5Hash(txtOldPassword.Text) == MD5.getMd5Hash(txtNewPassword.Text))))
                        {
                            MessageBox.Show(Properties.MessageLocalization.frmPass_PasswordNonCorrispondente, Properties.MessageLocalization.frmLogin_Errore, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPassword.Text = txtRepeatNewPassword.Text = string.Empty;
                            txtNewPassword.Focus();
                            return;
                        }

                        string newPassword = MD5.getMd5Hash(txtNewPassword.Text);
                        row.UTEPassword = Utility.CheckNULL(newPassword, string.Empty).ToString().Trim();
                        try
                        {
                            adapter.UpdatePassword(row.UTEPassword, row.UTEKey);
                            MessageBox.Show(Properties.MessageLocalization.frmPass_PasswordOK, "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.state_ = Program.PROGRAM_STATE.MAIN_APPLICATION;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("[Password: " + error.Message);
                        }

                        this.Close();

                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.state_ = Program.PROGRAM_STATE.MAIN_APPLICATION;
            this.Close();
        }
    }
}