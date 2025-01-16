using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if-statement : a basic form of decision making

            /*
            System.Console.WriteLine("Whats your age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                System.Console.WriteLine("You can Drive...");
            } else
            {
                System.Console.WriteLine("You cannot Vote...");
            }
            */

            System.Console.WriteLine("Enter your name :");
            string name = Convert.ToString(Console.ReadLine());

            if (name != "")
            {
                System.Console.WriteLine("YOur name is " + name);
            } else
            {
                System.Console.WriteLine("You did not enter your name...");
            }
        }
    }
}