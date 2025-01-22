using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            return : return data back to the place where method called.

            */

            System.Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            
            System.Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = multiply(a,b);

            System.Console.WriteLine($"Your Result is:{result}");

        }

        static double multiply(double x,double y){
            
            // double z = x * y;

            return x * y;
        }
    }
}