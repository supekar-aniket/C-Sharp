using System;
using System.Runtime.Intrinsics.Arm;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case : is an efficient alternative to many else if statements

            System.Console.WriteLine("What day it is Today ?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    System.Console.WriteLine("Today is Monday...");
                    break;
                case "Tuesday":
                    System.Console.WriteLine("Today is Tuesday...");
                    break;
                case "Wednesday":
                    System.Console.WriteLine("Today is Wednesday...");
                    break;
                case "Thurday":
                    System.Console.WriteLine("Today is Thurday...");
                    break;
                case "Friday":
                    System.Console.WriteLine("Today is Friday...");
                    break;
                case "Saterday":
                    System.Console.WriteLine("Today is Saterday...");
                    break;
                case "Sunday":
                    System.Console.WriteLine("Today is Sunday...");
                    break;
                default : 
                    System.Console.WriteLine(day + " is not a day...");
                    break;
            }
        }
    }
}