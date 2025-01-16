using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            string response;
            int guess;
            int guesses;
            int number;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                
                number = random.Next(min,max+1);

                while (guess != number)
                {
                    System.Console.WriteLine($"Guess a number between {min}-{max}:");
                    guess = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine("Guess:" + guess);

                    if (guess > number)
                    {
                        System.Console.WriteLine($"{guess} is to high!");
                    } else if (guess < number)
                    {
                        System.Console.WriteLine($"{guess} is to low!");
                    }
                    guesses++;
                }
                System.Console.WriteLine($"Number:{number}");
                System.Console.WriteLine("!!! YOU WIN !!!");
                System.Console.WriteLine($"Guesses:{guesses}");

                System.Console.WriteLine("Would you like to play agian (Y/N):");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                } else {
                    playAgain = false;
                }
            }
        }
    }
}