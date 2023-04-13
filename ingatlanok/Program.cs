using System;

namespace ingatlanok
{
    internal class Program
    {

        public static void Beolvas(IngatlanIroda iroda, string fajlnev)
        {
            StreamReader sr  = new StreamReader(fajlnev);

            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');

                if (adatok[0] == "I")
                {
                    Allapot allapot = (Allapot)Enum.Parse(typeof(Allapot), adatok[4]);
                    Ingatlan uj = new Ingatlan(adatok[1], int.Parse(adatok[2]), int.Parse(adatok[3]), allapot);

                    iroda.AddIngatlan(uj);
                }
                else
                {
                    Allapot allapot = (Allapot)Enum.Parse(typeof(Allapot), adatok[4]);

                    CsaladiHaz haz = new CsaladiHaz(adatok[1], int.Parse(adatok[2]), int.Parse(adatok[3]), allapot, int.Parse(adatok[5]),
                        int.Parse(adatok[6]), int.Parse(adatok[7]));

                    iroda.AddIngatlan(haz);

                }
            }

            sr.Close();
        }
        static void Main(string[] args)
        {
            IngatlanIroda iroda = new IngatlanIroda();

            Beolvas(iroda, "ingatlanok.csv");
            Console.WriteLine("Hello, World!");
        }
    }
}