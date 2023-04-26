using _12_VersenyzoDLL2;

namespace _11_Versenyzok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Versenyzo versenyzo1 = new Versenyzo("Név1", "Csapat1", 5, 10, 4);

            Versenyzo versenyzo2 = new Versenyzo("Név2", "Csapat2", 6, 2, 0);

            VersenyzokContainer kontener = new VersenyzokContainer();

            kontener.AddVersenyzo(versenyzo2);

            kontener.AddVersenyzo(versenyzo1);

            kontener.AddVersenyzo(new Versenyzo("Versenyzo 3", "Csapat3", 0, 10, 0));

            foreach (Versenyzo versenyzo in kontener.Versenyzok)
            {
                Console.WriteLine(versenyzo.KorIdo);
            }


            Console.ReadLine();
        }
    }
}