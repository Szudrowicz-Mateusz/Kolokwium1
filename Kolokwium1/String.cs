using System;

namespace String
{
    class Sth
    {
        public static void noMain()
        {
            string firstname;
            string lastname;

            firstname = "Steven Clark";
            lastname = "Clark";

            //Compare two string value and returns 0 for true and
            //1 for false      
            Console.WriteLine(firstname.CompareTo(lastname));

            //Check whether specified value exists or not in string
            Console.WriteLine(firstname.Contains("ven"));

            //Check whether specified value is the last character of string
            Console.WriteLine(firstname.EndsWith("n"));

            //Compare two string and returns true and false
            Console.WriteLine(firstname.Equals(lastname));

            //Returns type of string
            Console.WriteLine(firstname.GetType());

            //Returns the first index position of specified value
            //the first index position of specified value
            Console.WriteLine(firstname.IndexOf("e"));

            //Covert string into lower case
            Console.WriteLine(firstname.ToLower());

            //Convert string into Upper case
            Console.WriteLine(firstname.ToUpper());

            //Insert substring into string
            Console.WriteLine(firstname.Insert(0, "Hello"));

            //Returns the last index position of specified value
            Console.WriteLine(firstname.LastIndexOf("e"));

            //Returns the Length of String
            Console.WriteLine(firstname.Length);

            //Deletes all the characters from begining to specified index.
            Console.WriteLine(firstname.Remove(5));

            // Replace the character
            Console.WriteLine(firstname.Replace('e', 'i'));

            //Split the string based on specified value
            string[] split = firstname.Split(new char[] { 'e' }); 

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            //Check wheter first character of string is same as specified value
            Console.WriteLine(firstname.StartsWith("S"));

            //Returns substring
            Console.WriteLine(firstname.Substring(2, 5));

            //It removes starting and ending white spaces from
            //string.
            Console.WriteLine(firstname.Trim());

            Console.ReadKey();
        }
    }
}
