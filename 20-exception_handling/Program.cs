using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exception :
                    - errors that occur during the execution.

            Exception Handling :
                    - it is a mechanism that manage the runtime errors, and ensuring that program can handle them gracefully without crashing.

                try     : try some code that consider as dangerous.
                catch   : catch and handle the exception when error occurs.
                finally : always execute,error occurs or not.  
            */

            double x;
            double y;
            double result;

            try {
                System.Console.WriteLine("Enter the first value:");
                x = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Enter the second value:");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                System.Console.WriteLine($"Your result is:{result}");
                
            } catch(FormatException e) {
                System.Console.WriteLine("Plzz enter onlu Numbers!!!");
            } catch (DivideByZeroException e) {
                // This exception ocurrs only when datatype of values is "int",otherwise result is infinity.
                System.Console.WriteLine("You cannot divided by ZERO!!!");
            } catch(Exception e) {
                System.Console.WriteLine("Something is wrong!!!");
            } finally {
                System.Console.WriteLine("Thank you for Visiting !!!");
            }
        }
    }
}