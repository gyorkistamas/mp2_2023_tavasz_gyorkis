using System.Reflection;

namespace _15_DiakokLinq2
{
    internal class Program
    {
        static Random rnd = new Random();

        static List<string> noiNevek = new List<string> { "Ágnes", "Linda", "Diána", "Lili", "Zsófia", "Klára,", "Edit", "Margit", "Klaudia", "Fanni", "Klotild", "Eszter" };

        static List<string> ferfiNevek = new List<string> { "Roland", "Tihamér", "Pál", "László", "Sándor", "József", "Benedek", "Gáspár", "Menyhért", "Péter", "Tamás" };

        static List<string> vezetekNevek = new List<string> { "Szabó", "Kovács", "Barna", "Gál", "Molnár", "Juhász", "Szakács", "Takács", "Kádár", "Kis", "Nagy" };

        static List<string> varosok = new List<string> { "Eger", "Debrecen", "Miskolc", "Őrhalom", "Hugyag", "Pécs" };




        static void Feltolt(int db, Diakok diakok)
        {
            for (int i = 0; i < db; i++)
            {
                Gender gender = (Gender)rnd.Next(3);
                string keresztNev = "";

                switch (gender)
                {
                    case Gender.Ferfi:
                        keresztNev = ferfiNevek[rnd.Next(ferfiNevek.Count)];
                        break;
                    case Gender.No:
                        keresztNev = noiNevek[rnd.Next(noiNevek.Count)];
                        break;
                    case Gender.Egyeb:
                        keresztNev = rnd.NextDouble() < 0.5 ? ferfiNevek[rnd.Next(ferfiNevek.Count)] : noiNevek[rnd.Next(noiNevek.Count)];
                        break;
                }

                Diak diak = new Diak(
                    vezetekNevek[rnd.Next(vezetekNevek.Count)],
                    keresztNev,
                    new DateTime(rnd.Next(1985, 2004), rnd.Next(1, 13), rnd.Next(1, 28)),
                    gender,
                    varosok[rnd.Next(varosok.Count)],
                    (double)rnd.Next(100, 501) / 100
                    );

                diakok.AddDiak(diak);
            }
        }


        public static bool Egri_e(Diak diak)
        {
            return diak.Varos == "Eger";
        }

        public static double EletkorSelector(Diak diak)
        {
            return diak.Eletkor;
        }

        static void Main(string[] args)
        {
            Diakok osztaly = new Diakok();

            Feltolt(50, osztaly);


            Console.WriteLine("Összes diák:");
            foreach (Diak diak in osztaly)
            {
                Console.WriteLine(diak);
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Egri diákok:");

            //var egriDiakok = osztaly.Where(Egri_e);
            var egriDiakok = osztaly
                .Where(diak => diak.Varos == "Eger");

            foreach (Diak diak in egriDiakok)
            {
                Console.WriteLine(diak);
            }

            
            double atlag = osztaly.Average(x => x.Eletkor);
            Console.WriteLine("Diákok átlag átlaga: {0}", atlag);

            double Jegyekatlag = osztaly.Average(x => x.JegyekAtlaga);
            Console.WriteLine("Diákok jegyátlagának átlaga: {0}", atlag);

            //Hány éves a legidősebb Diák
            double ev = osztaly.Max(x => x.Eletkor);
            Console.WriteLine("A legidősebb diák életkora: {0}", ev);

            // Egri vagy Debreceni diákok
            // 20 nál idősebb diákok
            // Egri férfi diákok
            // Kovács vezetéknévvel rendelkező diákok

            Console.WriteLine("Egri legalább 3,5-ös átlaggal rendelkező diákok:");
            var atlagdiakok = osztaly
                .Where(x => x.Varos == "Eger")
                .Where(x => x.JegyekAtlaga > 3.5);


            Console.ReadLine();
        }
    }
}