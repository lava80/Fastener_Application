namespace Fastener.Controlli
{
    partial class CtrlTranslations
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
            this.dbTableLayoutPanel3 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel2 = new Fastener.DBPanel(this.components);
            this.comboBox_lingue = new System.Windows.Forms.ComboBox();
            this.manAnaLANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaintenance = new Fastener.DataSet.dsMaintenance();
            this.button_undo_AZI_REP = new System.Windows.Forms.Button();
            this.button_save_AZI_REP = new System.Windows.Forms.Button();
            this.dbDataGridView_translations = new Fastener.DBDataGridView(this.components);
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.man_Ana_LANTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_LANTableAdapter();
            this.translationsTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.TranslationsTableAdapter();
            this.dbTableLayoutPanel3.SuspendLayout();
            this.dbPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_translations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel3
            // 
            this.dbTableLayoutPanel3.ColumnCount = 1;
            this.dbTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel3.Controls.Add(this.dbPanel2, 0, 1);
            this.dbTableLayoutPanel3.Controls.Add(this.dbDataGridView_translations, 0, 2);
            this.dbTableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.dbTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.dbTableLayoutPanel3.Name = "dbTableLayoutPanel3";
            this.dbTableLayoutPanel3.RowCount = 3;
            this.dbTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel3.Size = new System.Drawing.Size(384, 346);
            this.dbTableLayoutPanel3.TabIndex = 7;
            // 
            // dbPanel2
            // 
            this.dbPanel2.Controls.Add(this.comboBox_lingue);
            this.dbPanel2.Controls.Add(this.button_undo_AZI_REP);
            this.dbPanel2.Controls.Add(this.button_save_AZI_REP);
            this.dbPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbPanel2.Location = new System.Drawing.Point(0, 18);
            this.dbPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.dbPanel2.Name = "dbPanel2";
            this.dbPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.dbPanel2.Size = new System.Drawing.Size(384, 30);
            this.dbPanel2.TabIndex = 0;
            // 
            // comboBox_lingue
            // 
            this.comboBox_lingue.DataSource = this.manAnaLANBindingSource;
            this.comboBox_lingue.DisplayMember = "LANName";
            this.comboBox_lingue.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_lingue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lingue.FormattingEnabled = true;
            this.comboBox_lingue.Location = new System.Drawing.Point(5, 5);
            this.comboBox_lingue.Name = "comboBox_lingue";
            this.comboBox_lingue.Size = new System.Drawing.Size(121, 21);
            this.comboBox_lingue.TabIndex = 3;
            this.comboBox_lingue.ValueMember = "LANKey";
            this.comboBox_lingue.SelectedIndexChanged += new System.EventHandler(this.comboBox_lingue_SelectedIndexChanged);
            // 
            // manAnaLANBindingSource
            // 
            this.manAnaLANBindingSource.DataMember = "Man_Ana_LAN";
            this.manAnaLANBindingSource.DataSource = this.dsMaintenance;
            // 
            // dsMaintenance
            // 
            this.dsMaintenance.DataSetName = "dsMaintenance";
            this.dsMaintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_undo_AZI_REP
            // 
            this.button_undo_AZI_REP.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_undo_AZI_REP.Location = new System.Drawing.Point(229, 5);
            this.button_undo_AZI_REP.Name = "button_undo_AZI_REP";
            this.button_undo_AZI_REP.Size = new System.Drawing.Size(75, 20);
            this.button_undo_AZI_REP.TabIndex = 1;
            this.button_undo_AZI_REP.Text = "UNDO";
            this.button_undo_AZI_REP.UseVisualStyleBackColor = true;
            this.button_undo_AZI_REP.Click += new System.EventHandler(this.button_undo_AZI_REP_Click);
            // 
            // button_save_AZI_REP
            // 
            this.button_save_AZI_REP.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_save_AZI_REP.Location = new System.Drawing.Point(304, 5);
            this.button_save_AZI_REP.Name = "button_save_AZI_REP";
            this.button_save_AZI_REP.Size = new System.Drawing.Size(75, 20);
            this.button_save_AZI_REP.TabIndex = 2;
            this.button_save_AZI_REP.Text = "SAVE";
            this.button_save_AZI_REP.UseVisualStyleBackColor = true;
            this.button_save_AZI_REP.Click += new System.EventHandler(this.button_save_AZI_REP_Click);
            // 
            // dbDataGridView_translations
            // 
            this.dbDataGridView_translations.AutoGenerateColumns = false;
            this.dbDataGridView_translations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_translations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagDataGridViewTextBoxColumn,
            this.translationDataGridViewTextBoxColumn,
            this.translationUIDDataGridViewTextBoxColumn});
            this.dbDataGridView_translations.DataSource = this.translationsBindingSource;
            this.dbDataGridView_translations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbDataGridView_translations.Location = new System.Drawing.Point(3, 51);
            this.dbDataGridView_translations.Name = "dbDataGridView_translations";
            this.dbDataGridView_translations.Size = new System.Drawing.Size(378, 292);
            this.dbDataGridView_translations.TabIndex = 0;
            this.dbDataGridView_translations.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dbDataGridView_translations_CellBeginEdit);
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Item";
            this.tagDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // translationDataGridViewTextBoxColumn
            // 
            this.translationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.translationDataGridViewTextBoxColumn.DataPropertyName = "translation";
            this.translationDataGridViewTextBoxColumn.HeaderText = "Traduzione";
            this.translationDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.translationDataGridViewTextBoxColumn.Name = "translationDataGridViewTextBoxColumn";
            // 
            // translationUIDDataGridViewTextBoxColumn
            // 
            this.translationUIDDataGridViewTextBoxColumn.DataPropertyName = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.HeaderText = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.Name = "translationUIDDataGridViewTextBoxColumn";
            this.translationUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // translationsBindingSource
            // 
            this.translationsBindingSource.DataMember = "Translations";
            this.translationsBindingSource.DataSource = this.dsMaintenance;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Traduzioni";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // man_Ana_LANTableAdapter
            // 
            this.man_Ana_LANTableAdapter.ClearBeforeFill = true;
            // 
            // translationsTableAdapter
            // 
            this.translationsTableAdapter.ClearBeforeFill = true;
            // 
            // CtrlTranslations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel3);
            this.Name = "CtrlTranslations";
            this.Size = new System.Drawing.Size(384, 346);
            this.dbTableLayoutPanel3.ResumeLayout(false);
            this.dbTableLayoutPanel3.PerformLayout();
            this.dbPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_translations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBTableLayoutPanel dbTableLayoutPanel3;
        private DBPanel dbPanel2;
        private System.Windows.Forms.ComboBox comboBox_lingue;
        private System.Windows.Forms.BindingSource manAnaLANBindingSource;
        private DataSet.dsMaintenance dsMaintenance;
        private System.Windows.Forms.Button button_undo_AZI_REP;
        private System.Windows.Forms.Button button_save_AZI_REP;
        private DBDataGridView dbDataGridView_translations;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource translationsBindingSource;
        private System.Windows.Forms.Label label2;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_LANTableAdapter man_Ana_LANTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.TranslationsTableAdapter translationsTableAdapter;
    }
}
