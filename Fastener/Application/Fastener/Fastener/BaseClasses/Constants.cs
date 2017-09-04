using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fastener.BaseClasses
{
    public static class Constants
    {
        public enum LoginLevel : int
        {
            SuperUser = 1,
            Amministratore = 2,
            Gestore = 3,
            Operatore = 4,
            Preposto = 5,
            UfficioAcquisti = 6
        }
    }
}
