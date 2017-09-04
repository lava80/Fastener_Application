using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Fastener
{
    public partial class frmRapportino : Form
    {
        public frmRapportino()
        {
            InitializeComponent();
        }

        public void SetReportKey(int report_key)
        {
            System.Uri uri = new Uri(@"http://vrmss01.metit.lan/reportserver/");
            reportViewer1.ServerReport.ReportServerUrl = uri;
            reportViewer1.ServerReport.ReportPath = "/Manutenzioni/RapportinoCompatto";

            ReportParameter param = new ReportParameter();
            param.Name = "reportkey";
            param.Values.Add(report_key.ToString());
            reportViewer1.ServerReport.SetParameters(param);
            //ReportParameter[] parameters = new ReportParameter[1];
            //parameters[0] = new ReportParameter("reportkey", report_key.ToString());
            //this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
