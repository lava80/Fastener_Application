using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.BaseClasses
{
    class ToolbarButtonOriz : Button
    {
        private bool active = false;
        static List<ToolbarButtonOriz> family_ = new List<ToolbarButtonOriz>();

        public ToolbarButtonOriz()
        {
            MouseEnter += new EventHandler(ToolbarButton_MouseEnter);
            MouseLeave += new EventHandler(ToolbarButton_MouseLeave);
            Click += new EventHandler(ToolbarButton_Click);

            Image = Properties.Resources.layout_bottoni_oriz_inattivi;

            family_.Add(this);
        }

        void ToolbarButton_Click(object sender, EventArgs e)
        {
            foreach (ToolbarButtonOriz b in family_)
            {
                b.active = false;
                b.Image = Properties.Resources.layout_bottoni_oriz_inattivi;
            }

            this.active = true;
            this.Image = Properties.Resources.layout_bottoni_oriz;
        }

        void ToolbarButton_MouseLeave(object sender, EventArgs e)
        {
            if (active)
                Image = Properties.Resources.layout_bottoni_oriz;
            else
                Image = Properties.Resources.layout_bottoni_oriz_inattivi;
        }

        void ToolbarButton_MouseEnter(object sender, EventArgs e)
        {
            Image = Properties.Resources.layout_bottoni_oriz_highlight;
        }
    }
}
