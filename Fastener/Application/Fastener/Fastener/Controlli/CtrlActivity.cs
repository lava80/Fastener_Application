using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fastener.BaseClasses;

namespace Fastener.Controlli
{
    public partial class CtrlActivity : UserControl
    {
        public event EventHandler SubmitEvent;

        bool treeview_initialized = false;
        private ComboBox comboBox_tipo_reparto_ = null;
        private ComboBox comboBox_utente_ = null;
        private ComboBox comboBox_azienda_ = null;

        public enum Type
        {
            INSERT,
            MODIFY
        }

        Type type_;

        public CtrlActivity(ComboBox tipo_reparto, ComboBox utente, ComboBox azienda, Type type = Type.INSERT)
        {
            InitializeComponent();

            comboBox_tipo_reparto_ = tipo_reparto;
            comboBox_utente_ = utente;
            comboBox_azienda_ = azienda;

            InitializeMask();
            man_Ana_CapexTableAdapter.Fill(dsActivities.Man_Ana_Capex);
            //TreeView_Initialize();
            //DrillThrough_Initialize();

            type_ = type;
            if (type_ == Type.INSERT)
            {
                label_plant.ForeColor = Color.White;
                label_remark.ForeColor = Color.White;
                label_tipo_man.ForeColor = Color.White;
                ctrlPlantSelector.FontColor = Color.White;
                ctrlDateTimePicker_end.FontColor = Color.White;
                ctrlDateTimePicker_start.FontColor = Color.White;
                dbPanel_main.BackgroundImage = Properties.Resources.activity_layout_25b;
                button_save.Text = Properties.MessageLocalization.activity_button_save;
            }
            else
            {
                label_plant.ForeColor = Color.Black;
                label_remark.ForeColor = Color.Black;
                label_tipo_man.ForeColor = Color.Black;
                ctrlPlantSelector.FontColor = Color.Black;
                ctrlDateTimePicker_end.FontColor = Color.Black;
                ctrlDateTimePicker_start.FontColor = Color.Black;
                dbPanel_main.BackgroundImage = Properties.Resources.activity_layout_25b_modifica;
                button_save.Text = Properties.MessageLocalization.activity_button_modify;
            }


            ctrlPlantSelector.InitEmpty();
        } 

        #region GESTIONE TREEVIEW

        class AreaTreeNode : TreeNode
        {
            public AreaTreeNode(string name) : base(name) { }
            public int AREKey = 0;
        }
        class ImpTreeNode : TreeNode
        {
            public ImpTreeNode(string name) : base(name) { }
            public int AREKey = 0; 
            public int IMPKey = 0;
        }
        class MacTreeNode : TreeNode
        {
            public MacTreeNode(string name) : base(name) { }
            public int MACKey = 0;
            public int IMPKey = 0;
            public int AREKey = 0;
        }
        class ComTreeNode : TreeNode
        {
            public ComTreeNode(string name) : base(name) { }
            public int COMKey = 0;
            public int MACKey = 0;
            public int IMPKey = 0;
            public int AREKey = 0;
        }
        class SCM_1TreeNode : TreeNode
        {
            public SCM_1TreeNode(string name) : base(name) { }
            public int SCM_1Key = 0;
            public int COMKey = 0;
            public int MACKey = 0;
            public int IMPKey = 0;
            public int AREKey = 0;
        }
        class SCM_2TreeNode : TreeNode
        {
            public SCM_2TreeNode(string name) : base(name) { }
            public int SCM_2Key = 0;
            public int SCM_1Key = 0;
            public int COMKey = 0;
            public int MACKey = 0;
            public int IMPKey = 0;
            public int AREKey = 0;
        }
        class SCM_3TreeNode : TreeNode
        {
            public SCM_3TreeNode(string name) : base(name) { }
            public int SCM_3Key = 0;
            public int SCM_2Key = 0;
            public int SCM_1Key = 0;
            public int COMKey = 0;
            public int MACKey = 0;
            public int IMPKey = 0;
            public int AREKey = 0;
        }

        private void TreeView_Initialize()
        {
            if (comboBox_tipo_reparto_.SelectedValue != null)
            {
                treeView_plant.Nodes.Clear();
                DataSet.dsActivities.Aree_T_ViewDataTable d_are = new DataSet.dsActivities.Aree_T_ViewDataTable();
                new DataSet.dsActivitiesTableAdapters.Aree_T_ViewTableAdapter().Fill(d_are, Program.language_);

                foreach (DataSet.dsActivities.Aree_T_ViewRow r_are in d_are.Rows)
                {
                    AreaTreeNode atn = new AreaTreeNode(r_are.LanTranslation);
                    atn.AREKey= r_are.AREKey;
                    TreeView_AddImp(atn);
                    treeView_plant.Nodes.Add(atn);
                }                
            }

            treeview_initialized = true;
        }

        private void TreeView_AddImp(AreaTreeNode atn)
        {
            DataSet.dsActivities.Impianti_T_ViewDataTable d_imp = new DataSet.dsActivities.Impianti_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Impianti_T_ViewTableAdapter().Fill(d_imp, Program.language_, atn.AREKey);

            foreach (DataSet.dsActivities.Impianti_T_ViewRow r_imp in d_imp.Rows)
            {
                ImpTreeNode itn = new ImpTreeNode(r_imp.LanTranslation);
                itn.AREKey = atn.AREKey;
                itn.IMPKey = r_imp.IMPKey;
                TreeView_AddMac(itn);
                atn.Nodes.Add(itn);
            }
        }

        private void TreeView_AddMac(ImpTreeNode itn)
        {
            DataSet.dsActivities.Macchine_T_ViewDataTable d_mac = new DataSet.dsActivities.Macchine_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Macchine_T_ViewTableAdapter().Fill(d_mac, Program.language_, itn.IMPKey);
            foreach (DataSet.dsActivities.Macchine_T_ViewRow r_mac in d_mac.Rows)
            {
                MacTreeNode mtn = new MacTreeNode(r_mac.LanTranslation);
                mtn.AREKey = itn.AREKey;
                mtn.MACKey = r_mac.MACKey;
                mtn.IMPKey = itn.IMPKey;
                //TreeView_AddCom(mtn);
                //interrompo qua e dopo esplodo solo se clicco.
                itn.Nodes.Add(mtn);
            }
        }

        private void TreeView_AddCom(MacTreeNode mtn)
        {
            DataSet.dsActivities.Componenti_T_ViewDataTable d_com = new DataSet.dsActivities.Componenti_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Componenti_T_ViewTableAdapter().Fill(d_com, mtn.MACKey, Program.language_);
            foreach (DataSet.dsActivities.Componenti_T_ViewRow r_com in d_com.Rows)
            {
                ComTreeNode ctn = new ComTreeNode(r_com.LanTranslation);
                ctn.COMKey = r_com.COMKey;
                ctn.MACKey = mtn.MACKey;
                ctn.IMPKey = mtn.IMPKey;
                ctn.AREKey = mtn.AREKey;
                TreeView_AddSMC_1(ctn);
                mtn.Nodes.Add(ctn);
            }
        }

        private void TreeView_AddSMC_1(ComTreeNode ctn)
        {
            DataSet.dsActivities.Sottocomponenti_1_T_ViewDataTable d_scm_1 = new DataSet.dsActivities.Sottocomponenti_1_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Sottocomponenti_1_T_ViewTableAdapter().Fill(d_scm_1, ctn.COMKey, Program.language_, (int)comboBox_tipo_reparto_.SelectedValue);
            foreach (DataSet.dsActivities.Sottocomponenti_1_T_ViewRow r_scm_1 in d_scm_1.Rows)
            {
                SCM_1TreeNode s1tn = new SCM_1TreeNode(r_scm_1.LanTranslation);
                s1tn.SCM_1Key = r_scm_1.SCMKey;
                s1tn.IMPKey = ctn.IMPKey;
                s1tn.MACKey = ctn.MACKey;
                s1tn.COMKey = ctn.COMKey;
                s1tn.AREKey = ctn.AREKey;
                TreeView_AddSMC_2(s1tn);
                ctn.Nodes.Add(s1tn);
            }
        }

        private void TreeView_AddSMC_2(SCM_1TreeNode s1tn)
        {
            DataSet.dsActivities.Sottocomponenti_2_T_ViewDataTable d_scm_2 = new DataSet.dsActivities.Sottocomponenti_2_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Sottocomponenti_2_T_ViewTableAdapter().Fill(d_scm_2, s1tn.SCM_1Key, (int)comboBox_tipo_reparto_.SelectedValue, Program.language_);
            foreach (DataSet.dsActivities.Sottocomponenti_2_T_ViewRow r_scm_2 in d_scm_2.Rows)
            {
                SCM_2TreeNode s2tn = new SCM_2TreeNode(r_scm_2.LanTranslation);
                s2tn.SCM_2Key = r_scm_2.SCMKey;
                s2tn.SCM_1Key = s1tn.SCM_1Key;
                s2tn.IMPKey = s1tn.IMPKey;
                s2tn.MACKey = s1tn.MACKey;
                s2tn.COMKey = s1tn.COMKey;
                s2tn.AREKey = s1tn.AREKey;
                TreeView_AddSMC_3(s2tn);
                s1tn.Nodes.Add(s2tn);
            }
        }

        private void TreeView_AddSMC_3(SCM_2TreeNode s2tn)
        {
            DataSet.dsActivities.Sottocomponenti_3_T_ViewDataTable d_scm_3 = new DataSet.dsActivities.Sottocomponenti_3_T_ViewDataTable();
            new DataSet.dsActivitiesTableAdapters.Sottocomponenti_3_T_ViewTableAdapter().Fill(d_scm_3, Program.language_, (int)comboBox_tipo_reparto_.SelectedValue, s2tn.SCM_2Key);
            foreach (DataSet.dsActivities.Sottocomponenti_3_T_ViewRow r_scm_3 in d_scm_3.Rows)
            {
                SCM_3TreeNode s3tn = new SCM_3TreeNode(r_scm_3.LanTranslation);
                s3tn.SCM_3Key = r_scm_3.SCMKey;
                s3tn.SCM_2Key = s2tn.SCM_2Key;
                s3tn.SCM_1Key = s2tn.SCM_1Key;
                s3tn.IMPKey = s2tn.IMPKey;
                s3tn.MACKey = s2tn.MACKey;
                s3tn.COMKey = s2tn.COMKey;
                s3tn.AREKey = s2tn.AREKey;
                s2tn.Nodes.Add(s3tn);
            }
        }

        private void treeView_plant_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                node.Collapse();
        }

        private void treeView_plant_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is MacTreeNode && e.Node.Nodes.Count == 0)
            {
                TreeView_AddCom(e.Node as MacTreeNode);
            }
        }

        private void treeView_plant_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is AreaTreeNode)
            {
                ctrlPlantSelector.InitEmpty();
            }
            else if (e.Node is ImpTreeNode) 
            {
                ctrlPlantSelector.PerformSelection(
                    ((ImpTreeNode)e.Node).AREKey,
                    ((ImpTreeNode)e.Node).IMPKey);                
            }
            else if (e.Node is MacTreeNode)
            {
                ctrlPlantSelector.PerformSelection(
                    ((MacTreeNode)e.Node).AREKey,
                    ((MacTreeNode)e.Node).IMPKey,
                    ((MacTreeNode)e.Node).MACKey);
            }
            else if (e.Node is ComTreeNode)
            {
                ctrlPlantSelector.PerformSelection(
                    ((ComTreeNode)e.Node).AREKey,
                    ((ComTreeNode)e.Node).IMPKey,
                    ((ComTreeNode)e.Node).MACKey,
                    ((ComTreeNode)e.Node).COMKey);
            }
            else if (e.Node is SCM_1TreeNode)
            {
                ctrlPlantSelector.PerformSelection(
                    ((SCM_1TreeNode)e.Node).AREKey,
                    ((SCM_1TreeNode)e.Node).IMPKey,
                    ((SCM_1TreeNode)e.Node).MACKey,
                    ((SCM_1TreeNode)e.Node).COMKey,
                    ((SCM_1TreeNode)e.Node).SCM_1Key);
            }
            else if (e.Node is SCM_2TreeNode)
            {
                ctrlPlantSelector.PerformSelection(
                    ((SCM_2TreeNode)e.Node).AREKey,
                    ((SCM_2TreeNode)e.Node).IMPKey,
                    ((SCM_2TreeNode)e.Node).MACKey,
                    ((SCM_2TreeNode)e.Node).COMKey,
                    ((SCM_2TreeNode)e.Node).SCM_1Key,
                    ((SCM_2TreeNode)e.Node).SCM_2Key);
            }
            else if (e.Node is SCM_3TreeNode)
            {
                ctrlPlantSelector.PerformSelection(
                    ((SCM_3TreeNode)e.Node).AREKey,
                    ((SCM_3TreeNode)e.Node).IMPKey,
                    ((SCM_3TreeNode)e.Node).MACKey,
                    ((SCM_3TreeNode)e.Node).COMKey,
                    ((SCM_3TreeNode)e.Node).SCM_1Key,
                    ((SCM_3TreeNode)e.Node).SCM_2Key,
                    ((SCM_3TreeNode)e.Node).SCM_3Key);
            }
        }

        #endregion

        private void InitializeMask()
        {
            TreeView_Initialize();

            if (comboBox_azienda_.SelectedValue != null)
                tipoOreTableAdapter.Fill(dsActivities.TipoOre, (int)comboBox_azienda_.SelectedValue);            

            comboBox_tipo_man.SelectedValue = -1;
            //if (ctrlDateTimePicker_start.ValueChanged != null)
                ctrlDateTimePicker_start.ValueChanged -= ctrlDateTimePicker_start_ValueChanged;
            //if (ctrlDateTimePicker_start.ValueChanged)
                ctrlDateTimePicker_end.ValueChanged -= ctrlDateTimePicker_end_ValueChanged;

            textBox_remark.Text = string.Empty;

            DataSet.dsActivities.LastHHMMDataTable d_hms = new DataSet.dsActivities.LastHHMMDataTable();
            if (comboBox_utente_.SelectedValue != null)
                new DataSet.dsActivitiesTableAdapters.LastHHMMTableAdapter().Fill(d_hms, (int)comboBox_utente_.SelectedValue);

            if (d_hms.Count > 0)
            {
                DateTime d = new DateTime(
                   d_hms[0].LastDateTime.Year,
                    d_hms[0].LastDateTime.Month,
                    d_hms[0].LastDateTime.Day,
                    d_hms[0].HMSHour24,
                    d_hms[0].HMSMinute,
                    0);
                ctrlDateTimePicker_start.WriteTs(d);
                ctrlDateTimePicker_end.WriteTs(d.AddMinutes(CtrlDateTimePicker.forward));
            }

            else
            {
                DateTime d = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    8,
                    0,
                    0);
                ctrlDateTimePicker_start.WriteTs(d);
                ctrlDateTimePicker_end.WriteTs(d.AddMinutes(15));                
            }

            tipo_Manutenzione_T_ViewTableAdapter.Fill(dsActivities.Tipo_Manutenzione_T_View, Program.language_);

            if (comboBox_tipo_reparto_.SelectedValue != null)
            {
                ctrlPlantSelector.TipoReparto = (int)comboBox_tipo_reparto_.SelectedValue;
                ctrlPlantSelector.Initialize();
            }

            ctrlDateTimePicker_start.ValueChanged += new EventHandler(ctrlDateTimePicker_start_ValueChanged);
            ctrlDateTimePicker_end.ValueChanged += new EventHandler(ctrlDateTimePicker_end_ValueChanged);

            comboBox_tipo_man.SelectedValue = -1;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string err = "";
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
            {
                err += Properties.MessageLocalization.activity_ts_mismatch + System.Environment.NewLine;
            }

            if (comboBox_tipo_man.SelectedValue == null)
            {
                err += Properties.MessageLocalization.activity_man_type_not_selected + System.Environment.NewLine;
            }

            if (ctrlDateTimePicker_start.ReadTs().Minute % 15 != 0 || ctrlDateTimePicker_end.ReadTs().Minute % 15 != 0)
            {
                err += Properties.MessageLocalization.activity_wrong_min_range + System.Environment.NewLine;
            }

            DataSet.dsActivities.OverlappingActivitiesDataTable d_overlap = new DataSet.dsActivities.OverlappingActivitiesDataTable();
            //new DataSet.dsActivitiesTableAdapters.OverlappingActivitiesTableAdapter().Fill(
            //    d_overlap,
            //    (int)comboBox_utente_.SelectedValue, activity_key_,
            //    Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
            //    Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
            //    Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
            //    Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()));

            new DataSet.dsActivitiesTableAdapters.OverlappingActivitiesTableAdapter().Fill(
                d_overlap,
                (int)comboBox_utente_.SelectedValue, activity_key_,
                ctrlDateTimePicker_start.ReadTs(),
                ctrlDateTimePicker_end.ReadTs());

            if (d_overlap.Count > 0)
            {
                err += Properties.MessageLocalization.activity_overlap + System.Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            else
            {
                try
                {
                    if (type_ == Type.INSERT)
                    {
                        int? id_ev = null;

                        new DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter().InsertActivity(
                            Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
                            Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
                            Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
                            Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()),
                            (int)(ctrlDateTimePicker_end.ReadTs() - ctrlDateTimePicker_start.ReadTs()).TotalSeconds,
                            textBox_remark.Text,
                            (int)comboBox_utente_.SelectedValue,
                            (int)comboBox_tipo_man.SelectedValue,
                            (int)comboBox_tipo_reparto_.SelectedValue,
                            id_ev,
                            ctrlPlantSelector.SelectedImpianto(),
                            ctrlPlantSelector.SelectedMacchina(),
                            ctrlPlantSelector.SelectedComponente(),
                            ctrlPlantSelector.SelectedSCM_1(),
                            ctrlPlantSelector.SelectedSCM_2(),
                            ctrlPlantSelector.SelectedSCM_3(),
                            Program.CurrentUser.Login,
                            ctrlDateTimePicker_start.ReadTs(),
                            ctrlDateTimePicker_end.ReadTs(),
                            (int)comboBox_tip_ore.SelectedValue,
                            comboBox_Capex.SelectedValue.ToString().Trim().Equals(string.Empty) ? null : comboBox_Capex.SelectedValue.ToString()
                            );

                        Program.RefreshActNoReport();
                    }
                    else if (type_ == Type.MODIFY)
                    {
                        new DataSet.dsActivitiesTableAdapters.ActivitiesTableAdapter().UpdateQuery(
                            Program.DateToInt(ctrlDateTimePicker_start.ReadTs()),
                            Program.DateToInt(ctrlDateTimePicker_end.ReadTs()),
                            Program.HmsToInt(ctrlDateTimePicker_start.ReadTs()),
                            Program.HmsToInt(ctrlDateTimePicker_end.ReadTs()),
                            (int)(ctrlDateTimePicker_end.ReadTs() - ctrlDateTimePicker_start.ReadTs()).TotalSeconds,
                            textBox_remark.Text,
                            (int)comboBox_utente_.SelectedValue,
                            (int)comboBox_tipo_man.SelectedValue,
                            (int)comboBox_tipo_reparto_.SelectedValue,                            
                            ctrlPlantSelector.SelectedImpianto(),
                            ctrlPlantSelector.SelectedMacchina(),
                            ctrlPlantSelector.SelectedComponente(),
                            ctrlPlantSelector.SelectedSCM_1(),
                            ctrlPlantSelector.SelectedSCM_2(),
                            ctrlPlantSelector.SelectedSCM_3(),
                            Program.CurrentUser.Login,
                            ctrlDateTimePicker_start.ReadTs(),
                            ctrlDateTimePicker_end.ReadTs(), (int)comboBox_tip_ore.SelectedValue,
                            comboBox_Capex.SelectedValue.ToString().Trim().Equals(string.Empty) ? null : comboBox_Capex.SelectedValue.ToString(),
                            activity_key_);
                    }
                    ActivitySubmitEventArgs ev = new ActivitySubmitEventArgs(ctrlDateTimePicker_start.ReadTs(), ctrlDateTimePicker_end.ReadTs());
                    InitializeMask();
                    SubmitEvent(this, ev);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

 
        public void TipoRepartoChanged()
        {
            TreeView_Initialize();
            if (comboBox_tipo_reparto_.SelectedValue != null)
            {
                ctrlPlantSelector.TipoReparto = (int)comboBox_tipo_reparto_.SelectedValue;
                ctrlPlantSelector.Initialize();
            }
        }        

        bool treeview_visible = false;
        private void button1_Click(object sender, EventArgs e)
        {            
            treeview_visible = !treeview_visible;
            dbPanel_treenode_view.Visible = treeview_visible;
            if (!treeview_initialized)
                TreeView_Initialize();
        }

        private void ctrlDateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
            ctrlDateTimePicker_end.ValueChanged -= ctrlDateTimePicker_end_ValueChanged;
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
            {
                ctrlDateTimePicker_end.WriteTs(ctrlDateTimePicker_start.ReadTs().AddMinutes(CtrlDateTimePicker.forward));
            }
            ctrlDateTimePicker_end.ValueChanged += new EventHandler(ctrlDateTimePicker_end_ValueChanged);
        }

        private void ctrlDateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            ctrlDateTimePicker_start.ValueChanged -= ctrlDateTimePicker_start_ValueChanged;
            if (ctrlDateTimePicker_start.ReadTs() >= ctrlDateTimePicker_end.ReadTs())
                ctrlDateTimePicker_start.WriteTs(ctrlDateTimePicker_end.ReadTs().AddMinutes(-CtrlDateTimePicker.backward));
            ctrlDateTimePicker_start.ValueChanged += new EventHandler(ctrlDateTimePicker_start_ValueChanged);
        }

        int activity_key_ = -1;
        internal void PerformSelection(DataSet.dsActivities.ActivitiesRow row)
        {
            //non si possono modificare eventi
            if (row.IsActEveGroupIdNull())
            {
                foreach (Control c in dbPanel_main.Controls)
                {
                    c.Enabled = true;
                    //c.Visible = true;
                }
            }
            else
            {
                foreach (Control c in dbPanel_main.Controls)
                {
                    c.Enabled = false;
                    //c.Visible = false;
                }
                return;
            }

            int ? mac_key = null;
            int ? com_key = null;
            int ? scm1_key = null;
            int ? scm2_key = null;
            int ? scm3_key = null;

            if (!row.IsMACKeyNull())
                mac_key = row.MACKey;
            if (!row.IsCOMKeyNull())
                com_key = row.COMKey;
            if (!row.IsSCM_1_KeyNull())
                scm1_key = row.SCM_1_Key;
            if (!row.IsSCM_2_KeyNull())
                scm2_key = row.SCM_2_Key;
            if (!row.IsSCM_3_keyNull())
                scm3_key = row.SCM_3_key;

            comboBox_tipo_man.SelectedValue = row.TipoManKey;

            ctrlDateTimePicker_start.ValueChanged -= ctrlDateTimePicker_start_ValueChanged;
            ctrlDateTimePicker_end.ValueChanged -= ctrlDateTimePicker_end_ValueChanged;
            ctrlDateTimePicker_start.WriteTs(new DateTime(row.dt_StartDate.Year, row.dt_StartDate.Month, row.dt_StartDate.Day,
                row.dt_StartHMS.Hours, row.dt_StartHMS.Minutes, row.dt_StartHMS.Seconds));
            ctrlDateTimePicker_end.WriteTs(new DateTime(row.dt_EndDate.Year, row.dt_EndDate.Month, row.dt_EndDate.Day,
                row.dt_EndHMS.Hours, row.dt_EndHMS.Minutes, row.dt_EndHMS.Seconds));
            ctrlDateTimePicker_start.ValueChanged += ctrlDateTimePicker_start_ValueChanged;
            ctrlDateTimePicker_end.ValueChanged += ctrlDateTimePicker_end_ValueChanged;

            ctrlPlantSelector.PerformSelection(row.AREKey, row.IMPKey, mac_key, com_key, scm1_key, scm2_key, scm3_key);

            textBox_remark.Text = row.ActivityRemark;
            comboBox_tip_ore.SelectedValue = row.TipoOreKey;
            this.manAnaCapexBindingSource.Filter = "Active = 'Y' OR PrjCode = '" + (row.IsCapexKeyNull() ? string.Empty : row.CapexKey) + "'";
            comboBox_Capex.SelectedValue = row.IsCapexKeyNull() ? string.Empty : row.CapexKey;

            activity_key_ = row.ActivityKey;
        }
    }
}
