namespace Fastener
{
    partial class frmLogin
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmbUtente = new System.Windows.Forms.ComboBox();
            this.manAnaUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUTE = new Fastener.DataSet.dsUTE();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain_ = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVersion_ = new System.Windows.Forms.Label();
            this.lblMill_ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_lingua = new System.Windows.Forms.ComboBox();
            this.manAnaLANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.man_Ana_UTETableAdapter = new Fastener.DataSet.dsUTETableAdapters.Man_Ana_UTETableAdapter();
            this.man_Ana_LANTableAdapter = new Fastener.DataSet.dsUTETableAdapters.Man_Ana_LANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUTE)).BeginInit();
            this.pnlMain_.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUtente
            // 
            this.cmbUtente.DataSource = this.manAnaUTEBindingSource;
            this.cmbUtente.DisplayMember = "UTEName";
            this.cmbUtente.FormattingEnabled = true;
            resources.ApplyResources(this.cmbUtente, "cmbUtente");
            this.cmbUtente.Name = "cmbUtente";
            this.cmbUtente.ValueMember = "UTEName";
            // 
            // manAnaUTEBindingSource
            // 
            this.manAnaUTEBindingSource.DataMember = "Man_Ana_UTE";
            this.manAnaUTEBindingSource.DataSource = this.dsUTE;
            // 
            // dsUTE
            // 
            this.dsUTE.DataSetName = "dsUTE";
            this.dsUTE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DimGray;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMain_
            // 
            this.pnlMain_.BackgroundImage = global::Fastener.Properties.Resources.Login_Form;
            this.pnlMain_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain_.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain_.Controls.Add(this.btnCancel);
            this.pnlMain_.Controls.Add(this.btnOk);
            this.pnlMain_.Controls.Add(this.label5);
            this.pnlMain_.Controls.Add(this.txtPassword);
            this.pnlMain_.Controls.Add(this.label2);
            this.pnlMain_.Controls.Add(this.label1);
            this.pnlMain_.Controls.Add(this.comboBox_lingua);
            this.pnlMain_.Controls.Add(this.cmbUtente);
            resources.ApplyResources(this.pnlMain_, "pnlMain_");
            this.pnlMain_.Name = "pnlMain_";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblVersion_, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMill_, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblVersion_
            // 
            resources.ApplyResources(this.lblVersion_, "lblVersion_");
            this.lblVersion_.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion_.ForeColor = System.Drawing.Color.White;
            this.lblVersion_.Name = "lblVersion_";
            // 
            // lblMill_
            // 
            resources.ApplyResources(this.lblMill_, "lblMill_");
            this.lblMill_.BackColor = System.Drawing.Color.Transparent;
            this.lblMill_.ForeColor = System.Drawing.Color.White;
            this.lblMill_.Name = "lblMill_";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // comboBox_lingua
            // 
            this.comboBox_lingua.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manAnaUTEBindingSource, "LANKey", true));
            this.comboBox_lingua.DataSource = this.manAnaLANBindingSource;
            this.comboBox_lingua.DisplayMember = "LANName";
            this.comboBox_lingua.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_lingua, "comboBox_lingua");
            this.comboBox_lingua.Name = "comboBox_lingua";
            this.comboBox_lingua.ValueMember = "LANKey";
            this.comboBox_lingua.SelectedValueChanged += new System.EventHandler(this.comboBox_lingua_SelectedValueChanged);
            // 
            // manAnaLANBindingSource
            // 
            this.manAnaLANBindingSource.DataMember = "Man_Ana_LAN";
            this.manAnaLANBindingSource.DataSource = this.dsUTE;
            // 
            // man_Ana_UTETableAdapter
            // 
            this.man_Ana_UTETableAdapter.ClearBeforeFill = true;
            // 
            // man_Ana_LANTableAdapter
            // 
            this.man_Ana_LANTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlMain_);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowInTaskbar = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUTE)).EndInit();
            this.pnlMain_.ResumeLayout(false);
            this.pnlMain_.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaLANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ComboBox cmbUtente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMain_;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVersion_;
        private System.Windows.Forms.Label lblMill_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DataSet.dsUTE dsUTE;
        private System.Windows.Forms.BindingSource manAnaUTEBindingSource;
        private DataSet.dsUTETableAdapters.Man_Ana_UTETableAdapter man_Ana_UTETableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_lingua;
        private System.Windows.Forms.BindingSource manAnaLANBindingSource;
        private DataSet.dsUTETableAdapters.Man_Ana_LANTableAdapter man_Ana_LANTableAdapter;
    }
}