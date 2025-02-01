using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             List : 
                - Lists are part of System.Collections.Generic.
                - They are type-safe, meaning you specify the data type at the time of declaration.
                - its similar to array but Lists dynamically resize as you add or remove elements.
                - Use Count to get the current size of the list.
                - Lists provide many methods for manipulation, such as adding, removing, searching, and sorting.
                
                - To use a list, you need to include the System.Collections.Generic namespace:
             */

            List<string> foodList = new List<string>();
            foodList.Add("Pizzaa");
            foodList.Add("Burger");
            foodList.Add("Hotdog");
            foodList.Add("fries");

            Console.WriteLine("Food List:\n");
            foreach (string food in foodList)
            {
                Console.WriteLine(food);
            }

            //// remove "fries" form the list
            //foodList.Remove("fries");

            //// insert "Tea" at 0 index
            //foodList.Insert(0, "Tea");

            //// Sorts the list in ascending order
            //foodList.Sort();

            //// Reverses the order of the list
            //foodList.Reverse();

            //// Removes the element at index 0
            //foodList.RemoveAt(0);  

            //// Removes all elements from the list
            //foodList.Clear();

            //Console.WriteLine("\nFood list after perform operation:\n");
            //foreach (string food in foodList)
            //{
            //    Console.WriteLine(food);
            //}

            //// count all items
            //Console.WriteLine("Total number of food List:" + foodList.Count);

            Console.WriteLine("Convert list into array");
            string[] foodArray = foodList.ToArray();

            foreach (string food in foodArray)
            {
                Console.WriteLine(food);
            }

            Console.ReadKey();
        }
    }
}