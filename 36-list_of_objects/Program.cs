using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             List of objects :
                - you can create a list of objects to store and work with custom data types or instances of a class.
                -  This is particularly useful when dealing with more complex data.
             */

            List<Car> cars = new List<Car>();

            //Car car1 = new Car("BMW");
            //Car car2 = new Car("Toyota");
            //Car car3 = new Car("Nisan");

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);

            cars.Add(new Car("BMW"));
            cars.Add(new Car("Toyota"));
            cars.Add(new Car("Nisan"));

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public string name;

        public Car(string name) 
        { 
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}