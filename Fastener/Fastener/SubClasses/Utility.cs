using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Fastener
{
    static class Utility
    {
        
        /// <summary>
        /// Proprietà per ottenere il Resource Manager predefinito dell'applicazione
        /// </summary>
        public static System.Resources.ResourceManager Manager
        {
            get { return Fastener.Properties.MessageLocalization.ResourceManager; }
        }

        /// <summary>
        /// Controlla se un valore è NULL e lo sostituisce con un default
        /// </summary>
        /// <param name="toCheck">Valore da controllare</param>
        /// <param name="defVal">Valore di default da restiture in caso di null</param>
        /// <returns>Il valore o il valore di default</returns>
        public static object CheckNULL(object toCheck, object defVal)
        {
            return toCheck == DBNull.Value ? defVal : toCheck;
        }

        /// <summary>
        /// Formatta graficamente un dragridview
        /// </summary>
        /// <param name="dg">Datagrid da formattare</param>
        /// <param name="alternate">True se deve alternare i colori delle righe</param>
        public static void formatDataGrid(System.Windows.Forms.DataGridView dg, bool alternate, bool is_editable = false, bool allow_delete = false)
        {
            dg.DoubleBuffered(true);
            formatDataGrid(dg, alternate, 9,false, is_editable, allow_delete);
        }

        /// <summary>
        /// Formatta graficamente un dragridview
        /// </summary>
        /// <param name="dg">Datagrid da formattare</param>
        /// <param name="alternate">True se deve alternare i colori delle righe</param>
        /// <param name="fontSize">Grandezza del font</param> 
        /// <param name="formatNumber">Formatta i numeri con spazi come separatore di gruppo</param>
        public static void formatDataGrid(System.Windows.Forms.DataGridView dg, bool alternate,int fontSize, bool formatNumber, bool is_editable, bool allow_delete = false)
        {
            try
            {
                dg.BackgroundColor = Color.White;

                if (!allow_delete)
                {
                    dg.RowHeadersVisible = false;
                    dg.AllowUserToDeleteRows = false;
                    dg.AllowUserToResizeColumns = false;
                    dg.AllowUserToResizeRows = false;
                }

                dg.DefaultCellStyle.Font = new Font("Tahoma", fontSize);
                dg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                

                dg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

                //dg.RowTemplate.Height = 20;

                if (formatNumber)
                {
                    System.Globalization.NumberFormatInfo provider;
                    provider = (System.Globalization.NumberFormatInfo)dg.DefaultCellStyle.FormatProvider.GetFormat(typeof(System.Globalization.NumberFormatInfo));
                    provider = new System.Globalization.NumberFormatInfo();
                    provider.NumberDecimalSeparator = ",";
                    provider.NumberGroupSeparator = " ";
                    dg.DefaultCellStyle.Format = "N2";
                    dg.DefaultCellStyle.FormatProvider = provider;
                }

                if (is_editable)
                {
                    if (alternate)
                    {
                        dg.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                        dg.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;
                        dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        dg.DefaultCellStyle.BackColor = Color.White;
                        dg.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        dg.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                        dg.DefaultCellStyle.SelectionForeColor = Color.LightCoral;
                        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.LightCoral;
                    }
                }
                else
                {
                    if (alternate)
                    {
                        dg.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        dg.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                        dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        dg.DefaultCellStyle.BackColor = Color.White;
                        dg.DefaultCellStyle.ForeColor = Color.Black;

                    }
                    else
                    {
                        dg.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        dg.DefaultCellStyle.SelectionForeColor = Color.Black;
                        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        dg.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

                    }
                }

                foreach (System.Windows.Forms.DataGridViewColumn col in dg.Columns)
                    col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception)
            {
                //problem at design time with unhandled exception
            }
        }

        /// <summary>
        /// Deseleziona tutte le righe del DataGridView
        /// </summary>
        /// <param name="dg">DataGridView per cui deselezionare le righe</param>
        public static void ClearDataGridSelection(DataGridView dg)
        {
            foreach (DataGridViewRow row in dg.Rows)
                row.Selected = false;
        }

        /// <summary>
        /// Assegna un datasource ad una combo box
        /// </summary>
        /// <param name="combo">ComboBox in oggetto</param>
        /// <param name="DataSource">DataSource da asseggnare</param>
        /// <param name="display">Nome DisplayMember</param>
        /// <param name="value">Nome Value Member</param>
        public static void BindDataGridComboBox(System.Windows.Forms.DataGridViewComboBoxCell combo, object DataSource, string display, string value)
        {
            combo.DataSource = DataSource;
            combo.DisplayMember = display;
            combo.ValueMember = value;
        }


        /// <summary>
        /// Assegna un datasource ad una combo box
        /// </summary>
        /// <param name="combo">ComboBox in oggetto</param>
        /// <param name="DataSource">DataSource da asseggnare</param>
        /// <param name="display">Nome DisplayMember</param>
        /// <param name="value">Nome Value Member</param>
        public static void BindDataGridComboBox(System.Windows.Forms.DataGridViewComboBoxColumn combo, object DataSource, string display, string value)
        {
            combo.DataSource = DataSource;
            combo.DisplayMember = display;
            combo.ValueMember = value;
        }

        
        /// <summary>
        /// Verifica se un oggetto è convertibile in Intero
        /// </summary>
        /// <param name="obj">Oggetto da convertire</param>
        /// <returns>true se l'oggetto è convertibile in intero</returns>
        public static bool isInteger(object obj)
        {
            try
            {
                Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifica se un oggetto è convertibile in numero
        /// </summary>
        /// <param name="obj">Oggetto da convertire</param>
        /// <returns>true se l'oggetto è convertibile in numero</returns>
        public static bool isNumeric(object obj)
        {
            try
            {
                Convert.ToDouble(obj);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Sostituisce nei numeri ',' con '.', o viceversa, per un corretto inserimento dei numeri decimali
        /// </summary>
        /// <param name="number">stringa contenente il numero da inserire</param>
        /// <returns>il numero formattato correttamente</returns>
        public static string FormatNumber(string number)
        {
            return number.Replace(System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator, System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }

        /// <summary>
        /// Ritorna il messaggio dell'eccezione e dell'eccezione interna ove presente
        /// </summary>
        /// <param name="e">Eccezione per cui stampare il messaggio</param>
        /// <returns>Il messaggio contenuto nell'eccezione</returns>
        public static string printInnerException(Exception e)
        {
            string message = e.Message;
            if (e.InnerException != null)
                message += "\n" + e.InnerException.Message;

            return message;
        }

       
        /// <summary>
        /// Copia tutti i campi comuni da una DataRow ad un'altra appartenenti a tabelle differenti
        /// </summary>
        /// <param name="rowSource">Riga Sorgente</param>
        /// <param name="rowDest">Riga Destinazione</param>
        public static void CopyRow(DataRow rowSource, DataRow rowDest)
        {
            foreach (DataColumn col in rowDest.Table.Columns)
            {
                if (rowSource.Table.Columns.Contains(col.ColumnName))
                    rowDest[col.ColumnName] = rowSource[col.ColumnName];
            }
        }

        
        /// <summary>
        /// Verifica se una lista ordinata di interi è formata da numeri consecutivi o meno
        /// </summary>
        /// <param name="lista">Lista di numeri</param>
        /// <returns>True se i numeri son consecituvi, false altrimenti</returns>
        public static bool CheckConsecutivi(List<int> lista)
        {
            if (lista == null)
                return false;

            int n = lista.Count;
            if (n <= 0)
                return false;

            int prec = lista[0];
            for (int k = 1; k < n; k++)
            {
                if (lista[k] == prec + 1)
                    prec++;
                else
                    return false;
            }
            //se non sono uscito nel ciclo, allora sono numeri consecutivi
            return true;
        }

        /// <summary>
        /// Scrive un file in PDF
        /// </summary>
        /// <param name="file">Array di byte di cui è formato il file</param>
        /// <param name="name">Nome del file da salvare</param>
        public static void PDFtoFile(byte[] file, string name)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(name);
            
            if (fi.Exists) 
                fi.Delete();

            using (System.IO.FileStream fs = System.IO.File.Create(name))
            {
                fs.Write(file, 0, file.Length);
                fs.Close();
            }

        }

        

        /// <summary>
        /// Ritorna la lingua usata dal thread corrente
        /// </summary>
        /// <returns>Cultura utilizzata</returns>
        public static string GetInterfaceLanguage()
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.Name;
        }
        
        /// <summary>
        /// When inserting a record into a DB table with an autoincrement field,
        /// the operation will produce two records to store the previous ID value.
        /// Since this is an unwanted feature in most of cases, then you can disable it
        /// by changing the UpdateStatus option of the tableadapter.
        /// </summary>
        /// <param name="adap">data adapter you want to change</param>
        static public void DoNotDuplicateOnInsertPrimaryKey(System.Data.SqlClient.SqlDataAdapter adap)
        {
            adap.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(OnRowUpdated);
        }

        /// <summary>
        /// See DoNotDuplicateOnInsertPrimaryKey
        /// </summary>
        static private void OnRowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs args)
        {
            //MS Bug: The Merge method may create duplicate records when you try to update records with an AutoIncrement field
            if (StatementType.Insert == args.StatementType)
                args.Status = UpdateStatus.SkipCurrentRow;
        }

        static public void SetComboBoxDrawModeCustom(ComboBox cb, DrawItemEventHandler handler)
        {
            cb.DrawItem += handler;
            cb.DrawMode = DrawMode.OwnerDrawFixed;
        }

        
        public static string GetAppVersion()
        {
            string version = string.Empty;
            /*
            if (true == System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad =
                        System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                version = " - [" + ad.CurrentVersion.ToString() + "]";
            }
            else
             */

            //Handled by MSBuild, now before compiling VS will overwrite assembly version to match
            //publish version
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                version = asm.GetName().Version.ToString();
            }

            return version;
        }

        /// <summary>
        /// Extension method to clean a folder content
        /// </summary>
        /// <param name="directory">directory object to extend</param>
        public static void Empty(this System.IO.DirectoryInfo directory)
        {
            foreach (System.IO.FileInfo file in directory.GetFiles()) file.Delete();
            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
        }

        // drop this class anywhere in your project


        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        /// <summary>
        /// Split a string in token of fixed length by meaninful words.
        /// </summary>
        /// <param name="longText">Text to split</param>
        /// <param name="overflow">return true if maxTokens is not sufficient to store whle text</param>
        /// <param name="shardLength">max token length</param>
        /// <param name="maxTokens">max number of tokens allowed to be generated</param>
        /// <returns>array of tokens</returns>
        public static string[] SplitByMeaningFulWords(string longText, out bool overflow, int shardLength = 30, int maxTokens = 6, bool excludeCarriageReturn = false)
        {
            string delimiters = (true == excludeCarriageReturn) ? @"[\ ]" : @"\s+";//spaces. @"\W+";//one or more non word characters. @"[\ +]" was uncorrectly filtering i caratteri '+'.
            string[] sentences = System.Text.RegularExpressions.Regex.Split(longText, delimiters);
            string shard = string.Empty;
            string[] labels = new string[maxTokens];
            int i = 0;
            overflow = false;

            List<string> words = new List<string>();
            foreach (string s in sentences)
            {
                if (s.Contains("\n"))
                {
                    int oldIdx = 0;
                    int idx = s.IndexOf("\n", oldIdx);
                    while (0 <= idx)
                    {
                        words.Add(s.Substring(oldIdx, idx - oldIdx + 1));
                        oldIdx = idx + 1;
                        idx = s.IndexOf("\n", oldIdx);
                    }

                    if (oldIdx < s.Length)
                    {
                        words.Add(s.Substring(oldIdx, s.Length - oldIdx));
                    }
                }
                else
                {
                    words.Add(s);
                }
            }

            bool addCRLF = false;
            foreach (string s in words)
            {
                // handle out of minimum range words
                string sentence = s;
                if (sentence.Length > shardLength)
                {
                    // Clean previous shard from carriage returns
                    if (shard.Contains("\n"))
                    {
                        shard = shard.Replace("\r\n", string.Empty);
                        addCRLF = true;
                    }
                    else
                        addCRLF = false;

                    bool stop = false;
                    while (false == stop)
                    {
                        string tmp = sentence.Substring(0, shardLength);
                        if (!string.IsNullOrEmpty(shard))
                        {
                            labels[i++] = shard;
                            if (i > maxTokens - 1)
                            {
                                overflow = true;
                                return labels;
                            }
                        }

                        labels[i++] = tmp;
                        shard = tmp;
                        if (i > maxTokens - 1)
                        {
                            overflow = true;
                            return labels;
                        }
                        else
                        {                      
                            if (0 == sentence.Length - tmp.Length)
                                stop = true;
                            else
                            {
                                sentence = sentence.Substring(tmp.Length, sentence.Length - tmp.Length);
                                if (sentence.Length <= shardLength)
                                {
                                    stop = true;
                                    shard = string.Empty;
                                }
                            }
                        }
                    }

                    // word of maximum length ends with "\r\n" ... skip... because it already goes to a new line.
                    if ("\r\n" == sentence)
                        continue;
                }

                // Regular processing from now on
                // Clean previous shard from carriage returns
                if (shard.Contains("\n"))
                {
                    shard = shard.Replace("\r\n", string.Empty);
                    addCRLF = true;
                }
                else
                    addCRLF = false;

                if ((shard.Length + sentence.Length) <= ((!string.IsNullOrEmpty(shard)) ? shardLength - 1 : shardLength) && !addCRLF)
                {
                    shard += (!string.IsNullOrEmpty(shard)) ? " " + sentence : sentence;
                }
                else
                {
                    labels[i++] = shard;
                    shard = sentence;
                    if (i > maxTokens - 1)
                    {
                        overflow = true;
                        return labels;
                    }
                }
            }

            if (false == string.IsNullOrEmpty(shard))
            {
                if (shard.Contains("\n"))
                {
                    shard = shard.Replace("\r\n", string.Empty);
                    addCRLF = true;
                }
                else
                    addCRLF = false;

                labels[i++] = shard;
            }

            return labels;
        }

        public enum LoginType_CA
        {
            Richiedente = 1,
            Pianificatore = 2,
            Esecutore = 3,
            Amministratore = 4,
            Unknown = 5
        }

        public enum StatoRichiesta_CA
        {
            Annullata_Richiedente =	1,
            Emessa	= 2,
            Assegnata =	3,
            Respinta =	4,
            Accettata =	5,
            Completata = 6,
            Non_Conforme = 7,
            Conforme =	8,
            Nuova =	9,
            Annullata_Pianificatore = 10
        }

        public enum Azioni_CA
        {
            Annulla_Richiesta = 	1,
            Invia_Richiesta = 	2,
            Assegna_Richiesta = 	3,
            Respingi_Richiesta = 	4,
            Accetta_Richiesta = 	5,
            Chiudi_Richiesta = 	6,
            Non_Conforme = 	7,
            Conforme = 	8,
            Riapri_Richiesta = 	9
        }

    }
}
