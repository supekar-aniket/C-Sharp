using System;

namespace Loops {

    class Nested {

        public static void nestedLoop() {

            /*
            Nested Loop : Loops inside of other loops.
            */

            /*
            System.Console.WriteLine("How many rows you want :");
            int rows = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("How many columns you want :");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write($"Enter value for element [{i+1}, {j+1}]:");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            System.Console.WriteLine("The 2D Array is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(array[i,j]+ " ");
                }
                System.Console.WriteLine();
            }
            */

            System.Console.WriteLine("How many rows you want:");
            int rows = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("How many columns you want:");
            int cols = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the Symbol you want:");
            string symbol = Console.ReadLine();

            System.Console.WriteLine("The pattern is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(symbol+ " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}