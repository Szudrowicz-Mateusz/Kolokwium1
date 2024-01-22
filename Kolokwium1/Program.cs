using System;

namespace Kolokwium
{
    public struct Person
    {
        // Nie musisz używać słowa kluczowego ,,this" jeżeli parametry kontrukotra mają inną nazwe
        
        // Pamiętaj o dodawaniu public, ponieważ domyślnie jest private i nie bedziesz mogła z tych rzeczy korzystać
        public Person(string Pesel,  string FirstName, string LastName, int wiek)
        {
            this.Pesel = Pesel;
            this.Name = FirstName;
            //this.Nazwisko=LastName;
            Nazwisko = LastName;
            this.wiek = wiek;
        }

        public readonly string Pesel;
        public string Name;
        public string Nazwisko;
        public int wiek;
    }
    internal class Program
    {

        public static int ReferenceFunction(ref int liczba)
        {
            return ++liczba;
        }
        public static int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
        public static void Array2D()
        {
            int[,] arr2d = new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr2d[i,j]);
                }
            }
        }
        static void Main(string[] args)
        {
            // 2D arry
            Array2D();

            // Random number
            for (int i = 0;i < 10; i++)
                Console.WriteLine(RandomNumber());

            // Struktura i tworzenie z niej zmiennej
            var juleczka = new Person("123456789", "Julia", "Plotkowiak", 20);

            // Przekazywanie do funkcji przez referencje
            int liczba = 0;
            ReferenceFunction(ref liczba);
            Console.WriteLine($"Ta liczba została podniesioan od jeden przez referencje {liczba}");

            Console.WriteLine("Podaj cos");
            string s = Console.ReadLine();

            try
            {
                int nr = Int32.Parse(s);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Blok try-catch sie zakonczyl. Ten komentarz zostanie wyswietlony niezaleznie od rezultatu bloku try ");
            }


        }
    }
}