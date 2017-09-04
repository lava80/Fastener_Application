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
    public partial class CtrlDateTimePicker : UserControl
    {
        public static int forward = 15;
        public static int fast_forward = 60;
        public static int backward = 15;
        public static int fastbackward = 60;

        private bool show_date_ = true;
        public bool ShowDate
        {
            get { return show_date_; }
            set { show_date_ = value; dateTimePicker.Visible = value; label.Visible = value; }
        }

        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        private Color font_color_ = Color.Black;
        public Color FontColor
        {
            set {
                label.ForeColor = value;
                label_fw.ForeColor = value;
                label_ffw.ForeColor = value;
                label_bw.ForeColor = value;
                label_fbw.ForeColor = value;
                label_h.ForeColor = value;
                label_m.ForeColor = value;
            }
            get { return font_color_; }
        }

        public event EventHandler ValueChanged;

        public CtrlDateTimePicker()
        {
            InitializeComponent();
        }

        public DateTime ReadTs()
        {
            DateTime d = new DateTime(
                dateTimePicker.Value.Year,
                dateTimePicker.Value.Month,
                dateTimePicker.Value.Day,
                int.Parse(textBox_h.Text.ToString()),
                int.Parse(textBox_m.Text.ToString()), 0);
            return d;
        }

        public void WriteTs(DateTime d)
        {
            dateTimePicker.Value = d;
            textBox_h.Text = d.Hour.ToString("00");
            textBox_m.Text = d.Minute.ToString("00");
        }

        private void button_fw_Click(object sender, EventArgs e)
        {
            WriteTs(ReadTs().AddMinutes(forward));
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }

        private void button_ffw_Click(object sender, EventArgs e)
        {
            WriteTs(ReadTs().AddMinutes(fast_forward));
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }

        private void button_bw_Click(object sender, EventArgs e)
        {
            WriteTs(ReadTs().AddMinutes(-forward));
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }

        private void button_fbw_Click(object sender, EventArgs e)
        {
            WriteTs(ReadTs().AddMinutes(-fast_forward));
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, new EventArgs());
        }

        private void textBox_h_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_h_KeyDown(object sender, KeyEventArgs e)
        {
            if (
                e.KeyCode != Keys.Left && 
                e.KeyCode != Keys.Right &&
                e.KeyCode != Keys.Back &&
                e.KeyCode != Keys.D1 &&
                e.KeyCode != Keys.D2 &&
                e.KeyCode != Keys.D3 &&
                e.KeyCode != Keys.D4 &&
                e.KeyCode != Keys.D5 &&
                e.KeyCode != Keys.D6 &&
                e.KeyCode != Keys.D7 &&
                e.KeyCode != Keys.D8 &&
                e.KeyCode != Keys.D9 &&
                e.KeyCode != Keys.D0)
                e.SuppressKeyPress = true;
        }
    }
}
