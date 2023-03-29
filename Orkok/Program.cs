namespace Orkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ork ork1 = new Ork(1, "Ork név");

            Harcos harcos1 = new Harcos(2, "Harcos ork név",
                new Fegyver("Kard", 1.9));


            ork1.TamadAnimacio(harcos1);

            harcos1.TamadAnimacio(ork1);

            Console.ReadLine();
        }
    }
}