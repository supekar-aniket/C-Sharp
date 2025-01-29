using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string interpolation :
                        - allows us to insert variables into a string literal
                        - string literal with 
                        - and {} with values
                        - Ex :
                            string name = "Alice";
                            int age = 25;
                            string message = $"Name: {name}, Age: {age}";
             */

            string firstName = "Agastya";
            string lastName = "Supekar";
            int age = 22;

            Console.WriteLine("Hello " + firstName + " " + lastName + " you are " + age + "years old");

            Console.ReadKey();
        }

    }
}