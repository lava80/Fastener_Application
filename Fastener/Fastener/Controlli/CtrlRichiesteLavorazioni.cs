using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fastener.DataSet;
using System.Data.SqlClient;
using Fastener.Dialog;

namespace Fastener.Controlli
{
    public partial class CtrlRichiesteLavorazioni : UserControl
    {
        //Here is the once-per-class call to initialize the log object
        protected static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private dsRichiesteLavorazioni.CA_RichiestaLavorazioniRow current_RichiestaLavorazione;
        private dsRichiesteLavorazioni.CA_InfoRichiedenteRow current_Richiedente;
        private dsRichiesteLavorazioni.CA_InfoPianificatoreRow current_Pianificatore;
        private dsRichiesteLavorazioni.CA_InfoEsecutoreRow current_Esecutore;

        private const int richiedente_Generico = 149;

        BindingSource Filtered_ContoAnal_Rich_BS;
        BindingSource Filtered_Scheda_Rich_BS;
        BindingSource Filtered_ContoAnal_Pian_BS;
        BindingSource Filtered_Scheda_Pian_BS;
        BindingSource Filtered_ContoAnal_Esec_BS;
        BindingSource Filtered_Scheda_Esec_BS;

        DataSet.dsRichiesteLavorazioniTableAdapters.CA_Ana_AbilitazioniUtentiTableAdapter cA_Ana_AbilitazioniUtentiTableAdapter;
        DataSet.dsRichiesteLavorazioniTableAdapters.CA_Ana_AbilitazioneAzioniTableAdapter cA_Ana_AbilitazioneAzioniTableAdapter;

        public CtrlRichiesteLavorazioni()
        {
            InitializeComponent();
        }

        private void CtrlRichiesteLavorazioni_Load(object sender, EventArgs e)
        {
            this.comboBox_Filtro_Esecutore.Enabled = false;
            this.comboBox_Filtro_Pianificatore.Enabled = false;
            this.comboBox_Filtro_Richiedente.Enabled = false;
            this.checkBox_Filter_AllRichieste.Checked = false;
            this.comboBox_Filtro_Stato.Enabled = false;

            cA_Ana_AbilitazioniUtentiTableAdapter = new DataSet.dsRichiesteLavorazioniTableAdapters.CA_Ana_AbilitazioniUtentiTableAdapter();
            cA_Ana_AbilitazioneAzioniTableAdapter = new DataSet.dsRichiesteLavorazioniTableAdapters.CA_Ana_AbilitazioneAzioniTableAdapter();

            cA_Ana_StatoRichiestaTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_StatoRichiesta);
            man_Ana_UTETableAdapter.Fill(dsRichiesteLavorazioni.Man_Ana_UTE);
            cA_Ana_PriorityTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_Priority);
            cA_Ana_TipoRischioTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_TipoRischio);
            cA_Ana_CDRTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_CDR);
            cA_Ana_TipoRichiestaTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_TipoRichiesta);
            cA_Ana_RichiestaMaterialiTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_RichiestaMateriali);
            cA_Ana_CompetenzaRDATableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_CompetenzaRDA);
            man_Ana_IMPTableAdapter.Fill(dsRichiesteLavorazioni.Man_Ana_IMP);
            man_Ana_SCHEDATableAdapter.Fill(dsRichiesteLavorazioni.Man_Ana_SCHEDA);
            man_Ana_CDCTableAdapter.Fill(dsRichiesteLavorazioni.Man_Ana_CDC);
            //man_Ana_MACTableAdapter.Fill(dsRichiesteLavorazioni.Man_Ana_MAC);

            Filtered_ContoAnal_Rich_BS = new BindingSource();
            DataView dv_ContoAnal_Rich = new DataView(dsRichiesteLavorazioni.Man_Ana_CDC);
            Filtered_ContoAnal_Rich_BS.DataSource = dv_ContoAnal_Rich;

            Filtered_Scheda_Rich_BS = new BindingSource();
            DataView dv_Scheda_Rich = new DataView(dsRichiesteLavorazioni.Man_Ana_SCHEDA);
            Filtered_Scheda_Rich_BS.DataSource = dv_Scheda_Rich;

            Filtered_ContoAnal_Pian_BS = new BindingSource();
            DataView dv_ContoAnal_Pian = new DataView(dsRichiesteLavorazioni.Man_Ana_CDC);
            Filtered_ContoAnal_Pian_BS.DataSource = dv_ContoAnal_Pian;

            Filtered_Scheda_Pian_BS = new BindingSource();
            DataView dv_Scheda_Pian = new DataView(dsRichiesteLavorazioni.Man_Ana_SCHEDA);
            Filtered_Scheda_Pian_BS.DataSource = dv_Scheda_Pian;

            Filtered_ContoAnal_Esec_BS = new BindingSource();
            DataView dv_ContoAnal_Esec = new DataView(dsRichiesteLavorazioni.Man_Ana_CDC);
            Filtered_ContoAnal_Esec_BS.DataSource = dv_ContoAnal_Esec;

            Filtered_Scheda_Esec_BS = new BindingSource();
            DataView dv_Scheda_Esec = new DataView(dsRichiesteLavorazioni.Man_Ana_SCHEDA);
            Filtered_Scheda_Esec_BS.DataSource = dv_Scheda_Esec;

            Initialize_DateTimePicker();
            this.nullableDateTimePicker_Esec_DataFineEffettiva.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1);

            populate_DataGridView_Data();
            populate_ComboBox_Filters();
            enableControls();
        }

        /// <summary>
        /// Use to set current month when calendar appears
        /// </summary>
        private void Initialize_DateTimePicker()
        {
            this.dateTimePicker_Esec_DataFine.Value = DateTime.Now;
            this.dateTimePicker_Esec_DataFine.Value = null;
            this.dateTimePicker_Esec_DataInizio.Value = DateTime.Now;
            this.dateTimePicker_Esec_DataInizio.Value = null;
            this.dateTimePicker_Pian_DataFine.Value = DateTime.Now;
            this.dateTimePicker_Pian_DataFine.Value = null;
            this.dateTimePicker_Pian_DataInizio.Value = DateTime.Now;
            this.dateTimePicker_Pian_DataInizio.Value = null;
            this.dateTimePicker_Rich_DataFine.Value = DateTime.Now;
            this.dateTimePicker_Rich_DataFine.Value = null;
            this.dateTimePicker_Rich_DataInizio.Value = DateTime.Now;
            this.dateTimePicker_Rich_DataInizio.Value = null;
            this.nullableDateTimePicker_Esec_DataFineEffettiva.Value = DateTime.Now;
            this.nullableDateTimePicker_Esec_DataFineEffettiva.Value = null;
            this.nullableDateTimePicker_Esec_DataInizioEffettiva.Value = DateTime.Now;
            this.nullableDateTimePicker_Esec_DataInizioEffettiva.Value = null;
        }

        /// <summary>
        /// Populate DataGridView1 with "Richieste di Lavorazione" data
        /// </summary>
        private void populate_DataGridView_Data()
        {
            string onlyOpened = string.Empty;
            string rich = string.Empty;
            string pian = string.Empty;
            string esec = string.Empty;

            if (this.checkBox_Filter_AllRichieste.Checked)
            {
                onlyOpened = "0";
            }
            else
            {
                onlyOpened = "1";
            }
            if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Unknown)
            {
                return;
            }
            if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Richiedente)
            {
                rich = Program.CurrentUser.Key.ToString();
            }
            if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Esecutore)
            {
                esec = Program.CurrentUser.Key.ToString();
            }

            cA_RichiestaLavorazioniTableAdapter.Fill(dsRichiesteLavorazioni.CA_RichiestaLavorazioni, onlyOpened, rich, pian, esec);
        }

        /// <summary>
        /// Used to see if user type is enabled for the "Richiesta" Status
        /// </summary>
        /// <param name="userType"></param>
        /// <param name="stato"></param>
        /// <returns></returns>
        private bool isUserEnabledbyStato(int userType, int stato)
        {
            bool? enabled = cA_Ana_AbilitazioniUtentiTableAdapter.isUserEnabledbyStato(userType, stato);
            if (enabled != null && (bool)enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Used to see if action is enabled for the "Richiesta" Status
        /// </summary>
        /// <param name="actionID"></param>
        /// <param name="stato"></param>
        /// <returns></returns>
        private bool isActionEnabledbyStato(int actionID, int stato)
        {
            bool? enabled = cA_Ana_AbilitazioneAzioniTableAdapter.isActionEnabledByStato(actionID, stato);
            if (enabled != null && (bool)enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Enable or Disable Graphic Controls
        /// </summary>
        private void enableControls()
        {
            bool enabledUser = (current_RichiestaLavorazione != null && isUserEnabledbyStato(Program.CurrentUser.UserType_CA, current_RichiestaLavorazione.Stato));

            this.tableLayoutPanelRichiedente.Enabled = false;
            this.flowLayoutPanel_Azioni_Rich.Enabled = false;
            this.tableLayoutPanelPianificatore.Enabled = false;
            this.flowLayoutPanel_Azioni_Pian.Enabled = false;
            this.tableLayoutPanelEsecutore.Enabled = false;
            this.flowLayoutPanel_Azioni_Esec.Enabled = false;
            this.button_NuovaRichiestaLavorazione.Enabled = false;
            this.textBox_Titolo.ReadOnly = true;
            this.textBox_Descrizione.ReadOnly = true;
            this.comboBox_Richiedente.ReadOnly = true;
            this.comboBox_Pianificatore.ReadOnly = true;
            this.comboBox_Esecutore.ReadOnly = true;

            if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Richiedente)
            {
                //this.button_NuovaRichiestaLavorazione.Enabled = true;
                //if (enabledUser)
                //{
                //    if (current_RichiestaLavorazione != null && (current_RichiestaLavorazione.Stato == (int)Utility.StatoRichiesta_CA.Nuova || current_RichiestaLavorazione.Stato == (int)Utility.StatoRichiesta_CA.Emessa))
                //    {
                //        this.textBox_Titolo.ReadOnly = false;
                //        this.textBox_Descrizione.ReadOnly = false;
                //        this.tableLayoutPanelRichiedente.Enabled = true;
                //    }
                //    this.flowLayoutPanel_Azioni_Rich.Enabled = true;
                //}
            }
            else if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore)
            {
                this.button_NuovaRichiestaLavorazione.Enabled = true;
                if (enabledUser)
                {
                    if (current_RichiestaLavorazione != null && (current_RichiestaLavorazione.Stato == (int)Utility.StatoRichiesta_CA.Nuova || current_RichiestaLavorazione.Stato == (int)Utility.StatoRichiesta_CA.Emessa))
                    {
                        this.textBox_Titolo.ReadOnly = false;
                        this.textBox_Descrizione.ReadOnly = false;
                        this.tableLayoutPanelRichiedente.Enabled = true;
                        this.flowLayoutPanel_Azioni_Rich.Enabled = true;
                    }                    
                    this.tableLayoutPanelPianificatore.Enabled = true;
                    this.flowLayoutPanel_Azioni_Pian.Enabled = true;
                }
            }
            else if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Esecutore)
            {
                if (enabledUser)
                {
                    if (current_Esecutore != null /*&& !current_Esecutore.isu.IsUtenteNull()*/ && current_Esecutore.Utente == Program.CurrentUser.Key)
                    {
                        this.tableLayoutPanelEsecutore.Enabled = true;
                        this.flowLayoutPanel_Azioni_Esec.Enabled = true;
                    }
                }
            }
            else if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Amministratore)
            {

            }
            else
            {
                this.splitContainer1.Enabled = false;
            }

            DisableButtons(this.tableLayoutPanelMain);
        }

        /// <summary>
        /// Enable or Disable GUI buttons of a specified Container
        /// </summary>
        /// <param name="con">the container</param>
        private void DisableButtons(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableButtons(c);
            }
            if (con is Button)
            {
                Button but = (Button)con;
                if (current_RichiestaLavorazione != null)
                {
                    con.Enabled = isActionEnabledbyStato(Convert.ToInt32(but.Tag), current_RichiestaLavorazione.Stato);
                }
                else
                {
                    con.Enabled = false;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Filtered_Scheda_Rich_BS.RemoveFilter();
            this.Filtered_ContoAnal_Rich_BS.RemoveFilter();
            this.Filtered_ContoAnal_Pian_BS.RemoveFilter();
            this.Filtered_Scheda_Pian_BS.RemoveFilter();
            this.Filtered_ContoAnal_Esec_BS.RemoveFilter();
            this.Filtered_Scheda_Esec_BS.RemoveFilter();

            Initialize_DateTimePicker();
            this.nullableDateTimePicker_Esec_DataFineEffettiva.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1);

            if (this.dataGridView1.CurrentRow != null)
            {
                current_RichiestaLavorazione = (dsRichiesteLavorazioni.CA_RichiestaLavorazioniRow)(((DataRowView)this.dataGridView1.CurrentRow.DataBoundItem).Row);
            }
            else
            {
                current_RichiestaLavorazione = null;
            }

            ReloadInfo();
            enableControls();
        }

        /// <summary>
        /// Reload the information of the current "Richiesta"
        /// </summary>
        private void ReloadInfo()
        {            
            if (current_RichiestaLavorazione != null)
            {
                getInfoRichiedente();
                if (current_Richiedente != null)
                {
                    current_Richiedente.BeginEdit();
                }
                getInfoPianificatore();
                if (current_Pianificatore != null)
                {
                    current_Pianificatore.BeginEdit();
                }
                getInfoEsecutore(false);
                if (current_Esecutore != null)
                {
                    current_Esecutore.BeginEdit();
                }
            }
            else
            {
                current_Richiedente = null;
                dsRichiesteLavorazioni.CA_InfoRichiedente.Clear();
                current_Pianificatore = null;
                dsRichiesteLavorazioni.CA_InfoPianificatore.Clear();
                current_Esecutore = null;
                dsRichiesteLavorazioni.CA_InfoEsecutore.Clear();
            }
        }

        private void populate_ComboBox_Filters(bool newInsertion = false)
        {
            string selected_richiedente = null;
            string selected_pianificatore = null;
            string selected_esecutore = null;
            string selected_stato = null;

            if (comboBox_Filtro_Richiedente.Enabled && comboBox_Filtro_Richiedente.Items.Count > 0)
            {
                selected_richiedente = this.comboBox_Filtro_Richiedente.Text;
            }
            if (comboBox_Filtro_Pianificatore.Enabled && comboBox_Filtro_Pianificatore.Items.Count > 0)
            {
                selected_pianificatore = this.comboBox_Filtro_Pianificatore.Text;
            }
            if (comboBox_Filtro_Esecutore.Enabled && comboBox_Filtro_Esecutore.Items.Count > 0)
            {
                selected_esecutore = this.comboBox_Filtro_Esecutore.Text;
            }
            if (comboBox_Filtro_Stato.Enabled && comboBox_Filtro_Stato.Items.Count > 0)
            {
                selected_stato = this.comboBox_Filtro_Stato.Text;
            }

            DataView view = new DataView(dsRichiesteLavorazioni.CA_RichiestaLavorazioni);
            view.Sort = "RichiedenteName";
            DataTable richiedenteName = view.ToTable(true, "RichiedenteName");

            this.comboBox_Filtro_Richiedente.DataSource = richiedenteName;
            this.comboBox_Filtro_Richiedente.ValueMember = "RichiedenteName";
            this.comboBox_Filtro_Richiedente.DisplayMember = "RichiedenteName";
            if (selected_richiedente != null)
            {
                if (newInsertion)
                {
                    this.checkBox_Filtro_Richiedente.Checked = false;
                }
                else
                {
                    this.comboBox_Filtro_Richiedente.SelectedValue = selected_richiedente;
                }
            }

            DataView viewPian = new DataView(dsRichiesteLavorazioni.CA_RichiestaLavorazioni);
            viewPian.Sort = "PianificatoreName";
            DataTable pianificatoreName = viewPian.ToTable(true, "PianificatoreName");

            this.comboBox_Filtro_Pianificatore.DataSource = pianificatoreName;
            this.comboBox_Filtro_Pianificatore.ValueMember = "PianificatoreName";
            this.comboBox_Filtro_Pianificatore.DisplayMember = "PianificatoreName";
            if (selected_pianificatore != null)
            {
                if (newInsertion)
                {
                    this.checkBox_Filtro_Pianificatore.Checked = false;
                }
                else
                {
                    this.comboBox_Filtro_Pianificatore.SelectedValue = selected_pianificatore;
                }
            }

            DataView viewEsec = new DataView(dsRichiesteLavorazioni.CA_RichiestaLavorazioni);
            viewEsec.Sort = "EsecutoreName";
            DataTable esecutoreName = viewEsec.ToTable(true, "EsecutoreName");

            this.comboBox_Filtro_Esecutore.DataSource = esecutoreName;
            this.comboBox_Filtro_Esecutore.ValueMember = "EsecutoreName";
            this.comboBox_Filtro_Esecutore.DisplayMember = "EsecutoreName";
            if (selected_esecutore != null)
            {
                if (newInsertion)
                {
                    this.checkBox_Filtro_Esecutore.Checked = false;
                }
                else
                {
                    this.comboBox_Filtro_Esecutore.SelectedValue = selected_esecutore;
                }
            }

            DataView viewStato = new DataView(dsRichiesteLavorazioni.CA_RichiestaLavorazioni);
            viewStato.Sort = "StatoDescriz";
            DataTable statoName = viewStato.ToTable(true, "StatoDescriz");

            this.comboBox_Filtro_Stato.DataSource = statoName;
            this.comboBox_Filtro_Stato.ValueMember = "StatoDescriz";
            this.comboBox_Filtro_Stato.DisplayMember = "StatoDescriz";
            if (selected_stato != null)
            {
                if (newInsertion)
                {
                    this.comboBox_Filtro_Stato.SelectedValue = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz((int)Fastener.Utility.StatoRichiesta_CA.Nuova);
                }
                else
                {
                    this.comboBox_Filtro_Stato.SelectedValue = selected_stato;
                }
            }
        }

        /// <summary>
        /// Get the information of current "Richiedente"
        /// </summary>
        private void getInfoRichiedente()
        {
            cA_InfoRichiedenteTableAdapter.Fill(dsRichiesteLavorazioni.CA_InfoRichiedente, current_RichiestaLavorazione.Numero);
            if (dsRichiesteLavorazioni.CA_InfoRichiedente.Rows.Count == 0)
            {
                //if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Richiedente)
                if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore)
                {
                    //dsRichiesteLavorazioni.CA_InfoRichiedenteRow newRichiedente = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)(((DataRowView)cAInfoRichiedenteBindingSource.AddNew()).Row);
                    dsRichiesteLavorazioni.CA_InfoRichiedenteRow newRichiedente = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)dsRichiesteLavorazioni.CA_InfoRichiedente.NewRow();
                    newRichiedente.NumRichiesta = current_RichiestaLavorazione.Numero;
                    newRichiedente.TipologiaUtente = (int)Fastener.Utility.LoginType_CA.Richiedente;
                    newRichiedente.Utente = richiedente_Generico; //Utente Generico
                    //newRichiedente.RepartoTecnico = (from utente in dsRichiesteLavorazioni.Man_Ana_UTE
                    //                                 where utente.UTEKey == Program.CurrentUser.Key
                    //                                 select utente.CDRKey).SingleOrDefault();
                    newRichiedente.RepartoTecnico = "UNK";

                    dsRichiesteLavorazioni.CA_InfoRichiedente.Rows.Add(newRichiedente);
                    current_Richiedente = newRichiedente;
                }
            }
            else
            {
                current_Richiedente = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)dsRichiesteLavorazioni.CA_InfoRichiedente.Rows[0];
            }
        }

        /// <summary>
        /// Get the information of current "Pianificatore"
        /// </summary>
        private void getInfoPianificatore()
        {
            cA_InfoPianificatoreTableAdapter.Fill(dsRichiesteLavorazioni.CA_InfoPianificatore, current_RichiestaLavorazione.Numero);

            if (dsRichiesteLavorazioni.CA_InfoPianificatore.Rows.Count == 0)
            {
                if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore && current_RichiestaLavorazione.Stato == (int)Utility.StatoRichiesta_CA.Emessa)
                {
                    //dsRichiesteLavorazioni.CA_InfoRichiedenteRow newRichiedente = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)(((DataRowView)cAInfoRichiedenteBindingSource.AddNew()).Row);
                    dsRichiesteLavorazioni.CA_InfoPianificatoreRow newPianificatore = (dsRichiesteLavorazioni.CA_InfoPianificatoreRow)dsRichiesteLavorazioni.CA_InfoPianificatore.NewRow();
                    newPianificatore.NumRichiesta = current_RichiestaLavorazione.Numero;
                    newPianificatore.TipologiaUtente = (int)Fastener.Utility.LoginType_CA.Pianificatore;
                    newPianificatore.Utente = Program.CurrentUser.Key;
                    if (current_Richiedente != null)
                    {
                        //newPianificatore.CentroDiCosto = current_Richiedente.CentroDiCosto;
                        //newPianificatore.SchedaMacchina = current_Richiedente.SchedaMacchina;
                        //newPianificatore.ContoAnalitico = current_Richiedente.ContoAnalitico;
                        //newPianificatore.DataFine = current_Richiedente.DataFine;
                        //newPianificatore.DataInizio = current_Richiedente.DataInizio;
                        //newPianificatore.MaterialiRichiesti = current_Richiedente.MaterialiRichiesti;
                        //newPianificatore.Priority = current_Richiedente.Priority; 
                        if (!current_Richiedente.IsNoteNull())
                        {
                            newPianificatore.Note = current_Richiedente.Note;
                        }                                               
                        if (!current_Richiedente.IsProgettoNull())
                        {
                            newPianificatore.Progetto = current_Richiedente.Progetto;
                        }
                        if (!current_Richiedente.IsRDANull())
                        {
                            newPianificatore.RDA = current_Richiedente.RDA;
                        }
                        if (!current_Richiedente.IsMittenteNull())
                        {
                            newPianificatore.Mittente = current_Richiedente.Mittente;
                        }
                        if (!current_Richiedente.IsEmailNull())
                        {
                            newPianificatore.Email = current_Richiedente.Email;
                        }
                        if (!current_Richiedente.IsRepartoTecnicoNull())
                        {
                            newPianificatore.RepartoTecnico = current_Richiedente.RepartoTecnico;
                        }
                        //newPianificatore.Rischio = current_Richiedente.Rischio;
                        //newPianificatore.TipologiaRichiesta = current_Richiedente.TipologiaRichiesta;                        
                    }

                    dsRichiesteLavorazioni.CA_InfoPianificatore.Rows.Add(newPianificatore);
                    current_Pianificatore = newPianificatore;
                }
            }
            else
            {
                current_Pianificatore = (dsRichiesteLavorazioni.CA_InfoPianificatoreRow)dsRichiesteLavorazioni.CA_InfoPianificatore.Rows[0];
            }
        }

        /// <summary>
        /// Get the information of current "Esecutore"
        /// </summary>
        /// <param name="newInsertion"></param>
        private void getInfoEsecutore(bool newInsertion, int esecutKey = -1)
        {
            cA_InfoEsecutoreTableAdapter.Fill(dsRichiesteLavorazioni.CA_InfoEsecutore, current_RichiestaLavorazione.Numero);

            if (dsRichiesteLavorazioni.CA_InfoEsecutore.Rows.Count == 0)
            {
                if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore && newInsertion)
                {
                    //dsRichiesteLavorazioni.CA_InfoRichiedenteRow newRichiedente = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)(((DataRowView)cAInfoRichiedenteBindingSource.AddNew()).Row);
                    dsRichiesteLavorazioni.CA_InfoEsecutoreRow newEsecutore = (dsRichiesteLavorazioni.CA_InfoEsecutoreRow)dsRichiesteLavorazioni.CA_InfoEsecutore.NewRow();
                    newEsecutore.NumRichiesta = current_RichiestaLavorazione.Numero;
                    newEsecutore.TipologiaUtente = (int)Fastener.Utility.LoginType_CA.Esecutore;
                    newEsecutore.Utente = esecutKey;
                    AssignInfoEsecutore(newEsecutore);
                    current_Esecutore = newEsecutore;

                    dsRichiesteLavorazioni.CA_InfoEsecutore.Rows.Add(current_Esecutore);
                }
            }
            else
            {
                current_Esecutore = (dsRichiesteLavorazioni.CA_InfoEsecutoreRow)dsRichiesteLavorazioni.CA_InfoEsecutore.Rows[0];
                if (Program.CurrentUser.UserType_CA == (int)Utility.LoginType_CA.Pianificatore && newInsertion)
                {
                    current_Esecutore.Utente = esecutKey;
                    AssignInfoEsecutore(current_Esecutore);
                }
            }
        }

        /// <summary>
        /// Used to copy "Pianificatore" information to "Esecutore" information
        /// </summary>
        /// <param name="newEsecutore"></param>
        private void AssignInfoEsecutore(dsRichiesteLavorazioni.CA_InfoEsecutoreRow newEsecutore)
        {
            if (current_Pianificatore != null)
            {
                if (current_Pianificatore.IsCentroDiCostoNull() || this.comboBox_Pian_CentroDiCosto.Text.Equals(string.Empty)) { newEsecutore.SetCentroDiCostoNull(); } else { newEsecutore.CentroDiCosto = current_Pianificatore.CentroDiCosto; }
                if (current_Pianificatore.IsSchedaMacchinaNull() || this.comboBox_Pian_Scheda.Text.Equals(string.Empty)) { newEsecutore.SetSchedaMacchinaNull(); } else { newEsecutore.SchedaMacchina = current_Pianificatore.SchedaMacchina; }
                if (current_Pianificatore.IsContoAnaliticoNull() || this.comboBox_Pian_ContoAnalitico.Text.Equals(string.Empty)) { newEsecutore.SetContoAnaliticoNull(); } else { newEsecutore.ContoAnalitico = current_Pianificatore.ContoAnalitico; }
                if (current_Pianificatore.IsDataFineNull()) { newEsecutore.SetDataFineNull(); } else { newEsecutore.DataFine = current_Pianificatore.DataFine; }
                if (current_Pianificatore.IsDataInizioNull()) { newEsecutore.SetDataInizioNull(); } else { newEsecutore.DataInizio = current_Pianificatore.DataInizio; }
                if (current_Pianificatore.IsMaterialiRichiestiNull()) { newEsecutore.SetMaterialiRichiestiNull(); } else { newEsecutore.MaterialiRichiesti = current_Pianificatore.MaterialiRichiesti; }
                if (current_Pianificatore.IsCompetenzaRDANull()) { newEsecutore.SetCompetenzaRDANull(); } else { newEsecutore.CompetenzaRDA = current_Pianificatore.CompetenzaRDA; }
                if (current_Pianificatore.IsPriorityNull()) { newEsecutore.SetPriorityNull(); } else { newEsecutore.Priority = current_Pianificatore.Priority; }
                if (current_Pianificatore.IsNoteNull()) { newEsecutore.SetNoteNull(); } else { newEsecutore.Note = current_Pianificatore.Note; }
                if (current_Pianificatore.IsProgettoNull()) { newEsecutore.SetProgettoNull(); } else { newEsecutore.Progetto = current_Pianificatore.Progetto; }
                if (current_Pianificatore.IsRDANull()) { newEsecutore.SetRDANull(); } else { newEsecutore.RDA = current_Pianificatore.RDA; }
                if (current_Pianificatore.IsRepartoTecnicoNull()) { newEsecutore.SetRepartoTecnicoNull(); } else { newEsecutore.RepartoTecnico = current_Pianificatore.RepartoTecnico; } 
                if (current_Pianificatore.IsRischioNull()) { newEsecutore.SetRischioNull(); } else { newEsecutore.Rischio = current_Pianificatore.Rischio; }
                if (current_Pianificatore.IsTipologiaRichiestaNull()) { newEsecutore.SetTipologiaRichiestaNull(); } else { newEsecutore.TipologiaRichiesta = current_Pianificatore.TipologiaRichiesta; }
                if (current_Pianificatore.IsMittenteNull()) { newEsecutore.SetMittenteNull(); } else { newEsecutore.Mittente = current_Pianificatore.Mittente; }
                if (current_Pianificatore.IsEmailNull()) { newEsecutore.SetEmailNull(); } else { newEsecutore.Email = current_Pianificatore.Email; }
                if (current_Pianificatore.IsCompetenzaRDANull()) { newEsecutore.SetCompetenzaRDANull(); } else { newEsecutore.CompetenzaRDA = current_Pianificatore.CompetenzaRDA; } 
            }
        }

        private void button_NuovaRichiestaLavorazione_Click(object sender, EventArgs e)
        {
            try
            {
                current_RichiestaLavorazione = AddNewRichiestaLavorazione();
                //this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Selected = true;
                int index = cARichiestaLavorazioniBindingSource.Find("Numero", current_RichiestaLavorazione.Numero);

                if (index >= 0)
                {
                    cARichiestaLavorazioniBindingSource.Position = index;
                    logInfo("Nuova Richiesta", null, null);
                }

                populate_ComboBox_Filters(true);                
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, null, null, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add a new "Richiesta di Lavorazione"
        /// </summary>
        /// <returns></returns>
        public dsRichiesteLavorazioni.CA_RichiestaLavorazioniRow AddNewRichiestaLavorazione()
        {
            current_RichiestaLavorazione = (dsRichiesteLavorazioni.CA_RichiestaLavorazioniRow)dsRichiesteLavorazioni.CA_RichiestaLavorazioni.NewRow();
            current_RichiestaLavorazione.Numero = this.cA_RichiestaLavorazioniTableAdapter.Max_NumeroRichiesta() == null ? (DateTime.Now.Year * 1000000 + 1) : (int)this.cA_RichiestaLavorazioniTableAdapter.Max_NumeroRichiesta() + 1;
            //current_RichiestaLavorazione.Richiedente = Program.CurrentUser.Key;
            current_RichiestaLavorazione.Richiedente = richiedente_Generico; //Richiedente Generico
            current_RichiestaLavorazione.RichiedenteName = "Richiedente Generico";            
            current_RichiestaLavorazione.Data_richiesta = DateTime.Now;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Nuova;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);
            dsRichiesteLavorazioni.CA_RichiestaLavorazioni.AddCA_RichiestaLavorazioniRow(current_RichiestaLavorazione);

            //clear_Controls();

            //this.dateTimePicker_FineVisita.Value = DateTime.Now;
            //this.dateTimePicker_FineVisita.Value = null;

            return current_RichiestaLavorazione;
        }

        SqlTransaction transaction;
        private void button_EmettiRichiesta_Click(object sender, EventArgs e)
        {
            if (!current_RichiestaLavorazione.IsTitoloNull())
            {
                int prev_stato = current_RichiestaLavorazione.Stato;
                current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Emessa;
                current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

                transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
                TransactionHelper.SetTransaction(cA_InfoRichiedenteTableAdapter, transaction);
                //if (qual_Schede_DifettiTableAdapter != null)
                //{
                //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
                //}

                try
                {
                    cARichiestaLavorazioniBindingSource.EndEdit();
                    cAInfoRichiedenteBindingSource.EndEdit();

                    int? RichiestaPadre;
                    if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                    {
                        RichiestaPadre = null;
                    }
                    else
                    {
                        RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                    }

                    if (current_RichiestaLavorazione.RowState.Equals(DataRowState.Modified))
                    {
                        this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                    }
                    else if (current_RichiestaLavorazione.RowState.Equals(DataRowState.Added))
                    {
                        this.cA_RichiestaLavorazioniTableAdapter.InsertQuery(current_RichiestaLavorazione.Numero, current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre);
                    }
                    else
                    {
                        throw new Exception("Anomalia di Salvataggio Richiesta!");
                    }

                    //foreach (dsRichiesteLavorazioni.CA_InfoRichiedenteRow dr in dsRichiesteLavorazioni.CA_InfoRichiedente.GetChanges().Rows)
                    //{
                    //    Console.WriteLine("tipo utente: " + dr.TipologiaUtente);
                    //    Console.WriteLine("cc: " + dr.CentroDiCosto);
                    //    Console.WriteLine("cAnal: " + dr.ContoAnalitico);
                    //    Console.WriteLine("dataf: " + dr.DataFine);
                    //    Console.WriteLine("dataI: " + dr.DataInizio);
                    //    Console.WriteLine("mater: " + dr.MaterialiRichiesti);
                    //    Console.WriteLine("note: " + dr.Note);
                    //    Console.WriteLine("prior: " + dr.Priority);
                    //    Console.WriteLine("prog: " + dr.Progetto);
                    //    Console.WriteLine("rda: " + dr.RDA);
                    //    Console.WriteLine("repTec: " + dr.RepartoTecnico);
                    //    Console.WriteLine("rischio: " + dr.Rischio);
                    //    Console.WriteLine("scheda: " + dr.SchedaMacchina);
                    //    Console.WriteLine("tipolR: " + dr.TipologiaRichiesta);
                    //    Console.WriteLine("tipoU: " + dr.TipologiaUtente);
                    //    Console.WriteLine("utente: " + dr.Utente);
                    //}

                    this.cA_InfoRichiedenteTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoRichiedente);

                    transaction.Commit();

                    MessageBox.Show("Richiesta Emessa!");
                    ReloadInfo();
                    enableControls();
                    logInfo("Richiesta Emessa", prev_stato, 2);
                    populate_ComboBox_Filters();
                    //ReloadInfo();
                }
                catch (Exception ex)
                {
                    logInfo(ex.Message, prev_stato, 2, null, ex);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (transaction != null)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            MessageBox.Show("Rollback Exception: ", ex2.Message);
                            logInfo("Rollback Exception: " + ex.Message, prev_stato, 2, null, ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Inserire un Titolo per la richiesta.\r\nEmissione Richiesta Annullata!");
            }
        }


        int? selected_SCHEDA_Rich;
        int? selected_IMP_Rich;

        private void comboBox_Rich_ContoAnalitico_DropDown(object sender, EventArgs e)
        {
            
            comboBox_Rich_ContoAnalitico.DataSource = Filtered_ContoAnal_Rich_BS;
            if (comboBox_Rich_Scheda.SelectedItem != null)
            {
                this.Filtered_ContoAnal_Rich_BS.Filter = "(SchedaKey = " + comboBox_Rich_Scheda.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_ContoAnal_Rich_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Rich_Scheda_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Rich_Scheda.SelectedValue != null)
            {
                selected_SCHEDA_Rich = Convert.ToInt32(comboBox_Rich_Scheda.SelectedValue);
            }
            else
            {
                selected_SCHEDA_Rich = null;
            }

            comboBox_Rich_Scheda.DataSource = Filtered_Scheda_Rich_BS;
            if (comboBox_Rich_CentroDiCosto.SelectedItem != null)
            {
                this.Filtered_Scheda_Rich_BS.Filter = "(IMPKey = " + comboBox_Rich_CentroDiCosto.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_Scheda_Rich_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Rich_Scheda_DropDownClosed(object sender, EventArgs e)
        {
            //comboBox_Rich_Scheda.DataSource = manAnaSCHEDABindingSource;
            //Filtered_Scheda_Rich_BS.RemoveFilter();

            if (comboBox_Rich_Scheda.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Rich_Scheda.SelectedValue) != selected_SCHEDA_Rich)
                {
                    this.comboBox_Rich_ContoAnalitico.SelectedItem = null;
                }
            }
        }


        private void comboBox_Rich_CentroDiCosto_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Rich_CentroDiCosto.SelectedValue != null)
            {
                selected_IMP_Rich = Convert.ToInt32(comboBox_Rich_CentroDiCosto.SelectedValue);
            }
            else
            {
                selected_IMP_Rich = null;
            }

        }

        private void comboBox_Rich_CentroDiCosto_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Rich_CentroDiCosto.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Rich_CentroDiCosto.SelectedValue) != selected_IMP_Rich)
                {
                    this.comboBox_Rich_Scheda.SelectedItem = null;
                    this.comboBox_Rich_ContoAnalitico.SelectedItem = null;
                }
            }
        }

        private void button_AnnullaRichiesta_Rich_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Annullata_Richiedente;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);

                MessageBox.Show("Richiesta Annullata!");
                enableControls();
                logInfo("Richiesta Annullata", prev_stato, (int)Fastener.Utility.Azioni_CA.Annulla_Richiesta);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, (int)Fastener.Utility.Azioni_CA.Annulla_Richiesta, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AnnullaRichiesta_Pian_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Annullata_Pianificatore;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);
            current_RichiestaLavorazione.SetEsecutoreNull();

            transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
            TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
            //if (qual_Schede_DifettiTableAdapter != null)
            //{
            //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
            //}

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();
                cAInfoEsecutoreBindingSource.EndEdit();

                if (current_Esecutore != null)
                {
                    current_Esecutore.Delete();
                }

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                this.cA_InfoEsecutoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoEsecutore);

                transaction.Commit();

                MessageBox.Show("Richiesta Annullata!");
                enableControls();
                logInfo("Richiesta Annullata", prev_stato, 1);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 1, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        MessageBox.Show("Rollback Exception: ", ex2.Message);
                        logInfo("Rollback Exception: " + ex.Message, prev_stato, 1, null, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Used to log user actions
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="prev_stato"></param>
        /// <param name="azione"></param>
        /// <param name="idUserAssegnato"></param>
        private void logInfo(string msg, int? prev_stato, int? azione, int? idUserAssegnato = null, Exception errorException = null)
        {
            log4net.GlobalContext.Properties["numRichiesta"] = current_RichiestaLavorazione.Numero.ToString();
            log4net.GlobalContext.Properties["statoIniziale"] = prev_stato;
            log4net.GlobalContext.Properties["statoFinale"] = current_RichiestaLavorazione.Stato;
            log4net.GlobalContext.Properties["azione"] = azione;
            log4net.GlobalContext.Properties["idUtente"] = Program.CurrentUser.Key;
            log4net.GlobalContext.Properties["idUtenteAssegnato"] = idUserAssegnato;
            if (errorException == null)
            {
                log.Info(msg);
            }
            else
            {
                log.Error(msg, errorException);
            }
        }

        private void button_AssegnaRichiesta_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Pian_RepTecnico.SelectedValue != null)
            {
                int prev_stato = current_RichiestaLavorazione.Stato;
                current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Assegnata;
                current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);
                int esecKey = -1;

                Assegna_RichiesteLavorazioni arl = new Assegna_RichiesteLavorazioni(this.comboBox_Pian_RepTecnico.SelectedValue.ToString());
                if (arl.ShowDialog() == DialogResult.OK)
                {
                    esecKey = arl.ret_value;
                    current_RichiestaLavorazione.Esecutore = esecKey;
                    current_RichiestaLavorazione.EsecutoreName = arl.ret_value_descriz;
                }
                else
                {
                    MessageBox.Show("Assegnazione Annullata.");
                    return;
                }

                getInfoEsecutore(true, esecKey);

                transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
                TransactionHelper.SetTransaction(cA_InfoPianificatoreTableAdapter, transaction);
                TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
                //if (qual_Schede_DifettiTableAdapter != null)
                //{
                //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
                //}

                try
                {
                    
                    //Console.WriteLine(dsRichiesteLavorazioni.CA_InfoRichiedente.Rows.Count);
                    //cAInfoRichiedenteBindingSource.EndEdit();
                    //this.cA_InfoRichiedenteTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoRichiedente);

                    cARichiestaLavorazioniBindingSource.EndEdit();                    
                    cAInfoPianificatoreBindingSource.EndEdit();
                    cAInfoEsecutoreBindingSource.EndEdit();

                    //foreach(DataRow dr in dsRichiesteLavorazioni.CA_InfoPianificatore.Rows)
                    //{
                    //    foreach (DataColumn col in dsRichiesteLavorazioni.CA_InfoPianificatore.Columns)
                    //    {
                            
                    //        bool isEqual;
                    //        if (dr[col, DataRowVersion.Original] != DBNull.Value && dr[col, DataRowVersion.Current] != DBNull.Value)
                    //        {
                    //            string originalVersionToCompare = dr[col, DataRowVersion.Original].ToString();
                    //            string currentVersionToCompare = dr[col, DataRowVersion.Current].ToString();
                    //            if (false)
                    //            {
                    //                originalVersionToCompare = originalVersionToCompare.Trim();
                    //                currentVersionToCompare = currentVersionToCompare.Trim();
                    //            }
                    //            isEqual = originalVersionToCompare.Equals(currentVersionToCompare, StringComparison.InvariantCultureIgnoreCase);
                    //            Console.WriteLine("Column: " + col.ColumnName + " equal " + isEqual);
                    //        }
                    //    }
                    //}
                    cARichiestaLavorazioniBindingSource.EndEdit();

                    int? RichiestaPadre;
                    if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                    {
                        RichiestaPadre = null;
                    }
                    else
                    {
                        RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                    }

                    this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                    this.cA_InfoPianificatoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoPianificatore);
                    this.cA_InfoEsecutoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoEsecutore);

                    transaction.Commit();

                    MessageBox.Show("Richiesta Assegnata!");
                    enableControls();
                    logInfo("Richiesta Assegnata", prev_stato, 3, current_Esecutore.Utente);
                    populate_ComboBox_Filters();
                }
                catch (Exception ex)
                {
                    logInfo(ex.Message, prev_stato, 3, current_Esecutore.Utente, ex);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (transaction != null)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            MessageBox.Show("Rollback Exception: ", ex2.Message);
                            logInfo("Rollback Exception: " + ex.Message, prev_stato, 3, current_Esecutore.Utente, ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nessun Reparto Tecnico selezionato.");
            }
        }

        int? selected_SCHEDA_Pian;
        int? selected_IMP_Pian;
        private void comboBox_Pian_ContoAnalitico_DropDown(object sender, EventArgs e)
        {
            comboBox_Pian_ContoAnalitico.DataSource = Filtered_ContoAnal_Pian_BS;
            if (comboBox_Pian_Scheda.SelectedItem != null)
            {
                this.Filtered_ContoAnal_Pian_BS.Filter = "(SchedaKey = " + comboBox_Pian_Scheda.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_ContoAnal_Pian_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Pian_Scheda_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Pian_Scheda.SelectedValue != null)
            {
                selected_SCHEDA_Pian = Convert.ToInt32(comboBox_Pian_Scheda.SelectedValue);
            }
            else
            {
                selected_SCHEDA_Pian = null;
            }

            comboBox_Pian_Scheda.DataSource = Filtered_Scheda_Pian_BS;
            if (comboBox_Pian_CentroDiCosto.SelectedItem != null)
            {
                this.Filtered_Scheda_Pian_BS.Filter = "(IMPKey = " + comboBox_Pian_CentroDiCosto.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_Scheda_Pian_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Pian_Scheda_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Pian_Scheda.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Pian_Scheda.SelectedValue) != selected_SCHEDA_Pian)
                {
                    this.comboBox_Pian_ContoAnalitico.SelectedItem = null;
                }
            }
        }

        private void comboBox_Pian_CentroDiCosto_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Pian_CentroDiCosto.SelectedValue != null)
            {
                selected_IMP_Pian = Convert.ToInt32(comboBox_Pian_CentroDiCosto.SelectedValue);
            }
            else
            {
                selected_IMP_Pian = null;
            }
        }

        private void comboBox_Pian_CentroDiCosto_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Pian_CentroDiCosto.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Pian_CentroDiCosto.SelectedValue) != selected_IMP_Pian)
                {
                    this.comboBox_Pian_Scheda.SelectedItem = null;
                    this.comboBox_Pian_ContoAnalitico.SelectedItem = null;
                }
            }
        }

        int? selected_SCHEDA_Esec;
        int? selected_IMP_Esec;
        private void comboBox_Esec_ContoAnalitico_DropDown(object sender, EventArgs e)
        {
            comboBox_Esec_ContoAnalitico.DataSource = Filtered_ContoAnal_Esec_BS;
            if (comboBox_Esec_Scheda.SelectedItem != null)
            {
                this.Filtered_ContoAnal_Esec_BS.Filter = "(SchedaKey = " + comboBox_Esec_Scheda.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_ContoAnal_Esec_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Esec_Scheda_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Esec_Scheda.SelectedValue != null)
            {
                selected_SCHEDA_Esec = Convert.ToInt32(comboBox_Esec_Scheda.SelectedValue);
            }
            else
            {
                selected_SCHEDA_Esec = null;
            }

            comboBox_Esec_Scheda.DataSource = Filtered_Scheda_Esec_BS;
            if (comboBox_Esec_CentroDiCosto.SelectedItem != null)
            {
                this.Filtered_Scheda_Esec_BS.Filter = "(IMPKey = " + comboBox_Esec_CentroDiCosto.SelectedValue.ToString() + ")";
            }
            else
            {
                this.Filtered_Scheda_Esec_BS.Filter = "1 = 0"; //always false
            }
        }

        private void comboBox_Esec_Scheda_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Esec_Scheda.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Esec_Scheda.SelectedValue) != selected_SCHEDA_Esec)
                {
                    this.comboBox_Esec_ContoAnalitico.SelectedItem = null;
                }
            }
        }

        private void comboBox_Esec_CentroDiCosto_DropDown(object sender, EventArgs e)
        {
            if (comboBox_Esec_CentroDiCosto.SelectedValue != null)
            {
                selected_IMP_Esec = Convert.ToInt32(comboBox_Esec_CentroDiCosto.SelectedValue);
            }
            else
            {
                selected_IMP_Esec = null;
            }
        }

        private void comboBox_Esec_CentroDiCosto_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox_Esec_CentroDiCosto.SelectedValue != null)
            {
                if (Convert.ToInt32(comboBox_Esec_CentroDiCosto.SelectedValue) != selected_IMP_Esec)
                {
                    this.comboBox_Esec_Scheda.SelectedItem = null;
                    this.comboBox_Esec_ContoAnalitico.SelectedItem = null;
                }
            }
        }

        private void button_RespingiRichiesta_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Respinta;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);

                MessageBox.Show("Richiesta Respinta!");
                enableControls();
                logInfo("Richiesta Respinta", prev_stato, 4);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 4, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AccettaRichiesta_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Accettata;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
            TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
            //if (qual_Schede_DifettiTableAdapter != null)
            //{
            //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
            //}

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();
                cAInfoEsecutoreBindingSource.EndEdit();

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                this.cA_InfoEsecutoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoEsecutore);

                transaction.Commit();

                MessageBox.Show("Richiesta Accettata!");
                enableControls();
                logInfo("Richiesta Accettata", prev_stato, 5);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 5, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        MessageBox.Show("Rollback Exception: ", ex2.Message);
                        logInfo("Rollback Exception: " + ex.Message, prev_stato, 5, null, ex);
                    }
                }
            }
        }

        private void button_ChiudiRichiesta_Click(object sender, EventArgs e)
        {
            if (this.nullableDateTimePicker_Esec_DataInizioEffettiva.Value == null
                || this.nullableDateTimePicker_Esec_DataFineEffettiva.Value == null
                || this.textBox_Esec_DurataOreEffettiva.Text.Equals(string.Empty)
                )
            {
                MessageBox.Show("Le informazioni riguardanti la durata, data_inizio, data_fine effettive non sono state inserite.\r\nChiusura richiesta annullata!");
                return;
            }
            else
            {
                int prev_stato = current_RichiestaLavorazione.Stato;
                current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Completata;
                current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

                transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
                TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
                //if (qual_Schede_DifettiTableAdapter != null)
                //{
                //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
                //}

                try
                {
                    cARichiestaLavorazioniBindingSource.EndEdit();
                    cAInfoEsecutoreBindingSource.EndEdit();

                    cARichiestaLavorazioniBindingSource.EndEdit();

                    int? RichiestaPadre;
                    if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                    {
                        RichiestaPadre = null;
                    }
                    else
                    {
                        RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                    }

                    this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                    this.cA_InfoEsecutoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoEsecutore);

                    transaction.Commit();

                    MessageBox.Show("Richiesta Chiusa!");
                    enableControls();
                    logInfo("Richiesta Accettata", prev_stato, 6);
                    populate_ComboBox_Filters();
                }
                catch (Exception ex)
                {
                    logInfo(ex.Message, prev_stato, 6, null, ex);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (transaction != null)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            MessageBox.Show("Rollback Exception: ", ex2.Message);
                            logInfo("Rollback Exception: " + ex.Message, prev_stato, 6, null, ex);
                        }
                    }
                }
            }
        }

        private void button_RichiestaNonConforme_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Non_Conforme;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);

                MessageBox.Show("Richiesta Non Conforme!");
                enableControls();
                logInfo("Richiesta Non Conforme", prev_stato, 7);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 7, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RichiestaConforme_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Conforme;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);

                MessageBox.Show("Richiesta Conforme!");
                enableControls();
                logInfo("Richiesta Conforme", prev_stato, 8);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 8, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RiapriRichiesta_Click(object sender, EventArgs e)
        {
            int prev_stato = current_RichiestaLavorazione.Stato;
            current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Accettata;
            current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

            transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
            TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
            //if (qual_Schede_DifettiTableAdapter != null)
            //{
            //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
            //}

            try
            {
                cARichiestaLavorazioniBindingSource.EndEdit();
                cAInfoEsecutoreBindingSource.EndEdit();

                cARichiestaLavorazioniBindingSource.EndEdit();

                int? RichiestaPadre;
                if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                {
                    RichiestaPadre = null;
                }
                else
                {
                    RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                }

                this.cA_RichiestaLavorazioniTableAdapter.UpdateQuery(current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre, current_RichiestaLavorazione.Numero);
                this.cA_InfoEsecutoreTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoEsecutore);

                transaction.Commit();

                MessageBox.Show("Richiesta Riaperta!");
                enableControls();
                logInfo("Richiesta Riaperta", prev_stato, 9);
                populate_ComboBox_Filters();
            }
            catch (Exception ex)
            {
                logInfo(ex.Message, prev_stato, 9, null, ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        MessageBox.Show("Rollback Exception: ", ex2.Message);
                        logInfo("Rollback Exception: " + ex.Message, prev_stato, 9, null, ex);
                    }
                }
            }
        }

        private void filtering_Data()
        {
            try
            {
                string filter = String.Empty;
                bool insert_and = false;

                if (this.comboBox_Filtro_Richiedente.Enabled && !this.comboBox_Filtro_Richiedente.Text.Equals(string.Empty))
                {
                    filter = "RichiedenteName = '" + this.comboBox_Filtro_Richiedente.Text + "'";
                    insert_and = true;
                }
                if (this.comboBox_Filtro_Pianificatore.Enabled && !this.comboBox_Filtro_Pianificatore.Text.Equals(string.Empty))
                {
                    if (insert_and)
                    {
                        filter += " AND ";
                    }
                    filter += "PianificatoreName = '" + this.comboBox_Filtro_Pianificatore.Text + "'";
                    insert_and = true;
                }
                if (this.comboBox_Filtro_Esecutore.Enabled && !this.comboBox_Filtro_Esecutore.Text.Equals(string.Empty))
                {
                    if (insert_and)
                    {
                        filter += " AND ";
                    }
                    filter += "EsecutoreName = '" + this.comboBox_Filtro_Esecutore.Text + "'";
                    insert_and = true;
                }
                if (this.comboBox_Filtro_Stato.Enabled && !this.comboBox_Filtro_Stato.Text.Equals(string.Empty))
                {
                    if (insert_and)
                    {
                        filter += " AND ";
                    }
                    filter += "StatoDescriz = '" + this.comboBox_Filtro_Stato.Text + "'";
                    insert_and = true;
                }

                cARichiestaLavorazioniBindingSource.Filter = filter;
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show("Errore stringa inserita: " + ex.Message);
            }
        }

        private void checkBox_Filtro_Richiedente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Filtro_Richiedente.Checked)
            {
                this.comboBox_Filtro_Richiedente.Enabled = true;
            }
            else
            {
                this.comboBox_Filtro_Richiedente.Enabled = false;
            }
            filtering_Data();
        }

        private void checkBox_Filtro_Pianificatore_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Filtro_Pianificatore.Checked)
            {
                this.comboBox_Filtro_Pianificatore.Enabled = true;
            }
            else
            {
                this.comboBox_Filtro_Pianificatore.Enabled = false;
            }
            filtering_Data();
        }

        private void checkBox_Filtro_Esecutore_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Filtro_Esecutore.Checked)
            {
                this.comboBox_Filtro_Esecutore.Enabled = true;
            }
            else
            {
                this.comboBox_Filtro_Esecutore.Enabled = false;
            }
            filtering_Data();
        }

        private void comboBox_Filtro_Richiedente_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering_Data();
        }

        private void comboBox_Filtro_Pianificatore_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering_Data();
        }

        private void comboBox_Filtro_Esecutore_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering_Data();
        }

        private void checkBox_Filter_AllRichieste_CheckedChanged(object sender, EventArgs e)
        {
            populate_DataGridView_Data();
            populate_ComboBox_Filters();
            filtering_Data();
        }

        private void checkBox_Filtro_Stato_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Filtro_Stato.Checked)
            {
                this.comboBox_Filtro_Stato.Enabled = true;
            }
            else
            {
                this.comboBox_Filtro_Stato.Enabled = false;
            }
            filtering_Data();
        }

        private void comboBox_Filtro_Stato_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering_Data();
        }

        private void nullableDateTimePicker_Esec_DataFineEffettiva_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Rich_DataInizio_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Rich_DataFine_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Pian_DataInizio_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Pian_DataFine_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Esec_DataInizio_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void dateTimePicker_Esec_DataFine_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void nullableDateTimePicker_Esec_DataInizioEffettiva_ValueChanged(object sender, EventArgs e)
        {
            NullableDateTimePicker dt = (NullableDateTimePicker)sender;
            if (dt.Value != null)
            {
                dt.Value = ((DateTime)dt.Value).Date;
            }
        }

        private void button_CreaRichiestaCorrelata_Click(object sender, EventArgs e)
        {            
            if (current_RichiestaLavorazione != null && current_RichiestaLavorazione.Numero != 0)
            {
                if (MessageBox.Show("Creare Richiesta Correlata?", "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    transaction = TransactionHelper.BeginTransaction(cA_RichiestaLavorazioniTableAdapter);
                    TransactionHelper.SetTransaction(cA_InfoRichiedenteTableAdapter, transaction);
                    TransactionHelper.SetTransaction(cA_InfoPianificatoreTableAdapter, transaction);
                    TransactionHelper.SetTransaction(cA_InfoEsecutoreTableAdapter, transaction);
                    //if (qual_Schede_DifettiTableAdapter != null)
                    //{
                    //    TransactionHelper.SetTransaction(qual_Schede_DifettiTableAdapter, transaction);
                    //}

                    try
                    {
                        int old_number = current_RichiestaLavorazione.Numero;
                        string old_commessa = null;
                        if (!current_Pianificatore.IsProgettoNull())
                        {
                            old_commessa = current_Pianificatore.Progetto;
                        }
                        AddNewRichiestaLavorazione();                        
                        current_RichiestaLavorazione.Richiesta_Padre = old_number;
                        current_RichiestaLavorazione.Titolo = "Correlata a Richiesta " + old_number;
                       
                        //this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Selected = true;
                        int index = cARichiestaLavorazioniBindingSource.Find("Numero", current_RichiestaLavorazione.Numero);

                        if (index >= 0)
                        {
                            cARichiestaLavorazioniBindingSource.Position = index;
                            logInfo("Nuova Richiesta", null, null);
                        }

                        populate_ComboBox_Filters(true);
                        current_RichiestaLavorazione.Stato = (int)Fastener.Utility.StatoRichiesta_CA.Emessa;
                        current_RichiestaLavorazione.StatoDescriz = cA_Ana_StatoRichiestaTableAdapter.getStatoDescriz(current_RichiestaLavorazione.Stato);

                        cARichiestaLavorazioniBindingSource.EndEdit();
                        cAInfoRichiedenteBindingSource.EndEdit();

                        if (current_RichiestaLavorazione.RowState.Equals(DataRowState.Added))
                        {
                            cARichiestaLavorazioniBindingSource.EndEdit();

                            int? RichiestaPadre;
                            if (current_RichiestaLavorazione.IsRichiesta_PadreNull())
                            {
                                RichiestaPadre = null;
                            }
                            else
                            {
                                RichiestaPadre = current_RichiestaLavorazione.Richiesta_Padre;
                            }

                            this.cA_RichiestaLavorazioniTableAdapter.InsertQuery(current_RichiestaLavorazione.Numero, current_RichiestaLavorazione.Richiedente, current_RichiestaLavorazione.Data_richiesta, current_RichiestaLavorazione.Stato, current_RichiestaLavorazione.Titolo, current_RichiestaLavorazione.Descrizione, DateTime.Now, RichiestaPadre);
                        }
                        else
                        {
                            throw new Exception("Anomalia di Salvataggio Richiesta!");
                        }


                        dsRichiesteLavorazioni.CA_InfoRichiedenteRow dr_new = (dsRichiesteLavorazioni.CA_InfoRichiedenteRow)dsRichiesteLavorazioni.CA_InfoRichiedente.NewRow();
                        dr_new.NumRichiesta = current_RichiestaLavorazione.Numero;
                        dr_new.TipologiaUtente = (int)Fastener.Utility.LoginType_CA.Richiedente;
                        dr_new.Utente = Program.CurrentUser.Key;
                        dr_new.Progetto = old_commessa;
                        current_Richiedente = dr_new;
                        dsRichiesteLavorazioni.CA_InfoRichiedente.Rows.Clear();
                        dsRichiesteLavorazioni.CA_InfoRichiedente.AddCA_InfoRichiedenteRow(current_Richiedente);
                        

                        this.cA_InfoRichiedenteTableAdapter.Update(dsRichiesteLavorazioni.CA_InfoRichiedente);

                        transaction.Commit();

                        MessageBox.Show("Creata Richiesta Correlata!");
                        enableControls();
                        logInfo("Creata Richiesta Correlata", 2, 2);
                        populate_ComboBox_Filters();

                        ReloadInfo();
                        enableControls();
                    }
                    catch (Exception ex)
                    {
                        logInfo(ex.Message, 2, 2, null, ex);
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (transaction != null)
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                // This catch block will handle any errors that may have occurred
                                // on the server that would cause the rollback to fail, such as
                                // a closed connection.
                                MessageBox.Show("Rollback Exception: ", ex2.Message);
                                logInfo("Rollback Exception: " + ex.Message, 2, 2, null, ex);
                            }
                        }
                    }
                }
            }     
            
        }
        

    }
}
