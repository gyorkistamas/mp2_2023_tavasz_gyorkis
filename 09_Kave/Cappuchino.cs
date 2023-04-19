using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Kave
{
    internal class Cappuchino : Kave
    {
        protected override void CukrotBele()
        {
            Console.WriteLine("Belerakja a cukrot");
        }

        protected override void KavetOrol()
        {
            Console.WriteLine("Megőrli a kávét");
        }

        protected override void TejetBele()
        {
            Console.WriteLine("Belerakja a tejhabot");
        }
        public Cappuchino()
        {
            KavetOrol();
            CukrotBele();
            TejetBele();
        }
    }
}
