namespace Égitestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Csillag ujcsillag = new Csillag("Alfa Centaur", 300, CsillagOsztaly.VorosOrias, 156.34);


            Csillag masik = new Csillag();

            object valami = new Csillag();

            List<Egitest> univerzum = new List<Egitest>();

            univerzum.Add(ujcsillag);
            univerzum.Add(new Egitest());
            univerzum.Add(new Csillag());


        }
    }
}