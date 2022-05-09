using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac
{
    public class Misto
    {
        private string Mesto { get; set; }
        private string Ulice { get; set; }
        private int CisloPopisne { get; set; }
        private int PSC { get; set; }

        public Misto(string mesto, string ulice, int cisloPopisne, int pSC)
        {
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            PSC = pSC;
        }
    }
}
