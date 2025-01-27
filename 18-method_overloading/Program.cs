using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             method overloading : 
                    - Multiple methods with the same name but different parameters(type, number, or order)..
                    - Improves code readability and flexibility.
                    - all methods in same class
            */

            double num1 = 10;
            double num2 = 20;
            double num3 = 30;
            double num4 = 40;

            double result1 = Addition(num1,num2);
            double result2 = Addition(num1,num2,num3);
             double result3 = Addition(num1,num2,num3,num4);

            System.Console.WriteLine($"Result 1:{result1}");
            System.Console.WriteLine($"Result 2:{result2}");
            System.Console.WriteLine($"Result 3:{result3}");

        }

        static double Addition(double x,double y) {
            return x + y;
        }

        static double Addition(double v,double x,double y) {
            return v + x + y;
        }

        static double Addition(double v,double x,double y,double z) {
            return v + x + y + z;
        }
    }
}