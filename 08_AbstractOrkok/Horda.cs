using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AbstractOrkok
{
    internal class Horda
    {
        private List<Ork> orkok = new List<Ork>();
        private static int ID = 0;

        public void AddHarcos(string nev, Fegyver fegyver)
        {
            Harcos temp = new Harcos(ID, nev, fegyver);
            ID++;
            orkok.Add(temp);
        }

        public void AddVarazslo(string nev, Varazslat varazslat)
        {
            Varazslo temp = new Varazslo(ID, nev, varazslat);
            ID++;
            orkok.Add(temp);
        }


        public Ork MaxSebzesuOrk
        {
            get
            {
                Ork max = new Harcos(0, "test", new Fegyver("Bot", 0.1));

                foreach (Ork ork in orkok)
                {
                    if (ork.Sebzes > max.Sebzes)
                        max = ork;
                }

                return max;
            }
        }


        public List<Harcos> AdottFegyveruHarcosok(string fegyvernev)
        {
            List<Harcos> temp = new List<Harcos>();

            foreach (Ork ork in orkok)
            {
                if (ork is Harcos && (ork as Harcos).Fegyver.Nev == fegyvernev)
                    temp.Add(new Harcos(ork.Id, ork.Nev, (ork as Harcos).Fegyver));
            }

            return temp;

        }

        public List<Ork> Elesettek
        {
            get
            {
                List<Ork> temp = new List<Ork>();

                foreach (Ork ork in orkok)
                {
                    if (ork.Halott)
                        temp.Add(ork);
                }

                return temp;
            }
        }

        public List<Varazslo> MannaNelkuliVarazslok
        {
            get
            {
                List<Varazslo> temp = new List<Varazslo>();

                foreach (Ork ork in orkok)
                {
                    if (ork is Varazslo && (ork as Varazslo).Mana <= 0)
                        temp.Add(new Varazslo(ork.Id, ork.Nev, (ork as Varazslo).Varazslat));
                }

                return temp;
            }
        }



        public void Harc()
        {

            Random rnd = new Random();

            Ork nyertes = null;

            while (Elesettek.Count() != orkok.Count() - 1)
            {

                int tamadoindex;
                do
                {
                    tamadoindex = rnd.Next(orkok.Count());
                } while (orkok[tamadoindex].Halott);

                Ork tamado = orkok[tamadoindex];


                int ellensegindex;

                do
                {
                    ellensegindex = rnd.Next(orkok.Count());
                } while (tamadoindex == ellensegindex || ((tamado is Harcos || tamado is Varazslo) && orkok[ellensegindex].Halott));

                Ork ellenseg = orkok[ellensegindex];


                tamado.Tamad(ellenseg);
                Console.WriteLine("\n\n------------------------------\n\n");

                nyertes = tamado;
            }

            Console.Write($"A nyertes: {nyertes}");
        }
    }
}
