using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                System.Console.WriteLine("---------------------");
                System.Console.WriteLine("! Simple Calculator !");
                System.Console.WriteLine("---------------------");

                System.Console.Write("Enter number 1:");
                num1 = Convert.ToDouble(Console.ReadLine());

                System.Console.Write("Enter number 2:");
                num2 = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Your option is:");
                System.Console.WriteLine("\t + : Add");
                System.Console.WriteLine("\t - : Subtract");
                System.Console.WriteLine("\t * : Multiply");
                System.Console.WriteLine("\t / : Divide");
                System.Console.Write("Enter an option:");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        System.Console.WriteLine($"Your result:{num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        System.Console.WriteLine($"Your result:{num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        System.Console.WriteLine($"Your result:{num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        System.Console.WriteLine($"Your result:{num1} / {num2} = {result}");
                        break;
                    default:
                        System.Console.WriteLine("This was not a valid option!!!");
                        break;
                }

                System.Console.WriteLine("You want to continue! (Y/N):");

            } while (Console.ReadLine().ToUpper() == "Y");

            System.Console.WriteLine("!!! Thank You !!!");
        }
    }
}