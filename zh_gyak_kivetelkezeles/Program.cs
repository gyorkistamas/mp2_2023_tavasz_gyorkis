namespace zh_gyak_kivetelkezeles
{
    internal class Program
    {

        public static void Beolvas(string file)
        {
            //StreamReader sr = new StreamReader(file);

            //while (!sr.EndOfStream)
            //{
            //    //Csinálok valamit
            //}

            //sr.Close();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(file);
                // Csinálok valamit....
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }

        }

        static void Main(string[] args)
        {
            Gepkocsi kocsi1;

            try
            {
                kocsi1 = new Gepkocsi("", 2002, 300000, Allapot.Ujszeru);
            }
            
            catch (InvalidCharacterException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A hibás karakter: {0}", e.InvalidCharater);
            }
            catch(RendszamIsNullOrEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Váratlan hiba következett be: {0}", e.Message);
            }
            finally
            {

            }



            Console.ReadLine();
        }
    }
}