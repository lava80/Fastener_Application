using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.Controlli
{
    public partial class CtrlImpThumbnail : UserControl
    {
        public CtrlImpThumbnail()
        {
            InitializeComponent();
        }

        public void SetLabel(string text)
        {
            label1.Text = text;
        }
    }
}
