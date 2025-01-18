using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string you;
            string computer;
            string choice;
            bool playAgain = true;

            while(playAgain) {

                you = "";
                computer = "";
                choice = "";

                while(you != "ROCK" && you != "PAPER" && you != "SCISSORS") {
                    
                    System.Console.WriteLine("Enter ROCK, PAPER or SCISSORS:");
                    you = Console.ReadLine();
                    you = you.ToUpper();
                }
                    switch(random.Next(1,4)) {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                    }

                    System.Console.WriteLine($"Computer Choice:{computer}");
                    System.Console.WriteLine($"Your choice:{you}");

                    switch (you) {
                        case "ROCK":
                            if (computer == "ROCK") {
                                System.Console.WriteLine("Its a Draw!");
                            }else if(computer == "PAPER"){
                                System.Console.WriteLine("You lose!");
                            }else{
                                System.Console.WriteLine("You Win!!!");
                            }
                            break;
                        case "PAPER":
                            if (computer == "ROCK") {
                                System.Console.WriteLine("You Win!!!");
                            }else if(computer == "PAPER"){
                                System.Console.WriteLine("Its a Draw!");
                            }else{
                                System.Console.WriteLine("You lose!");
                            }
                            break;
                        case "SCISSORS":
                            if (computer == "ROCK") {
                                System.Console.WriteLine("You lose!");
                            }else if(computer == "PAPER"){
                                System.Console.WriteLine("You Win!!!");
                            }else{
                                System.Console.WriteLine("Its a Draw!");
                            }
                            break;
                    }

                    System.Console.WriteLine("Would you like to play again (Y/N):");
                    choice = Console.ReadLine();
                    choice = choice.ToUpper();

                    if (choice == "Y")
                    {
                        playAgain = true;
                    } else {
                        playAgain = false;
                    }
            }

            System.Console.WriteLine("Thanks for playing!!!");
        }
    }
}