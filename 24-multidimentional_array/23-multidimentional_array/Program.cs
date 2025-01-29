using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bmw = {"M1","M2","M3","m4"};
            string[] ford = {"Mustang","Shelby","Fusion","F-150"};
            string[] toyota = { "GTR", "GTR-35", "Supra" };

            string[,] parkingLot = { { "M1", "M2", "M3", "m4" }, 
                                     {"Mustang","Shelby","Fusion","F-150"},
                                     { "GTR", "GTR-35", "Supra","Fortuner"}
                                    };

            //this foreach loop display in single line
            //foreach(string car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            //parkingLot.GetLength(0); = for row and 
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                //parkingLot.GetLength(1); = for column and 
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j]+ " \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}