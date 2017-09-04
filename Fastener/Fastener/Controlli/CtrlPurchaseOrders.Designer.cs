namespace Fastener.Controlli
{
    partial class CtrlPurchaseOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.ReportPath = "/Manutenzioni/ReportOrdiniAcq";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("http://vrmss01.metit.lan/reportserver/", System.UriKind.Absolute);
            this.reportViewer1.Size = new System.Drawing.Size(832, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // CtrlPurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "CtrlPurchaseOrders";
            this.Size = new System.Drawing.Size(832, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
