using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class More_Files
    {
        public static void Read()
        {
            
            var fs = new FileStream("..\\dane.txt", FileMode.Create);

            // Dane do pliku

            byte[] buffer = new byte[128];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (byte)i;


            try
            {
                fs.Write(buffer);
            }
            catch(Exception ex)
            { 
            Console.WriteLine(ex.Message);
            }
            fs.Close();

            var fsr = new FileStream("..\\dane.txt", FileMode.Open);

            try
            {
                fsr.Read(buffer);
                fsr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, buffer[i]);
            }

            // Pauza
            Console.ReadKey();

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("..\\plik.txt");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Wprowadzaj wiersze tekstu do zapisu");
            Console.WriteLine("Aby zakończyć wpisz koniec");
            string linia;
            try
            {
                do
                {
                    linia = Console.ReadLine();
                    sw.WriteLine(linia);
                } while (linia != "koniec");
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("..\\plik.txt");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            string zawartosc = sr.ReadToEnd();
                Console.WriteLine(zawartosc);

            
            
            sr.Close();


        }
    }
}
