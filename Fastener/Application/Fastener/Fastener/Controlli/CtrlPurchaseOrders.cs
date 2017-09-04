using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Fastener.Controlli
{
    public partial class CtrlPurchaseOrders : UserControl
    {
        public CtrlPurchaseOrders()
        {
            InitializeComponent();

            ReportParameter param = new ReportParameter();
            param.Name = "user";
            param.Values.Add(Program.CurrentUser.Login);
            reportViewer1.ServerReport.SetParameters(param);
            reportViewer1.RefreshReport();
        }
    }
}
