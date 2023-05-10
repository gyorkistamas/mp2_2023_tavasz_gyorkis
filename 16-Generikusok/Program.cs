namespace _16_Generikusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rangsor<Futo> futoRangsor = new Rangsor<Futo>();

            Futo f1 = new Futo("Valami név", new TimeSpan(0, 5, 12));

            Futo f2 = new Futo("Név 2", new TimeSpan(0, 7, 8));

            futoRangsor.Add(f1);
            futoRangsor.Add(f2);

            foreach (Futo futo in futoRangsor)
            {
                Console.WriteLine("{0} - {1}", futo.Nev, futo.KorIdo);
            }


            Rangsor<Fekvenyomo> fekvenyomoRangsor = new Rangsor<Fekvenyomo>();


            Fekvenyomo valaki;
            try
            {
                new Fekvenyomo("Nev", 4534);
            }
            
            catch (TomegInvalidValueException e)
            {
                Console.WriteLine("Hiba a létrehozáskor: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ertek);
            }
            catch(OverflowException e)
            {
                //....
            }
            catch (Exception e)
            {

            }





            StreamReader sr = null;
            try
            {
                sr = new StreamReader("fajlnev.txt");
                while(!sr.EndOfStream)
                {
                    try
                    {
                        string[] adatok = sr.ReadLine().Split(';');

                        Fekvenyomo uj =
                            new Fekvenyomo(adatok[0],
                                         int.Parse(adatok[1]));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Hiba a beolvasás során: {0}");
                    }

                    //Eltárolás

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Hiba történt a fájl olvasása közben: {0}", e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }


            Console.ReadKey();
        }
    }
}