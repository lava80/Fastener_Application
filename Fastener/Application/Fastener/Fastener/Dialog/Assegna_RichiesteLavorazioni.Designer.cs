namespace Fastener.Dialog
{
    partial class Assegna_RichiesteLavorazioni
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
            this.comboBox_Esecutore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dsRichiesteLavorazioni = new Fastener.DataSet.dsRichiesteLavorazioni();
            this.manAnaUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.man_Ana_UTETableAdapter = new Fastener.DataSet.dsRichiesteLavorazioniTableAdapters.Man_Ana_UTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRichiesteLavorazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Esecutore
            // 
            this.comboBox_Esecutore.DataSource = this.manAnaUTEBindingSource;
            this.comboBox_Esecutore.DisplayMember = "UTEName";
            this.comboBox_Esecutore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Esecutore.FormattingEnabled = true;
            this.comboBox_Esecutore.Location = new System.Drawing.Point(153, 54);
            this.comboBox_Esecutore.Name = "comboBox_Esecutore";
            this.comboBox_Esecutore.Size = new System.Drawing.Size(187, 25);
            this.comboBox_Esecutore.TabIndex = 0;
            this.comboBox_Esecutore.ValueMember = "UTEKey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esecutore:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(295, 110);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(82, 31);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 110);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(82, 31);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dsRichiesteLavorazioni
            // 
            this.dsRichiesteLavorazioni.DataSetName = "dsRichiesteLavorazioni";
            this.dsRichiesteLavorazioni.Locale = new System.Globalization.CultureInfo("it-IT");
            this.dsRichiesteLavorazioni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manAnaUTEBindingSource
            // 
            this.manAnaUTEBindingSource.DataMember = "Man_Ana_UTE";
            this.manAnaUTEBindingSource.DataSource = this.dsRichiesteLavorazioni;
            // 
            // man_Ana_UTETableAdapter
            // 
            this.man_Ana_UTETableAdapter.ClearBeforeFill = true;
            // 
            // Assegna_RichiesteLavorazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(389, 151);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Esecutore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Assegna_RichiesteLavorazioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DaySelector";
            this.Load += new System.EventHandler(this.Assegna_RichiesteLavorazioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRichiesteLavorazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manAnaUTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Esecutore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button buttonOK;
        private DataSet.dsRichiesteLavorazioni dsRichiesteLavorazioni;
        private System.Windows.Forms.BindingSource manAnaUTEBindingSource;
        private DataSet.dsRichiesteLavorazioniTableAdapters.Man_Ana_UTETableAdapter man_Ana_UTETableAdapter;
    }
}