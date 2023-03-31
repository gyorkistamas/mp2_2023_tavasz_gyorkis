namespace Orkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horda teszt = new Horda();

            teszt.AddOrk("Gloomcrumpa");
            teszt.AddOrk("Gahrlblux");
            teszt.AddOrk("Muzzlrboilah");
            teszt.AddHarcos("Skagtoger", new Fegyver("Pöröly", 1.5));
            teszt.AddHarcos("Klawkurska", new Fegyver("Fejsze", 2.3));
            teszt.AddVarazslo("Harry Potter", new Varazslat("Abra Dekabra", 1.7, 0.7, 20));
            teszt.AddVarazslo("Ron Weasly", new Varazslat("Protego", 1.1, 0.2, 30));


            teszt.Harc();


            Console.ReadLine();

            Console.ReadLine();
        }
    }
}