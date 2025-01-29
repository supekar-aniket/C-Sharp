using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             objects :
                    - is an instance of a class
                    - A class can use as a blueprint to create a objects (OOP)
                    - objects can have fields and methods
             */

            Human human1 = new Human();
            human1.name = "Agastya";

            human1.Eat();
            human1.Sleep();

            Human human2 = new Human();
            human2.name = "Arpita";

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }

        class Human
        {
            public string name;

            public void Eat()
            {
                Console.WriteLine($"{name} is eating!!!");
            }

            public void Sleep()
            {
                Console.WriteLine($"{name} is Sleeping!!!");
            }
        }
    }
}