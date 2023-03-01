namespace _1_Diakok
{
    internal class Program
    {

        public static void Kiir(Diak diak)
        {
            Console.WriteLine($"Név: {diak.nev}");
            Console.WriteLine("Születés nap: {0}", diak.szuletesNap);
            Console.WriteLine("Lakcím: {0}, {1}, {2}", diak.lakcim.iranyitoszam, diak.lakcim.utcaNev, diak.lakcim.hazSzam);
            Console.WriteLine("Tagozat: {0}", diak.tagozat);
            Console.WriteLine("Kezdés éve: {0}", diak.kezdesEve);
        }

        static void Main(string[] args)
        {
            Diak tamas = new Diak();

            tamas.nev = "Györkis Tamás";

            tamas.lakcim = new Lakcim();
            tamas.lakcim.iranyitoszam = 3000;
            tamas.lakcim.utcaNev = "asdasdsadas utca";
            tamas.lakcim.hazSzam = 20;

            tamas.tagozat = Tagozat.NAPPALI;

            tamas.szuletesNap = new DateTime(2001, 4, 30);

            tamas.kezdesEve = 2021;

            Kiir(tamas);

            Console.ReadLine();
        }
    }
}