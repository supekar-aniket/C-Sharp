using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Polymorphism :
                - It means "many forms" and allows objects to be treated in different ways
                - Write general code that works for different types.
                - Add new behavior by extending classes without changing existing code.
                - Easier to manage and update code.

                # Types of Polymorphism :

                    1) Compile-Time Polymorphism (Static Binding):
                        - Achieved using method overloading and operator overloading.
                        - The method to call is determined at compile time.

                    2) Run-Time Polymorphism (Dynamic Binding):
                        - Achieved using method overriding with inheritance.
                        - The method to call is determined at runtime based on the actual object.

                # Key Concepts :
                    1) Method Overloading: Same method name, different parameter list.
                    2) Method Overriding: Redefining a method in a derived class using inheritance.
                    
             */

            //// Compile-Time Polymorphism
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(5, 3));        // Output: 8
            //Console.WriteLine(calc.Add(5.5, 3.3));   // Output: 8.8

            //// Run-Time Polymorphism
            //Animal myAnimal = new Dog();
            //myAnimal.Speak();   // Output: Dog barks

            //myAnimal = new Cat();
            //myAnimal.Speak();   // Output: Cat meows

            // ----------------
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car,bicycle,boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    //class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public double Add(double a, double b)
    //    {
    //        return a + b;
    //    }
    //}

    //class Animal
    //{
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("Animal makes a sound");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Dog barks");
    //    }
    //}

    //class Cat : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Cat meows");
    //    }
    //}

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving!!!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving!!!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving!!!");
        }
    }
    
}