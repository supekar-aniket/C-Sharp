using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             static keyword :
                - is used to declare members.
                - Used with fields, methods,class,constructor
                
                    1) static class :
                        - A class declared as static can only contain static members.
                        - Cannot be instantiated or inherited.
                        - Ex :
                            static class Utilities
                            {
                                public static void PrintMessage(string message)
                                {
                                    Console.WriteLine(message);
                                }
                            }


                    2) static constructor :
                        - nitializes static members of a class.
                        - Automatically called once, before the class is accessed for the first time.
                        - Ex :
                            class Example
                            {
                                static Example()
                                {
                                    Console.WriteLine("Static Constructor Called");
                                }
                            }
                    
                    3) static method :
                        - It belongs to the class itself rather than any instance of the class.
                        - Static methods cannot be overridden because they are not tied to an instance.
                        - Static methods can be called directly using the class name.
                            
             */

            Car car1 = new Car("Mustang");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Supra");
            Car car4 = new Car("Nisan GTR");

            Console.WriteLine($"Total Number of cars:{Car.carCount}");
            Car.RaceStart();

            Console.WriteLine("Welcome to MathUtilities!");

            // Call static methods from the static class
            double radius = 5.0;
            Console.WriteLine($"Area of circle with radius {radius}: {MathUtilities.CalculateCircleArea(radius)}");

            Console.ReadKey();
        }

        class Car
        {
            string model;
            public static int carCount; // static field

            public Car(string model)
            {
                this.model = model;
                carCount++;
            }

            public static void RaceStart() // static method
            {
                Console.WriteLine("Race is Begun!!!");
            }
        }

        // static class
        static class MathUtilities
        {
            // Static field
            private static double _pi;

            // Static constructor
            static MathUtilities()
            {
                _pi = 3.14159; // Initialize static data
                Console.WriteLine("Static Constructor Called: Pi initialized.");
            }

            // Static method for calculating the area of a circle
            public static double CalculateCircleArea(double radius)
            {
                return _pi * radius * radius;
            }

        }
    }
}