using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * enums :
             *  - is a special class that contains set of named constant values.
             *  - use enum when you have values that will not change.
             *  - to get the integer value from the item, you must explicitly convert to an int
             *  
             */

            DayOfWeek day = DayOfWeek.Monday;

            Console.WriteLine(day);

            TrafficLight signal = TrafficLight.Green;

            if (signal == TrafficLight.Red)
            {
                Console.WriteLine("\nStop!!!");
            } else if (signal == TrafficLight.Yellow)
            {
                Console.WriteLine("\nGet Ready!!!");
            } else
            {
                Console.WriteLine("\nGo!!!");
            }


            Console.ReadKey();
        }
    }

    enum DayOfWeek 
    {
        Sunday,    // 0
        Monday,    // 1
        Tuesday,   // 2
        Wednesday, // 3
        Thursday,  // 4
        Friday,    // 5
        Saturday   // 6
    }

    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }
}