using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car("Mustang","Blue");

            // before update color
            Console.WriteLine($"Your car model is {car1.model} and color is {car1.color}!!!");

            ChangeColor(car1,"Red");

            // after upadate color
            Console.WriteLine($"Your car model is {car1.model} and color is {car1.color}!!!");
           
            Car car2 = CopyCar(car1);
            
            Console.WriteLine($"Your car model is {car2.model} and color is {car2.color}!!!");

            Console.ReadKey();
        }

        static void ChangeColor(Car car,string color)
        {
            car.color = color;
            Console.WriteLine("Update Color!!!");
        }

        static Car CopyCar(Car car)
        {
            return new Car(car.model,car.color);
        }
    }

    class Car
    {
        public string model;
        public string color;

        public Car(string model,string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}