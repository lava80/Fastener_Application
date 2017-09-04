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
    public partial class CtrlAreaThumbnail : UserControl
    {
        static List<CtrlAreaThumbnail> Family_ = new List<CtrlAreaThumbnail>();
        public CtrlAreaThumbnail()
        {
            InitializeComponent();

            Family_.Add(this);
        }

        public event EventHandler ManageActive;
        bool active = false;
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            active = !active;

            foreach (CtrlAreaThumbnail c in Family_)
            {
                c.pictureBox_active.Visible = false;
            }

            pictureBox_active.Visible = active;
            if (active)
                ManageActive(this, new EventArgs());
        }

        public void SetLabel(string text)
        {
            label_area_name.Text = text;
        }

        private int area_code_ = 0;

        public int AreaCode
        {
            get { return area_code_; }
            set { area_code_ = value; }
        }
    }
}
