using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener
{
    class ComboBoxReadOnly : ComboBox
    {
        public ComboBoxReadOnly()
        {
            textBox = new TextBox();
            textBox.ReadOnly = true;
            textBox.Visible = false;
        }

        private TextBox textBox;

        private bool readOnly = false;

        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;

                if (readOnly)
                {
                    this.Visible = false;
                    textBox.Text = this.Text;
                    textBox.Location = this.Location;
                    textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                    textBox.Size = this.Parent.Size;
                    textBox.Visible = true;
                    textBox.BackColor = Color.White;
                    this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.textBox.ForeColor = System.Drawing.Color.SteelBlue;
                    this.textBox.TextAlign = HorizontalAlignment.Center;

                    if (textBox.Parent == null)
                        this.Parent.Controls.Add(textBox);
                }
                else
                {
                    this.Visible = true;
                    this.textBox.Visible = false;
                }
            }
        }
    }
}
