namespace Fastener.Controlli
{
    partial class CtrlActivity
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
            this.dbPanel_main = new Fastener.DBPanel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Capex = new System.Windows.Forms.ComboBox();
            this.manAnaCapexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsActivities = new Fastener.DataSet.dsActivities();
            this.ctrlPlantSelector = new Fastener.Controlli.CtrlPlantSelector();
            this.ctrlDateTimePicker_start = new Fastener.Controlli.CtrlDateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlDateTimePicker_end = new Fastener.Controlli.CtrlDateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tipo_man = new System.Windows.Forms.Label();
            this.comboBox_tip_ore = new System.Windows.Forms.ComboBox();
            this.tipoOreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_tipo_man = new System.Windows.Forms.ComboBox();
            this.tipoManutenzioneTViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_remark = new System.Windows.Forms.TextBox();
            this.label_plant = new System.Windows.Forms.Label();
            this.label_remark = new System.Windows.Forms.Label();
            this.dbPanel_treenode_view = new Fastener.DBPanel(this.components);
            this.treeView_plant = new System.Windows.Forms.TreeView();
            this.tipo_Manutenzione_T_ViewTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter();
            this.tipoOreTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.TipoOreTableAdapter();
            this.man_Ana_CapexTableAdapter = new Fastener.DataSet.dsActivitiesTableAdapters.Man_Ana_CapexTableAdapter();
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbPanel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaCapexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).BeginInit();
            this.dbPanel_treenode_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 4;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel_main, 1, 1);
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel_treenode_view, 2, 1);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 3;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(1485, 589);
            this.dbTableLayoutPanel1.TabIndex = 6;
            // 
            // dbPanel_main
            // 
            this.dbPanel_main.BackgroundImage = global::Fastener.Properties.Resources.activity_layout_25b;
            this.dbPanel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbPanel_main.Controls.Add(this.label2);
            this.dbPanel_main.Controls.Add(this.comboBox_Capex);
            this.dbPanel_main.Controls.Add(this.ctrlPlantSelector);
            this.dbPanel_main.Controls.Add(this.ctrlDateTimePicker_start);
            this.dbPanel_main.Controls.Add(this.button1);
            this.dbPanel_main.Controls.Add(this.ctrlDateTimePicker_end);
            this.dbPanel_main.Controls.Add(this.button_save);
            this.dbPanel_main.Controls.Add(this.label1);
            this.dbPanel_main.Controls.Add(this.label_tipo_man);
            this.dbPanel_main.Controls.Add(this.comboBox_tip_ore);
            this.dbPanel_main.Controls.Add(this.comboBox_tipo_man);
            this.dbPanel_main.Controls.Add(this.textBox_remark);
            this.dbPanel_main.Controls.Add(this.label_plant);
            this.dbPanel_main.Controls.Add(this.label_remark);
            this.dbPanel_main.Location = new System.Drawing.Point(212, 59);
            this.dbPanel_main.Name = "dbPanel_main";
            this.dbPanel_main.Size = new System.Drawing.Size(705, 470);
            this.dbPanel_main.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Capex";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Capex
            // 
            this.comboBox_Capex.DataSource = this.manAnaCapexBindingSource;
            this.comboBox_Capex.DisplayMember = "Descr";
            this.comboBox_Capex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Capex.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Capex.FormattingEnabled = true;
            this.comboBox_Capex.Location = new System.Drawing.Point(164, 45);
            this.comboBox_Capex.Name = "comboBox_Capex";
            this.comboBox_Capex.Size = new System.Drawing.Size(521, 24);
            this.comboBox_Capex.TabIndex = 21;
            this.comboBox_Capex.ValueMember = "PrjCode";
            // 
            // manAnaCapexBindingSource
            // 
            this.manAnaCapexBindingSource.DataMember = "Man_Ana_Capex";
            this.manAnaCapexBindingSource.DataSource = this.dsActivities;
            // 
            // dsActivities
            // 
            this.dsActivities.DataSetName = "dsActivities";
            this.dsActivities.Locale = new System.Globalization.CultureInfo("it-IT");
            this.dsActivities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctrlPlantSelector
            // 
            this.ctrlPlantSelector.AutoSize = true;
            this.ctrlPlantSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPlantSelector.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPlantSelector.Location = new System.Drawing.Point(350, 247);
            this.ctrlPlantSelector.Name = "ctrlPlantSelector";
            this.ctrlPlantSelector.Size = new System.Drawing.Size(276, 98);
            this.ctrlPlantSelector.TabIndex = 19;
            // 
            // ctrlDateTimePicker_start
            // 
            this.ctrlDateTimePicker_start.AutoSize = true;
            this.ctrlDateTimePicker_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_start.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_start.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_start.LabelText = "Inizio";
            this.ctrlDateTimePicker_start.Location = new System.Drawing.Point(61, 110);
            this.ctrlDateTimePicker_start.Name = "ctrlDateTimePicker_start";
            this.ctrlDateTimePicker_start.ShowDate = true;
            this.ctrlDateTimePicker_start.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_start.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "TREEVIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlDateTimePicker_end
            // 
            this.ctrlDateTimePicker_end.AutoSize = true;
            this.ctrlDateTimePicker_end.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlDateTimePicker_end.BackColor = System.Drawing.Color.Transparent;
            this.ctrlDateTimePicker_end.FontColor = System.Drawing.Color.Black;
            this.ctrlDateTimePicker_end.LabelText = "Fine";
            this.ctrlDateTimePicker_end.Location = new System.Drawing.Point(406, 111);
            this.ctrlDateTimePicker_end.Name = "ctrlDateTimePicker_end";
            this.ctrlDateTimePicker_end.ShowDate = true;
            this.ctrlDateTimePicker_end.Size = new System.Drawing.Size(211, 75);
            this.ctrlDateTimePicker_end.TabIndex = 17;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(36, 431);
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
            this.label1.Location = new System.Drawing.Point(354, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Ore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_tipo_man
            // 
            this.label_tipo_man.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo_man.ForeColor = System.Drawing.Color.White;
            this.label_tipo_man.Location = new System.Drawing.Point(17, 17);
            this.label_tipo_man.Name = "label_tipo_man";
            this.label_tipo_man.Size = new System.Drawing.Size(141, 18);
            this.label_tipo_man.TabIndex = 0;
            this.label_tipo_man.Text = "Tipo Manutenzione";
            this.label_tipo_man.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_tip_ore
            // 
            this.comboBox_tip_ore.DataSource = this.tipoOreBindingSource;
            this.comboBox_tip_ore.DisplayMember = "TipOreName";
            this.comboBox_tip_ore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tip_ore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tip_ore.FormattingEnabled = true;
            this.comboBox_tip_ore.Location = new System.Drawing.Point(505, 15);
            this.comboBox_tip_ore.Name = "comboBox_tip_ore";
            this.comboBox_tip_ore.Size = new System.Drawing.Size(180, 24);
            this.comboBox_tip_ore.TabIndex = 0;
            this.comboBox_tip_ore.ValueMember = "TipOreKey";
            // 
            // tipoOreBindingSource
            // 
            this.tipoOreBindingSource.DataMember = "TipoOre";
            this.tipoOreBindingSource.DataSource = this.dsActivities;
            // 
            // comboBox_tipo_man
            // 
            this.comboBox_tipo_man.DataSource = this.tipoManutenzioneTViewBindingSource;
            this.comboBox_tipo_man.DisplayMember = "LanTranslation";
            this.comboBox_tipo_man.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_man.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_man.FormattingEnabled = true;
            this.comboBox_tipo_man.Location = new System.Drawing.Point(164, 15);
            this.comboBox_tipo_man.Name = "comboBox_tipo_man";
            this.comboBox_tipo_man.Size = new System.Drawing.Size(180, 24);
            this.comboBox_tipo_man.TabIndex = 0;
            this.comboBox_tipo_man.ValueMember = "TipoManKey";
            // 
            // tipoManutenzioneTViewBindingSource
            // 
            this.tipoManutenzioneTViewBindingSource.DataMember = "Tipo_Manutenzione_T_View";
            this.tipoManutenzioneTViewBindingSource.DataSource = this.dsActivities;
            // 
            // textBox_remark
            // 
            this.textBox_remark.BackColor = System.Drawing.Color.Silver;
            this.textBox_remark.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_remark.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_remark.Location = new System.Drawing.Point(36, 243);
            this.textBox_remark.Multiline = true;
            this.textBox_remark.Name = "textBox_remark";
            this.textBox_remark.Size = new System.Drawing.Size(282, 143);
            this.textBox_remark.TabIndex = 15;
            this.textBox_remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_plant
            // 
            this.label_plant.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plant.ForeColor = System.Drawing.Color.White;
            this.label_plant.Location = new System.Drawing.Point(324, 226);
            this.label_plant.Name = "label_plant";
            this.label_plant.Size = new System.Drawing.Size(378, 18);
            this.label_plant.TabIndex = 0;
            this.label_plant.Text = "Impianto";
            this.label_plant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_remark
            // 
            this.label_remark.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_remark.ForeColor = System.Drawing.Color.White;
            this.label_remark.Location = new System.Drawing.Point(3, 222);
            this.label_remark.Name = "label_remark";
            this.label_remark.Size = new System.Drawing.Size(341, 18);
            this.label_remark.TabIndex = 0;
            this.label_remark.Text = "Commento";
            this.label_remark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbPanel_treenode_view
            // 
            this.dbPanel_treenode_view.AutoScroll = true;
            this.dbPanel_treenode_view.Controls.Add(this.treeView_plant);
            this.dbPanel_treenode_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbPanel_treenode_view.Location = new System.Drawing.Point(923, 59);
            this.dbPanel_treenode_view.Name = "dbPanel_treenode_view";
            this.dbPanel_treenode_view.Size = new System.Drawing.Size(350, 470);
            this.dbPanel_treenode_view.TabIndex = 6;
            // 
            // treeView_plant
            // 
            this.treeView_plant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_plant.Location = new System.Drawing.Point(0, 0);
            this.treeView_plant.Name = "treeView_plant";
            this.treeView_plant.Size = new System.Drawing.Size(350, 470);
            this.treeView_plant.TabIndex = 0;
            this.treeView_plant.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_plant_AfterCollapse);
            this.treeView_plant.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_plant_BeforeSelect);
            this.treeView_plant.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_plant_AfterSelect);
            // 
            // tipo_Manutenzione_T_ViewTableAdapter
            // 
            this.tipo_Manutenzione_T_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // tipoOreTableAdapter
            // 
            this.tipoOreTableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_CapexTableAdapter
            // 
            this.man_Ana_CapexTableAdapter.ClearBeforeFill = true;
            // 
            // CtrlActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Name = "CtrlActivity";
            this.Size = new System.Drawing.Size(1485, 589);
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbPanel_main.ResumeLayout(false);
            this.dbPanel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaCapexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoManutenzioneTViewBindingSource)).EndInit();
            this.dbPanel_treenode_view.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_remark;
        private System.Windows.Forms.TextBox textBox_remark;
        private System.Windows.Forms.Label label_tipo_man;
        private System.Windows.Forms.ComboBox comboBox_tipo_man;
        private DBPanel dbPanel_main;
        private DBTableLayoutPanel dbTableLayoutPanel1;
        private System.Windows.Forms.Button button_save;
        private DataSet.dsActivities dsActivities;
        private System.Windows.Forms.BindingSource tipoManutenzioneTViewBindingSource;
        private DataSet.dsActivitiesTableAdapters.Tipo_Manutenzione_T_ViewTableAdapter tipo_Manutenzione_T_ViewTableAdapter;
        private DBPanel dbPanel_treenode_view;
        private System.Windows.Forms.TreeView treeView_plant;
        private System.Windows.Forms.Button button1;
        private CtrlDateTimePicker ctrlDateTimePicker_end;
        private CtrlDateTimePicker ctrlDateTimePicker_start;
        private CtrlPlantSelector ctrlPlantSelector;
        private System.Windows.Forms.Label label_plant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tip_ore;
        private System.Windows.Forms.BindingSource tipoOreBindingSource;
        private DataSet.dsActivitiesTableAdapters.TipoOreTableAdapter tipoOreTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Capex;
        private System.Windows.Forms.BindingSource manAnaCapexBindingSource;
        private DataSet.dsActivitiesTableAdapters.Man_Ana_CapexTableAdapter man_Ana_CapexTableAdapter;
    }
}
