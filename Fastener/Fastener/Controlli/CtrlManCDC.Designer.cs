namespace Fastener.Controlli
{
    partial class CtrlManCDC
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
            this.dbTableLayoutPanel1 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel1 = new Fastener.DBPanel(this.components);
            this.button_refresh_CDC = new System.Windows.Forms.Button();
            this.button_save_CDC = new System.Windows.Forms.Button();
            this.dbDataGridView_CDC = new Fastener.DBDataGridView(this.components);
            this.manAnaStatoRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaintenance = new Fastener.DataSet.dsMaintenance();
            this.manAnaCDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.man_Ana_CDCTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_CDCTableAdapter();
            this.man_Ana_Stato_RecordTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_Stato_RecordTableAdapter();
            this.CDCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDCDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statoRecKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDCKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_CDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaCDCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 1;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel1, 0, 1);
            this.dbTableLayoutPanel1.Controls.Add(this.dbDataGridView_CDC, 0, 2);
            this.dbTableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 3;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(547, 367);
            this.dbTableLayoutPanel1.TabIndex = 4;
            // 
            // dbPanel1
            // 
            this.dbPanel1.Controls.Add(this.button_refresh_CDC);
            this.dbPanel1.Controls.Add(this.button_save_CDC);
            this.dbPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbPanel1.Location = new System.Drawing.Point(0, 18);
            this.dbPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbPanel1.Name = "dbPanel1";
            this.dbPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.dbPanel1.Size = new System.Drawing.Size(547, 30);
            this.dbPanel1.TabIndex = 0;
            // 
            // button_refresh_CDC
            // 
            this.button_refresh_CDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_refresh_CDC.Location = new System.Drawing.Point(392, 5);
            this.button_refresh_CDC.Name = "button_refresh_CDC";
            this.button_refresh_CDC.Size = new System.Drawing.Size(75, 20);
            this.button_refresh_CDC.TabIndex = 1;
            this.button_refresh_CDC.Text = "UNDO";
            this.button_refresh_CDC.UseVisualStyleBackColor = true;
            this.button_refresh_CDC.Click += new System.EventHandler(this.button_refresh_CDC_Click);
            // 
            // button_save_CDC
            // 
            this.button_save_CDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_save_CDC.Location = new System.Drawing.Point(467, 5);
            this.button_save_CDC.Name = "button_save_CDC";
            this.button_save_CDC.Size = new System.Drawing.Size(75, 20);
            this.button_save_CDC.TabIndex = 2;
            this.button_save_CDC.Text = "SAVE";
            this.button_save_CDC.UseVisualStyleBackColor = true;
            this.button_save_CDC.Click += new System.EventHandler(this.button_save_CDC_Click);
            // 
            // dbDataGridView_CDC
            // 
            this.dbDataGridView_CDC.AutoGenerateColumns = false;
            this.dbDataGridView_CDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_CDC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDCName,
            this.cDCDescrDataGridViewTextBoxColumn,
            this.statoRecKeyDataGridViewTextBoxColumn,
            this.cDCKeyDataGridViewTextBoxColumn});
            this.dbDataGridView_CDC.DataSource = this.manAnaCDCBindingSource;
            this.dbDataGridView_CDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbDataGridView_CDC.Location = new System.Drawing.Point(3, 51);
            this.dbDataGridView_CDC.Name = "dbDataGridView_CDC";
            this.dbDataGridView_CDC.Size = new System.Drawing.Size(541, 313);
            this.dbDataGridView_CDC.TabIndex = 0;
            this.dbDataGridView_CDC.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dbDataGridView_CDC_CellBeginEdit);
            // 
            // manAnaStatoRecordBindingSource
            // 
            this.manAnaStatoRecordBindingSource.DataMember = "Man_Ana_Stato_Record";
            this.manAnaStatoRecordBindingSource.DataSource = this.dsMaintenance;
            // 
            // dsMaintenance
            // 
            this.dsMaintenance.DataSetName = "dsMaintenance";
            this.dsMaintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manAnaCDCBindingSource
            // 
            this.manAnaCDCBindingSource.DataMember = "Man_Ana_CDC";
            this.manAnaCDCBindingSource.DataSource = this.dsMaintenance;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Centri di Costo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // man_Ana_CDCTableAdapter
            // 
            this.man_Ana_CDCTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_Stato_RecordTableAdapter
            // 
            this.man_Ana_Stato_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // CDCName
            // 
            this.CDCName.DataPropertyName = "CDCName";
            this.CDCName.HeaderText = "Name";
            this.CDCName.Name = "CDCName";
            this.CDCName.Width = 150;
            // 
            // cDCDescrDataGridViewTextBoxColumn
            // 
            this.cDCDescrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDCDescrDataGridViewTextBoxColumn.DataPropertyName = "CDCDescr";
            this.cDCDescrDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.cDCDescrDataGridViewTextBoxColumn.Name = "cDCDescrDataGridViewTextBoxColumn";
            // 
            // statoRecKeyDataGridViewTextBoxColumn
            // 
            this.statoRecKeyDataGridViewTextBoxColumn.DataPropertyName = "StatoRecKey";
            this.statoRecKeyDataGridViewTextBoxColumn.DataSource = this.manAnaStatoRecordBindingSource;
            this.statoRecKeyDataGridViewTextBoxColumn.DisplayMember = "StatoRecName";
            this.statoRecKeyDataGridViewTextBoxColumn.HeaderText = "StatoRecKey";
            this.statoRecKeyDataGridViewTextBoxColumn.Name = "statoRecKeyDataGridViewTextBoxColumn";
            this.statoRecKeyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statoRecKeyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statoRecKeyDataGridViewTextBoxColumn.ValueMember = "StatoRecKey";
            this.statoRecKeyDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDCKeyDataGridViewTextBoxColumn
            // 
            this.cDCKeyDataGridViewTextBoxColumn.DataPropertyName = "CDCKey";
            this.cDCKeyDataGridViewTextBoxColumn.HeaderText = "CDCKey";
            this.cDCKeyDataGridViewTextBoxColumn.Name = "cDCKeyDataGridViewTextBoxColumn";
            this.cDCKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDCKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // CtrlManCDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Name = "CtrlManCDC";
            this.Size = new System.Drawing.Size(547, 367);
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbTableLayoutPanel1.PerformLayout();
            this.dbPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_CDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaStatoRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaCDCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBTableLayoutPanel dbTableLayoutPanel1;
        private DBPanel dbPanel1;
        private System.Windows.Forms.Button button_refresh_CDC;
        private System.Windows.Forms.Button button_save_CDC;
        private DBDataGridView dbDataGridView_CDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource manAnaStatoRecordBindingSource;
        private DataSet.dsMaintenance dsMaintenance;
        private System.Windows.Forms.BindingSource manAnaCDCBindingSource;
        private System.Windows.Forms.Label label1;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_CDCTableAdapter man_Ana_CDCTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_Stato_RecordTableAdapter man_Ana_Stato_RecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statoRecKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCKeyDataGridViewTextBoxColumn;
    }
}
