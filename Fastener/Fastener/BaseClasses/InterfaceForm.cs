using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fastener
{
    public partial class InterfaceForm : Form
    {
        //ResrouceManager per il componente
       
        protected CultureManager cultureManager;

        public InterfaceForm()
        {
            InitializeComponent();
         
            cultureManager = new CultureManager(this.components);
            this.cultureManager.ManagedControl = this;
            this.cultureManager.ExcludeProperties = new List<string>();
            this.cultureManager.ExcludeProperties.Add("Visible");
            //this.cultureManager.UICultureChanged += new CultureManager.CultureChangedHandler(this.cultureManager_UICultureChanged);

            CultureManager.ApplicationUICulture = new System.Globalization.CultureInfo(Program.language_);
        }        
    }
}