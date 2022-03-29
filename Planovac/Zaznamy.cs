﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanovacTridy
{
    public class Zaznamy
    {

       
        public Udalost[] udalosti;
        public int Pocet { get => udalosti.Length; }

        public Udalost this[int index]
        {
            get
            {
                if (index < 0 || index >= udalosti.Length)
                    return null;

                return udalosti[index];
            }
        }

        public Zaznamy()
        {
            udalosti = new Udalost[0];  
        }

        public void Pridej(Udalost udalost)
        {
            Array.Resize(ref udalosti, Pocet + 1);
            for (int i = 0; i < Pocet; i++)
            {
                if (udalosti[i] == null)
                {
                    udalosti[i] = udalost;
                }

            }

        }

    }

}
