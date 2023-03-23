namespace Égitestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csillag ujcsillag = new Csillag("Alfa Centaur", 300, CsillagOsztaly.VorosOrias, 156.34);


            Dictionary<CsillagOsztaly, int> darabszamok = new Dictionary<CsillagOsztaly, int>();


            darabszamok.Add(CsillagOsztaly.Neutron, 5);
            darabszamok.Add(CsillagOsztaly.NemIsmert, 343);
            darabszamok.Add(CsillagOsztaly.FeherOrias, 676);
            darabszamok.Add(CsillagOsztaly.BarnaTorpe, 787);

            Console.WriteLine(darabszamok[CsillagOsztaly.Neutron]);

            darabszamok[CsillagOsztaly.Neutron]++;

            Console.WriteLine(darabszamok[CsillagOsztaly.Neutron]);

            Console.WriteLine("------------------");

            foreach (var darabszam in darabszamok)
            {
                Console.WriteLine("Osztály: {0}, darabszám: {1}", darabszam.Key, darabszam.Value);
            }

            Console.ReadLine();

        }
    }
}