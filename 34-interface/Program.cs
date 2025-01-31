using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Interface :
                - Use the interface keyword.
                - A class or struct uses the : symbol to implement an interface.
                - A class can implement multiple interfaces.
                - Interfaces cannot contain fields,constructor or method bodies.
                - Default implementation (since C# 8.0) is allowed with default keyword.
                - romotes code reusability and flexibility.
                - Supports multiple inheritance.
                - Improves testability and abstraction.

             */

            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.RaceStart();
            car.RaceStop();

            bicycle.RaceStart();
            bicycle.RaceStop();

            Console.ReadKey();
        }
    }

    interface Vehicle
    {
        void RaceStart();

        void RaceStop();
    }

    class Car : Vehicle
    {
        public void  RaceStart()
        {
            Console.WriteLine("Car Start!!!");
        }

        public void RaceStop()
        {
            Console.WriteLine("Car Stop!!!");
        }
    }

    class Bicycle : Vehicle
    {
        public void RaceStart()
        {
            Console.WriteLine("Bicycle Start!!!");
        }

        public void RaceStop()
        {
            Console.WriteLine("Bicycle Stop!!!");
        }
    }
}