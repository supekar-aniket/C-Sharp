using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname = "Aniket Supekar";
            // fullname = fullname.ToUpper();   // convert string into UPPER case
            // fullname = fullname.ToLower();   // Convert string into lower case

            System.Console.WriteLine(fullname);

            string birthdate = "26/12/2002";
            birthdate = birthdate.Replace("/","-"); // "/" repalce by "-"

            System.Console.WriteLine(birthdate);

            string firstName = fullname.Substring(0,6); // Substring method cut the string in prticular partcd..
            string lastName = fullname.Substring(7,7);

            System.Console.WriteLine(firstName);
            System.Console.WriteLine(lastName);
        }
    }
}