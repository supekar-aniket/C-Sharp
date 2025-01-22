using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            method :
                - it is a bunch of code, that run when it called.
                - it is a reuseable code
            */

            methodWithoutArgument();

            string name = "Agastya";
            // method with argument
            happyBirthday(name);
        }

        static void methodWithoutArgument(){
            // Code
            System.Console.WriteLine("Hello");
        }

        static void happyBirthday(string birthdayBoy){
            System.Console.WriteLine("Happy Birthday to you!");
            System.Console.WriteLine("Happy Birthday to you!");
            System.Console.WriteLine($"Happy Birthday dear {birthdayBoy}");
            System.Console.WriteLine("Happy Birthday to you!");
        }
    }
}