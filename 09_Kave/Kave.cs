using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Kave
{
    abstract class Kave
    {
        protected void VizetForral()
        {
            Console.WriteLine( "Felforralja a vizet.");
        }

        protected void PoharatAdagol()
        {
            Console.WriteLine(  "Kiad egy poharat.");
        }

        protected abstract void CukrotBele();
        
        protected abstract void TejetBele();

        protected abstract void KavetOrol();

        public Kave()
        {
            VizetForral();

            PoharatAdagol();
        }

    }
}
