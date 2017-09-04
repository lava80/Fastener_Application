namespace Fastener.Controlli
{
    partial class CtrlActivityEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlActivityEvent));
            this.dbTableLayoutPanel1 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel_main = new Fastener.DBPanel(this.components);
            this.comboBox_tipo_ore = new System.Windows.Forms.ComboBox();
            this.dbDataGridView_events = new Fastener.DBDataGridView(this.components);
            this.tipoRepartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoManutenzioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventContractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTEKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statoRecKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRepKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoManKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTENameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starthourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startminuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endhourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endminuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventiTestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEvents = new Fastener.DataSet.dsEvents();
            this.ctrlDateTimePicker_start = new Fastener.Controlli.CtrlDateTimePicker();
            this.ctrlDateTimePicker_end = new Fastener.Controlli.CtrlDateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoManutenzioneTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsActivities = new Fastener.DataSet.dsActivities();
            this.tipo_Manutenzione_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter();
            this.eventiTestaTableAdapter = new Fastener.DataSet.dsEventsTableAdapters.EventiTestaTableAdapter();
            this.tipoOreTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.TipoOreTableAdapter();
            this.tipoOreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbPanel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_events)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiTestaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 3;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel_main, 1, 1);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 3;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(771, 537);
            this.dbTableLayoutPanel1.TabIndex = 6;
            // 
            // dbPanel_main
            // 
            this.dbPanel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbPanel_main.BackgroundImage")));
            this.dbPanel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbPanel_main.Controls.Add(this.comboBox_tipo_ore);
            this.dbPanel_main.Controls.Add(this.dbDataGridView_events);
            this.dbPanel_main.Controls.Add(this.ctrlDateTimePicker_start);
            this.dbPanel_main.Controls.Add(this.ctrlDateTimePicker_end);
            this.dbPanel_main.Controls.Add(this.button_save);
            this.dbPanel_main.Controls.Add(this.label1);
            this.dbPanel_main.Controls.Add(this.label2);
            this.dbPanel_main.Location = new System.Drawing.Point(33, 33);
            this.dbPanel_main.Name = "dbPanel_main";
            this.dbPanel_main.Size = new System.Drawing.Size(705, 470);
            this.dbPanel_main.TabIndex = 5;
            // 
            // comboBox_tipo_ore
            // 
            this.comboBox_tipo_ore.DataSource = this.tipoOreBindingSource;
            this.comboBox_tipo_ore.DisplayMember = "TipOreName";
            this.comboBox_tipo_ore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_ore.FormattingEnabled = true;
            this.comboBox_tipo_ore.Location = new System.Drawing.Point(572, 135);
            this.comboBox_tipo_ore.Name = "comboBox_tipo_ore";
            this.comboBox_tipo_ore.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo_ore.TabIndex = 20;
            this.comboBox_tipo_ore.ValueMember = "TipOreKey";
            // 
            // dbDataGridView_events
            // 
            this.dbDataGridView_events.AllowUserToAddRows = false;
            this.dbDataGridView_events.AllowUserToDeleteRows = false;
            this.dbDataGridView_events.AutoGenerateColumns = false;
            this.dbDataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoRepartoDataGridViewTextBoxColumn,
            this.tipoManutenzioneDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn,
            this.eventRemarkDataGridViewTextBoxColumn,
            this.eventContractNumberDataGridViewTextBoxColumn,
            this.uTEKeyDataGridViewTextBoxColumn,
            this.statoRecKeyDataGridViewTextBoxColumn,
            this.tipoRepKeyDataGridViewTextBoxColumn,
            this.tipoManKeyDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.startHMSDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.endHMSDataGridViewTextBoxColumn,
            this.uTENameDataGridViewTextBoxColumn,
            this.eventKeyDataGridViewTextBoxColumn,
            this.dtstartdateDataGridViewTextBoxColumn,
            this.dtenddateDataGridViewTextBoxColumn,
            this.starthourDataGridViewTextBoxColumn,
            this.startminuteDataGridViewTextBoxColumn,
            this.endhourDataGridViewTextBoxColumn,
            this.endminuteDataGridViewTextBoxColumn});
            this.dbDataGridView_events.DataSource = this.eventiTestaBindingSource;
            this.dbDataGridView_events.Location = new System.Drawing.Point(12, 164);
            this.dbDataGridView_events.MultiSelect = false;
            this.dbDataGridView_events.Name = "dbDataGridView_events";
            this.dbDataGridView_events.ReadOnly = true;
            this.dbDataGridView_events.RowHeadersVisible = false;
            this.dbDataGridView_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbDataGridView_events.Size = new System.Drawing.Size(683, 232);
            this.dbDataGridView_events.TabIndex = 19;
            // 
            // tipoRepartoDataGridViewTextBoxColumn
            // 
            this.tipoRepartoDataGridViewTextBoxColumn.DataPropertyName = "TipoReparto";
            this.tipoRepartoDataGridViewTextBoxColumn.HeaderText = "Reparto";
            this.tipoRepartoDataGridViewTextBoxColumn.Name = "tipoRepartoDataGridViewTextBoxColumn";
            this.tipoRepartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoManutenzioneDataGridViewTextBoxColumn
            // 
            this.tipoManutenzioneDataGridViewTextBoxColumn.DataPropertyName = "TipoManutenzione";
            this.tipoManutenzioneDataGridViewTextBoxColumn.HeaderText = "Tipo Manutenzione";
            this.tipoManutenzioneDataGridViewTextBoxColumn.Name = "tipoManutenzioneDataGridViewTextBoxColumn";
            this.tipoManutenzioneDataGridViewTextBoxColumn.ReadOnly = true;
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
            // eventRemarkDataGridViewTextBoxColumn
            // 
            this.eventRemarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventRemarkDataGridViewTextBoxColumn.DataPropertyName = "EventRemark";
            this.eventRemarkDataGridViewTextBoxColumn.HeaderText = "Commento";
            this.eventRemarkDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.eventRemarkDataGridViewTextBoxColumn.Name = "eventRemarkDataGridViewTextBoxColumn";
            this.eventRemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventContractNumberDataGridViewTextBoxColumn
            // 
            this.eventContractNumberDataGridViewTextBoxColumn.DataPropertyName = "EventContractNumber";
            this.eventContractNumberDataGridViewTextBoxColumn.HeaderText = "Contratto";
            this.eventContractNumberDataGridViewTextBoxColumn.Name = "eventContractNumberDataGridViewTextBoxColumn";
            this.eventContractNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // startHMSDataGridViewTextBoxColumn
            // 
            this.startHMSDataGridViewTextBoxColumn.DataPropertyName = "StartHMS";
            this.startHMSDataGridViewTextBoxColumn.HeaderText = "StartHMS";
            this.startHMSDataGridViewTextBoxColumn.Name = "startHMSDataGridViewTextBoxColumn";
            this.startHMSDataGridViewTextBoxColumn.ReadOnly = true;
            this.startHMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // endHMSDataGridViewTextBoxColumn
            // 
            this.endHMSDataGridViewTextBoxColumn.DataPropertyName = "EndHMS";
            this.endHMSDataGridViewTextBoxColumn.HeaderText = "EndHMS";
            this.endHMSDataGridViewTextBoxColumn.Name = "endHMSDataGridViewTextBoxColumn";
            this.endHMSDataGridViewTextBoxColumn.ReadOnly = true;
            this.endHMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // uTENameDataGridViewTextBoxColumn
            // 
            this.uTENameDataGridViewTextBoxColumn.DataPropertyName = "UTEName";
            this.uTENameDataGridViewTextBoxColumn.HeaderText = "UTEName";
            this.uTENameDataGridViewTextBoxColumn.Name = "uTENameDataGridViewTextBoxColumn";
            this.uTENameDataGridViewTextBoxColumn.ReadOnly = true;
            this.uTENameDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventKeyDataGridViewTextBoxColumn
            // 
            this.eventKeyDataGridViewTextBoxColumn.DataPropertyName = "EventKey";
            this.eventKeyDataGridViewTextBoxColumn.HeaderText = "EventKey";
            this.eventKeyDataGridViewTextBoxColumn.Name = "eventKeyDataGridViewTextBoxColumn";
            this.eventKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtstartdateDataGridViewTextBoxColumn
            // 
            this.dtstartdateDataGridViewTextBoxColumn.DataPropertyName = "dt_start_date";
            this.dtstartdateDataGridViewTextBoxColumn.HeaderText = "dt_start_date";
            this.dtstartdateDataGridViewTextBoxColumn.Name = "dtstartdateDataGridViewTextBoxColumn";
            this.dtstartdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtstartdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtenddateDataGridViewTextBoxColumn
            // 
            this.dtenddateDataGridViewTextBoxColumn.DataPropertyName = "dt_end_date";
            this.dtenddateDataGridViewTextBoxColumn.HeaderText = "dt_end_date";
            this.dtenddateDataGridViewTextBoxColumn.Name = "dtenddateDataGridViewTextBoxColumn";
            this.dtenddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtenddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // starthourDataGridViewTextBoxColumn
            // 
            this.starthourDataGridViewTextBoxColumn.DataPropertyName = "start_hour";
            this.starthourDataGridViewTextBoxColumn.HeaderText = "start_hour";
            this.starthourDataGridViewTextBoxColumn.Name = "starthourDataGridViewTextBoxColumn";
            this.starthourDataGridViewTextBoxColumn.ReadOnly = true;
            this.starthourDataGridViewTextBoxColumn.Visible = false;
            // 
            // startminuteDataGridViewTextBoxColumn
            // 
            this.startminuteDataGridViewTextBoxColumn.DataPropertyName = "start_minute";
            this.startminuteDataGridViewTextBoxColumn.HeaderText = "start_minute";
            this.startminuteDataGridViewTextBoxColumn.Name = "startminuteDataGridViewTextBoxColumn";
            this.startminuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.startminuteDataGridViewTextBoxColumn.Visible = false;
            // 
            // endhourDataGridViewTextBoxColumn
            // 
            this.endhourDataGridViewTextBoxColumn.DataPropertyName = "end_hour";
            this.endhourDataGridViewTextBoxColumn.HeaderText = "end_hour";
            this.endhourDataGridViewTextBoxColumn.Name = "endhourDataGridViewTextBoxColumn";
            this.endhourDataGridViewTextBoxColumn.ReadOnly = true;
            this.endhourDataGridViewTextBoxColumn.Visible = false;
            // 
            // endminuteDataGridViewTextBoxColumn
            // 
            this.endminuteDataGridViewTextBoxColumn.DataPropertyName = "end_minute";
            this.endminuteDataGridViewTextBoxColumn.HeaderText = "end_minute";
            this.endminuteDataGridViewTextBoxColumn.Name = "endminuteDataGridViewTextBoxColumn";
            this.endminuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.endminuteDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventiTestaBindingSource
            // 
            this.eventiTestaBindingSource.DataMember = "EventiTesta";
            this.eventiTestaBindingSource.DataSource = this.dsEvents;
            // 
            // dsEvents
            // 
            this.dsEvents.DataSetName = "dsEvents";
            this.dsEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctrlDateTimePicker_start
            // 
            this.ctrlDateTimePicker_start.AutoSize = true;
            this.ctrlDateTimePicker_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_start.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_start.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_start.LabelText = "Inizio";
            this.ctrlDateTimePicker_start.Location = new System.Drawing.Point(61, 23);
            this.ctrlDateTimePicker_start.Name = "ctrlDateTimePicker_start";
            this.ctrlDateTimePicker_start.ShowDate = true;
            this.ctrlDateTimePicker_start.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_start.TabIndex = 18;
            // 
            // ctrlDateTimePicker_end
            // 
            this.ctrlDateTimePicker_end.AutoSize = true;
            this.ctrlDateTimePicker_end.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_end.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_end.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_end.LabelText = "Fine";
            this.ctrlDateTimePicker_end.Location = new System.Drawing.Point(421, 23);
            this.ctrlDateTimePicker_end.Name = "ctrlDateTimePicker_end";
            this.ctrlDateTimePicker_end.ShowDate = true;
            this.ctrlDateTimePicker_end.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_end.TabIndex = 17;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(36, 430);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(634, 24);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "SALVA";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Ore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eventi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoManutenzioneTViewBindingSource
            // 
            this.tipoManutenzioneTViewBindingSource.DataMember = "Tipo_Manutenzione_T_View";
            this.tipoManutenzioneTViewBindingSource.DataSource = this.dsActivities;
            // 
            // dsActivities
            // 
            this.dsActivities.DataSetName = "dsActivities";
            this.dsActivities.Locale = new System.Globalization.CultureInfo("it-IT");
            this.dsActivities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_Manutenzione_T_ViewTableAdapter
            // 
            this.tipo_Manutenzione_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // eventiTestaTableAdapter
            // 
            this.eventiTestaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoOreTableAdapter
            // 
            this.tipoOreTableAdapter.ClearBeforeFill = true;
            // 
            // tipoOreBindingSource
            // 
            this.tipoOreBindingSource.DataMember = "TipoOre";
            this.tipoOreBindingSource.DataSource = this.dsActivities;
            // 
            // CtrlActivityEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Name = "CtrlActivityEvent";
            this.Size = new System.Drawing.Size(771, 537);
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbPanel_main.ResumeLayout(false);
            this.dbPanel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_events)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventiTestaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel dbPanel_main;
        private DBTableLayoutPanel dbTableLayoutPanel1;
        private System.Windows.Forms.Button button_save;
        private DataSet.dsActivities dsActivities;
        private System.Windows.Forms.BindingSource tipoManutenzioneTViewBindingSource;
        private DataSet.dsActivitiesTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter tipo_Manutenzione_T_ViewTableAdapter;
        private CtrlDateTimePicker ctrlDateTimePicker_end;
        private CtrlDateTimePicker ctrlDateTimePicker_start;
        private DBDataGridView dbDataGridView_events;
        private System.Windows.Forms.BindingSource eventiTestaBindingSource;
        private DataSet.dsEvents dsEvents;
        private DataSet.dsEventsTableAdapters.EventiTestaTableAdapter eventiTestaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoManutenzioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventContractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uTEKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statoRecKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRepKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoManKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uTENameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starthourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startminuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endhourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endminuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_tipo_ore;
        private System.Windows.Forms.Label label1;
        private DataSet.dsActivitiesTableAdapters.TipoOreTableAdapter tipoOreTableAdapter;
        private System.Windows.Forms.BindingSource tipoOreBindingSource;
    }
}
