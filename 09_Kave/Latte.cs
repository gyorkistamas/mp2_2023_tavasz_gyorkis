using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Kave
{
    internal class Latte : Kave
    {
        protected override void CukrotBele()
        {
            Console.WriteLine("Nem raknak bele cukrot");
        }

        protected override void KavetOrol()
        {
            Console.WriteLine("Sok kávét megőröl!");
        }

        protected override void TejetBele()
        {
            Console.WriteLine("Kevés tejet rak bele");
        }

        public Latte()
        {
            KavetOrol();
            CukrotBele();
            TejetBele();
        }
    }
}
