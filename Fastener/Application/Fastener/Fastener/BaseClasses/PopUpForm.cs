using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Fastener
{
    public partial class PopUpForm : InterfaceForm
    {
        //ResrouceManager per il componente
        protected System.Resources.ResourceManager resManager;

        public PopUpForm()
        {
            InitializeComponent();
            resManager = Properties.MessageLocalization.ResourceManager;
        }

        public void ChangeLanguage(string lang)
        {
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name, System.Globalization.CultureInfo.CurrentUICulture);
        }

        #region Form Dragging API Support

        //The SendMessage function sends a message to a window or windows.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        //ReleaseCapture releases a mouse capture
        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private Form parent = null;
        /// <summary>
        /// Make this form borderless. 
        /// Also add dragging capabilities.
        /// </summary>
        /// <param name="mainPanel">form must contains at least a main panel to allow dragging.</param>
        public void MakeBorderless(Panel mainPanel, Form parent_for_resize = null)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mainPanel.MouseDown += new MouseEventHandler(mainPanel_MouseDown);
            if (parent_for_resize != null)
            {
                parent = parent_for_resize;                
                mainPanel.MouseDoubleClick += new MouseEventHandler(mainPanel_MouseDoubleClick);
            }
        }

        void mainPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (parent.WindowState == FormWindowState.Normal)
                parent.WindowState = FormWindowState.Maximized;
            else
                parent.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// This function manages inner main Panel down (left) events.
        /// </summary>
        /// <param name="sender">undelying control</param>
        /// <param name="args">classic MouseEventArgs</param>
        void mainPanel_MouseDown(object sender, MouseEventArgs args)
        {
            HandleMouseMove(this.Handle);
        }

        /// <summary>
        /// Internal function to handle mouse moving.
        /// </summary>
        /// <param name="handle">pointer to parent window.</param>
        private void HandleMouseMove(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        
        #endregion
    }
}