namespace Fastener.Controlli
{
    partial class CtrlManUtenti
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlManUtenti));
            this.dbTableLayoutPanel2 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel_utenti = new Fastener.DBPanel(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Centro_Di_Responsabilità = new System.Windows.Forms.ComboBox();
            this.cAAnaCDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaintenance = new Fastener.DataSet.dsMaintenance();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tipo_utente_CA = new System.Windows.Forms.ComboBox();
            this.cAAnaTipologiaUtenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox_p_valori = new System.Windows.Forms.CheckBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new_user = new System.Windows.Forms.Button();
            this.dbDataGridView_p_cdr = new Fastener.DBDataGridView(this.components);
            this.responsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsabileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPurchaseOrder = new Fastener.DataSet.dsPurchaseOrder();
            this.dbDataGridView_p_ass = new Fastener.DBDataGridView(this.components);
            this.cdrAbilitatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteAbilitatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoriDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordiniAcqVisibilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataGridView_rep_ass = new Fastener.DBDataGridView(this.components);
            this.tipoRepNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRepKeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utentiRepartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataGridView_p_rich = new Fastener.DBDataGridView(this.components);
            this.richiedenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richiedentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataGridView_rep_disp = new Fastener.DBDataGridView(this.components);
            this.manAnaTipoRepartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_stato_record = new System.Windows.Forms.ComboBox();
            this.manAnaStatoRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_azienda = new System.Windows.Forms.ComboBox();
            this.manAnaAZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_tipo_utente = new System.Windows.Forms.ComboBox();
            this.manAnaTipoUtenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_lingua = new System.Windows.Forms.ComboBox();
            this.manAnaLANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_reset_password = new System.Windows.Forms.Button();
            this.textBox_nome_dominio = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.comboBox_utente = new System.Windows.Forms.ComboBox();
            this.manAnaUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.man_Ana_Tipo_RepartoTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_RepartoTableAdapter();
            this.utenti_RepartiTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Utenti_RepartiTableAdapter();
            this.man_Ana_UTETableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_UTETableAdapter();
            this.man_Ana_LANTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_LANTableAdapter();
            this.man_Ana_Tipo_UtenteTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_UtenteTableAdapter();
            this.man_Ana_AZITableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_AZITableAdapter();
            this.man_Ana_Stato_RecordTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_Stato_RecordTableAdapter();
            this.richiedentiTableAdapter = new Fastener.DataSet.dsPurchaseOrderTableAdapters.RichiedentiTableAdapter();
            this.cdRTableAdapter = new Fastener.DataSet.dsPurchaseOrderTableAdapters.CdRTableAdapter();
            this.ordiniAcq_VisibilityTableAdapter = new Fastener.DataSet.dsPurchaseOrderTableAdapters.OrdiniAcq_VisibilityTableAdapter();
            this.cA_Ana_TipologiaUtenteTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.CA_Ana_TipologiaUtenteTableAdapter();
            this.cA_Ana_CDRTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.CA_Ana_CDRTableAdapter();
            this.tipoRepNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRepKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDRTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTableLayoutPanel2.SuspendLayout();
            this.dbPanel_utenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAAnaCDRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAAnaTipologiaUtenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_cdr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_ass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordiniAcqVisibilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_rep_ass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiRepartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_rich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richiedentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_rep_disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoRepartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaAZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoUtenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel2
            // 
            this.dbTableLayoutPanel2.ColumnCount = 3;
            this.dbTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel2.Controls.Add(this.dbPanel_utenti, 1, 1);
            this.dbTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.dbTableLayoutPanel2.Name = "dbTableLayoutPanel2";
            this.dbTableLayoutPanel2.RowCount = 3;
            this.dbTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel2.Size = new System.Drawing.Size(1160, 585);
            this.dbTableLayoutPanel2.TabIndex = 4;
            // 
            // dbPanel_utenti
            // 
            this.dbPanel_utenti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbPanel_utenti.BackgroundImage")));
            this.dbPanel_utenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbPanel_utenti.Controls.Add(this.label11);
            this.dbPanel_utenti.Controls.Add(this.comboBox_Centro_Di_Responsabilità);
            this.dbPanel_utenti.Controls.Add(this.label3);
            this.dbPanel_utenti.Controls.Add(this.comboBox_tipo_utente_CA);
            this.dbPanel_utenti.Controls.Add(this.checkBox_p_valori);
            this.dbPanel_utenti.Controls.Add(this.button_add);
            this.dbPanel_utenti.Controls.Add(this.label2);
            this.dbPanel_utenti.Controls.Add(this.button_save);
            this.dbPanel_utenti.Controls.Add(this.button_new_user);
            this.dbPanel_utenti.Controls.Add(this.dbDataGridView_p_cdr);
            this.dbPanel_utenti.Controls.Add(this.dbDataGridView_p_ass);
            this.dbPanel_utenti.Controls.Add(this.dbDataGridView_rep_ass);
            this.dbPanel_utenti.Controls.Add(this.dbDataGridView_p_rich);
            this.dbPanel_utenti.Controls.Add(this.dbDataGridView_rep_disp);
            this.dbPanel_utenti.Controls.Add(this.label10);
            this.dbPanel_utenti.Controls.Add(this.label9);
            this.dbPanel_utenti.Controls.Add(this.label8);
            this.dbPanel_utenti.Controls.Add(this.label7);
            this.dbPanel_utenti.Controls.Add(this.label6);
            this.dbPanel_utenti.Controls.Add(this.label1);
            this.dbPanel_utenti.Controls.Add(this.label5);
            this.dbPanel_utenti.Controls.Add(this.label4);
            this.dbPanel_utenti.Controls.Add(this.comboBox_stato_record);
            this.dbPanel_utenti.Controls.Add(this.comboBox_azienda);
            this.dbPanel_utenti.Controls.Add(this.comboBox_tipo_utente);
            this.dbPanel_utenti.Controls.Add(this.comboBox_lingua);
            this.dbPanel_utenti.Controls.Add(this.button_reset_password);
            this.dbPanel_utenti.Controls.Add(this.textBox_nome_dominio);
            this.dbPanel_utenti.Controls.Add(this.textBox_nome);
            this.dbPanel_utenti.Controls.Add(this.textBox_login);
            this.dbPanel_utenti.Controls.Add(this.comboBox_utente);
            this.dbPanel_utenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPanel_utenti.Location = new System.Drawing.Point(98, 67);
            this.dbPanel_utenti.Margin = new System.Windows.Forms.Padding(0);
            this.dbPanel_utenti.Name = "dbPanel_utenti";
            this.dbPanel_utenti.Size = new System.Drawing.Size(963, 450);
            this.dbPanel_utenti.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(20, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Centro di Respons";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Centro_Di_Responsabilità
            // 
            this.comboBox_Centro_Di_Responsabilità.DataSource = this.cAAnaCDRBindingSource;
            this.comboBox_Centro_Di_Responsabilità.DisplayMember = "Descrizione";
            this.comboBox_Centro_Di_Responsabilità.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Centro_Di_Responsabilità.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Centro_Di_Responsabilità.FormattingEnabled = true;
            this.comboBox_Centro_Di_Responsabilità.Location = new System.Drawing.Point(122, 353);
            this.comboBox_Centro_Di_Responsabilità.Name = "comboBox_Centro_Di_Responsabilità";
            this.comboBox_Centro_Di_Responsabilità.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Centro_Di_Responsabilità.TabIndex = 15;
            this.comboBox_Centro_Di_Responsabilità.ValueMember = "CodiceCDR";
            // 
            // cAAnaCDRBindingSource
            // 
            this.cAAnaCDRBindingSource.DataMember = "CA_Ana_CDR";
            this.cAAnaCDRBindingSource.DataSource = this.dsMaintenance;
            // 
            // dsMaintenance
            // 
            this.dsMaintenance.DataSetName = "dsMaintenance";
            this.dsMaintenance.Locale = new System.Globalization.CultureInfo("it-IT");
            this.dsMaintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(20, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipologia Utente CA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tipo_utente_CA
            // 
            this.comboBox_tipo_utente_CA.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_tipo_utente_CA.DataSource = this.cAAnaTipologiaUtenteBindingSource;
            this.comboBox_tipo_utente_CA.DisplayMember = "Descrizione";
            this.comboBox_tipo_utente_CA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_utente_CA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_utente_CA.FormattingEnabled = true;
            this.comboBox_tipo_utente_CA.Location = new System.Drawing.Point(122, 326);
            this.comboBox_tipo_utente_CA.Name = "comboBox_tipo_utente_CA";
            this.comboBox_tipo_utente_CA.Size = new System.Drawing.Size(100, 21);
            this.comboBox_tipo_utente_CA.TabIndex = 13;
            this.comboBox_tipo_utente_CA.ValueMember = "TipoUtenteKey";
            // 
            // cAAnaTipologiaUtenteBindingSource
            // 
            this.cAAnaTipologiaUtenteBindingSource.DataMember = "CA_Ana_TipologiaUtente";
            this.cAAnaTipologiaUtenteBindingSource.DataSource = this.dsMaintenance;
            // 
            // checkBox_p_valori
            // 
            this.checkBox_p_valori.AutoSize = true;
            this.checkBox_p_valori.ForeColor = System.Drawing.Color.White;
            this.checkBox_p_valori.Location = new System.Drawing.Point(485, 410);
            this.checkBox_p_valori.Name = "checkBox_p_valori";
            this.checkBox_p_valori.Size = new System.Drawing.Size(52, 17);
            this.checkBox_p_valori.TabIndex = 11;
            this.checkBox_p_valori.Text = "Valori";
            this.checkBox_p_valori.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add.BackgroundImage")));
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(691, 258);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(34, 30);
            this.button_add.TabIndex = 10;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(506, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Visibilità ordini di acquisto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(856, 24);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new_user
            // 
            this.button_new_user.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_user.Location = new System.Drawing.Point(766, 24);
            this.button_new_user.Name = "button_new_user";
            this.button_new_user.Size = new System.Drawing.Size(75, 23);
            this.button_new_user.TabIndex = 7;
            this.button_new_user.Text = "New";
            this.button_new_user.UseVisualStyleBackColor = true;
            this.button_new_user.Click += new System.EventHandler(this.button_new_user_Click);
            // 
            // dbDataGridView_p_cdr
            // 
            this.dbDataGridView_p_cdr.AllowUserToAddRows = false;
            this.dbDataGridView_p_cdr.AllowUserToDeleteRows = false;
            this.dbDataGridView_p_cdr.AutoGenerateColumns = false;
            this.dbDataGridView_p_cdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_p_cdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responsDataGridViewTextBoxColumn,
            this.responsabileDataGridViewTextBoxColumn});
            this.dbDataGridView_p_cdr.DataSource = this.cdRBindingSource;
            this.dbDataGridView_p_cdr.Location = new System.Drawing.Point(485, 278);
            this.dbDataGridView_p_cdr.MultiSelect = false;
            this.dbDataGridView_p_cdr.Name = "dbDataGridView_p_cdr";
            this.dbDataGridView_p_cdr.ReadOnly = true;
            this.dbDataGridView_p_cdr.RowHeadersVisible = false;
            this.dbDataGridView_p_cdr.Size = new System.Drawing.Size(200, 122);
            this.dbDataGridView_p_cdr.TabIndex = 6;
            this.dbDataGridView_p_cdr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_rep_ass_MouseDoubleClick);
            // 
            // responsDataGridViewTextBoxColumn
            // 
            this.responsDataGridViewTextBoxColumn.DataPropertyName = "respons";
            this.responsDataGridViewTextBoxColumn.HeaderText = "CdR";
            this.responsDataGridViewTextBoxColumn.Name = "responsDataGridViewTextBoxColumn";
            this.responsDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsDataGridViewTextBoxColumn.Width = 40;
            // 
            // responsabileDataGridViewTextBoxColumn
            // 
            this.responsabileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responsabileDataGridViewTextBoxColumn.DataPropertyName = "responsabile";
            this.responsabileDataGridViewTextBoxColumn.HeaderText = "Responsabile";
            this.responsabileDataGridViewTextBoxColumn.Name = "responsabileDataGridViewTextBoxColumn";
            this.responsabileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cdRBindingSource
            // 
            this.cdRBindingSource.DataMember = "CdR";
            this.cdRBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // dsPurchaseOrder
            // 
            this.dsPurchaseOrder.DataSetName = "dsPurchaseOrder";
            this.dsPurchaseOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDataGridView_p_ass
            // 
            this.dbDataGridView_p_ass.AllowUserToAddRows = false;
            this.dbDataGridView_p_ass.AllowUserToDeleteRows = false;
            this.dbDataGridView_p_ass.AutoGenerateColumns = false;
            this.dbDataGridView_p_ass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_p_ass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdrAbilitatoDataGridViewTextBoxColumn,
            this.utenteAbilitatoDataGridViewTextBoxColumn,
            this.valoriDataGridViewCheckBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn,
            this.utenteDataGridViewTextBoxColumn});
            this.dbDataGridView_p_ass.DataSource = this.ordiniAcqVisibilityBindingSource;
            this.dbDataGridView_p_ass.Location = new System.Drawing.Point(731, 149);
            this.dbDataGridView_p_ass.Name = "dbDataGridView_p_ass";
            this.dbDataGridView_p_ass.ReadOnly = true;
            this.dbDataGridView_p_ass.RowHeadersVisible = false;
            this.dbDataGridView_p_ass.Size = new System.Drawing.Size(200, 278);
            this.dbDataGridView_p_ass.TabIndex = 6;
            this.dbDataGridView_p_ass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_p_ass_MouseDoubleClick);
            // 
            // cdrAbilitatoDataGridViewTextBoxColumn
            // 
            this.cdrAbilitatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdrAbilitatoDataGridViewTextBoxColumn.DataPropertyName = "CdrAbilitato";
            this.cdrAbilitatoDataGridViewTextBoxColumn.HeaderText = "CdR";
            this.cdrAbilitatoDataGridViewTextBoxColumn.Name = "cdrAbilitatoDataGridViewTextBoxColumn";
            this.cdrAbilitatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utenteAbilitatoDataGridViewTextBoxColumn
            // 
            this.utenteAbilitatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.utenteAbilitatoDataGridViewTextBoxColumn.DataPropertyName = "UtenteAbilitato";
            this.utenteAbilitatoDataGridViewTextBoxColumn.HeaderText = "Richiedente";
            this.utenteAbilitatoDataGridViewTextBoxColumn.Name = "utenteAbilitatoDataGridViewTextBoxColumn";
            this.utenteAbilitatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoriDataGridViewCheckBoxColumn
            // 
            this.valoriDataGridViewCheckBoxColumn.DataPropertyName = "Valori";
            this.valoriDataGridViewCheckBoxColumn.HeaderText = "Valori";
            this.valoriDataGridViewCheckBoxColumn.Name = "valoriDataGridViewCheckBoxColumn";
            this.valoriDataGridViewCheckBoxColumn.ReadOnly = true;
            this.valoriDataGridViewCheckBoxColumn.Width = 40;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timestampDataGridViewTextBoxColumn.Visible = false;
            // 
            // utenteDataGridViewTextBoxColumn
            // 
            this.utenteDataGridViewTextBoxColumn.DataPropertyName = "Utente";
            this.utenteDataGridViewTextBoxColumn.HeaderText = "Utente";
            this.utenteDataGridViewTextBoxColumn.Name = "utenteDataGridViewTextBoxColumn";
            this.utenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.utenteDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordiniAcqVisibilityBindingSource
            // 
            this.ordiniAcqVisibilityBindingSource.DataMember = "OrdiniAcq_Visibility";
            this.ordiniAcqVisibilityBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // dbDataGridView_rep_ass
            // 
            this.dbDataGridView_rep_ass.AllowUserToAddRows = false;
            this.dbDataGridView_rep_ass.AllowUserToDeleteRows = false;
            this.dbDataGridView_rep_ass.AutoGenerateColumns = false;
            this.dbDataGridView_rep_ass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_rep_ass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoRepNameDataGridViewTextBoxColumn1,
            this.tipoRepKeyDataGridViewTextBoxColumn1});
            this.dbDataGridView_rep_ass.DataSource = this.utentiRepartiBindingSource;
            this.dbDataGridView_rep_ass.Location = new System.Drawing.Point(238, 277);
            this.dbDataGridView_rep_ass.MultiSelect = false;
            this.dbDataGridView_rep_ass.Name = "dbDataGridView_rep_ass";
            this.dbDataGridView_rep_ass.ReadOnly = true;
            this.dbDataGridView_rep_ass.RowHeadersVisible = false;
            this.dbDataGridView_rep_ass.Size = new System.Drawing.Size(190, 119);
            this.dbDataGridView_rep_ass.TabIndex = 6;
            this.dbDataGridView_rep_ass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_rep_ass_MouseDoubleClick);
            // 
            // tipoRepNameDataGridViewTextBoxColumn1
            // 
            this.tipoRepNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoRepNameDataGridViewTextBoxColumn1.DataPropertyName = "TipoRepName";
            this.tipoRepNameDataGridViewTextBoxColumn1.HeaderText = "Tipologia Reparto Assegnate";
            this.tipoRepNameDataGridViewTextBoxColumn1.Name = "tipoRepNameDataGridViewTextBoxColumn1";
            this.tipoRepNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoRepKeyDataGridViewTextBoxColumn1
            // 
            this.tipoRepKeyDataGridViewTextBoxColumn1.DataPropertyName = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn1.HeaderText = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn1.Name = "tipoRepKeyDataGridViewTextBoxColumn1";
            this.tipoRepKeyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipoRepKeyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // utentiRepartiBindingSource
            // 
            this.utentiRepartiBindingSource.DataMember = "Utenti_Reparti";
            this.utentiRepartiBindingSource.DataSource = this.dsMaintenance;
            // 
            // dbDataGridView_p_rich
            // 
            this.dbDataGridView_p_rich.AllowUserToAddRows = false;
            this.dbDataGridView_p_rich.AllowUserToDeleteRows = false;
            this.dbDataGridView_p_rich.AutoGenerateColumns = false;
            this.dbDataGridView_p_rich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_p_rich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.richiedenteDataGridViewTextBoxColumn});
            this.dbDataGridView_p_rich.DataSource = this.richiedentiBindingSource;
            this.dbDataGridView_p_rich.Location = new System.Drawing.Point(485, 150);
            this.dbDataGridView_p_rich.MultiSelect = false;
            this.dbDataGridView_p_rich.Name = "dbDataGridView_p_rich";
            this.dbDataGridView_p_rich.ReadOnly = true;
            this.dbDataGridView_p_rich.RowHeadersVisible = false;
            this.dbDataGridView_p_rich.Size = new System.Drawing.Size(200, 122);
            this.dbDataGridView_p_rich.TabIndex = 5;
            this.dbDataGridView_p_rich.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_rep_disp_MouseDoubleClick);
            // 
            // richiedenteDataGridViewTextBoxColumn
            // 
            this.richiedenteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.richiedenteDataGridViewTextBoxColumn.DataPropertyName = "richiedente";
            this.richiedenteDataGridViewTextBoxColumn.HeaderText = "Richiedente";
            this.richiedenteDataGridViewTextBoxColumn.Name = "richiedenteDataGridViewTextBoxColumn";
            this.richiedenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // richiedentiBindingSource
            // 
            this.richiedentiBindingSource.DataMember = "Richiedenti";
            this.richiedentiBindingSource.DataSource = this.dsPurchaseOrder;
            // 
            // dbDataGridView_rep_disp
            // 
            this.dbDataGridView_rep_disp.AllowUserToAddRows = false;
            this.dbDataGridView_rep_disp.AllowUserToDeleteRows = false;
            this.dbDataGridView_rep_disp.AutoGenerateColumns = false;
            this.dbDataGridView_rep_disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_rep_disp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoRepNameDataGridViewTextBoxColumn,
            this.translationUIDDataGridViewTextBoxColumn,
            this.tipoRepKeyDataGridViewTextBoxColumn,
            this.CDRTextBoxColumn});
            this.dbDataGridView_rep_disp.DataSource = this.manAnaTipoRepartoBindingSource;
            this.dbDataGridView_rep_disp.Location = new System.Drawing.Point(238, 148);
            this.dbDataGridView_rep_disp.MultiSelect = false;
            this.dbDataGridView_rep_disp.Name = "dbDataGridView_rep_disp";
            this.dbDataGridView_rep_disp.ReadOnly = true;
            this.dbDataGridView_rep_disp.RowHeadersVisible = false;
            this.dbDataGridView_rep_disp.Size = new System.Drawing.Size(190, 118);
            this.dbDataGridView_rep_disp.TabIndex = 5;
            this.dbDataGridView_rep_disp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_rep_disp_MouseDoubleClick);
            // 
            // manAnaTipoRepartoBindingSource
            // 
            this.manAnaTipoRepartoBindingSource.DataMember = "Man_Ana_Tipo_Reparto";
            this.manAnaTipoRepartoBindingSource.DataSource = this.dsMaintenance;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(29, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Stato Record";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(29, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Azienda";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(29, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tipologia Utente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(29, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lingua predefinita";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(29, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome nel Dominio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestione Anagrafica Utenti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_stato_record
            // 
            this.comboBox_stato_record.DataSource = this.manAnaStatoRecordBindingSource;
            this.comboBox_stato_record.DisplayMember = "StatoRecName";
            this.comboBox_stato_record.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stato_record.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_stato_record.FormattingEnabled = true;
            this.comboBox_stato_record.Location = new System.Drawing.Point(122, 380);
            this.comboBox_stato_record.Name = "comboBox_stato_record";
            this.comboBox_stato_record.Size = new System.Drawing.Size(100, 21);
            this.comboBox_stato_record.TabIndex = 7;
            this.comboBox_stato_record.ValueMember = "StatoRecKey";
            // 
            // manAnaStatoRecordBindingSource
            // 
            this.manAnaStatoRecordBindingSource.DataMember = "Man_Ana_Stato_Record";
            this.manAnaStatoRecordBindingSource.DataSource = this.dsMaintenance;
            // 
            // comboBox_azienda
            // 
            this.comboBox_azienda.DataSource = this.manAnaAZIBindingSource;
            this.comboBox_azienda.DisplayMember = "AZIName";
            this.comboBox_azienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_azienda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_azienda.FormattingEnabled = true;
            this.comboBox_azienda.Location = new System.Drawing.Point(122, 299);
            this.comboBox_azienda.Name = "comboBox_azienda";
            this.comboBox_azienda.Size = new System.Drawing.Size(100, 21);
            this.comboBox_azienda.TabIndex = 6;
            this.comboBox_azienda.ValueMember = "AZIKey";
            // 
            // manAnaAZIBindingSource
            // 
            this.manAnaAZIBindingSource.DataMember = "Man_Ana_AZI";
            this.manAnaAZIBindingSource.DataSource = this.dsMaintenance;
            // 
            // comboBox_tipo_utente
            // 
            this.comboBox_tipo_utente.DataSource = this.manAnaTipoUtenteBindingSource;
            this.comboBox_tipo_utente.DisplayMember = "TipoUteName";
            this.comboBox_tipo_utente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_utente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_utente.FormattingEnabled = true;
            this.comboBox_tipo_utente.Location = new System.Drawing.Point(122, 272);
            this.comboBox_tipo_utente.Name = "comboBox_tipo_utente";
            this.comboBox_tipo_utente.Size = new System.Drawing.Size(100, 21);
            this.comboBox_tipo_utente.TabIndex = 5;
            this.comboBox_tipo_utente.ValueMember = "TipoUteKey";
            this.comboBox_tipo_utente.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_utente_SelectedIndexChanged);
            // 
            // manAnaTipoUtenteBindingSource
            // 
            this.manAnaTipoUtenteBindingSource.DataMember = "Man_Ana_Tipo_Utente";
            this.manAnaTipoUtenteBindingSource.DataSource = this.dsMaintenance;
            // 
            // comboBox_lingua
            // 
            this.comboBox_lingua.DataSource = this.manAnaLANBindingSource;
            this.comboBox_lingua.DisplayMember = "LANName";
            this.comboBox_lingua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lingua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lingua.FormattingEnabled = true;
            this.comboBox_lingua.Location = new System.Drawing.Point(122, 245);
            this.comboBox_lingua.Name = "comboBox_lingua";
            this.comboBox_lingua.Size = new System.Drawing.Size(100, 21);
            this.comboBox_lingua.TabIndex = 4;
            this.comboBox_lingua.ValueMember = "LANKey";
            // 
            // manAnaLANBindingSource
            // 
            this.manAnaLANBindingSource.DataMember = "Man_Ana_LAN";
            this.manAnaLANBindingSource.DataSource = this.dsMaintenance;
            // 
            // button_reset_password
            // 
            this.button_reset_password.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset_password.Location = new System.Drawing.Point(122, 414);
            this.button_reset_password.Name = "button_reset_password";
            this.button_reset_password.Size = new System.Drawing.Size(100, 23);
            this.button_reset_password.TabIndex = 2;
            this.button_reset_password.Text = "Reset Password";
            this.button_reset_password.UseVisualStyleBackColor = true;
            this.button_reset_password.Click += new System.EventHandler(this.button_reset_password_Click);
            // 
            // textBox_nome_dominio
            // 
            this.textBox_nome_dominio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome_dominio.Location = new System.Drawing.Point(122, 213);
            this.textBox_nome_dominio.Name = "textBox_nome_dominio";
            this.textBox_nome_dominio.Size = new System.Drawing.Size(100, 21);
            this.textBox_nome_dominio.TabIndex = 3;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(122, 181);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 21);
            this.textBox_nome.TabIndex = 2;
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_login.Location = new System.Drawing.Point(122, 149);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.ReadOnly = true;
            this.textBox_login.Size = new System.Drawing.Size(100, 21);
            this.textBox_login.TabIndex = 1;
            // 
            // comboBox_utente
            // 
            this.comboBox_utente.DataSource = this.manAnaUTEBindingSource;
            this.comboBox_utente.DisplayMember = "UTELogin";
            this.comboBox_utente.DropDownHeight = 190;
            this.comboBox_utente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_utente.FormattingEnabled = true;
            this.comboBox_utente.IntegralHeight = false;
            this.comboBox_utente.Location = new System.Drawing.Point(766, 53);
            this.comboBox_utente.Name = "comboBox_utente";
            this.comboBox_utente.Size = new System.Drawing.Size(165, 21);
            this.comboBox_utente.TabIndex = 0;
            this.comboBox_utente.ValueMember = "UTEKey";
            this.comboBox_utente.SelectedIndexChanged += new System.EventHandler(this.comboBox_utente_SelectedIndexChanged);
            // 
            // manAnaUTEBindingSource
            // 
            this.manAnaUTEBindingSource.DataMember = "Man_Ana_UTE";
            this.manAnaUTEBindingSource.DataSource = this.dsMaintenance;
            // 
            // man_Ana_Tipo_RepartoTableAdapter
            // 
            this.man_Ana_Tipo_RepartoTableAdapter.ClearBeforeFill = true;
            // 
            // utenti_RepartiTableAdapter
            // 
            this.utenti_RepartiTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_UTETableAdapter
            // 
            this.man_Ana_UTETableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_LANTableAdapter
            // 
            this.man_Ana_LANTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_Tipo_UtenteTableAdapter
            // 
            this.man_Ana_Tipo_UtenteTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_AZITableAdapter
            // 
            this.man_Ana_AZITableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_Stato_RecordTableAdapter
            // 
            this.man_Ana_Stato_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // richiedentiTableAdapter
            // 
            this.richiedentiTableAdapter.ClearBeforeFill = true;
            // 
            // cdRTableAdapter
            // 
            this.cdRTableAdapter.ClearBeforeFill = true;
            // 
            // ordiniAcq_VisibilityTableAdapter
            // 
            this.ordiniAcq_VisibilityTableAdapter.ClearBeforeFill = true;
            // 
            // cA_Ana_TipologiaUtenteTableAdapter
            // 
            this.cA_Ana_TipologiaUtenteTableAdapter.ClearBeforeFill = true;
            // 
            // cA_Ana_CDRTableAdapter
            // 
            this.cA_Ana_CDRTableAdapter.ClearBeforeFill = true;
            // 
            // tipoRepNameDataGridViewTextBoxColumn
            // 
            this.tipoRepNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoRepNameDataGridViewTextBoxColumn.DataPropertyName = "TipoRepName";
            this.tipoRepNameDataGridViewTextBoxColumn.HeaderText = "Tipologia Reparto Disponibili";
            this.tipoRepNameDataGridViewTextBoxColumn.Name = "tipoRepNameDataGridViewTextBoxColumn";
            this.tipoRepNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // translationUIDDataGridViewTextBoxColumn
            // 
            this.translationUIDDataGridViewTextBoxColumn.DataPropertyName = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.HeaderText = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.Name = "translationUIDDataGridViewTextBoxColumn";
            this.translationUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.translationUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoRepKeyDataGridViewTextBoxColumn
            // 
            this.tipoRepKeyDataGridViewTextBoxColumn.DataPropertyName = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn.HeaderText = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn.Name = "tipoRepKeyDataGridViewTextBoxColumn";
            this.tipoRepKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoRepKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // CDRTextBoxColumn
            // 
            this.CDRTextBoxColumn.DataPropertyName = "CDR";
            this.CDRTextBoxColumn.HeaderText = "CDR";
            this.CDRTextBoxColumn.Name = "CDRTextBoxColumn";
            this.CDRTextBoxColumn.ReadOnly = true;
            this.CDRTextBoxColumn.Width = 70;
            // 
            // CtrlManUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlManUtenti";
            this.Size = new System.Drawing.Size(1160, 585);
            this.dbTableLayoutPanel2.ResumeLayout(false);
            this.dbPanel_utenti.ResumeLayout(false);
            this.dbPanel_utenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAAnaCDRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAAnaTipologiaUtenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_cdr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_ass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordiniAcqVisibilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_rep_ass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiRepartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_p_rich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richiedentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_rep_disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoRepartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaAZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoUtenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel dbPanel_utenti;
        private System.Windows.Forms.ComboBox comboBox_utente;
        private DBTableLayoutPanel dbTableLayoutPanel2;
        private DBDataGridView dbDataGridView_rep_ass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepKeyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource utentiRepartiBindingSource;
        private DataSet.dsMaintenance dsMaintenance;
        private DBDataGridView dbDataGridView_rep_disp;
        private System.Windows.Forms.BindingSource manAnaTipoRepartoBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_stato_record;
        private System.Windows.Forms.ComboBox comboBox_azienda;
        private System.Windows.Forms.ComboBox comboBox_tipo_utente;
        private System.Windows.Forms.ComboBox comboBox_lingua;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.BindingSource manAnaUTEBindingSource;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_RepartoTableAdapter man_Ana_Tipo_RepartoTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Utenti_RepartiTableAdapter utenti_RepartiTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_UTETableAdapter man_Ana_UTETableAdapter;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_new_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nome_dominio;
        private System.Windows.Forms.BindingSource manAnaStatoRecordBindingSource;
        private System.Windows.Forms.BindingSource manAnaAZIBindingSource;
        private System.Windows.Forms.BindingSource manAnaTipoUtenteBindingSource;
        private System.Windows.Forms.BindingSource manAnaLANBindingSource;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_LANTableAdapter man_Ana_LANTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_UtenteTableAdapter man_Ana_Tipo_UtenteTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_AZITableAdapter man_Ana_AZITableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_Stato_RecordTableAdapter man_Ana_Stato_RecordTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset_password;
        private DBDataGridView dbDataGridView_p_cdr;
        private DBDataGridView dbDataGridView_p_ass;
        private DBDataGridView dbDataGridView_p_rich;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cdRBindingSource;
        private DataSet.dsPurchaseOrder dsPurchaseOrder;
        private System.Windows.Forms.BindingSource ordiniAcqVisibilityBindingSource;
        private System.Windows.Forms.BindingSource richiedentiBindingSource;
        private DataSet.dsPurchaseOrderTableAdapters.RichiedentiTableAdapter richiedentiTableAdapter;
        private DataSet.dsPurchaseOrderTableAdapters.CdRTableAdapter cdRTableAdapter;
        private DataSet.dsPurchaseOrderTableAdapters.OrdiniAcq_VisibilityTableAdapter ordiniAcq_VisibilityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdrAbilitatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utenteAbilitatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valoriDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn richiedenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox_p_valori;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsabileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo_utente_CA;
        private System.Windows.Forms.BindingSource cAAnaTipologiaUtenteBindingSource;
        private DataSet.dsMaintenanceTableAdapters.CA_Ana_TipologiaUtenteTableAdapter cA_Ana_TipologiaUtenteTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_Centro_Di_Responsabilità;
        private System.Windows.Forms.BindingSource cAAnaCDRBindingSource;
        private DataSet.dsMaintenanceTableAdapters.CA_Ana_CDRTableAdapter cA_Ana_CDRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDRTextBoxColumn;
    }
}
