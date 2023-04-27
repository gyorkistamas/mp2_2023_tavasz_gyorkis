using _12_VersenyzoDLL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _11_Versenyzok
{
    static class VersenyzoBovito
    {
        public static double GetMilliSeconds(this Versenyzo versenyzo)
        {
            return versenyzo.KorIdo.TotalMilliseconds;
        }
    }
}
