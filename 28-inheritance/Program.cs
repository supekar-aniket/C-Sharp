using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Inheritance :
                - It acquire the properties and behaviors of another class.
                - stablishes a parent-child relationship between classes.
                - allowing derived classes to inherit and reuse the code in the base class.
                - Allows the derived class to extend or modify the behavior of the base class.

                # Types of Inheritance in C#:
                        1) Single Inheritance: A class inherits from one base class.
                        Example: class B : A { }
                        2) Multilevel Inheritance: A class inherits from a class that is already derived from another class.
                        Example: class C : B { }
                        3) Hierarchical Inheritance: Multiple derived classes inherit from a single base class.
                        Example: class B : A { } and class C : A { }
                        4) Multiple Inheritance: Not supported directly in C#, but can be achieved through interfaces.

             */

            Dog myDog = new Dog();
            myDog.Eat();  // Method inherited from Animal
            myDog.Bark(); // Method from Dog

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eat food!!!");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("This dog Bark!!!");
        }
    }
}