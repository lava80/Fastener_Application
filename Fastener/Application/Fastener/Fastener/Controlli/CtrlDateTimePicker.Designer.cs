namespace Fastener.Controlli
{
    partial class CtrlDateTimePicker
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
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label_bw = new System.Windows.Forms.Label();
            this.label_fw = new System.Windows.Forms.Label();
            this.label_ffw = new System.Windows.Forms.Label();
            this.label_fbw = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.button_bw = new System.Windows.Forms.Button();
            this.button_fbw = new System.Windows.Forms.Button();
            this.button_ffw = new System.Windows.Forms.Button();
            this.button_fw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_m
            // 
            this.textBox_m.BackColor = System.Drawing.Color.Silver;
            this.textBox_m.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_m.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_m.Location = new System.Drawing.Point(106, 27);
            this.textBox_m.Multiline = true;
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.ReadOnly = true;
            this.textBox_m.Size = new System.Drawing.Size(44, 35);
            this.textBox_m.TabIndex = 17;
            this.textBox_m.Text = "00";
            this.textBox_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_m.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_h_KeyDown);
            // 
            // textBox_h
            // 
            this.textBox_h.BackColor = System.Drawing.Color.Silver;
            this.textBox_h.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_h.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_h.Location = new System.Drawing.Point(60, 27);
            this.textBox_h.Multiline = true;
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.ReadOnly = true;
            this.textBox_h.Size = new System.Drawing.Size(44, 35);
            this.textBox_h.TabIndex = 18;
            this.textBox_h.Text = "00";
            this.textBox_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_h_KeyDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(89, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label.Location = new System.Drawing.Point(7, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 18);
            this.label.TabIndex = 15;
            this.label.Text = "Data";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_bw
            // 
            this.label_bw.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_bw.Location = new System.Drawing.Point(7, 27);
            this.label_bw.Name = "label_bw";
            this.label_bw.Size = new System.Drawing.Size(39, 18);
            this.label_bw.TabIndex = 15;
            this.label_bw.Text = "-15 m";
            this.label_bw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fw
            // 
            this.label_fw.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_fw.Location = new System.Drawing.Point(169, 26);
            this.label_fw.Name = "label_fw";
            this.label_fw.Size = new System.Drawing.Size(39, 18);
            this.label_fw.TabIndex = 15;
            this.label_fw.Text = "+15 m";
            this.label_fw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ffw
            // 
            this.label_ffw.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ffw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_ffw.Location = new System.Drawing.Point(171, 44);
            this.label_ffw.Name = "label_ffw";
            this.label_ffw.Size = new System.Drawing.Size(35, 18);
            this.label_ffw.TabIndex = 15;
            this.label_ffw.Text = "+1 h";
            this.label_ffw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_fbw
            // 
            this.label_fbw.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fbw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_fbw.Location = new System.Drawing.Point(8, 43);
            this.label_fbw.Name = "label_fbw";
            this.label_fbw.Size = new System.Drawing.Size(29, 18);
            this.label_fbw.TabIndex = 15;
            this.label_fbw.Text = "-1 h";
            this.label_fbw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_h
            // 
            this.label_h.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_h.Location = new System.Drawing.Point(60, 63);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(44, 12);
            this.label_h.TabIndex = 15;
            this.label_h.Text = "Ore";
            this.label_h.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_m
            // 
            this.label_m.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_m.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_m.Location = new System.Drawing.Point(104, 63);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(46, 12);
            this.label_m.TabIndex = 15;
            this.label_m.Text = "Minuti";
            this.label_m.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_bw
            // 
            this.button_bw.BackColor = System.Drawing.Color.White;
            this.button_bw.BackgroundImage = global::Fastener.Properties.Resources.button_bw;
            this.button_bw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_bw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bw.Location = new System.Drawing.Point(40, 27);
            this.button_bw.Name = "button_bw";
            this.button_bw.Size = new System.Drawing.Size(20, 18);
            this.button_bw.TabIndex = 21;
            this.button_bw.UseVisualStyleBackColor = false;
            this.button_bw.Click += new System.EventHandler(this.button_bw_Click);
            // 
            // button_fbw
            // 
            this.button_fbw.BackColor = System.Drawing.Color.White;
            this.button_fbw.BackgroundImage = global::Fastener.Properties.Resources.button_fbw;
            this.button_fbw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_fbw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fbw.Location = new System.Drawing.Point(40, 44);
            this.button_fbw.Name = "button_fbw";
            this.button_fbw.Size = new System.Drawing.Size(20, 18);
            this.button_fbw.TabIndex = 22;
            this.button_fbw.UseVisualStyleBackColor = false;
            this.button_fbw.Click += new System.EventHandler(this.button_fbw_Click);
            // 
            // button_ffw
            // 
            this.button_ffw.BackColor = System.Drawing.Color.White;
            this.button_ffw.BackgroundImage = global::Fastener.Properties.Resources.button_ffw;
            this.button_ffw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ffw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ffw.Location = new System.Drawing.Point(150, 46);
            this.button_ffw.Name = "button_ffw";
            this.button_ffw.Size = new System.Drawing.Size(20, 16);
            this.button_ffw.TabIndex = 20;
            this.button_ffw.UseVisualStyleBackColor = false;
            this.button_ffw.Click += new System.EventHandler(this.button_ffw_Click);
            // 
            // button_fw
            // 
            this.button_fw.BackColor = System.Drawing.Color.White;
            this.button_fw.BackgroundImage = global::Fastener.Properties.Resources.button_fw;
            this.button_fw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_fw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fw.Location = new System.Drawing.Point(150, 27);
            this.button_fw.Name = "button_fw";
            this.button_fw.Size = new System.Drawing.Size(20, 18);
            this.button_fw.TabIndex = 19;
            this.button_fw.UseVisualStyleBackColor = false;
            this.button_fw.Click += new System.EventHandler(this.button_fw_Click);
            // 
            // CtrlDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_bw);
            this.Controls.Add(this.button_fbw);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.label_fbw);
            this.Controls.Add(this.label_ffw);
            this.Controls.Add(this.label_fw);
            this.Controls.Add(this.label_bw);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_ffw);
            this.Controls.Add(this.button_fw);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.dateTimePicker);
            this.DoubleBuffered = true;
            this.Name = "CtrlDateTimePicker";
            this.Size = new System.Drawing.Size(211, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bw;
        private System.Windows.Forms.Button button_fbw;
        private System.Windows.Forms.Button button_ffw;
        private System.Windows.Forms.Button button_fw;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_bw;
        private System.Windows.Forms.Label label_fw;
        private System.Windows.Forms.Label label_ffw;
        private System.Windows.Forms.Label label_fbw;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_m;
    }
}
