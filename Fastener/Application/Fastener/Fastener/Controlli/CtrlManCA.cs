using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;

namespace Fastener.Controlli
{
    public partial class CtrlManCA : UserControl
    {
        public CtrlManCA()
        {
            InitializeComponent();

            //man_Ana_Stato_RecordTableAdapter.Fill(dsMaintenance.Man_Ana_Stato_Record);
            ////man_Ana_CDCTableAdapter.Fill(dsMaintenance.Man_Ana_CDC);            
            //man_Ana_Tipo_RepartoTableAdapter.Fill(dsMaintenance.Man_Ana_Tipo_Reparto);

            //dbDataGridView_Priorita.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            //dbDataGridView_rischio.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            //dbDataGridView_repTecnico.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLAN_PRE_COMPONENTE");
            //dbDataGridView_tipo.ReadOnly = !Program.CurrentUser.GetPermission("MAN_PLANT_DOPO_COMP");

            InitRISCHIO();
            InitPRIORITA();
            InitTIPO_RICHIESTA();
            InitRepTECNICO();
            InitCONTO_COGE();
            InitCDR_Reporting();
        }

        private DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter translations = new DataSet.dsMaintenanceTableAdapters.Man_Ana_LAN_TRATableAdapter();

        #region PRIORITA

        private void button_undo_priorita_Click(object sender, EventArgs e)
        {
            try
            {
                InitPRIORITA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitPRIORITA()
        {
            Utility.formatDataGrid(dbDataGridView_Priorita, true);

            cA_Ana_PriorityTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_Priority);
        }

        private void dbDataGridView_priorita_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try 
            { 
                Utility.formatDataGrid(dbDataGridView_Priorita, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_priorita_Click(object sender, EventArgs e)
        {
            try { 
                Utility.formatDataGrid(dbDataGridView_Priorita, true);
                cAAnaPriorityBindingSource.EndEdit();

                cA_Ana_PriorityTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_Priority);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region REP_TECNICO
        private void InitRepTECNICO()
        {
            Utility.formatDataGrid(dbDataGridView_repTecnico, true);

            cA_Ana_CDRTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_CDR);
        }

        private void dbDataGridView_repTecnico_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try 
            { 
                Utility.formatDataGrid(dbDataGridView_repTecnico, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_undo_repTecnico_Click(object sender, EventArgs e)
        {
            try
            {
                InitRepTECNICO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_repTecnico_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_repTecnico, true);
                cAAnaCDRBindingSource.EndEdit();

                cA_Ana_CDRTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_CDR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region RISCHIO
        private void InitRISCHIO()
        {
            Utility.formatDataGrid(dbDataGridView_rischio, true);

            cA_Ana_TipoRischioTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_TipoRischio);
        }

        private void dbDataGridView_rischio_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try 
            { 
                Utility.formatDataGrid(dbDataGridView_rischio, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_undo_rischio_Click(object sender, EventArgs e)
        {
            try
            {
                InitRISCHIO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_rischio_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_rischio, true);
                cAAnaTipoRischioBindingSource.EndEdit();

                cA_Ana_TipoRischioTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_TipoRischio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TIPO RICHIESTA
        private void InitTIPO_RICHIESTA()
        {
            Utility.formatDataGrid(dbDataGridView_tipo, true);

            cA_Ana_TipoRichiestaTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_TipoRichiesta);
        }

        private void dbDataGridView_tipo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_tipo, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_undo_tipo_Click(object sender, EventArgs e)
        {
            try
            {
                InitTIPO_RICHIESTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_tipo_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_tipo, true);
                cAAnaTipoRichiestaBindingSource.EndEdit();

                cA_Ana_TipoRichiestaTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_TipoRichiesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CONTO COGE
        private void InitCONTO_COGE()
        {
            Utility.formatDataGrid(dbDataGridView_conto_coge, true);
            cA_Ana_ContoCogeTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_ContoCoge);
        }

        private void button_undo_conto_coge_Click(object sender, EventArgs e)
        {
            try
            {
                InitCONTO_COGE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_conto_coge_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_conto_coge, true);
                cAAnaContoCogeBindingSource.EndEdit();

                cA_Ana_ContoCogeTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_ContoCoge);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void dbDataGridView_conto_coge_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_conto_coge, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CDR Reporting
        private void InitCDR_Reporting()
        {
            Utility.formatDataGrid(dbDataGridView_CDR_Reporting, true);
            cA_Ana_CDR_ReportingTableAdapter.Fill(dsRichiesteLavorazioni.CA_Ana_CDR_Reporting);
        }

        private void button_undo_CDR_Reporting_Click(object sender, EventArgs e)
        {
            try
            {
                InitCDR_Reporting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_CDR_Reporting_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_CDR_Reporting, true);
                cAAnaCDRReportingBindingSource.EndEdit();

                cA_Ana_CDR_ReportingTableAdapter.Update(dsRichiesteLavorazioni.CA_Ana_CDR_Reporting);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dbDataGridView_CDR_Reporting_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                Utility.formatDataGrid(dbDataGridView_CDR_Reporting, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion




    }
}
