using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            params keyword :
                    - allow to pass vaiable number of arguments to the method.
                    - it is use to specify a parameter that can accept zero or more arguments of a specific type.
                    - The arguments are treated as a Array within the method.

                    - you can pass comma seperated list of arguments or an array
                    - a method can only one params parameter.
                    
                    - it must be the lasyt parameter in the method.
            */

            double total = TotalPrice(10,20,30,40,50);

            System.Console.WriteLine($"Total price is:{total}");
        }

        static double TotalPrice(params double[] x){
            double total=0;
            foreach (double price in x)
            {
                // total = total + price;
                total += price;
            }
            return total;
        }
    }
}