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
    public partial class CtrlPlantSelector : UserControl
    {
        int tipo_reparto = -1;
        public int TipoReparto
        {
            set { tipo_reparto = value; }
        }
        public CtrlPlantSelector()
        {
            InitializeComponent();
            Initialize();
        }

        private Color font_color_ = Color.Black;
        public Color FontColor
        {
            set
            {
                label_area.ForeColor = value;
                label_impianto.ForeColor = value;
                label_macchina.ForeColor = value;
                label_scm1.ForeColor = value;
                label_scm2.ForeColor = value;
                label_scm3.ForeColor = value;
                label_com.ForeColor = value;
            }
        }
#region INTERFACCIA PUBBLICA

        public void Initialize()
        {
            aree_T_ViewTableAdapter.Fill(dsActivities.Aree_T_View, Program.language_);
            InitIMP();            
        }

        private void InitIMP()
        {
            if (comboBox_area.SelectedValue != null)
            {
                impianti_T_ViewTableAdapter.Fill(dsActivities.Impianti_T_View, Program.language_, (int)comboBox_area.SelectedValue);
                InitMAC();
            }
        }

        public int ? SelectedImpianto()
        {
            return (int)comboBox_imp.SelectedValue;
        }

        public int ? SelectedMacchina()
        {
            return (int)comboBox_mac.SelectedValue;
        }

        public int ? SelectedComponente()
        {
            if (comboBox_com.Visible && comboBox_com.SelectedValue != null)
                return (int)comboBox_com.SelectedValue;
            return null;
        }

        public int ? SelectedSCM_1()
        {
            if (comboBox_scm1.Visible && comboBox_scm1.SelectedValue != null)
                return (int)comboBox_scm1.SelectedValue;
            return null;
        }

        public int ? SelectedSCM_2()
        {
            if (comboBox_scm2.Visible && comboBox_scm2.SelectedValue != null)
                return (int)comboBox_scm2.SelectedValue;
            return null;
        }

        public int ? SelectedSCM_3()
        {
            if (comboBox_scm3.Visible && comboBox_scm3.SelectedValue != null)
                return (int)comboBox_scm3.SelectedValue;
            return null;
        }

        public void PerformSelection
            (
            int AREKey,
            int IMPKey,
            int ? MACKey = null,
            int ? COMKey = null,
            int? SCM_1Key = null,
            int? SCM_2Key = null,
            int? SCM_3Key = null
            )
        {
            comboBox_area.BeginUpdate();
            comboBox_imp.BeginUpdate();
            comboBox_mac.BeginUpdate();
            comboBox_com.BeginUpdate();
            comboBox_scm1.BeginUpdate();
            comboBox_scm2.BeginUpdate();
            comboBox_scm3.BeginUpdate();

            ToggleButtonCOM(false, true);
            ToggleButtonSCM_1(false, true);
            ToggleButtonSCM_2(false, true);
            ToggleButtonSCM_3(false, true);


            comboBox_area.SelectedValue = AREKey;

            if (MACKey == null)
            {
                InitEmpty();

                return;
            }

            comboBox_imp.SelectedValue = IMPKey;
            Initialize();

            if (SCM_3Key != null)
            {
                comboBox_area.SelectedValue = AREKey;
                InitIMP();
                comboBox_imp.SelectedValue = IMPKey;
                InitMAC();
                comboBox_mac.SelectedValue = MACKey;
                ToggleButtonCOM(true);
                comboBox_com.SelectedValue = COMKey;
                ToggleButtonSCM_1(true);
                comboBox_scm1.SelectedValue = SCM_1Key;
                ToggleButtonSCM_2(true);
                comboBox_scm2.SelectedValue = SCM_2Key;
                ToggleButtonSCM_3(true);
                comboBox_scm3.SelectedValue = SCM_3Key;
            }

            else if (SCM_2Key != null)
            {
                comboBox_area.SelectedValue = AREKey;
                InitIMP();
                comboBox_imp.SelectedValue = IMPKey;
                InitMAC();
                comboBox_mac.SelectedValue = MACKey;
                ToggleButtonCOM(true);
                comboBox_com.SelectedValue = COMKey;
                ToggleButtonSCM_1(true);
                comboBox_scm1.SelectedValue = SCM_1Key;
                ToggleButtonSCM_2(true);
                comboBox_scm2.SelectedValue = SCM_2Key;
            }

            else if (SCM_1Key != null)
            {
                comboBox_area.SelectedValue = AREKey;
                InitIMP();
                comboBox_imp.SelectedValue = IMPKey;
                InitMAC();
                comboBox_mac.SelectedValue = MACKey;
                ToggleButtonCOM(true);
                comboBox_com.SelectedValue = COMKey;
                ToggleButtonSCM_1(true);
                comboBox_scm1.SelectedValue = SCM_1Key;
            }
            else if (COMKey != null)
            {
                comboBox_area.SelectedValue = AREKey;
                InitIMP();
                comboBox_imp.SelectedValue = IMPKey;
                InitMAC();
                comboBox_mac.SelectedValue = MACKey;
                ToggleButtonCOM(true);
                comboBox_com.SelectedValue = COMKey;
            }
            else if (MACKey != null)
            {
                comboBox_area.SelectedValue = AREKey;
                InitIMP();
                comboBox_imp.SelectedValue = IMPKey;
                InitMAC();
                comboBox_mac.SelectedValue = MACKey;
            }        
    
            comboBox_area.EndUpdate();
            comboBox_imp.EndUpdate();
            comboBox_mac.EndUpdate();
            comboBox_com.EndUpdate();
            comboBox_scm1.EndUpdate();
            comboBox_scm2.EndUpdate();
            comboBox_scm3.EndUpdate();
        }

        public void InitEmpty()
        {
            comboBox_area.SelectedValue = -1;
            comboBox_imp.SelectedValue = -1;
            comboBox_mac.SelectedValue = -1;
            comboBox_com.SelectedValue = -1;
            comboBox_scm1.SelectedValue = -1;
            comboBox_scm2.SelectedValue = -1;
            comboBox_scm3.SelectedValue = -1;

            comboBox_area.EndUpdate();
            comboBox_imp.EndUpdate();
            comboBox_mac.EndUpdate();
            comboBox_com.EndUpdate();
            comboBox_scm1.EndUpdate();
            comboBox_scm2.EndUpdate();
            comboBox_scm3.EndUpdate();
        }
#endregion
 
        private void comboBox_imp_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitMAC();
        }

        private void InitMAC()
        {
            ToggleButtonCOM(false, true);
            ToggleButtonSCM_1(false, true);
            ToggleButtonSCM_2(false, true);
            ToggleButtonSCM_3(false, true);

            dsActivities.Macchine_T_View.Clear();
            dsActivities.Componenti_T_View.Clear();
            dsActivities.Sottocomponenti_1_T_View.Clear();
            dsActivities.Sottocomponenti_2_T_View.Clear();
            dsActivities.Sottocomponenti_3_T_View.Clear();

            label_com.Visible = false;
            comboBox_com.Visible = false;
            label_scm1.Visible = false;
            comboBox_scm1.Visible = false;
            label_scm2.Visible = false;
            comboBox_scm2.Visible = false;
            label_scm3.Visible = false;
            comboBox_scm3.Visible = false;

            if (comboBox_imp.SelectedValue != null)
            {
                macchine_T_ViewTableAdapter.Fill(dsActivities.Macchine_T_View, Program.language_, (int)comboBox_imp.SelectedValue);
                RefreshComboboxCom();


                //if (dsActivities.Macchine_T_View.Count == 0)
                //{
                //    button_plus_com.Visible = false;                    
                //}
                //else
                //    button_plus_com.Visible = true;                
            }
        }

        private void ToggleVisibilityCOM(bool show)
        {
            dsActivities.Componenti_T_View.Clear();
            dsActivities.Sottocomponenti_1_T_View.Clear();
            dsActivities.Sottocomponenti_2_T_View.Clear();
            dsActivities.Sottocomponenti_3_T_View.Clear();

            label_com.Visible = false;
            comboBox_com.Visible = false;
            label_scm1.Visible = false;
            comboBox_scm1.Visible = false;
            label_scm2.Visible = false;
            comboBox_scm2.Visible = false;
            label_scm3.Visible = false;
            comboBox_scm3.Visible = false;

            if (show)
            {
                if (comboBox_mac.SelectedValue != null)
                {
                    componenti_T_ViewTableAdapter.Fill(dsActivities.Componenti_T_View, (int)comboBox_mac.SelectedValue, Program.language_);
                    if (dsActivities.Componenti_T_View.Count > 0)
                    {
                        label_com.Visible = true;
                        comboBox_com.Visible = true;
                        ResfreshComboboxSCM_1();
                    }
                }
            }
        }

        private void ToggleVisibilitySCM_1(bool show)
        {
            dsActivities.Sottocomponenti_1_T_View.Clear();
            dsActivities.Sottocomponenti_2_T_View.Clear();
            dsActivities.Sottocomponenti_3_T_View.Clear();

            label_scm1.Visible = false;
            comboBox_scm1.Visible = false;
            label_scm2.Visible = false;
            comboBox_scm2.Visible = false;
            label_scm3.Visible = false;
            comboBox_scm3.Visible = false;

            if (show)
            {
                if (comboBox_com.SelectedValue != null)
                {
                    sottocomponenti_1_T_ViewTableAdapter.Fill(
                        dsActivities.Sottocomponenti_1_T_View,
                        (int)comboBox_com.SelectedValue,
                        Program.language_,
                        tipo_reparto);
                    if (dsActivities.Sottocomponenti_1_T_View.Count > 0)
                    {
                        label_scm1.Visible = true;
                        comboBox_scm1.Visible = true;
                        ResfreshComboboxSCM_2();
                    }
                }
            }
        }

        private void ToggleVisibilitySCM_2(bool show)
        {
            dsActivities.Sottocomponenti_2_T_View.Clear();
            dsActivities.Sottocomponenti_3_T_View.Clear();

            label_scm2.Visible = false;
            comboBox_scm2.Visible = false;
            label_scm3.Visible = false;
            comboBox_scm3.Visible = false;

            if (show)
            {
                if (comboBox_scm1.SelectedValue != null)
                {
                    sottocomponenti_2_T_ViewTableAdapter.Fill
                        (dsActivities.Sottocomponenti_2_T_View,
                        (int)comboBox_scm1.SelectedValue,
                        tipo_reparto,
                        Program.language_);

                    if (dsActivities.Sottocomponenti_2_T_View.Count > 0)
                    {
                        label_scm2.Visible = true;
                        comboBox_scm2.Visible = true;
                        ResfreshComboboxSCM_3();
                    }
                }
            }
        }

        private void ToggleVisibilitySCM_3(bool show)
        {
            dsActivities.Sottocomponenti_3_T_View.Clear();

            label_scm3.Visible = false;
            comboBox_scm3.Visible = false;
            
            if (show)
            {
                if (comboBox_scm2.SelectedValue != null)
                {
                    sottocomponenti_3_T_ViewTableAdapter.Fill
                        (dsActivities.Sottocomponenti_3_T_View,
                        Program.language_,
                        tipo_reparto,
                        (int)comboBox_scm2.SelectedValue
                        );

                    if (dsActivities.Sottocomponenti_3_T_View.Count > 0)
                    {
                        label_scm3.Visible = true;
                        comboBox_scm3.Visible = true;
                    }
                }
            }
        }

        bool com_toggled = false;
        private void button_plus_com_Click(object sender, EventArgs e)
        {
            ToggleButtonCOM(!com_toggled);
        }

        private void ToggleButtonCOM(bool toggled, bool hide = false)
        {
            if (toggled)
            {
                ToggleVisibilityCOM(true);
                button_plus_com.Visible = true;
                button_plus_com.Image = Properties.Resources.minus;
            }
            else
            {
                ToggleVisibilityCOM(false);
                button_plus_com.Visible = !hide;
                button_plus_com.Image = Properties.Resources.plus;
                ToggleButtonSCM_1(false, true);
            }
            com_toggled = toggled;
        }

        private void ToggleButtonSCM_1(bool toggled, bool hide =  false)
        {
            if (toggled)
            {
                ToggleVisibilitySCM_1(true);
                button_plus_scm1.Visible = true;
                button_plus_scm1.Image = Properties.Resources.minus;
            }
            else
            {
                ToggleVisibilitySCM_1(false);
                button_plus_scm1.Visible = !hide;
                button_plus_scm1.Image = Properties.Resources.plus;
                ToggleButtonSCM_2(false, true);
            }
            scm1_tollged = toggled;
        }

        bool scm1_tollged = false;
        private void button_plus_scm1_Click(object sender, EventArgs e)
        {
            ToggleButtonSCM_1(!scm1_tollged);
        }

        private void ToggleButtonSCM_2(bool toggled, bool hide = false)
        {
            if (toggled)
            {
                ToggleVisibilitySCM_2(true);
                button_plus_scm2.Visible = true;
                button_plus_scm2.Image = Properties.Resources.minus;
            }
            else
            {
                ToggleVisibilitySCM_2(false);
                button_plus_scm2.Visible = !hide;
                button_plus_scm2.Image = Properties.Resources.plus;
                ToggleButtonSCM_3(false, true);
            }

            scm2_tollged = toggled;
        }

        bool scm2_tollged = false;
        private void button_plus_scm2_Click(object sender, EventArgs e)
        {
            ToggleButtonSCM_2(!scm2_tollged);
        }

        private void ToggleButtonSCM_3(bool toggled, bool hide = false)
        {
            if (toggled)
            {
                ToggleVisibilitySCM_3(true);
                button_plus_scm3.Visible = true;
                button_plus_scm3.Image = Properties.Resources.minus;
            }
            else
            {
                ToggleVisibilitySCM_3(false);
                button_plus_scm3.Visible = !hide;
                button_plus_scm3.Image = Properties.Resources.plus;
            }

            scm3_tollged = toggled;
        }

        bool scm3_tollged = false;
        private void button_plus_scm3_Click(object sender, EventArgs e)
        {
            ToggleButtonSCM_3(!scm3_tollged);
        }

        private void comboBox_mac_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshComboboxCom();
        }

        private void RefreshComboboxCom()
        {
            if (comboBox_mac.SelectedValue != null)
            {
                componenti_T_ViewTableAdapter.Fill(dsActivities.Componenti_T_View, (int)comboBox_mac.SelectedValue, Program.language_);
                if (dsActivities.Componenti_T_View.Count == 0)
                {
                    button_plus_com.Visible = false;
                    ToggleButtonCOM(false, true);
                }
                else
                    button_plus_com.Visible = true;
                ToggleButtonSCM_1(false, !com_toggled);
            }
        }

        private void comboBox_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResfreshComboboxSCM_1();
        }

        private void ResfreshComboboxSCM_1()
        {
            if (comboBox_com.SelectedValue != null)
            {
                sottocomponenti_1_T_ViewTableAdapter.Fill(
                    dsActivities.Sottocomponenti_1_T_View,
                    (int)comboBox_com.SelectedValue,
                    Program.language_,
                    tipo_reparto);
                if (dsActivities.Sottocomponenti_1_T_View.Count == 0)
                {
                    button_plus_scm1.Visible = false;
                    ToggleButtonSCM_1(false, true);
                }
                else
                    button_plus_scm1.Visible = true;
                ToggleButtonSCM_2(false, !scm1_tollged);
            }
        }

        private void comboBox_scm1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResfreshComboboxSCM_2();
        }

        private void ResfreshComboboxSCM_2()
        {
            if (comboBox_scm1.SelectedValue != null)
            {
                sottocomponenti_2_T_ViewTableAdapter.Fill
                    (dsActivities.Sottocomponenti_2_T_View,
                    (int)comboBox_scm1.SelectedValue,
                    tipo_reparto,
                    Program.language_);
                if (dsActivities.Sottocomponenti_2_T_View.Count == 0)
                {
                    button_plus_scm2.Visible = false;
                    ToggleButtonSCM_2(false, true);
                }
                else
                    button_plus_scm2.Visible = true;
                ToggleButtonSCM_3(false, !scm2_tollged);
            }
        }

        private void comboBox_scm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResfreshComboboxSCM_3();
        }

        private void ResfreshComboboxSCM_3()
        {
            if (comboBox_scm2.SelectedValue != null)
            {
                sottocomponenti_3_T_ViewTableAdapter.Fill
                    (dsActivities.Sottocomponenti_3_T_View,
                    Program.language_,
                    tipo_reparto,
                    (int)comboBox_scm2.SelectedValue
                    );
                if (dsActivities.Sottocomponenti_3_T_View.Count == 0)
                {
                    button_plus_scm3.Visible = false;
                    ToggleButtonSCM_3(false, true);
                }
                else
                    button_plus_scm3.Visible = true;
            }
        }

        private void comboBox_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitIMP(); 
        }
    }
}
