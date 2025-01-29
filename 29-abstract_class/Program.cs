using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.0); // Abstract class reference, object of derived class
            circle.DisplayShapeType();     // Calls concrete method
            Console.WriteLine($"Area: {circle.CalculateArea()}"); // Calls overridden method

            Console.ReadKey();
        }
    }

    abstract class Shape
    {
        // Abstract method to calculate area
        public abstract double CalculateArea();

        // Concrete method
        public void DisplayShapeType()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}