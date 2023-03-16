using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Diakok
{
    static class TagozatFormatter
    {
        public static string Format(Tagozat tagozat)
        {
            switch(tagozat)
            {
                case Tagozat.NAPPALI: return "Nappali";
                case Tagozat.LEVELEZO: return "Levelező";
                case Tagozat.TAVOKTATAS: return "Távoktatás";
                default: throw new Exception("Nem várt érték!");
            }
        }
    }
}
