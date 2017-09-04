using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//Here is the once-per-application setup information
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Fastener
{
    static class Program
    {
        public static Utente CurrentUser;
        public static string language_ = "";
        public static frmMain frmMain_link = null;

        public enum PROGRAM_STATE
        {
            LOGIN,
            PASSWORD_CHANGE,
            MAIN_APPLICATION,
            QUIT
        }

        static public PROGRAM_STATE state_ = PROGRAM_STATE.LOGIN;

        public static string FilterTipoRep()
        {
            DataSet.dsMaintenance.Utenti_RepartiDataTable d = new DataSet.dsMaintenance.Utenti_RepartiDataTable();
            new DataSet.dsMaintenanceTableAdapters.Utenti_RepartiTableAdapter().Fill(d, Program.CurrentUser.Key);
            string filter = "";
            foreach (DataSet.dsMaintenance.Utenti_RepartiRow row in d.Rows)
            {
                filter += (string.IsNullOrEmpty(filter) ? "" : ", ") + row.TipoRepKey.ToString();
            }
            filter = "TipoRepKey in (" + filter + ")";
            return filter;
        }

        static public void LoadControl(Control where, Control what) 
        {
            where.Controls.Clear();
            what.Dock = DockStyle.Fill;
            where.Controls.Add(what);
        }

        static public void LoadControl<C>(Control where) where C : Control, new()
        {
            where.Controls.Clear();
            C c = new C();
            c.Dock = DockStyle.Fill;
            where.Controls.Add(c);
        }

        static public void RefreshActNoReport()
        {
            if (frmMain_link != null)
            {
                DataSet.dsActivities.ActMinStartDateNoReportDataTable d = new DataSet.dsActivities.ActMinStartDateNoReportDataTable();
                new DataSet.dsActivitiesTableAdapters.ActMinStartDateNoReportTableAdapter().Fill(d, CurrentUser.Key);
                if (d.Count > 0)
                    frmMain_link.ShowWarningActWithNoReport(true);
                else
                   frmMain_link.ShowWarningActWithNoReport(false);
            }
        }

        static public void PerformCorrectRightClick(DataGridView grid, ContextMenuStrip menu, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!grid.Rows[e.RowIndex].Selected)
                    grid.ClearSelection();

                if (grid.Rows.Count > 0)
                    grid.Rows[e.RowIndex].Selected = true;

                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    menu.Show(Cursor.Position);
                }
            }
        }

        static public int DateToInt(DateTimePicker d)
        {
            return d.Value.Year * 10000 + d.Value.Month * 100 + d.Value.Day;
        }

        static public int DateToInt(DateTime d)
        {
            return d.Year * 10000 + d.Month * 100 + d.Day;
        }

        static public int HmsToInt(DateTime d)
        {
            return d.Hour * 10000 + d.Minute * 100 + d.Second;
        }


        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());

            //if (true)
            //{
            //    MessageBox.Show("Manutenzione del Programma in corso.");
            //    if (System.Windows.Forms.Application.MessageLoop)
            //    {
            //        // WinForms app
            //        System.Windows.Forms.Application.Exit();
            //    }
            //    else
            //    {
            //        // Console app
            //        System.Environment.Exit(1);
            //    }
            //}

            bool go = true;

            do
            {
                switch (state_)
                {
                    case PROGRAM_STATE.LOGIN:
                        Application.Run(new frmLogin());
                        break;
                    case PROGRAM_STATE.PASSWORD_CHANGE:
                        Application.Run(new frmPass());
                        break;
                    case PROGRAM_STATE.MAIN_APPLICATION:
                        Application.Run(new frmMain());
                        break;
                    case PROGRAM_STATE.QUIT:
                        go = false;
                        break;
                }
            } while (go);
        }
    }
}
