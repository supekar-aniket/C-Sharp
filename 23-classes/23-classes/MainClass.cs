using System;
using _23_classes;

namespace MyApp
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            /*
             classes :
                    - is a bundel of related code.
                    - is a blueprint for creating the objects.
                    - It defines the properties (data) and methods (functions) that an object can have.
                    - Classes are the building blocks of object-oriented programming
             */

            ////this is public inner class

            //InnerClass innerClass = new InnerClass();
            //innerClass.Hello();
            //innerClass.Greeting();
            //innerClass.Bye();

            //// this is for static inner class

            //InnerClass.Hello();
            //InnerClass.Greeting();
            //InnerClass.Bye();

            //// this is for public outer class

            //PublicClass publicClass = new PublicClass();
            //publicClass.Hello();
            //publicClass.Greeting();
            //publicClass.Bye();

            // this is for static outer class

            StaticClass.Hello();
            StaticClass.Greeting();
            StaticClass.Bye();

            Console.ReadKey();
        }

        //// this is public inner class
        
        //class InnerClass
        //{
        //    public void Hello()
        //    {
        //        Console.WriteLine("This is Hello method!!!");
        //    }

        //    public void Greeting()
        //    {
        //        Console.WriteLine("This is Greeting method!!!");
        //    }

        //    public void Bye()
        //    {
        //        Console.WriteLine("This is Bye method!!!");
        //    }
        //}


        //// this is a static inner class
        
        //static class InnerClass
        //{
        //    public static void Hello()
        //    {
        //        Console.WriteLine("This is Hello method!!!");
        //    }

        //    public static void Greeting()
        //    {
        //        Console.WriteLine("This is Greeting method!!!");
        //    }

        //    public static void Bye()
        //    {
        //        Console.WriteLine("This is Bye method!!!");
        //    }
        //}
    }
}