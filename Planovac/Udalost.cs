using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanovacTridy
{
    public class Udalost
    {
        public string Nazev;
        public string Misto;
        public string Datum;
        public Priorita Priorita;

        public Udalost(string nazev, string misto, string datum, Priorita priorita)
        {
            Nazev = nazev;
            Misto = misto;
            Datum = datum;
            Priorita = priorita;
        }
    }
}
