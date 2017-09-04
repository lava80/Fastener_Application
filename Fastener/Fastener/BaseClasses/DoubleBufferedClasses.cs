using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Fastener
{
    public partial class DBDataGridView : DataGridView
    {
        public DBDataGridView()
        {
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public DBDataGridView(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }        
    }

    public partial class DBTableLayoutPanel : TableLayoutPanel
    {
        public DBTableLayoutPanel()
        {                        
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public DBTableLayoutPanel(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }
    }

    public partial class DBFlowLayoutPanel : FlowLayoutPanel
    {
        public DBFlowLayoutPanel()
        {
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public DBFlowLayoutPanel(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }
    }

    public partial class DBPanel : Panel
    {
        public DBPanel()
        {
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public DBPanel(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }
    }
}
