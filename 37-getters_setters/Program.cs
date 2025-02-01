using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             getters and setters :
                - add security to fields by encapsulation.
                - get accessors : used to return property value
                - set accessors : used to assign a new value
                - value keyword : define the value begin assined by the set (parameter)
             */

            Person person = new Person();
            person.Name = "Agsatya";

            person.Age = 22;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }

    class Person
    {
        private int age;
        private string name; // Private field

        //public string Age     // Public property
        //{
        //    get { return Age; }
        //    set { Age = value; }

        //}

        public int Age { get; set; }  // Public property

        //public string Name   // Public property
        //{
        //    get { return name; }  // Getter
        //    set { name = value; } // Setter
        //}

        public string Name { get; set; }  // Public property

    }

}