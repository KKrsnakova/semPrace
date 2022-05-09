using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanovacTridy
{
    public class Udalost
    {
        public string Nazev { get; set; }
        public string Misto { get; set; }
        public DateTime Datum { get; set; }
        public Priorita Priorita { get; set; }
        public string Poznamka { get; set; }

        public Udalost(string nazev, DateTime datum, string misto,  Priorita priorita, string poznamka)
        {
            Nazev = nazev;
            Misto = misto;
            Datum = datum;
            Priorita = priorita;
            Poznamka = poznamka;
        }
    }
}
