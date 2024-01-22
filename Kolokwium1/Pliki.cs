using System;
using System.IO;

namespace Kolokwium1
{
    class Pliki
    {
        public static void Files()
        {
            var dir = new DirectoryInfo(".");

            DirectoryInfo[] katalogi = dir.GetDirectories();
            FileInfo[] pliki = dir.GetFiles();

            Console.WriteLine("Podkatalogi");
            foreach (DirectoryInfo katalog in katalogi)
            {
                Console.WriteLine(katalog.Name);
            }
            Console.WriteLine("Pliki");
            foreach (FileInfo plik in pliki)
            {
                Console.WriteLine(plik.Name);
            }

            // Tworzenie katalogów
            try
            {
                dir.Create();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tworzenie katalogu");
            }

            Console.ReadKey();

            try
            {
                dir.Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Usuwanie katalogu");
            }

            Console.ReadKey();

            FileInfo fi = null;
            try
            {
               fi = new FileInfo("./Program");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Tutaj");
            }

            
            FileStream fs;
            try
            {
                fs = fi.Create();
            }
            catch (Exception)
            {
                Console.WriteLine("FileStream");
                return;
            }
            // tutaj można wykonać operacje na pliku
            fs.Close();

            Console.WriteLine("Atrybuty: {0}", fi.Attributes);
            Console.WriteLine("Katalof: {0}", fi.Directory);
            Console.WriteLine("Rozszerzenie: {0}", fi.Extension);
            Console.WriteLine("Ścieżka: {0}", fi.FullName);
            Console.WriteLine("Długość: {0}", fi.Length);
            Console.WriteLine("Data utworzenia: {0}", fi.CreationTime);
            Console.WriteLine("Data ostatniej modyfikacji: {0}", fi.LastWriteTime);
            Console.WriteLine("Data ostatniego dostępu: {0}", fi.LastAccessTime);



            Console.ReadKey();

        }
    }
}
