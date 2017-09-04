namespace Fastener
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dbTableLayoutPanel1 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel3 = new Fastener.DBPanel(this.components);
            this.dbFlowLayoutPanel2 = new Fastener.DBFlowLayoutPanel(this.components);
            this.button_max_restore = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_act_no_report = new System.Windows.Forms.Label();
            this.dbPanel2 = new Fastener.DBPanel(this.components);
            this.label_utente = new System.Windows.Forms.Label();
            this.label_language = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.dbTableLayoutPanel2 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel_main = new Fastener.DBPanel(this.components);
            this.dbFlowLayoutPanel1 = new Fastener.DBFlowLayoutPanel(this.components);
            this.toolbarButton_quit = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_RichiesteLavorazioni = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_trackingAcq = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_maintenance = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_data_entry = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_eventi_man = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_change_password = new Fastener.BaseClasses.ToolbarButton();
            this.toolbarButton_back_to_login = new Fastener.BaseClasses.ToolbarButton();
            this.dbPanel1 = new Fastener.DBPanel(this.components);
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbPanel3.SuspendLayout();
            this.dbFlowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dbPanel2.SuspendLayout();
            this.dbTableLayoutPanel2.SuspendLayout();
            this.dbFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.dbTableLayoutPanel1, "dbTableLayoutPanel1");
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel3, 0, 0);
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel2, 0, 2);
            this.dbTableLayoutPanel1.Controls.Add(this.dbTableLayoutPanel2, 0, 1);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            // 
            // dbPanel3
            // 
            this.dbPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.dbPanel3.Controls.Add(this.dbFlowLayoutPanel2);
            resources.ApplyResources(this.dbPanel3, "dbPanel3");
            this.dbPanel3.Name = "dbPanel3";
            // 
            // dbFlowLayoutPanel2
            // 
            resources.ApplyResources(this.dbFlowLayoutPanel2, "dbFlowLayoutPanel2");
            this.dbFlowLayoutPanel2.Controls.Add(this.button_max_restore);
            this.dbFlowLayoutPanel2.Controls.Add(this.button_minimize);
            this.dbFlowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.dbFlowLayoutPanel2.Controls.Add(this.label_act_no_report);
            this.dbFlowLayoutPanel2.Name = "dbFlowLayoutPanel2";
            // 
            // button_max_restore
            // 
            resources.ApplyResources(this.button_max_restore, "button_max_restore");
            this.button_max_restore.BackColor = System.Drawing.Color.Transparent;
            this.button_max_restore.BackgroundImage = global::Fastener.Properties.Resources.maximize;
            this.button_max_restore.Name = "button_max_restore";
            this.button_max_restore.UseVisualStyleBackColor = false;
            this.button_max_restore.Click += new System.EventHandler(this.button_max_restore_Click);
            // 
            // button_minimize
            // 
            resources.ApplyResources(this.button_minimize, "button_minimize");
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = global::Fastener.Properties.Resources.minimize;
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label_act_no_report
            // 
            resources.ApplyResources(this.label_act_no_report, "label_act_no_report");
            this.label_act_no_report.ForeColor = System.Drawing.Color.IndianRed;
            this.label_act_no_report.Name = "label_act_no_report";
            // 
            // dbPanel2
            // 
            this.dbPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dbPanel2.Controls.Add(this.label_utente);
            this.dbPanel2.Controls.Add(this.label_language);
            this.dbPanel2.Controls.Add(this.label_version);
            resources.ApplyResources(this.dbPanel2, "dbPanel2");
            this.dbPanel2.Name = "dbPanel2";
            // 
            // label_utente
            // 
            resources.ApplyResources(this.label_utente, "label_utente");
            this.label_utente.ForeColor = System.Drawing.SystemColors.Window;
            this.label_utente.Name = "label_utente";
            // 
            // label_language
            // 
            resources.ApplyResources(this.label_language, "label_language");
            this.label_language.ForeColor = System.Drawing.SystemColors.Window;
            this.label_language.Name = "label_language";
            // 
            // label_version
            // 
            resources.ApplyResources(this.label_version, "label_version");
            this.label_version.ForeColor = System.Drawing.SystemColors.Window;
            this.label_version.Name = "label_version";
            // 
            // dbTableLayoutPanel2
            // 
            this.dbTableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dbTableLayoutPanel2, "dbTableLayoutPanel2");
            this.dbTableLayoutPanel2.Controls.Add(this.dbPanel_main, 2, 0);
            this.dbTableLayoutPanel2.Controls.Add(this.dbFlowLayoutPanel1, 0, 0);
            this.dbTableLayoutPanel2.Controls.Add(this.dbPanel1, 1, 0);
            this.dbTableLayoutPanel2.Name = "dbTableLayoutPanel2";
            // 
            // dbPanel_main
            // 
            this.dbPanel_main.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dbPanel_main, "dbPanel_main");
            this.dbPanel_main.Name = "dbPanel_main";
            // 
            // dbFlowLayoutPanel1
            // 
            resources.ApplyResources(this.dbFlowLayoutPanel1, "dbFlowLayoutPanel1");
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_quit);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_RichiesteLavorazioni);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_trackingAcq);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_maintenance);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_data_entry);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_eventi_man);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_change_password);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButton_back_to_login);
            this.dbFlowLayoutPanel1.Name = "dbFlowLayoutPanel1";
            // 
            // toolbarButton_quit
            // 
            resources.ApplyResources(this.toolbarButton_quit, "toolbarButton_quit");
            this.toolbarButton_quit.Name = "toolbarButton_quit";
            this.toolbarButton_quit.UseVisualStyleBackColor = true;
            this.toolbarButton_quit.Click += new System.EventHandler(this.toolbarButton_quit_Click);
            // 
            // toolbarButton_RichiesteLavorazioni
            // 
            resources.ApplyResources(this.toolbarButton_RichiesteLavorazioni, "toolbarButton_RichiesteLavorazioni");
            this.toolbarButton_RichiesteLavorazioni.Name = "toolbarButton_RichiesteLavorazioni";
            this.toolbarButton_RichiesteLavorazioni.UseVisualStyleBackColor = true;
            this.toolbarButton_RichiesteLavorazioni.Click += new System.EventHandler(this.toolbarButton_RichiesteLavorazioni_Click);
            // 
            // toolbarButton_trackingAcq
            // 
            resources.ApplyResources(this.toolbarButton_trackingAcq, "toolbarButton_trackingAcq");
            this.toolbarButton_trackingAcq.Name = "toolbarButton_trackingAcq";
            this.toolbarButton_trackingAcq.UseVisualStyleBackColor = true;
            this.toolbarButton_trackingAcq.Click += new System.EventHandler(this.toolbarButton_trackingAcq_Click);
            // 
            // toolbarButton_maintenance
            // 
            resources.ApplyResources(this.toolbarButton_maintenance, "toolbarButton_maintenance");
            this.toolbarButton_maintenance.Name = "toolbarButton_maintenance";
            this.toolbarButton_maintenance.UseVisualStyleBackColor = true;
            this.toolbarButton_maintenance.Click += new System.EventHandler(this.toolbarButton_maintenance_Click);
            // 
            // toolbarButton_data_entry
            // 
            resources.ApplyResources(this.toolbarButton_data_entry, "toolbarButton_data_entry");
            this.toolbarButton_data_entry.Name = "toolbarButton_data_entry";
            this.toolbarButton_data_entry.UseVisualStyleBackColor = true;
            this.toolbarButton_data_entry.Click += new System.EventHandler(this.toolbarButton_data_entry_Click);
            // 
            // toolbarButton_eventi_man
            // 
            resources.ApplyResources(this.toolbarButton_eventi_man, "toolbarButton_eventi_man");
            this.toolbarButton_eventi_man.Name = "toolbarButton_eventi_man";
            this.toolbarButton_eventi_man.UseVisualStyleBackColor = true;
            this.toolbarButton_eventi_man.Click += new System.EventHandler(this.toolbarButton_eventi_man_Click);
            // 
            // toolbarButton_change_password
            // 
            resources.ApplyResources(this.toolbarButton_change_password, "toolbarButton_change_password");
            this.toolbarButton_change_password.Name = "toolbarButton_change_password";
            this.toolbarButton_change_password.UseVisualStyleBackColor = true;
            this.toolbarButton_change_password.Click += new System.EventHandler(this.toolbarButton_change_password_Click);
            // 
            // toolbarButton_back_to_login
            // 
            resources.ApplyResources(this.toolbarButton_back_to_login, "toolbarButton_back_to_login");
            this.toolbarButton_back_to_login.Name = "toolbarButton_back_to_login";
            this.toolbarButton_back_to_login.UseVisualStyleBackColor = true;
            this.toolbarButton_back_to_login.Click += new System.EventHandler(this.toolbarButton_back_to_login_Click);
            // 
            // dbPanel1
            // 
            this.dbPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.dbPanel1, "dbPanel1");
            this.dbPanel1.Name = "dbPanel1";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowInTaskbar = true;
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbPanel3.ResumeLayout(false);
            this.dbPanel3.PerformLayout();
            this.dbFlowLayoutPanel2.ResumeLayout(false);
            this.dbFlowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dbPanel2.ResumeLayout(false);
            this.dbTableLayoutPanel2.ResumeLayout(false);
            this.dbTableLayoutPanel2.PerformLayout();
            this.dbFlowLayoutPanel1.ResumeLayout(false);
            this.dbFlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DBTableLayoutPanel dbTableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DBPanel dbPanel_main;
        private DBPanel dbPanel2;
        private DBPanel dbPanel3;
        private DBTableLayoutPanel dbTableLayoutPanel2;
        private DBFlowLayoutPanel dbFlowLayoutPanel1;
        private BaseClasses.ToolbarButton toolbarButton1;
        private BaseClasses.ToolbarButton toolbarButton_data_entry;
        private BaseClasses.ToolbarButton toolbarButton_maintenance;
        private BaseClasses.ToolbarButton toolbarButton_quit;
        private BaseClasses.ToolbarButton toolbarButton_change_password;
        private BaseClasses.ToolbarButton toolbarButton_back_to_login;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_language;
        private DBPanel dbPanel1;
        private System.Windows.Forms.Label label_utente;
        private System.Windows.Forms.Button button_max_restore;
        private BaseClasses.ToolbarButton toolbarButton_eventi_man;
        private DBFlowLayoutPanel dbFlowLayoutPanel2;
        private System.Windows.Forms.Label label_act_no_report;
        private System.Windows.Forms.Button button_minimize;
        private BaseClasses.ToolbarButton toolbarButton_trackingAcq;
        private BaseClasses.ToolbarButton toolbarButton_RichiesteLavorazioni;
    }
}