namespace _02_Konyvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konyv konyv = new Konyv();
            //konyv.Id = 1;
            //konyv.Szerzo = "Robert C. Martin";
            //konyv.Cim = "Tiszta kód";
            //konyv.Ar = 4500;
            //konyv.Isbn = "I-456783245-3";

            //Konyv tisztaKod = new Konyv("Robert C. Martin", "Tiszta kód", 4500, "I-456783245-3");

            //Konyv tulelokonyv = new Konyv("Robert C. Martin", "Túlélőkönyv programozóknak", 5000, "I-45454564543-1");

            //Konyv harryPotter = new Konyv("J. K. Rowling", "Harry Potter és a bölcsek köve");



            //Console.WriteLine(tisztaKod);
            //Console.WriteLine(tulelokonyv);
            //Console.WriteLine(harryPotter);
            //Console.WriteLine(headFirst);


            List<Konyv> konyvek = new List<Konyv>();

            //konyvek.Add(new Konyv("Robert C. Martin", "Headfirst Design Patterns", 5278));

            //konyvek.Add(new Konyv("Robert C. Martin", "Tiszta kód", 4500, "I-456783245-3"));

            //konyvek.Add(new Konyv("Robert C. Martin", "Túlélőkönyv programozóknak", 5000, "I-45454564543-1"));

            //konyvek.Add(new Konyv("J. K. Rowling", "Harry Potter és a bölcsek köve"));


            Konyvesbolt libri = new Konyvesbolt("Libri");

            libri.Addkonyv("Robert C. Martin", "Headfirst Design Patterns", 5278, "I-45454564543-1");

            libri.Addkonyv("Robert C. Martin", "Tiszta kód", 4500, "I-456783245-3");

            libri.Addkonyv("Robert C. Martin", "Túlélőkönyv programozóknak", 5000, "I-45454564543-1");

            libri.Addkonyv("J. K. Rowling", "Harry Potter és a bölcsek köve", 4500, "I-45454564543-1");

            foreach (Konyv konyv in libri.OsszesKonyv)
            {
                Console.WriteLine(konyv);
            }


            libri.OsszesKonyv.Add(new Konyv("teszt", "teszt"));

            Console.WriteLine("-----------------------");

            libri.OsszesKonyv[0].Ar = 4000;

            foreach (Konyv konyv in libri.OsszesKonyv)
            {
                Console.WriteLine(konyv);
            }


            Console.WriteLine("-----------------------");

            libri.RemoveKonyv("J. K. Rowling", "Harry Potter és a bölcsek köve");

            foreach (Konyv konyv in libri.OsszesKonyv)
            {
                Console.WriteLine(konyv);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Robert C. Martin könyvei:");

            foreach(Konyv konyv in libri.AdottSzerzojuKonyvek("Robert C. Martin"))
            {
                Console.WriteLine(konyv);
            }


            Console.WriteLine("------------------");
            Console.WriteLine("Legdrágább könyv:\n{0}", libri.LegdragabbKonyv);

            Console.WriteLine("------------------");

            Console.WriteLine("Listában az első könyv: ");
            Console.WriteLine(libri[0]);

            Console.WriteLine("------------------");

            Console.WriteLine("Martinnak Tiszta kód könyve: ");
            Console.WriteLine(libri["Robert C. Martin", "Tiszta kód"]);

            Console.ReadLine();


        }
    }
}