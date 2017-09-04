using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener.BaseClasses
{
    class ToolbarButton : Button
    {
        private bool active = false;
        static List<ToolbarButton> family_ = new List<ToolbarButton>();

        public ToolbarButton()
        {
            MouseEnter += new EventHandler(ToolbarButton_MouseEnter);
            MouseLeave += new EventHandler(ToolbarButton_MouseLeave);
            Click += new EventHandler(ToolbarButton_Click);

            Image = Properties.Resources.layout_bottoni_inattivi;

            family_.Add(this);
        }

        void ToolbarButton_Click(object sender, EventArgs e)
        {
            foreach (ToolbarButton b in family_)
            {
                b.active = false;
                b.Image = Properties.Resources.layout_bottoni_inattivi;
            }

            this.active = true;
            this.Image = Properties.Resources.layout_bottoni;
        }

        void ToolbarButton_MouseLeave(object sender, EventArgs e)
        {
            if (active)
                Image = Properties.Resources.layout_bottoni;
            else
                Image = Properties.Resources.layout_bottoni_inattivi;
        }

        void ToolbarButton_MouseEnter(object sender, EventArgs e)
        {
            Image = Properties.Resources.layout_bottoni_highlight;
        }
    }
}
