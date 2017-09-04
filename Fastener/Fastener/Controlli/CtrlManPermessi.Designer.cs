namespace Fastener.Controlli
{
    partial class CtrlManPermessi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_new_per = new System.Windows.Forms.Button();
            this.button_save_per = new System.Windows.Forms.Button();
            this.textBox_per_descr = new System.Windows.Forms.TextBox();
            this.textBox_famiglia = new System.Windows.Forms.TextBox();
            this.textBox_per_name = new System.Windows.Forms.TextBox();
            this.dbDataGridView_cat_ute_per = new Fastener.DBDataGridView(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permessiNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUteNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUtenteKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermessiKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUtentePermessiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaintenance = new Fastener.DataSet.dsMaintenance();
            this.dbDataGridView_permessi = new Fastener.DBDataGridView(this.components);
            this.PermessiFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permessiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permessiDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permessiKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manAnaPermessiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataGridView_cat_ute = new Fastener.DBDataGridView(this.components);
            this.tipoUteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUteKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manAnaTipoUtenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.man_Ana_PermessiTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_PermessiTableAdapter();
            this.man_Ana_Tipo_UtenteTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_UtenteTableAdapter();
            this.tipoUtente_PermessiTableAdapter = new Fastener.DataSet.dsMaintenanceTableAdapters.TipoUtente_PermessiTableAdapter();
            this.contextMenuStrip_permessi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_cat_ute_per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUtentePermessiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_permessi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaPermessiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_cat_ute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoUtenteBindingSource)).BeginInit();
            this.contextMenuStrip_permessi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 3;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel1, 1, 1);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 3;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(905, 685);
            this.dbTableLayoutPanel1.TabIndex = 0;
            // 
            // dbPanel1
            // 
            this.dbPanel1.BackgroundImage = global::Fastener.Properties.Resources.Anagrafica_Permessi;
            this.dbPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbPanel1.Controls.Add(this.label4);
            this.dbPanel1.Controls.Add(this.label2);
            this.dbPanel1.Controls.Add(this.label3);
            this.dbPanel1.Controls.Add(this.label1);
            this.dbPanel1.Controls.Add(this.button_new_per);
            this.dbPanel1.Controls.Add(this.button_save_per);
            this.dbPanel1.Controls.Add(this.textBox_per_descr);
            this.dbPanel1.Controls.Add(this.textBox_famiglia);
            this.dbPanel1.Controls.Add(this.textBox_per_name);
            this.dbPanel1.Controls.Add(this.dbDataGridView_cat_ute_per);
            this.dbPanel1.Controls.Add(this.dbDataGridView_permessi);
            this.dbPanel1.Controls.Add(this.dbDataGridView_cat_ute);
            this.dbPanel1.Location = new System.Drawing.Point(15, 47);
            this.dbPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbPanel1.Name = "dbPanel1";
            this.dbPanel1.Size = new System.Drawing.Size(874, 590);
            this.dbPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(329, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Famiglia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(332, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anagrafica Permessi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(29, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 69);
            this.label3.TabIndex = 3;
            this.label3.Text = "Associazione\r\nTipologie Utenti -- Permessi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipologie Utente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_new_per
            // 
            this.button_new_per.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_per.Location = new System.Drawing.Point(332, 63);
            this.button_new_per.Name = "button_new_per";
            this.button_new_per.Size = new System.Drawing.Size(106, 22);
            this.button_new_per.TabIndex = 3;
            this.button_new_per.Text = "Nuovo Permesso";
            this.button_new_per.UseVisualStyleBackColor = true;
            this.button_new_per.Click += new System.EventHandler(this.button_new_per_Click);
            // 
            // button_save_per
            // 
            this.button_save_per.Enabled = false;
            this.button_save_per.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_per.Location = new System.Drawing.Point(739, 63);
            this.button_save_per.Name = "button_save_per";
            this.button_save_per.Size = new System.Drawing.Size(106, 22);
            this.button_save_per.TabIndex = 2;
            this.button_save_per.Text = "Salva Permesso";
            this.button_save_per.UseVisualStyleBackColor = true;
            this.button_save_per.Click += new System.EventHandler(this.button_save_per_Click);
            // 
            // textBox_per_descr
            // 
            this.textBox_per_descr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_per_descr.Location = new System.Drawing.Point(332, 117);
            this.textBox_per_descr.Multiline = true;
            this.textBox_per_descr.Name = "textBox_per_descr";
            this.textBox_per_descr.ReadOnly = true;
            this.textBox_per_descr.Size = new System.Drawing.Size(513, 45);
            this.textBox_per_descr.TabIndex = 2;
            // 
            // textBox_famiglia
            // 
            this.textBox_famiglia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_famiglia.Location = new System.Drawing.Point(444, 90);
            this.textBox_famiglia.Name = "textBox_famiglia";
            this.textBox_famiglia.ReadOnly = true;
            this.textBox_famiglia.Size = new System.Drawing.Size(401, 21);
            this.textBox_famiglia.TabIndex = 1;
            // 
            // textBox_per_name
            // 
            this.textBox_per_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_per_name.Location = new System.Drawing.Point(444, 64);
            this.textBox_per_name.Name = "textBox_per_name";
            this.textBox_per_name.ReadOnly = true;
            this.textBox_per_name.Size = new System.Drawing.Size(289, 21);
            this.textBox_per_name.TabIndex = 0;
            // 
            // dbDataGridView_cat_ute_per
            // 
            this.dbDataGridView_cat_ute_per.AllowUserToAddRows = false;
            this.dbDataGridView_cat_ute_per.AllowUserToDeleteRows = false;
            this.dbDataGridView_cat_ute_per.AutoGenerateColumns = false;
            this.dbDataGridView_cat_ute_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_cat_ute_per.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.permessiNameDataGridViewTextBoxColumn1,
            this.tipoUteNameDataGridViewTextBoxColumn1,
            this.TipoUtenteKey,
            this.PermessiKey});
            this.dbDataGridView_cat_ute_per.DataSource = this.tipoUtentePermessiBindingSource;
            this.dbDataGridView_cat_ute_per.Location = new System.Drawing.Point(29, 311);
            this.dbDataGridView_cat_ute_per.MultiSelect = false;
            this.dbDataGridView_cat_ute_per.Name = "dbDataGridView_cat_ute_per";
            this.dbDataGridView_cat_ute_per.ReadOnly = true;
            this.dbDataGridView_cat_ute_per.RowHeadersVisible = false;
            this.dbDataGridView_cat_ute_per.Size = new System.Drawing.Size(242, 254);
            this.dbDataGridView_cat_ute_per.TabIndex = 0;
            this.dbDataGridView_cat_ute_per.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbDataGridView_cat_ute_per_CellContentClick);
            this.dbDataGridView_cat_ute_per.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_cat_ute_per_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PermessiFamily";
            this.dataGridViewTextBoxColumn1.HeaderText = "Famiglia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // permessiNameDataGridViewTextBoxColumn1
            // 
            this.permessiNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.permessiNameDataGridViewTextBoxColumn1.DataPropertyName = "PermessiName";
            this.permessiNameDataGridViewTextBoxColumn1.HeaderText = "Permessi";
            this.permessiNameDataGridViewTextBoxColumn1.Name = "permessiNameDataGridViewTextBoxColumn1";
            this.permessiNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoUteNameDataGridViewTextBoxColumn1
            // 
            this.tipoUteNameDataGridViewTextBoxColumn1.DataPropertyName = "TipoUteName";
            this.tipoUteNameDataGridViewTextBoxColumn1.HeaderText = "TipoUteName";
            this.tipoUteNameDataGridViewTextBoxColumn1.Name = "tipoUteNameDataGridViewTextBoxColumn1";
            this.tipoUteNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipoUteNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // TipoUtenteKey
            // 
            this.TipoUtenteKey.DataPropertyName = "TipoUtenteKey";
            this.TipoUtenteKey.HeaderText = "TipoUtenteKey";
            this.TipoUtenteKey.Name = "TipoUtenteKey";
            this.TipoUtenteKey.ReadOnly = true;
            this.TipoUtenteKey.Visible = false;
            // 
            // PermessiKey
            // 
            this.PermessiKey.DataPropertyName = "PermessiKey";
            this.PermessiKey.HeaderText = "PermessiKey";
            this.PermessiKey.Name = "PermessiKey";
            this.PermessiKey.ReadOnly = true;
            this.PermessiKey.Visible = false;
            // 
            // tipoUtentePermessiBindingSource
            // 
            this.tipoUtentePermessiBindingSource.DataMember = "TipoUtente_Permessi";
            this.tipoUtentePermessiBindingSource.DataSource = this.dsMaintenance;
            // 
            // dsMaintenance
            // 
            this.dsMaintenance.DataSetName = "dsMaintenance";
            this.dsMaintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDataGridView_permessi
            // 
            this.dbDataGridView_permessi.AllowUserToAddRows = false;
            this.dbDataGridView_permessi.AllowUserToDeleteRows = false;
            this.dbDataGridView_permessi.AutoGenerateColumns = false;
            this.dbDataGridView_permessi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_permessi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermessiFamily,
            this.permessiNameDataGridViewTextBoxColumn,
            this.permessiDescriptionDataGridViewTextBoxColumn,
            this.permessiKeyDataGridViewTextBoxColumn});
            this.dbDataGridView_permessi.DataSource = this.manAnaPermessiBindingSource;
            this.dbDataGridView_permessi.Location = new System.Drawing.Point(332, 168);
            this.dbDataGridView_permessi.MultiSelect = false;
            this.dbDataGridView_permessi.Name = "dbDataGridView_permessi";
            this.dbDataGridView_permessi.ReadOnly = true;
            this.dbDataGridView_permessi.RowHeadersVisible = false;
            this.dbDataGridView_permessi.Size = new System.Drawing.Size(513, 397);
            this.dbDataGridView_permessi.TabIndex = 0;
            this.dbDataGridView_permessi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbDataGridView_permessi_CellMouseClick);
            this.dbDataGridView_permessi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbDataGridView_permessi_MouseDoubleClick);
            // 
            // PermessiFamily
            // 
            this.PermessiFamily.DataPropertyName = "PermessiFamily";
            this.PermessiFamily.HeaderText = "Famiglia";
            this.PermessiFamily.Name = "PermessiFamily";
            this.PermessiFamily.ReadOnly = true;
            // 
            // permessiNameDataGridViewTextBoxColumn
            // 
            this.permessiNameDataGridViewTextBoxColumn.DataPropertyName = "PermessiName";
            this.permessiNameDataGridViewTextBoxColumn.HeaderText = "Permesso";
            this.permessiNameDataGridViewTextBoxColumn.Name = "permessiNameDataGridViewTextBoxColumn";
            this.permessiNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.permessiNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // permessiDescriptionDataGridViewTextBoxColumn
            // 
            this.permessiDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.permessiDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PermessiDescription";
            this.permessiDescriptionDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.permessiDescriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.permessiDescriptionDataGridViewTextBoxColumn.Name = "permessiDescriptionDataGridViewTextBoxColumn";
            this.permessiDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permessiKeyDataGridViewTextBoxColumn
            // 
            this.permessiKeyDataGridViewTextBoxColumn.DataPropertyName = "PermessiKey";
            this.permessiKeyDataGridViewTextBoxColumn.HeaderText = "PermessiKey";
            this.permessiKeyDataGridViewTextBoxColumn.Name = "permessiKeyDataGridViewTextBoxColumn";
            this.permessiKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.permessiKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // manAnaPermessiBindingSource
            // 
            this.manAnaPermessiBindingSource.DataMember = "Man_Ana_Permessi";
            this.manAnaPermessiBindingSource.DataSource = this.dsMaintenance;
            // 
            // dbDataGridView_cat_ute
            // 
            this.dbDataGridView_cat_ute.AllowUserToAddRows = false;
            this.dbDataGridView_cat_ute.AllowUserToDeleteRows = false;
            this.dbDataGridView_cat_ute.AutoGenerateColumns = false;
            this.dbDataGridView_cat_ute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView_cat_ute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoUteNameDataGridViewTextBoxColumn,
            this.translationUIDDataGridViewTextBoxColumn,
            this.tipoUteKeyDataGridViewTextBoxColumn});
            this.dbDataGridView_cat_ute.DataSource = this.manAnaTipoUtenteBindingSource;
            this.dbDataGridView_cat_ute.Location = new System.Drawing.Point(29, 64);
            this.dbDataGridView_cat_ute.MultiSelect = false;
            this.dbDataGridView_cat_ute.Name = "dbDataGridView_cat_ute";
            this.dbDataGridView_cat_ute.ReadOnly = true;
            this.dbDataGridView_cat_ute.RowHeadersVisible = false;
            this.dbDataGridView_cat_ute.Size = new System.Drawing.Size(242, 169);
            this.dbDataGridView_cat_ute.TabIndex = 0;
            this.dbDataGridView_cat_ute.SelectionChanged += new System.EventHandler(this.dbDataGridView_cat_ute_SelectionChanged);
            // 
            // tipoUteNameDataGridViewTextBoxColumn
            // 
            this.tipoUteNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoUteNameDataGridViewTextBoxColumn.DataPropertyName = "TipoUteName";
            this.tipoUteNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.tipoUteNameDataGridViewTextBoxColumn.Name = "tipoUteNameDataGridViewTextBoxColumn";
            this.tipoUteNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // translationUIDDataGridViewTextBoxColumn
            // 
            this.translationUIDDataGridViewTextBoxColumn.DataPropertyName = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.HeaderText = "TranslationUID";
            this.translationUIDDataGridViewTextBoxColumn.Name = "translationUIDDataGridViewTextBoxColumn";
            this.translationUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.translationUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoUteKeyDataGridViewTextBoxColumn
            // 
            this.tipoUteKeyDataGridViewTextBoxColumn.DataPropertyName = "TipoUteKey";
            this.tipoUteKeyDataGridViewTextBoxColumn.HeaderText = "TipoUteKey";
            this.tipoUteKeyDataGridViewTextBoxColumn.Name = "tipoUteKeyDataGridViewTextBoxColumn";
            this.tipoUteKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoUteKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // manAnaTipoUtenteBindingSource
            // 
            this.manAnaTipoUtenteBindingSource.DataMember = "Man_Ana_Tipo_Utente";
            this.manAnaTipoUtenteBindingSource.DataSource = this.dsMaintenance;
            // 
            // man_Ana_PermessiTableAdapter
            // 
            this.man_Ana_PermessiTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_Tipo_UtenteTableAdapter
            // 
            this.man_Ana_Tipo_UtenteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoUtente_PermessiTableAdapter
            // 
            this.tipoUtente_PermessiTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip_permessi
            // 
            this.contextMenuStrip_permessi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_permessi.Name = "contextMenuStrip_permessi";
            this.contextMenuStrip_permessi.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CtrlManPermessi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlManPermessi";
            this.Size = new System.Drawing.Size(905, 685);
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbPanel1.ResumeLayout(false);
            this.dbPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_cat_ute_per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUtentePermessiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_permessi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaPermessiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView_cat_ute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaTipoUtenteBindingSource)).EndInit();
            this.contextMenuStrip_permessi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DBTableLayoutPanel dbTableLayoutPanel1;
        private DBPanel dbPanel1;
        private DBDataGridView dbDataGridView_cat_ute;
        private System.Windows.Forms.Button button_new_per;
        private System.Windows.Forms.Button button_save_per;
        private System.Windows.Forms.TextBox textBox_per_descr;
        private System.Windows.Forms.TextBox textBox_per_name;
        private DBDataGridView dbDataGridView_cat_ute_per;
        private DBDataGridView dbDataGridView_permessi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manAnaPermessiBindingSource;
        private DataSet.dsMaintenance dsMaintenance;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_PermessiTableAdapter man_Ana_PermessiTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipoUtentePermessiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUteKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource manAnaTipoUtenteBindingSource;
        private DataSet.dsMaintenanceTableAdapters.Man_Ana_Tipo_UtenteTableAdapter man_Ana_Tipo_UtenteTableAdapter;
        private DataSet.dsMaintenanceTableAdapters.TipoUtente_PermessiTableAdapter tipoUtente_PermessiTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_famiglia;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_permessi;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermessiFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn permessiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permessiDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permessiKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permessiNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUteNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUtenteKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermessiKey;
    }
}
