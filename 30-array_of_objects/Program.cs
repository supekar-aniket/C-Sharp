using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car[] garrage = new Car[3];

            //Car car1 = new Car("Mustang");
            //Car car2 = new Car("BMW");
            //Car car3 = new Car("Totota");

            //garrage[0] = car1;
            //garrage[1] = car2;
            //garrage[2] = car3;

            ////Console.WriteLine(garrage[0].model);
            ////Console.WriteLine(garrage[1].model);
            ////Console.WriteLine(garrage[2].model);

            //// insted of cw we use foreach loop
            //foreach(Car car in garrage)
            //{
            //    Console.WriteLine(car.model);
            //}

            // Insted of all above we pass the array as object

            Car[] garrage = { new Car("Mustang"), new Car("BMW"), new Car("Totota")};

            foreach (Car car in garrage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}