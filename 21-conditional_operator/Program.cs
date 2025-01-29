using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            conditional operator :
                        - it is also knows as ternary operator.
                        - it is shorthand for if-else statement
                        - Ex :
                            (condition) ? trueResult : falseResult;

                            - condition: A boolean expression that is evaluated.
                            - trueResult: The value or expression returned if the condition is true.
                            - falseResult: The value or expression returned if the condition is false.
                
                Nested Conditional operator :
                    Ex :
                        int number = 0;
                        string result = (number > 0) ? "Positive" : (number < 0) ? "Negative" : "Zero";
                        Console.WriteLine(result); // Output: Zero

            */

            System.Console.WriteLine("Enter the number:");
            double num = Convert.ToDouble(Console.ReadLine());

            string message = "";

            /*
            if (num < 0)
            {
                message = $"{num} is negative!!!";
            } else if(num > 0) {
                message = $"{num} is positive!!!";
            } else {
                message = $"{num} is zero!!!";
            }

            System.Console.WriteLine(message);
            */
            
            message = (num > 0) ? $"{num} is positive!!!" : (num < 0) ? $"{num} is negative!!!" : $"{num} is zero!!!";

            System.Console.WriteLine(message);
        }
    }
}