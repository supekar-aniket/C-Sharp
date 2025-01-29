using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             constructor : 
                - is a special method in a class
                - it is a same method as the class
                - can be used to assign arguments to field when creating an object
             */

            Car car = new Car("BMW","M5 Compitition",2024,"Mat Black");

            car.Drive();

            Console.ReadKey();
        }

        class Car
        {
            string company;
            string model;
            int year;
            string color;

            public Car(string company,string model,int year,string color)
            {
                this.company = company;
                this.model = model;
                this.year = year;
                this.color = color;
            }

            public void Drive()
            {
                Console.WriteLine($"You are so lucky because you drive {company} {model} which build in {year} and color is {color}!!!");
            }
        }
    }
}