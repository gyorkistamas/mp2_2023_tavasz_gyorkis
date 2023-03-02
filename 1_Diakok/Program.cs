namespace _1_Diakok
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Diak tamas = new Diak();

            //tamas.nev = "Györkis Tamás";

            //tamas.lakcim = new Lakcim();
            //tamas.lakcim.iranyitoszam = 3000;
            //tamas.lakcim.utcaNev = "asdasdsadas utca";
            //tamas.lakcim.hazSzam = 20;

            //tamas.tagozat = Tagozat.NAPPALI;

            //tamas.szuletesNap = new DateTime(2001, 4, 30);

            //tamas.kezdesEve = 2021;

            //tamas.Kiir();



            //Diak adam = new Diak();

            //adam.nev = "Teszt Ádám";
            //adam.lakcim = new Lakcim();
            //adam.lakcim.iranyitoszam = 3300;
            //adam.lakcim.utcaNev = "Teszt Elek utca";
            //adam.lakcim.hazSzam = 54;

            ////adam.Kiir();


            //Console.WriteLine(tamas);

            Diak gergo = new Diak();


            gergo.SetNev("Valami Gergő");

            gergo.KezdesEve = 2020;

            Console.WriteLine(gergo.KezdesEve);

            Console.ReadLine();
        }
    }
}