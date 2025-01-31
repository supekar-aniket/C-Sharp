using System;
using System.Xml.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             toString method :
                - a method that converts an object into a text (string) form.
                - By default, if you don't customize it, calling ToString() will usually just tell you the object's type (like Namespace.ClassName).
                - Ex : 
                    object obj = new object();
                    Console.WriteLine(obj.ToString());  // Output: System.Object
                
                Why we use ?
                    - To show meaningful information about objects.
                    - To make debugging and logging easier.
                    - To display object information in a readable way (e.g., in the Console or UI).
             */

            //Person car = new Person("BMW", "M5 Competition", "Mat Black");
            //Console.WriteLine(car.ToString());


            Person person = new Person { name = "John", age = 30 };
            Console.WriteLine(person.ToString());

            Console.ReadKey();
        }

        class Person
        {
            //public string company;
            //public string model;
            //public string color;

            //public Person(string company,string model,string color)
            //{
            //    this.company = company;
            //    this.model = model; 
            //    this.color = color;
            //}

            //public override string ToString()
            //{
            //    return $"I have a {company} {model} which color is {color}!!!";
            //}

            public string name { get; set; }
            public int age { get; set; }

            // Without override toString method it returns "System.Object"
            public override string ToString()
            {
                return $"My name is {name} and i am {age} years old!!!";
            }
        }
    }
}