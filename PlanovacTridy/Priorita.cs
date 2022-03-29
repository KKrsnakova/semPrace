using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanovacTridy
{
    public enum Priorita
    {
        Normalni,
        Vysoka,
        Dulezite,
        Urgentni,
    }

    public class Priority
    {
        public static IEnumerable Polozky { get => Enum.GetValues(typeof(Priorita)); }

        public static string GetName(Priorita priorita)
        {
            switch (priorita)
            {
                case Priorita.Normalni: return "Normální";
                case Priorita.Urgentni: return "Urgentní";
                case Priorita.Dulezite: return "Důležité";
                case Priorita.Vysoka: return "Vysoká";
                default: return "Normální";
            }
        }
    }
}
