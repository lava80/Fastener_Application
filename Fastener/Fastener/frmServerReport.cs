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
    public partial class frmServerReport : Form
    {
        public frmServerReport(string reportserver, string reportpath)
        {
            InitializeComponent();

            System.Uri uri = new Uri(reportserver);
            reportViewer1.ServerReport.ReportServerUrl = uri;
            reportViewer1.ServerReport.ReportPath = reportpath;

            AddParameter("UTEKey", Program.CurrentUser.Key.ToString());
            SetParameterSafe();
            
            this.reportViewer1.RefreshReport();
        }

        private List<ReportParameter> parameters_ = new List<ReportParameter>();
        public void AddParameter(string param_name, string param_value)
        {
            try
            {
                //Aggiungo i parametri (user)
                ReportParameter param = new ReportParameter();
                param.Name = param_name;
                param.Values.Add(param_value);
                parameters_.Add(param);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        private void SetParameterSafe()
        {
            foreach (ReportParameter param in parameters_)
            {
                try
                {
                    reportViewer1.ServerReport.SetParameters(param);
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                }
            }
        }
    }
}
