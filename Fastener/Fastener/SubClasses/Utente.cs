using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Security.Principal;
using Fastener.DataSet.dsUTETableAdapters;

namespace Fastener
{
    /// <summary>
    /// Classe per gestire l'eccezione Utente non trovato
    /// </summary>
    class UtenteNotFoundException : Exception
    {
        string utente;
        public string Utente
        {
            get { return utente; }
        }

        public UtenteNotFoundException(string login)
        {
            utente = login;
        }
    }

    /// <summary>
    /// Classe per gestire l'eccezione Password non valida
    /// </summary>
    class UtenteInvalidPasswordException : Exception
    {
        public UtenteInvalidPasswordException()
        {
        }
    }

    /// <summary>
    /// Classe che rappresenta l'utente attualmente loggato
    /// </summary>
    class Utente
    {
        //chiave univoca dell'utente
        private int key;
        //nome dell'utente
        private string nome;
        //nome usato per retrocompatibilità con dominio VALSIDER.it e AMEL, va a morire con i nuovi utenti
        private string nomeNelDominio;
        //utente (login)
        private string login = string.Empty;
        
        //id della categoria di appartenenza dell'utente
        private int categoria;
        
        //reparto di default
        int default_reparto;

        //Azienda
        private int azienda;
        //lingua di default
        private int lingua;
        //utente di dominio
        private string utenteDominio;

        //tipologia utente Conto Analitico
        private int ute_Type_CA;
        //Centro di Responsabilità
        private string cdr_CA;

        #region Properties

        public int Azienda
        {
            get { return azienda; }
        }
        public string Nome
        {
            get { return nome; }
        }

        public int Key
        {
            get { return key; }
        }

        public string NomeNelDominio
        {
            get { return nomeNelDominio; }
        }

        public string Login
        {
            get { return login; }
        }

        public string LoginDominio
        {
            get { return utenteDominio; }
        }

        public int Categoria
        {
            get { return categoria; }
        }

        
        public int Lingua
        {
            get { return lingua; }
        }

        public int DefaultReparto
        {
            get { return default_reparto; }
        }

        public int UserType_CA
        {
            get { return ute_Type_CA;  }
        }

        public string CDR_CA
        {
            get { return cdr_CA;  }
        }
        
        #endregion Properties

        #region Funzioni Caricamento Dati
        /// <summary>
        /// Carica ed effettua il login del nuovo utente
        /// </summary>
        /// <param name="utente">Nome utente</param>
        /// <param name="nomeUtente">Password</param>
        private void CaricaDatiUtente(string nomeUtente, string password)
        {
            using (Man_Ana_UTETableAdapter adapter = new Man_Ana_UTETableAdapter())
            {
                using (Fastener.DataSet.dsUTE.Man_Ana_UTEDataTable user = adapter.GetDataByNomeUtente(nomeUtente))
                {
                    if (user.Rows.Count <= 0)
                        throw new UtenteNotFoundException(nomeUtente);
                    else
                    {
                        DataSet.dsUTE.Man_Ana_UTERow row = user[0];

                        if (Utility.CheckNULL(row.UTEPassword, string.Empty).ToString().Trim() != password)
                            throw new UtenteInvalidPasswordException();
                        else
                        {
                            key = Convert.ToInt32(Utility.CheckNULL(row.UTEKey, -1).ToString());
                            login = Utility.CheckNULL(row.UTELogin, string.Empty).ToString();
                            nomeNelDominio = Utility.CheckNULL(row.UTEDomainName, string.Empty).ToString();
                            nome = Utility.CheckNULL(row.UTEName, string.Empty).ToString();
                            categoria = Convert.ToInt32(Utility.CheckNULL(row.TipoUteKey, -1).ToString());
                            lingua = Convert.ToInt32(Utility.CheckNULL(row.LANKey, 1).ToString());
                            azienda = Convert.ToInt32(Utility.CheckNULL(row.AZIKey, 1).ToString());
                            default_reparto = Convert.ToInt32(Utility.CheckNULL(row.DefRepKey, 1).ToString());
                            ute_Type_CA = row.IsTipoUteCA_KeyNull() ? (int)Utility.LoginType_CA.Unknown : row.TipoUteCA_Key;
                            cdr_CA = row.IsCDRKeyNull() ? "UNK" : row.CDRKey;

                            const string kDefaultPasswordHash = "baaab6fa3b287456d2ff691027920826";
                            if (kDefaultPasswordHash == password)
                            {
                                Program.state_ = Program.PROGRAM_STATE.PASSWORD_CHANGE;
                            }
                            else
                            {
                                Program.state_ = Program.PROGRAM_STATE.MAIN_APPLICATION;
                            }

                            LoadProperties(key);
                        }
                    }
                }
            }
        }

        #region GESTIONE PERMESSI
        private List<string> Permessi = new List<string>();
        public bool GetPermission(string permission)
        {
            return Permessi.Contains(permission);
        }
        private void LoadProperties(int key)
        {
            Permessi.Clear();
            DataSet.dsUTE.Man_Ana_PermessiDataTable d = new DataSet.dsUTE.Man_Ana_PermessiDataTable();
            new DataSet.dsUTETableAdapters.Man_Ana_PermessiTableAdapter().Fill(d, key);

            foreach (DataSet.dsUTE.Man_Ana_PermessiRow row in d.Rows)
            {
                Permessi.Add(row.PermessiName);
            }
        }
        #endregion

        /// <summary>
        /// Setta l'utente di dominio tramite la classe WindowsIdentity. Se si verifica un errore la stringa viene settata vuota
        /// </summary>
        private void SetUtenteDominio()
        {
            try
            {
                utenteDominio = WindowsIdentity.GetCurrent().Name;
            }
            catch (Exception e)
            {
                e.ToString();
                utenteDominio = string.Empty;
            }
        }
                
        /// <summary>
        /// Crea un nuovo Utente
        /// </summary>
        /// <param name="login">Login Utilizzato</param>
        /// <param name="password">Password</param>
        public static Utente CaricaUtente(string login, string password)
        {
            Utente user = new Utente();
            //carica l'utente
            user.CaricaDatiUtente(login, password);
            //Carica le liste di permessi per l'utente

            //Utility.ChangeCulture(user.Lingua);
            CultureManager.ApplicationUICulture = new System.Globalization.CultureInfo(user.Lingua);
            return user;
        }

        #endregion Funzioni Caricamento Dati
    }
}
