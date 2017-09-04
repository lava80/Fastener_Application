namespace Fastener.Controlli
{
    partial class CtrlEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEvent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_descr = new System.Windows.Forms.TextBox();
            this.comboBox_rep = new System.Windows.Forms.ComboBox();
            this.tipoRepartoTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEvents = new Fastener.DataSet.dsEvents();
            this.comboBox_ute = new System.Windows.Forms.ComboBox();
            this.manAnaUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlDateTimePicker_start = new Fastener.Controlli.CtrlDateTimePicker();
            this.ctrlDateTimePicker_end = new Fastener.Controlli.CtrlDateTimePicker();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.comboBox_man = new System.Windows.Forms.ComboBox();
            this.tipoManutenzioneTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlPlantSelector = new Fastener.Controlli.CtrlPlantSelector();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_contratto = new System.Windows.Forms.TextBox();
            this.comboBox_stato_rec = new System.Windows.Forms.ComboBox();
            this.manAnaStatoRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_new_event = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dbDataGridView_teste = new Fastener.DBDataGridView(this.components);
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTEName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReparto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoManutenzione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventContractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTEKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statoRecKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRepKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoManKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventiTestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbPanel3 = new Fastener.DBPanel(this.components);
            this.button_modifica_righe = new System.Windows.Forms.Button();
            this.button_aggiungi_righe = new System.Windows.Forms.Button();
            this.textBox_remaining = new System.Windows.Forms.TextBox();
            this.textBox_driver = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dbDataGridView_righe = new Fastener.DBDataGridView(this.components);
            this.driverPercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventRowKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventiRigheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTableLayoutPanel1 = new Fastener.DBTableLayoutPanel(this.components);
            this.eventiTestaTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.EventiTestaTableAdapter();
            this.eventiRigheTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.EventiRigheTableAdapter();
            this.contextMenuStrip_teste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancellaRecordSelezionatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_righe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancellaRecordSelezionatiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipo_Reparto_T_ViewTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.Tipo_Reparto_T_ViewTableAdapter();
            this.tipo_Manutenzione_T_ViewTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter();
            this.man_Ana_UTETableAdapter = new Fastener.DataSet.dsEventsTableAdapters.Man_Ana_UTETableAdapter();
            this.man_Ana_Stato_RecordTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.Man_Ana_Stato_RecordTableAdapter();
            this.copiaEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRepartoTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiTestaBindingSource)).BeginInit();
            this.dbPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_righe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiRigheBindingSource)).BeginInit();
            this.dbTableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip_teste.SuspendLayout();
            this.contextMenuStrip_righe.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_descr
            // 
            this.textBox_descr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descr.Location = new System.Drawing.Point(755, 135);
            this.textBox_descr.Multiline = true;
            this.textBox_descr.Name = "textBox_descr";
            this.textBox_descr.Size = new System.Drawing.Size(105, 56);
            this.textBox_descr.TabIndex = 0;
            // 
            // comboBox_rep
            // 
            this.comboBox_rep.DataSource = this.tipoRepartoTViewBindingSource;
            this.comboBox_rep.DisplayMember = "LanTranslation";
            this.comboBox_rep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rep.FormattingEnabled = true;
            this.comboBox_rep.Location = new System.Drawing.Point(755, 70);
            this.comboBox_rep.Name = "comboBox_rep";
            this.comboBox_rep.Size = new System.Drawing.Size(105, 22);
            this.comboBox_rep.TabIndex = 1;
            this.comboBox_rep.ValueMember = "TipoRepKey";
            // 
            // tipoRepartoTViewBindingSource
            // 
            this.tipoRepartoTViewBindingSource.DataMember = "Tipo_Reparto_T_View";
            this.tipoRepartoTViewBindingSource.DataSource = this.dsEvents;
            // 
            // dsEvents
            // 
            this.dsEvents.DataSetName = "dsEvents";
            this.dsEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_ute
            // 
            this.comboBox_ute.DataSource = this.manAnaUTEBindingSource;
            this.comboBox_ute.DisplayMember = "UTEName";
            this.comboBox_ute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ute.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ute.FormattingEnabled = true;
            this.comboBox_ute.Location = new System.Drawing.Point(946, 37);
            this.comboBox_ute.Name = "comboBox_ute";
            this.comboBox_ute.Size = new System.Drawing.Size(103, 22);
            this.comboBox_ute.TabIndex = 2;
            this.comboBox_ute.ValueMember = "UTEKey";
            // 
            // manAnaUTEBindingSource
            // 
            this.manAnaUTEBindingSource.DataMember = "Man_Ana_UTE";
            this.manAnaUTEBindingSource.DataSource = this.dsEvents;
            // 
            // ctrlDateTimePicker_start
            // 
            this.ctrlDateTimePicker_start.AutoSize = true;
            this.ctrlDateTimePicker_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_start.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_start.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_start.LabelText = "Inizio";
            this.ctrlDateTimePicker_start.Location = new System.Drawing.Point(627, 224);
            this.ctrlDateTimePicker_start.Name = "ctrlDateTimePicker_start";
            this.ctrlDateTimePicker_start.ShowDate = true;
            this.ctrlDateTimePicker_start.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_start.TabIndex = 3;
            // 
            // ctrlDateTimePicker_end
            // 
            this.ctrlDateTimePicker_end.AutoSize = true;
            this.ctrlDateTimePicker_end.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_end.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_end.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_end.LabelText = "Fine";
            this.ctrlDateTimePicker_end.Location = new System.Drawing.Point(849, 224);
            this.ctrlDateTimePicker_end.Name = "ctrlDateTimePicker_end";
            this.ctrlDateTimePicker_end.ShowDate = true;
            this.ctrlDateTimePicker_end.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_end.TabIndex = 4;
            // 
            // textBox_note
            // 
            this.textBox_note.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_note.Location = new System.Drawing.Point(946, 135);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(103, 56);
            this.textBox_note.TabIndex = 0;
            // 
            // comboBox_man
            // 
            this.comboBox_man.DataSource = this.tipoManutenzioneTViewBindingSource;
            this.comboBox_man.DisplayMember = "LanTranslation";
            this.comboBox_man.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_man.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_man.FormattingEnabled = true;
            this.comboBox_man.Location = new System.Drawing.Point(755, 102);
            this.comboBox_man.Name = "comboBox_man";
            this.comboBox_man.Size = new System.Drawing.Size(105, 22);
            this.comboBox_man.TabIndex = 2;
            this.comboBox_man.ValueMember = "TipoManKey";
            // 
            // tipoManutenzioneTViewBindingSource
            // 
            this.tipoManutenzioneTViewBindingSource.DataMember = "Tipo_Manutenzione_T_View";
            this.tipoManutenzioneTViewBindingSource.DataSource = this.dsEvents;
            // 
            // ctrlPlantSelector
            // 
            this.ctrlPlantSelector.AutoSize = true;
            this.ctrlPlantSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPlantSelector.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPlantSelector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctrlPlantSelector.Location = new System.Drawing.Point(755, 421);
            this.ctrlPlantSelector.Name = "ctrlPlantSelector";
            this.ctrlPlantSelector.Size = new System.Drawing.Size(276, 98);
            this.ctrlPlantSelector.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(861, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 50);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stato Record";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(880, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Utente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(881, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Note";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(651, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 51);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo Manutenzione";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(651, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Reparto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(651, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contratto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(642, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrizione Evento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_contratto
            // 
            this.textBox_contratto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contratto.Location = new System.Drawing.Point(755, 37);
            this.textBox_contratto.Name = "textBox_contratto";
            this.textBox_contratto.Size = new System.Drawing.Size(105, 22);
            this.textBox_contratto.TabIndex = 0;
            // 
            // comboBox_stato_rec
            // 
            this.comboBox_stato_rec.DataSource = this.manAnaStatoRecordBindingSource;
            this.comboBox_stato_rec.DisplayMember = "StatoRecName";
            this.comboBox_stato_rec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stato_rec.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_stato_rec.FormattingEnabled = true;
            this.comboBox_stato_rec.Location = new System.Drawing.Point(946, 70);
            this.comboBox_stato_rec.Name = "comboBox_stato_rec";
            this.comboBox_stato_rec.Size = new System.Drawing.Size(105, 22);
            this.comboBox_stato_rec.TabIndex = 2;
            this.comboBox_stato_rec.ValueMember = "StatoRecKey";
            // 
            // manAnaStatoRecordBindingSource
            // 
            this.manAnaStatoRecordBindingSource.DataMember = "Man_Ana_Stato_Record";
            this.manAnaStatoRecordBindingSource.DataSource = this.dsEvents;
            // 
            // button_new_event
            // 
            this.button_new_event.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_event.Location = new System.Drawing.Point(640, 331);
            this.button_new_event.Name = "button_new_event";
            this.button_new_event.Size = new System.Drawing.Size(185, 23);
            this.button_new_event.TabIndex = 10;
            this.button_new_event.Text = "NUOVO EVENTO";
            this.button_new_event.UseVisualStyleBackColor = true;
            this.button_new_event.Click += new System.EventHandler(this.button_new_event_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(864, 331);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(185, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "SALVA EVENTO";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dbDataGridView_teste
            // 
            this.dbDataGridView_teste.AllowUserToAddRows = false;
            this.dbDataGridView_teste.AllowUserToDeleteRows = false;
            this.dbDataGridView_teste.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbDataGridView_teste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbDataGridView_teste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_teste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.startHMSDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.endHMSDataGridViewTextBoxColumn,
            this.UTEName,
            this.TipoReparto,
            this.TipoManutenzione,
            this.eventDescriptionDataGridViewTextBoxColumn,
            this.eventContractNumberDataGridViewTextBoxColumn,
            this.eventRemarkDataGridViewTextBoxColumn,
            this.uTEKeyDataGridViewTextBoxColumn,
            this.statoRecKeyDataGridViewTextBoxColumn,
            this.tipoRepKeyDataGridViewTextBoxColumn,
            this.tipoManKeyDataGridViewTextBoxColumn});
            this.dbDataGridView_teste.DataSource = this.eventiTestaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbDataGridView_teste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dbDataGridView_teste.Location = new System.Drawing.Point(49, 117);
            this.dbDataGridView_teste.Name = "dbDataGridView_teste";
            this.dbDataGridView_teste.ReadOnly = true;
            this.dbDataGridView_teste.RowHeadersVisible = false;
            this.dbDataGridView_teste.Size = new System.Drawing.Size(559, 237);
            this.dbDataGridView_teste.TabIndex = 7;
            this.dbDataGridView_teste.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbDataGridView_teste_CellMouseClick);
            this.dbDataGridView_teste.SelectionChanged += new System.EventHandler(this.dbDataGridView_teste_SelectionChanged);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Inizio";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 65;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 65;
            // 
            // startHMSDataGridViewTextBoxColumn
            // 
            this.startHMSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.startHMSDataGridViewTextBoxColumn.DataPropertyName = "StartHMS";
            this.startHMSDataGridViewTextBoxColumn.HeaderText = "Start HMS";
            this.startHMSDataGridViewTextBoxColumn.MinimumWidth = 55;
            this.startHMSDataGridViewTextBoxColumn.Name = "startHMSDataGridViewTextBoxColumn";
            this.startHMSDataGridViewTextBoxColumn.ReadOnly = true;
            this.startHMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Fine";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 65;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 65;
            // 
            // endHMSDataGridViewTextBoxColumn
            // 
            this.endHMSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.endHMSDataGridViewTextBoxColumn.DataPropertyName = "EndHMS";
            this.endHMSDataGridViewTextBoxColumn.HeaderText = "End HMS";
            this.endHMSDataGridViewTextBoxColumn.MinimumWidth = 55;
            this.endHMSDataGridViewTextBoxColumn.Name = "endHMSDataGridViewTextBoxColumn";
            this.endHMSDataGridViewTextBoxColumn.ReadOnly = true;
            this.endHMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // UTEName
            // 
            this.UTEName.DataPropertyName = "UTEName";
            this.UTEName.HeaderText = "Utente";
            this.UTEName.Name = "UTEName";
            this.UTEName.ReadOnly = true;
            this.UTEName.Visible = false;
            // 
            // TipoReparto
            // 
            this.TipoReparto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoReparto.DataPropertyName = "TipoReparto";
            this.TipoReparto.HeaderText = "Reparto";
            this.TipoReparto.Name = "TipoReparto";
            this.TipoReparto.ReadOnly = true;
            this.TipoReparto.Width = 70;
            // 
            // TipoManutenzione
            // 
            this.TipoManutenzione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoManutenzione.DataPropertyName = "TipoManutenzione";
            this.TipoManutenzione.HeaderText = "Tipo Man";
            this.TipoManutenzione.Name = "TipoManutenzione";
            this.TipoManutenzione.ReadOnly = true;
            this.TipoManutenzione.Width = 77;
            // 
            // eventDescriptionDataGridViewTextBoxColumn
            // 
            this.eventDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.eventDescriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
            this.eventDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventContractNumberDataGridViewTextBoxColumn
            // 
            this.eventContractNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eventContractNumberDataGridViewTextBoxColumn.DataPropertyName = "EventContractNumber";
            this.eventContractNumberDataGridViewTextBoxColumn.HeaderText = "Contratto";
            this.eventContractNumberDataGridViewTextBoxColumn.Name = "eventContractNumberDataGridViewTextBoxColumn";
            this.eventContractNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventContractNumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // eventRemarkDataGridViewTextBoxColumn
            // 
            this.eventRemarkDataGridViewTextBoxColumn.DataPropertyName = "EventRemark";
            this.eventRemarkDataGridViewTextBoxColumn.HeaderText = "Note";
            this.eventRemarkDataGridViewTextBoxColumn.Name = "eventRemarkDataGridViewTextBoxColumn";
            this.eventRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uTEKeyDataGridViewTextBoxColumn
            // 
            this.uTEKeyDataGridViewTextBoxColumn.DataPropertyName = "UTEKey";
            this.uTEKeyDataGridViewTextBoxColumn.HeaderText = "UTEKey";
            this.uTEKeyDataGridViewTextBoxColumn.Name = "uTEKeyDataGridViewTextBoxColumn";
            this.uTEKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.uTEKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // statoRecKeyDataGridViewTextBoxColumn
            // 
            this.statoRecKeyDataGridViewTextBoxColumn.DataPropertyName = "StatoRecKey";
            this.statoRecKeyDataGridViewTextBoxColumn.HeaderText = "StatoRecKey";
            this.statoRecKeyDataGridViewTextBoxColumn.Name = "statoRecKeyDataGridViewTextBoxColumn";
            this.statoRecKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.statoRecKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoRepKeyDataGridViewTextBoxColumn
            // 
            this.tipoRepKeyDataGridViewTextBoxColumn.DataPropertyName = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn.HeaderText = "TipoRepKey";
            this.tipoRepKeyDataGridViewTextBoxColumn.Name = "tipoRepKeyDataGridViewTextBoxColumn";
            this.tipoRepKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoRepKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoManKeyDataGridViewTextBoxColumn
            // 
            this.tipoManKeyDataGridViewTextBoxColumn.DataPropertyName = "TipoManKey";
            this.tipoManKeyDataGridViewTextBoxColumn.HeaderText = "TipoManKey";
            this.tipoManKeyDataGridViewTextBoxColumn.Name = "tipoManKeyDataGridViewTextBoxColumn";
            this.tipoManKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoManKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventiTestaBindingSource
            // 
            this.eventiTestaBindingSource.DataMember = "EventiTesta";
            this.eventiTestaBindingSource.DataSource = this.dsEvents;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(303, 41);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker_end.TabIndex = 8;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_start.Location = new System.Drawing.Point(170, 41);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker_start.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Validità da ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(284, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "a";
            // 
            // dbPanel3
            // 
            this.dbPanel3.AutoScroll = true;
            this.dbPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbPanel3.BackgroundImage")));
            this.dbPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbPanel3.Controls.Add(this.label9);
            this.dbPanel3.Controls.Add(this.button_modifica_righe);
            this.dbPanel3.Controls.Add(this.label8);
            this.dbPanel3.Controls.Add(this.ctrlDateTimePicker_start);
            this.dbPanel3.Controls.Add(this.label5);
            this.dbPanel3.Controls.Add(this.button_aggiungi_righe);
            this.dbPanel3.Controls.Add(this.label6);
            this.dbPanel3.Controls.Add(this.button_save);
            this.dbPanel3.Controls.Add(this.label4);
            this.dbPanel3.Controls.Add(this.ctrlPlantSelector);
            this.dbPanel3.Controls.Add(this.button_new_event);
            this.dbPanel3.Controls.Add(this.label7);
            this.dbPanel3.Controls.Add(this.label3);
            this.dbPanel3.Controls.Add(this.textBox_remaining);
            this.dbPanel3.Controls.Add(this.textBox_contratto);
            this.dbPanel3.Controls.Add(this.textBox_driver);
            this.dbPanel3.Controls.Add(this.comboBox_stato_rec);
            this.dbPanel3.Controls.Add(this.button_search);
            this.dbPanel3.Controls.Add(this.comboBox_ute);
            this.dbPanel3.Controls.Add(this.label13);
            this.dbPanel3.Controls.Add(this.textBox_descr);
            this.dbPanel3.Controls.Add(this.label12);
            this.dbPanel3.Controls.Add(this.textBox_note);
            this.dbPanel3.Controls.Add(this.label11);
            this.dbPanel3.Controls.Add(this.label10);
            this.dbPanel3.Controls.Add(this.label1);
            this.dbPanel3.Controls.Add(this.comboBox_rep);
            this.dbPanel3.Controls.Add(this.dbDataGridView_righe);
            this.dbPanel3.Controls.Add(this.comboBox_man);
            this.dbPanel3.Controls.Add(this.label2);
            this.dbPanel3.Controls.Add(this.ctrlDateTimePicker_end);
            this.dbPanel3.Controls.Add(this.dbDataGridView_teste);
            this.dbPanel3.Controls.Add(this.dateTimePicker_start);
            this.dbPanel3.Controls.Add(this.dateTimePicker_end);
            this.dbPanel3.Location = new System.Drawing.Point(20, 85);
            this.dbPanel3.Name = "dbPanel3";
            this.dbPanel3.Size = new System.Drawing.Size(1101, 704);
            this.dbPanel3.TabIndex = 10;
            // 
            // button_modifica_righe
            // 
            this.button_modifica_righe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifica_righe.Location = new System.Drawing.Point(769, 646);
            this.button_modifica_righe.Name = "button_modifica_righe";
            this.button_modifica_righe.Size = new System.Drawing.Size(130, 23);
            this.button_modifica_righe.TabIndex = 10;
            this.button_modifica_righe.Text = "MODIFICA";
            this.button_modifica_righe.UseVisualStyleBackColor = true;
            this.button_modifica_righe.Click += new System.EventHandler(this.button_modifica_righe_Click);
            // 
            // button_aggiungi_righe
            // 
            this.button_aggiungi_righe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aggiungi_righe.Location = new System.Drawing.Point(916, 646);
            this.button_aggiungi_righe.Name = "button_aggiungi_righe";
            this.button_aggiungi_righe.Size = new System.Drawing.Size(130, 23);
            this.button_aggiungi_righe.TabIndex = 10;
            this.button_aggiungi_righe.Text = "AGGIUNGI";
            this.button_aggiungi_righe.UseVisualStyleBackColor = true;
            this.button_aggiungi_righe.Click += new System.EventHandler(this.button_aggiungi_righe_Click);
            // 
            // textBox_remaining
            // 
            this.textBox_remaining.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_remaining.Enabled = false;
            this.textBox_remaining.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_remaining.ForeColor = System.Drawing.Color.Black;
            this.textBox_remaining.Location = new System.Drawing.Point(984, 381);
            this.textBox_remaining.Multiline = true;
            this.textBox_remaining.Name = "textBox_remaining";
            this.textBox_remaining.ReadOnly = true;
            this.textBox_remaining.Size = new System.Drawing.Size(62, 34);
            this.textBox_remaining.TabIndex = 0;
            this.textBox_remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_driver
            // 
            this.textBox_driver.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBox_driver.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_driver.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_driver.Location = new System.Drawing.Point(884, 381);
            this.textBox_driver.Multiline = true;
            this.textBox_driver.Name = "textBox_driver";
            this.textBox_driver.Size = new System.Drawing.Size(62, 34);
            this.textBox_driver.TabIndex = 0;
            this.textBox_driver.Text = "20";
            this.textBox_driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(471, 41);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(137, 22);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "RICERCA";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(950, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 34);
            this.label13.TabIndex = 9;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(811, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 45);
            this.label12.TabIndex = 9;
            this.label12.Text = "Driver";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(49, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(689, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dettaglio evento selezionato";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(49, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(559, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Eventi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbDataGridView_righe
            // 
            this.dbDataGridView_righe.AllowUserToAddRows = false;
            this.dbDataGridView_righe.AllowUserToDeleteRows = false;
            this.dbDataGridView_righe.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbDataGridView_righe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dbDataGridView_righe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_righe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverPercDataGridViewTextBoxColumn,
            this.impDataGridViewTextBoxColumn,
            this.macDataGridViewTextBoxColumn,
            this.comDataGridViewTextBoxColumn,
            this.sCM1DataGridViewTextBoxColumn,
            this.sCM2DataGridViewTextBoxColumn,
            this.sCM3DataGridViewTextBoxColumn,
            this.filler,
            this.eventKeyDataGridViewTextBoxColumn,
            this.eventRowKeyDataGridViewTextBoxColumn});
            this.dbDataGridView_righe.DataSource = this.eventiRigheBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbDataGridView_righe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dbDataGridView_righe.Location = new System.Drawing.Point(49, 400);
            this.dbDataGridView_righe.Name = "dbDataGridView_righe";
            this.dbDataGridView_righe.ReadOnly = true;
            this.dbDataGridView_righe.RowHeadersVisible = false;
            this.dbDataGridView_righe.Size = new System.Drawing.Size(689, 267);
            this.dbDataGridView_righe.TabIndex = 7;
            this.dbDataGridView_righe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbDataGridView_righe_CellMouseClick);
            this.dbDataGridView_righe.SelectionChanged += new System.EventHandler(this.dbDataGridView_righe_SelectionChanged);
            // 
            // driverPercDataGridViewTextBoxColumn
            // 
            this.driverPercDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.driverPercDataGridViewTextBoxColumn.DataPropertyName = "DriverPerc";
            this.driverPercDataGridViewTextBoxColumn.HeaderText = "Perc";
            this.driverPercDataGridViewTextBoxColumn.Name = "driverPercDataGridViewTextBoxColumn";
            this.driverPercDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverPercDataGridViewTextBoxColumn.Width = 54;
            // 
            // impDataGridViewTextBoxColumn
            // 
            this.impDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.impDataGridViewTextBoxColumn.DataPropertyName = "Imp";
            this.impDataGridViewTextBoxColumn.HeaderText = "Impianto";
            this.impDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.impDataGridViewTextBoxColumn.Name = "impDataGridViewTextBoxColumn";
            this.impDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macDataGridViewTextBoxColumn
            // 
            this.macDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.macDataGridViewTextBoxColumn.DataPropertyName = "Mac";
            this.macDataGridViewTextBoxColumn.HeaderText = "Macchina";
            this.macDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.macDataGridViewTextBoxColumn.Name = "macDataGridViewTextBoxColumn";
            this.macDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comDataGridViewTextBoxColumn
            // 
            this.comDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.comDataGridViewTextBoxColumn.DataPropertyName = "Com";
            this.comDataGridViewTextBoxColumn.HeaderText = "Componente";
            this.comDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.comDataGridViewTextBoxColumn.Name = "comDataGridViewTextBoxColumn";
            this.comDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCM1DataGridViewTextBoxColumn
            // 
            this.sCM1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sCM1DataGridViewTextBoxColumn.DataPropertyName = "SCM_1";
            this.sCM1DataGridViewTextBoxColumn.HeaderText = "Sotto Componente 1";
            this.sCM1DataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sCM1DataGridViewTextBoxColumn.Name = "sCM1DataGridViewTextBoxColumn";
            this.sCM1DataGridViewTextBoxColumn.ReadOnly = true;
            this.sCM1DataGridViewTextBoxColumn.Width = 118;
            // 
            // sCM2DataGridViewTextBoxColumn
            // 
            this.sCM2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sCM2DataGridViewTextBoxColumn.DataPropertyName = "SCM_2";
            this.sCM2DataGridViewTextBoxColumn.HeaderText = "Sotto Componente 2";
            this.sCM2DataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sCM2DataGridViewTextBoxColumn.Name = "sCM2DataGridViewTextBoxColumn";
            this.sCM2DataGridViewTextBoxColumn.ReadOnly = true;
            this.sCM2DataGridViewTextBoxColumn.Width = 118;
            // 
            // sCM3DataGridViewTextBoxColumn
            // 
            this.sCM3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sCM3DataGridViewTextBoxColumn.DataPropertyName = "SCM_3";
            this.sCM3DataGridViewTextBoxColumn.HeaderText = "Sotto Componente 3";
            this.sCM3DataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sCM3DataGridViewTextBoxColumn.Name = "sCM3DataGridViewTextBoxColumn";
            this.sCM3DataGridViewTextBoxColumn.ReadOnly = true;
            this.sCM3DataGridViewTextBoxColumn.Width = 118;
            // 
            // filler
            // 
            this.filler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filler.HeaderText = "";
            this.filler.Name = "filler";
            this.filler.ReadOnly = true;
            // 
            // eventKeyDataGridViewTextBoxColumn
            // 
            this.eventKeyDataGridViewTextBoxColumn.DataPropertyName = "EventKey";
            this.eventKeyDataGridViewTextBoxColumn.HeaderText = "EventKey";
            this.eventKeyDataGridViewTextBoxColumn.Name = "eventKeyDataGridViewTextBoxColumn";
            this.eventKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventRowKeyDataGridViewTextBoxColumn
            // 
            this.eventRowKeyDataGridViewTextBoxColumn.DataPropertyName = "EventRowKey";
            this.eventRowKeyDataGridViewTextBoxColumn.HeaderText = "EventRowKey";
            this.eventRowKeyDataGridViewTextBoxColumn.Name = "eventRowKeyDataGridViewTextBoxColumn";
            this.eventRowKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventRowKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventiRigheBindingSource
            // 
            this.eventiRigheBindingSource.DataMember = "EventiRighe";
            this.eventiRigheBindingSource.DataSource = this.dsEvents;
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 3;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel3, 1, 1);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 3;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(1141, 875);
            this.dbTableLayoutPanel1.TabIndex = 11;
            // 
            // eventiTestaTableAdapter
            // 
            this.eventiTestaTableAdapter.ClearBeforeFill = true;
            // 
            // eventiRigheTableAdapter
            // 
            this.eventiRigheTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip_teste
            // 
            this.contextMenuStrip_teste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancellaRecordSelezionatiToolStripMenuItem,
            this.copiaEventoToolStripMenuItem});
            this.contextMenuStrip_teste.Name = "contextMenuStrip_teste";
            this.contextMenuStrip_teste.Size = new System.Drawing.Size(219, 70);
            // 
            // cancellaRecordSelezionatiToolStripMenuItem
            // 
            this.cancellaRecordSelezionatiToolStripMenuItem.Name = "cancellaRecordSelezionatiToolStripMenuItem";
            this.cancellaRecordSelezionatiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cancellaRecordSelezionatiToolStripMenuItem.Text = "Cancella Record Selezionati";
            this.cancellaRecordSelezionatiToolStripMenuItem.Click += new System.EventHandler(this.cancellaRecordSelezionatiToolStripMenuItem_Click);
            // 
            // contextMenuStrip_righe
            // 
            this.contextMenuStrip_righe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancellaRecordSelezionatiToolStripMenuItem1});
            this.contextMenuStrip_righe.Name = "contextMenuStrip_righe";
            this.contextMenuStrip_righe.Size = new System.Drawing.Size(219, 26);
            // 
            // cancellaRecordSelezionatiToolStripMenuItem1
            // 
            this.cancellaRecordSelezionatiToolStripMenuItem1.Name = "cancellaRecordSelezionatiToolStripMenuItem1";
            this.cancellaRecordSelezionatiToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.cancellaRecordSelezionatiToolStripMenuItem1.Text = "Cancella Record Selezionati";
            this.cancellaRecordSelezionatiToolStripMenuItem1.Click += new System.EventHandler(this.cancellaRecordSelezionatiToolStripMenuItem1_Click);
            // 
            // tipo_Reparto_T_ViewTableAdapter
            // 
            this.tipo_Reparto_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_Manutenzione_T_ViewTableAdapter
            // 
            this.tipo_Manutenzione_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_UTETableAdapter
            // 
            this.man_Ana_UTETableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_Stato_RecordTableAdapter
            // 
            this.man_Ana_Stato_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // copiaEventoToolStripMenuItem
            // 
            this.copiaEventoToolStripMenuItem.Name = "copiaEventoToolStripMenuItem";
            this.copiaEventoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.copiaEventoToolStripMenuItem.Text = "Copia Evento";
            this.copiaEventoToolStripMenuItem.Click += new System.EventHandler(this.copiaEventoToolStripMenuItem_Click);
            // 
            // CtrlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Name = "CtrlEvent";
            this.Size = new System.Drawing.Size(1141, 875);
            ((System.ComponentModel.ISupportInitialize)(this.tipoRepartoTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiTestaBindingSource)).EndInit();
            this.dbPanel3.ResumeLayout(false);
            this.dbPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_righe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiRigheBindingSource)).EndInit();
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip_teste.ResumeLayout(false);
            this.contextMenuStrip_righe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_descr;
        private System.Windows.Forms.ComboBox comboBox_rep;
        private System.Windows.Forms.ComboBox comboBox_ute;
        private CtrlDateTimePicker ctrlDateTimePicker_start;
        private CtrlDateTimePicker ctrlDateTimePicker_end;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.ComboBox comboBox_man;
        private CtrlPlantSelector ctrlPlantSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DBDataGridView dbDataGridView_teste;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_contratto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_stato_rec;
        private DBPanel dbPanel3;
        private DBDataGridView dbDataGridView_righe;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_aggiungi_righe;
        private System.Windows.Forms.TextBox textBox_driver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DBTableLayoutPanel dbTableLayoutPanel1;
        private System.Windows.Forms.BindingSource eventiTestaBindingSource;
        private DataSet.dsEvents dsEvents;
        private DataSet.dsEventsTableAdapters.EventiTestaTableAdapter eventiTestaTableAdapter;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.BindingSource eventiRigheBindingSource;
        private DataSet.dsEventsTableAdapters.EventiRigheTableAdapter eventiRigheTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_teste;
        private System.Windows.Forms.ToolStripMenuItem cancellaRecordSelezionatiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_righe;
        private System.Windows.Forms.ToolStripMenuItem cancellaRecordSelezionatiToolStripMenuItem1;
        private System.Windows.Forms.Button button_new_event;
        private System.Windows.Forms.BindingSource tipoRepartoTViewBindingSource;
        private System.Windows.Forms.BindingSource manAnaUTEBindingSource;
        private System.Windows.Forms.BindingSource tipoManutenzioneTViewBindingSource;
        private System.Windows.Forms.BindingSource manAnaStatoRecordBindingSource;
        private DataSet.dsEventsTableAdapters.Tipo_Reparto_T_ViewTableAdapter tipo_Reparto_T_ViewTableAdapter;
        private DataSet.dsEventsTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter tipo_Manutenzione_T_ViewTableAdapter;
        private DataSet.dsEventsTableAdapters.Man_Ana_UTETableAdapter man_Ana_UTETableAdapter;
        private DataSet.dsEventsTableAdapters.Man_Ana_Stato_RecordTableAdapter man_Ana_Stato_RecordTableAdapter;
        private System.Windows.Forms.Button button_modifica_righe;
        private System.Windows.Forms.TextBox textBox_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverPercDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filler;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventRowKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTEName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReparto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoManutenzione;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventContractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uTEKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statoRecKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoManKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem copiaEventoToolStripMenuItem;
    }
}
