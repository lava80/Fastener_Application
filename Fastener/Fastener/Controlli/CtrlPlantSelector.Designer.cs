namespace Fastener.Controlli
{
    partial class CtrlPlantSelector
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
            this.label_impianto = new System.Windows.Forms.Label();
            this.comboBox_imp = new System.Windows.Forms.ComboBox();
            this.impiantiTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsActivities = new Fastener.DataSet.dsActivities();
            this.label_macchina = new System.Windows.Forms.Label();
            this.comboBox_mac = new System.Windows.Forms.ComboBox();
            this.macchineTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_plus_scm3 = new System.Windows.Forms.Button();
            this.button_plus_scm2 = new System.Windows.Forms.Button();
            this.button_plus_scm1 = new System.Windows.Forms.Button();
            this.button_plus_com = new System.Windows.Forms.Button();
            this.label_com = new System.Windows.Forms.Label();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.componentiTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_scm1 = new System.Windows.Forms.Label();
            this.comboBox_scm1 = new System.Windows.Forms.ComboBox();
            this.sottocomponenti1TViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_scm2 = new System.Windows.Forms.Label();
            this.label_scm3 = new System.Windows.Forms.Label();
            this.comboBox_scm2 = new System.Windows.Forms.ComboBox();
            this.sottocomponenti2TViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_scm3 = new System.Windows.Forms.ComboBox();
            this.sottocomponenti3TViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impianti_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Impianti_T_ViewTableAdapter();
            this.macchine_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Macchine_T_ViewTableAdapter();
            this.componenti_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Componenti_T_ViewTableAdapter();
            this.sottocomponenti_1_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Sottocomponenti_1_T_ViewTableAdapter();
            this.sottocomponenti_2_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Sottocomponenti_2_T_ViewTableAdapter();
            this.sottocomponenti_3_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Sottocomponenti_3_T_ViewTableAdapter();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.areeTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_area = new System.Windows.Forms.Label();
            this.aree_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Aree_T_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.impiantiTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentiTViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti1TViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti2TViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti3TViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areeTViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_impianto
            // 
            this.label_impianto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_impianto.ForeColor = System.Drawing.Color.Black;
            this.label_impianto.Location = new System.Drawing.Point(9, 25);
            this.label_impianto.Name = "label_impianto";
            this.label_impianto.Size = new System.Drawing.Size(91, 40);
            this.label_impianto.TabIndex = 0;
            this.label_impianto.Text = "Impianto";
            this.label_impianto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_imp
            // 
            this.comboBox_imp.DataSource = this.impiantiTViewBindingSource;
            this.comboBox_imp.DisplayMember = "LanTranslation";
            this.comboBox_imp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_imp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_imp.FormattingEnabled = true;
            this.comboBox_imp.Location = new System.Drawing.Point(109, 33);
            this.comboBox_imp.Name = "comboBox_imp";
            this.comboBox_imp.Size = new System.Drawing.Size(164, 24);
            this.comboBox_imp.TabIndex = 1;
            this.comboBox_imp.ValueMember = "IMPKey";
            this.comboBox_imp.SelectedIndexChanged += new System.EventHandler(this.comboBox_imp_SelectedIndexChanged);
            // 
            // impiantiTViewBindingSource
            // 
            this.impiantiTViewBindingSource.DataMember = "Impianti_T_View";
            this.impiantiTViewBindingSource.DataSource = this.dsActivities;
            // 
            // dsActivities
            // 
            this.dsActivities.DataSetName = "dsActivities";
            this.dsActivities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_macchina
            // 
            this.label_macchina.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_macchina.ForeColor = System.Drawing.Color.Black;
            this.label_macchina.Location = new System.Drawing.Point(9, 58);
            this.label_macchina.Name = "label_macchina";
            this.label_macchina.Size = new System.Drawing.Size(91, 40);
            this.label_macchina.TabIndex = 0;
            this.label_macchina.Text = "Macchina";
            this.label_macchina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_mac
            // 
            this.comboBox_mac.DataSource = this.macchineTViewBindingSource;
            this.comboBox_mac.DisplayMember = "LanTranslation";
            this.comboBox_mac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_mac.FormattingEnabled = true;
            this.comboBox_mac.Location = new System.Drawing.Point(109, 65);
            this.comboBox_mac.Name = "comboBox_mac";
            this.comboBox_mac.Size = new System.Drawing.Size(164, 24);
            this.comboBox_mac.TabIndex = 2;
            this.comboBox_mac.ValueMember = "MACKey";
            this.comboBox_mac.SelectedIndexChanged += new System.EventHandler(this.comboBox_mac_SelectedIndexChanged);
            // 
            // macchineTViewBindingSource
            // 
            this.macchineTViewBindingSource.DataMember = "Macchine_T_View";
            this.macchineTViewBindingSource.DataSource = this.dsActivities;
            // 
            // button_plus_scm3
            // 
            this.button_plus_scm3.BackColor = System.Drawing.Color.White;
            this.button_plus_scm3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_scm3.Image = global::Fastener.Properties.Resources.plus;
            this.button_plus_scm3.Location = new System.Drawing.Point(279, 161);
            this.button_plus_scm3.Name = "button_plus_scm3";
            this.button_plus_scm3.Size = new System.Drawing.Size(22, 23);
            this.button_plus_scm3.TabIndex = 7;
            this.button_plus_scm3.UseVisualStyleBackColor = false;
            this.button_plus_scm3.Visible = false;
            this.button_plus_scm3.Click += new System.EventHandler(this.button_plus_scm3_Click);
            // 
            // button_plus_scm2
            // 
            this.button_plus_scm2.BackColor = System.Drawing.Color.White;
            this.button_plus_scm2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_scm2.Image = global::Fastener.Properties.Resources.plus;
            this.button_plus_scm2.Location = new System.Drawing.Point(279, 129);
            this.button_plus_scm2.Name = "button_plus_scm2";
            this.button_plus_scm2.Size = new System.Drawing.Size(22, 23);
            this.button_plus_scm2.TabIndex = 7;
            this.button_plus_scm2.UseVisualStyleBackColor = false;
            this.button_plus_scm2.Visible = false;
            this.button_plus_scm2.Click += new System.EventHandler(this.button_plus_scm2_Click);
            // 
            // button_plus_scm1
            // 
            this.button_plus_scm1.BackColor = System.Drawing.Color.White;
            this.button_plus_scm1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_scm1.Image = global::Fastener.Properties.Resources.plus;
            this.button_plus_scm1.Location = new System.Drawing.Point(279, 97);
            this.button_plus_scm1.Name = "button_plus_scm1";
            this.button_plus_scm1.Size = new System.Drawing.Size(22, 23);
            this.button_plus_scm1.TabIndex = 7;
            this.button_plus_scm1.UseVisualStyleBackColor = false;
            this.button_plus_scm1.Visible = false;
            this.button_plus_scm1.Click += new System.EventHandler(this.button_plus_scm1_Click);
            // 
            // button_plus_com
            // 
            this.button_plus_com.BackColor = System.Drawing.Color.White;
            this.button_plus_com.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_com.Image = global::Fastener.Properties.Resources.plus;
            this.button_plus_com.Location = new System.Drawing.Point(279, 66);
            this.button_plus_com.Name = "button_plus_com";
            this.button_plus_com.Size = new System.Drawing.Size(22, 23);
            this.button_plus_com.TabIndex = 7;
            this.button_plus_com.UseVisualStyleBackColor = false;
            this.button_plus_com.Visible = false;
            this.button_plus_com.Click += new System.EventHandler(this.button_plus_com_Click);
            // 
            // label_com
            // 
            this.label_com.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_com.ForeColor = System.Drawing.Color.Black;
            this.label_com.Location = new System.Drawing.Point(9, 89);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(91, 40);
            this.label_com.TabIndex = 0;
            this.label_com.Text = "Componente";
            this.label_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_com.Visible = false;
            // 
            // comboBox_com
            // 
            this.comboBox_com.DataSource = this.componentiTViewBindingSource;
            this.comboBox_com.DisplayMember = "LanTranslation";
            this.comboBox_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_com.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(109, 97);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(164, 24);
            this.comboBox_com.TabIndex = 3;
            this.comboBox_com.ValueMember = "COMKey";
            this.comboBox_com.Visible = false;
            this.comboBox_com.SelectedIndexChanged += new System.EventHandler(this.comboBox_com_SelectedIndexChanged);
            // 
            // componentiTViewBindingSource
            // 
            this.componentiTViewBindingSource.DataMember = "Componenti_T_View";
            this.componentiTViewBindingSource.DataSource = this.dsActivities;
            // 
            // label_scm1
            // 
            this.label_scm1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scm1.ForeColor = System.Drawing.Color.Black;
            this.label_scm1.Location = new System.Drawing.Point(9, 119);
            this.label_scm1.Name = "label_scm1";
            this.label_scm1.Size = new System.Drawing.Size(91, 40);
            this.label_scm1.TabIndex = 0;
            this.label_scm1.Text = "Sotto Componente 1";
            this.label_scm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_scm1.Visible = false;
            // 
            // comboBox_scm1
            // 
            this.comboBox_scm1.DataSource = this.sottocomponenti1TViewBindingSource;
            this.comboBox_scm1.DisplayMember = "LanTranslation";
            this.comboBox_scm1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_scm1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_scm1.FormattingEnabled = true;
            this.comboBox_scm1.Location = new System.Drawing.Point(109, 129);
            this.comboBox_scm1.Name = "comboBox_scm1";
            this.comboBox_scm1.Size = new System.Drawing.Size(164, 24);
            this.comboBox_scm1.TabIndex = 4;
            this.comboBox_scm1.ValueMember = "SCMKey";
            this.comboBox_scm1.Visible = false;
            this.comboBox_scm1.SelectedIndexChanged += new System.EventHandler(this.comboBox_scm1_SelectedIndexChanged);
            // 
            // sottocomponenti1TViewBindingSource
            // 
            this.sottocomponenti1TViewBindingSource.DataMember = "Sottocomponenti_1_T_View";
            this.sottocomponenti1TViewBindingSource.DataSource = this.dsActivities;
            // 
            // label_scm2
            // 
            this.label_scm2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scm2.ForeColor = System.Drawing.Color.Black;
            this.label_scm2.Location = new System.Drawing.Point(9, 153);
            this.label_scm2.Name = "label_scm2";
            this.label_scm2.Size = new System.Drawing.Size(91, 40);
            this.label_scm2.TabIndex = 0;
            this.label_scm2.Text = "Sotto Componente 2";
            this.label_scm2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_scm2.Visible = false;
            // 
            // label_scm3
            // 
            this.label_scm3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scm3.ForeColor = System.Drawing.Color.Black;
            this.label_scm3.Location = new System.Drawing.Point(9, 186);
            this.label_scm3.Name = "label_scm3";
            this.label_scm3.Size = new System.Drawing.Size(91, 40);
            this.label_scm3.TabIndex = 0;
            this.label_scm3.Text = "Sotto Componente 3";
            this.label_scm3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_scm3.Visible = false;
            // 
            // comboBox_scm2
            // 
            this.comboBox_scm2.DataSource = this.sottocomponenti2TViewBindingSource;
            this.comboBox_scm2.DisplayMember = "LanTranslation";
            this.comboBox_scm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_scm2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_scm2.FormattingEnabled = true;
            this.comboBox_scm2.Location = new System.Drawing.Point(109, 161);
            this.comboBox_scm2.Name = "comboBox_scm2";
            this.comboBox_scm2.Size = new System.Drawing.Size(164, 24);
            this.comboBox_scm2.TabIndex = 5;
            this.comboBox_scm2.ValueMember = "SCMKey";
            this.comboBox_scm2.Visible = false;
            this.comboBox_scm2.SelectedIndexChanged += new System.EventHandler(this.comboBox_scm2_SelectedIndexChanged);
            // 
            // sottocomponenti2TViewBindingSource
            // 
            this.sottocomponenti2TViewBindingSource.DataMember = "Sottocomponenti_2_T_View";
            this.sottocomponenti2TViewBindingSource.DataSource = this.dsActivities;
            // 
            // comboBox_scm3
            // 
            this.comboBox_scm3.DataSource = this.sottocomponenti3TViewBindingSource;
            this.comboBox_scm3.DisplayMember = "LanTranslation";
            this.comboBox_scm3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_scm3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_scm3.FormattingEnabled = true;
            this.comboBox_scm3.Location = new System.Drawing.Point(109, 194);
            this.comboBox_scm3.Name = "comboBox_scm3";
            this.comboBox_scm3.Size = new System.Drawing.Size(164, 24);
            this.comboBox_scm3.TabIndex = 6;
            this.comboBox_scm3.ValueMember = "SCMKey";
            this.comboBox_scm3.Visible = false;
            // 
            // sottocomponenti3TViewBindingSource
            // 
            this.sottocomponenti3TViewBindingSource.DataMember = "Sottocomponenti_3_T_View";
            this.sottocomponenti3TViewBindingSource.DataSource = this.dsActivities;
            // 
            // impianti_T_ViewTableAdapter
            // 
            this.impianti_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // macchine_T_ViewTableAdapter
            // 
            this.macchine_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // componenti_T_ViewTableAdapter
            // 
            this.componenti_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // sottocomponenti_1_T_ViewTableAdapter
            // 
            this.sottocomponenti_1_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // sottocomponenti_2_T_ViewTableAdapter
            // 
            this.sottocomponenti_2_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // sottocomponenti_3_T_ViewTableAdapter
            // 
            this.sottocomponenti_3_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_area
            // 
            this.comboBox_area.DataSource = this.areeTViewBindingSource;
            this.comboBox_area.DisplayMember = "LanTranslation";
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Location = new System.Drawing.Point(109, 3);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(164, 24);
            this.comboBox_area.TabIndex = 1;
            this.comboBox_area.ValueMember = "AREKey";
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // areeTViewBindingSource
            // 
            this.areeTViewBindingSource.DataMember = "Aree_T_View";
            this.areeTViewBindingSource.DataSource = this.dsActivities;
            // 
            // label_area
            // 
            this.label_area.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_area.ForeColor = System.Drawing.Color.Black;
            this.label_area.Location = new System.Drawing.Point(9, -5);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(91, 40);
            this.label_area.TabIndex = 0;
            this.label_area.Text = "Area";
            this.label_area.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aree_T_ViewTableAdapter
            // 
            this.aree_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // CtrlPlantSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_area);
            this.Controls.Add(this.label_impianto);
            this.Controls.Add(this.comboBox_scm3);
            this.Controls.Add(this.comboBox_area);
            this.Controls.Add(this.comboBox_imp);
            this.Controls.Add(this.comboBox_scm2);
            this.Controls.Add(this.label_macchina);
            this.Controls.Add(this.label_scm3);
            this.Controls.Add(this.comboBox_mac);
            this.Controls.Add(this.label_scm2);
            this.Controls.Add(this.button_plus_scm3);
            this.Controls.Add(this.comboBox_scm1);
            this.Controls.Add(this.button_plus_scm2);
            this.Controls.Add(this.label_scm1);
            this.Controls.Add(this.button_plus_scm1);
            this.Controls.Add(this.comboBox_com);
            this.Controls.Add(this.button_plus_com);
            this.Controls.Add(this.label_com);
            this.DoubleBuffered = true;
            this.Name = "CtrlPlantSelector";
            this.Size = new System.Drawing.Size(304, 226);
            ((System.ComponentModel.ISupportInitialize)(this.impiantiTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentiTViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti1TViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti2TViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sottocomponenti3TViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areeTViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_impianto;
        private System.Windows.Forms.ComboBox comboBox_imp;
        private System.Windows.Forms.Label label_macchina;
        private System.Windows.Forms.ComboBox comboBox_mac;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.Label label_scm1;
        private System.Windows.Forms.ComboBox comboBox_scm1;
        private System.Windows.Forms.Label label_scm2;
        private System.Windows.Forms.ComboBox comboBox_scm2;
        private System.Windows.Forms.ComboBox comboBox_scm3;
        private System.Windows.Forms.Label label_scm3;
        private System.Windows.Forms.Button button_plus_com;
        private System.Windows.Forms.Button button_plus_scm3;
        private System.Windows.Forms.Button button_plus_scm2;
        private System.Windows.Forms.Button button_plus_scm1;
        private System.Windows.Forms.BindingSource impiantiTViewBindingSource;
        private DataSet.dsActivities dsActivities;
        private System.Windows.Forms.BindingSource macchineTViewBindingSource;
        private System.Windows.Forms.BindingSource componentiTViewBindingSource;
        private System.Windows.Forms.BindingSource sottocomponenti1TViewBindingSource;
        private System.Windows.Forms.BindingSource sottocomponenti2TViewBindingSource;
        private System.Windows.Forms.BindingSource sottocomponenti3TViewBindingSource;
        private DataSet.dsActivitiesTableAdapters.Impianti_T_ViewTableAdapter impianti_T_ViewTableAdapter;
        private DataSet.dsActivitiesTableAdapters.Macchine_T_ViewTableAdapter macchine_T_ViewTableAdapter;
        private DataSet.dsActivitiesTableAdapters.Componenti_T_ViewTableAdapter componenti_T_ViewTableAdapter;
        private DataSet.dsActivitiesTableAdapters.Sottocomponenti_1_T_ViewTableAdapter sottocomponenti_1_T_ViewTableAdapter;
        private DataSet.dsActivitiesTableAdapters.Sottocomponenti_2_T_ViewTableAdapter sottocomponenti_2_T_ViewTableAdapter;
        private DataSet.dsActivitiesTableAdapters.Sottocomponenti_3_T_ViewTableAdapter sottocomponenti_3_T_ViewTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.BindingSource areeTViewBindingSource;
        private DataSet.dsActivitiesTableAdapters.Aree_T_ViewTableAdapter aree_T_ViewTableAdapter;
    }
}
