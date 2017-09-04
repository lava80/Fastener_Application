namespace Fastener.Controlli
{
    partial class CtrlManContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlManContainer));
            this.dbTableLayoutPanel1 = new Fastener.DBTableLayoutPanel(this.components);
            this.dbPanel_main = new Fastener.DBPanel(this.components);
            this.dbFlowLayoutPanel1 = new Fastener.DBFlowLayoutPanel(this.components);
            this.toolbarButtonOriz_sistema = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_traduzioni = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_aziende = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_CDC = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_impianti = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_permessi = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_utenti = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.toolbarButtonOriz_CA = new Fastener.BaseClasses.ToolbarButtonOriz();
            this.dbTableLayoutPanel1.SuspendLayout();
            this.dbFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTableLayoutPanel1
            // 
            this.dbTableLayoutPanel1.ColumnCount = 1;
            this.dbTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel1.Controls.Add(this.dbPanel_main, 0, 1);
            this.dbTableLayoutPanel1.Controls.Add(this.dbFlowLayoutPanel1, 0, 0);
            this.dbTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbTableLayoutPanel1.Name = "dbTableLayoutPanel1";
            this.dbTableLayoutPanel1.RowCount = 2;
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dbTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dbTableLayoutPanel1.Size = new System.Drawing.Size(1433, 523);
            this.dbTableLayoutPanel1.TabIndex = 0;
            // 
            // dbPanel_main
            // 
            this.dbPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbPanel_main.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPanel_main.Location = new System.Drawing.Point(0, 79);
            this.dbPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.dbPanel_main.Name = "dbPanel_main";
            this.dbPanel_main.Size = new System.Drawing.Size(1433, 444);
            this.dbPanel_main.TabIndex = 0;
            // 
            // dbFlowLayoutPanel1
            // 
            this.dbFlowLayoutPanel1.AutoSize = true;
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_sistema);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_traduzioni);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_aziende);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_CDC);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_impianti);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_permessi);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_utenti);
            this.dbFlowLayoutPanel1.Controls.Add(this.toolbarButtonOriz_CA);
            this.dbFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.dbFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dbFlowLayoutPanel1.Name = "dbFlowLayoutPanel1";
            this.dbFlowLayoutPanel1.Size = new System.Drawing.Size(1433, 79);
            this.dbFlowLayoutPanel1.TabIndex = 1;
            // 
            // toolbarButtonOriz_sistema
            // 
            this.toolbarButtonOriz_sistema.AutoSize = true;
            this.toolbarButtonOriz_sistema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_sistema.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_sistema.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_sistema.Image")));
            this.toolbarButtonOriz_sistema.Location = new System.Drawing.Point(1318, 4);
            this.toolbarButtonOriz_sistema.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_sistema.Name = "toolbarButtonOriz_sistema";
            this.toolbarButtonOriz_sistema.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_sistema.TabIndex = 1;
            this.toolbarButtonOriz_sistema.Text = "\r\nAnagrafica\r\nSistema";
            this.toolbarButtonOriz_sistema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_sistema.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_sistema.Click += new System.EventHandler(this.toolbarButtonOriz_sistema_Click);
            // 
            // toolbarButtonOriz_traduzioni
            // 
            this.toolbarButtonOriz_traduzioni.AutoSize = true;
            this.toolbarButtonOriz_traduzioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_traduzioni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_traduzioni.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_traduzioni.Image")));
            this.toolbarButtonOriz_traduzioni.Location = new System.Drawing.Point(1199, 4);
            this.toolbarButtonOriz_traduzioni.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_traduzioni.Name = "toolbarButtonOriz_traduzioni";
            this.toolbarButtonOriz_traduzioni.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_traduzioni.TabIndex = 1;
            this.toolbarButtonOriz_traduzioni.Text = "\r\nTabella \r\nTraduzioni";
            this.toolbarButtonOriz_traduzioni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_traduzioni.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_traduzioni.Click += new System.EventHandler(this.toolbarButtonOriz_traduzioni_Click);
            // 
            // toolbarButtonOriz_aziende
            // 
            this.toolbarButtonOriz_aziende.AutoSize = true;
            this.toolbarButtonOriz_aziende.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_aziende.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_aziende.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_aziende.Image")));
            this.toolbarButtonOriz_aziende.Location = new System.Drawing.Point(1080, 4);
            this.toolbarButtonOriz_aziende.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_aziende.Name = "toolbarButtonOriz_aziende";
            this.toolbarButtonOriz_aziende.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_aziende.TabIndex = 1;
            this.toolbarButtonOriz_aziende.Text = "\r\nAnagrafica\r\nAziende";
            this.toolbarButtonOriz_aziende.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_aziende.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_aziende.Click += new System.EventHandler(this.toolbarButtonOriz_aziende_Click);
            // 
            // toolbarButtonOriz_CDC
            // 
            this.toolbarButtonOriz_CDC.AutoSize = true;
            this.toolbarButtonOriz_CDC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_CDC.Enabled = false;
            this.toolbarButtonOriz_CDC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_CDC.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_CDC.Image")));
            this.toolbarButtonOriz_CDC.Location = new System.Drawing.Point(961, 4);
            this.toolbarButtonOriz_CDC.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_CDC.Name = "toolbarButtonOriz_CDC";
            this.toolbarButtonOriz_CDC.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_CDC.TabIndex = 1;
            this.toolbarButtonOriz_CDC.Text = "\r\nCentri\r\ndi Costo";
            this.toolbarButtonOriz_CDC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_CDC.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_CDC.Click += new System.EventHandler(this.toolbarButtonOriz_CDC_Click);
            // 
            // toolbarButtonOriz_impianti
            // 
            this.toolbarButtonOriz_impianti.AutoSize = true;
            this.toolbarButtonOriz_impianti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_impianti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_impianti.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_impianti.Image")));
            this.toolbarButtonOriz_impianti.Location = new System.Drawing.Point(842, 4);
            this.toolbarButtonOriz_impianti.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_impianti.Name = "toolbarButtonOriz_impianti";
            this.toolbarButtonOriz_impianti.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_impianti.TabIndex = 1;
            this.toolbarButtonOriz_impianti.Text = "\r\nAnagrafica\r\nImpianti";
            this.toolbarButtonOriz_impianti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_impianti.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_impianti.Click += new System.EventHandler(this.toolbarButtonOriz_impianti_Click);
            // 
            // toolbarButtonOriz_permessi
            // 
            this.toolbarButtonOriz_permessi.AutoSize = true;
            this.toolbarButtonOriz_permessi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_permessi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_permessi.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_permessi.Image")));
            this.toolbarButtonOriz_permessi.Location = new System.Drawing.Point(723, 4);
            this.toolbarButtonOriz_permessi.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_permessi.Name = "toolbarButtonOriz_permessi";
            this.toolbarButtonOriz_permessi.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_permessi.TabIndex = 1;
            this.toolbarButtonOriz_permessi.Text = "\r\nAnagrafica\r\nPermessi";
            this.toolbarButtonOriz_permessi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_permessi.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_permessi.Click += new System.EventHandler(this.toolbarButtonOriz_permessi_Click);
            // 
            // toolbarButtonOriz_utenti
            // 
            this.toolbarButtonOriz_utenti.AutoSize = true;
            this.toolbarButtonOriz_utenti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_utenti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_utenti.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_utenti.Image")));
            this.toolbarButtonOriz_utenti.Location = new System.Drawing.Point(604, 4);
            this.toolbarButtonOriz_utenti.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_utenti.Name = "toolbarButtonOriz_utenti";
            this.toolbarButtonOriz_utenti.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_utenti.TabIndex = 1;
            this.toolbarButtonOriz_utenti.Text = "\r\nAnagrafica\r\nUtenti";
            this.toolbarButtonOriz_utenti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_utenti.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_utenti.Click += new System.EventHandler(this.toolbarButtonOriz_utenti_Click);
            // 
            // toolbarButtonOriz_CA
            // 
            this.toolbarButtonOriz_CA.AutoSize = true;
            this.toolbarButtonOriz_CA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarButtonOriz_CA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarButtonOriz_CA.Image = ((System.Drawing.Image)(resources.GetObject("toolbarButtonOriz_CA.Image")));
            this.toolbarButtonOriz_CA.Location = new System.Drawing.Point(485, 4);
            this.toolbarButtonOriz_CA.Margin = new System.Windows.Forms.Padding(4);
            this.toolbarButtonOriz_CA.Name = "toolbarButtonOriz_CA";
            this.toolbarButtonOriz_CA.Size = new System.Drawing.Size(111, 71);
            this.toolbarButtonOriz_CA.TabIndex = 2;
            this.toolbarButtonOriz_CA.Text = "\r\nAnagrafica\r\nCA";
            this.toolbarButtonOriz_CA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolbarButtonOriz_CA.UseVisualStyleBackColor = true;
            this.toolbarButtonOriz_CA.Click += new System.EventHandler(this.toolbarButtonOriz_CA_Click);
            // 
            // CtrlManContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbTableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlManContainer";
            this.Size = new System.Drawing.Size(1433, 523);
            this.dbTableLayoutPanel1.ResumeLayout(false);
            this.dbTableLayoutPanel1.PerformLayout();
            this.dbFlowLayoutPanel1.ResumeLayout(false);
            this.dbFlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DBTableLayoutPanel dbTableLayoutPanel1;
        private DBPanel dbPanel_main;
        private DBFlowLayoutPanel dbFlowLayoutPanel1;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_utenti;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_impianti;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_sistema;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_traduzioni;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_aziende;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_CDC;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_permessi;
        private BaseClasses.ToolbarButtonOriz toolbarButtonOriz_CA;
    }
}
