using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Arrays : a variable that can store multiple values of same datatype.
                    - arrays is a fixed size.
            */

            string[] cars = new string[3];
            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            // System.Console.WriteLine(cars[0]);
            // System.Console.WriteLine(cars[1]);
            // System.Console.WriteLine(cars[2]);

            // for(int i=0; i<cars.Length; i++) {
            //     System.Console.WriteLine(cars[i]);
            // }

            foreach (string c in cars)
            {
                System.Console.WriteLine(c);
            }
        }
    }
}