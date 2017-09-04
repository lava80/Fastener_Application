using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Threading;

namespace Fastener
{
    public partial class frmLogin : PopUpForm 
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MakeBorderless(pnlMain_);

            lblMill_.Text += " "; //+ Utility.GetParam("Company");
            lblVersion_.Text += " " + Utility.GetAppVersion();

#if DEBUG
            comboBox_lingua.Enabled = true;
#else
            comboBox_lingua.Enabled = false;
#endif
        }

        private bool autoLogin = false;

        /// <summary>
        /// Enable/disable autologin feature
        /// </summary>
        public bool AutoLogin { get { return this.autoLogin; } set { this.autoLogin = value; } }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dsUTE.Man_Ana_LAN'. È possibile spostarla o rimuoverla se necessario.
            this.man_Ana_LANTableAdapter.Fill(this.dsUTE.Man_Ana_LAN);
            try
            {
                this.man_Ana_UTETableAdapter.Fill(this.dsUTE.Man_Ana_UTE);
                
                string currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                currentUser = currentUser.Substring(currentUser.IndexOf(@"\") + 1);
                var query =
                    from userRow in dsUTE.Man_Ana_UTE.AsEnumerable()
                    where userRow.UTEDomainName != null && userRow.UTEDomainName == currentUser
                    select new
                    {
                        //UserName = userRow.Field<string>("Utente"),
                        UserName = userRow.UTEName,
                        Password = userRow.UTEPassword.Trim()
                    };

                foreach (var userRecord in query)
                {
                    cmbUtente.Text = userRecord.UserName;
                    txtPassword.Select();
                    if (true == autoLogin && Properties.Settings.Default.DEFAULT_PASSWORD != userRecord.Password)
                    {
                        txtPassword.Text = userRecord.Password;
                        try
                        {
                            LoadUserSettings(userRecord.Password);
                            this.Close();
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show(resManager.GetString("frmLogin_UtenteNonTrovato"), resManager.GetString("Errore"));
                            txtPassword.Text = string.Empty;
                            return;
                        }
                    }
                    break;
                }                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show(Properties.MessageLocalization.frmLogin_Connessione, Properties.MessageLocalization.frmLogin_Errore);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.state_ = Program.PROGRAM_STATE.QUIT;
            this.Close();
        }

        private void LoadUserSettings(string pwd)
        {
            try
            {
                Program.CurrentUser = Utente.CaricaUtente(cmbUtente.SelectedValue.ToString(), pwd);
            }
            catch (UtenteNotFoundException)
            {
                MessageBox.Show(Properties.MessageLocalization.frmLogin_UtenteNonTrovato, Properties.MessageLocalization.frmLogin_Errore);
                throw;
            }
            catch (UtenteInvalidPasswordException)
            {
                MessageBox.Show(Properties.MessageLocalization.fmrLogin_PasswordNonValida, Properties.MessageLocalization.frmLogin_Errore);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.MessageLocalization.frmLogin_ErroreCaricamenteUtente + ": " + ex.Message, Properties.MessageLocalization.frmLogin_Errore);
                throw;
            }
        }

        /// <summary>
        /// Valida e carica l'utente
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            cmbUtente.SelectedValue = cmbUtente.Text;
            if (null == cmbUtente.SelectedValue)
                MessageBox.Show(Properties.MessageLocalization.frmLogin_UtenteNonTrovato, Properties.MessageLocalization.frmLogin_Errore);
            else
            {
                try
                {
                    LoadUserSettings(MD5.getMd5Hash(txtPassword.Text.Trim()));                    
                    this.Close();
                }
                catch (Exception)
                {
                    //MessageBox.Show(resManager.GetString("frmLogin_UtenteNonTrovato"), resManager.GetString("Errore"));
                    return;
                }
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;
        }

        private void comboBox_lingua_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_lingua.SelectedValue != null)
            {
                //CultureManager cultureManager = new CultureManager(this.components);
                //cultureManager.ManagedControl = this;
                //cultureManager.ExcludeProperties = new List<string>();
                //cultureManager.ExcludeProperties.Add("Visible");

                System.Globalization.CultureInfo c = 
                CultureManager.ApplicationUICulture = new System.Globalization.CultureInfo(comboBox_lingua.Text);
                Program.language_ = comboBox_lingua.Text;
                
                //Thread.CurrentThread.CurrentCulture = new CultureInfo(Program.language_);
            }
        }
    }
}