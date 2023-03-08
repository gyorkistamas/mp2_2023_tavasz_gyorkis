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

            konyvek.Add(new Konyv("Robert C. Martin", "Headfirst Design Patterns", 5278));

            konyvek.Add(new Konyv("Robert C. Martin", "Tiszta kód", 4500, "I-456783245-3"));

            konyvek.Add(new Konyv("Robert C. Martin", "Túlélőkönyv programozóknak", 5000, "I-45454564543-1"));

            konyvek.Add(new Konyv("J. K. Rowling", "Harry Potter és a bölcsek köve"));

            Console.ReadLine();


        }
    }
}