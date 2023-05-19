using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_zh2_gyak_dll
{
    public class SzenzorHalozat : IEnumerable
    {
       private List<Szenzor> szenzorok=new List<Szenzor>();

        public IEnumerator GetEnumerator()
        {
            foreach (Szenzor szenzor in szenzorok)
            {
                yield return (Szenzor)szenzor.Clone();
            }
        }

        public void Telepit(Szenzor szenzor)
        {
            szenzorok.Add(szenzor);
        }
        public List<Szenzor> AktivSzenzorok
        { 
            get
            {
                List<Szenzor> szenzorVissza = szenzorok
                    .Where(szenzor => szenzor.Aktiv)
                    .OrderBy(szenzor => szenzor.Pozicio.x)
                    .ThenByDescending(szenzor => szenzor.Pozicio.y)
                    .Select(szenzor => szenzor.Clone() as Szenzor)
                    .ToList<Szenzor>();
                return szenzorVissza;
            }
        }
        public delegate int AtlagDelegate(Homero homero);

        public double AktivAtlag(AtlagDelegate atlagDelegate)
        {
            //double atlag = 0;
            //int db = 0;
            //foreach (Szenzor szenzor in szenzorok)
            //{
            //    if (szenzor.Aktiv==true&&szenzor is Homero)
            //    {
            //        atlag += atlagDelegate(szenzor as Homero);
            //        db++;
            //    }
            //}
            //return atlag / db;

            List<Homero> homerok = AktivSzenzorok
                        .Where(szenzor => szenzor is Homero)
                        .Select(szenzor => szenzor as Homero)
                        .ToList<Homero>();

            double atlag = 0;

            foreach (Homero homero in homerok)
            {
                atlag += atlagDelegate(homero);
            }

            return atlag / homerok.Count();

        }
        

    }

}
