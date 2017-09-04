namespace Fastener.Controlli
{
    partial class CtrlAreaThumbnail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_area_name = new System.Windows.Forms.Label();
            this.pictureBox_active = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_active)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fastener.Properties.Resources.icona;
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // label_area_name
            // 
            this.label_area_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_area_name.Location = new System.Drawing.Point(3, 63);
            this.label_area_name.Name = "label_area_name";
            this.label_area_name.Size = new System.Drawing.Size(117, 18);
            this.label_area_name.TabIndex = 1;
            this.label_area_name.Text = "Area Duo";
            this.label_area_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_active
            // 
            this.pictureBox_active.Image = global::Fastener.Properties.Resources.button_ffw;
            this.pictureBox_active.Location = new System.Drawing.Point(92, 3);
            this.pictureBox_active.Name = "pictureBox_active";
            this.pictureBox_active.Size = new System.Drawing.Size(41, 57);
            this.pictureBox_active.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_active.TabIndex = 2;
            this.pictureBox_active.TabStop = false;
            this.pictureBox_active.Visible = false;
            // 
            // CtrlAreaThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox_active);
            this.Controls.Add(this.label_area_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CtrlAreaThumbnail";
            this.Size = new System.Drawing.Size(142, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_active)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_area_name;
        private System.Windows.Forms.PictureBox pictureBox_active;
    }
}
