using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_VersenyzoDLL2
{
    public interface IVersenyzo : IComparable
    {
        string Nev { get; }

        string Csapat { get; }

        TimeSpan KorIdo { get; }
    }
}
