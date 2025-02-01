using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3};
            double[] doubleArray = { 1.2, 2.3, 4.5 };
            string[] stringArray = { "Agstya","Anuja","Arpita"};

            //IntArray(intArray);
            //DoubleArray(doubleArray);
            //StringArray(stringArray);

            PrintAllValue(intArray);
            PrintAllValue(doubleArray);
            PrintAllValue(stringArray);

            Console.WriteLine("One more example");
            PrintData(100);
            PrintData("Agastya");
            PrintData(3.14);

            Console.ReadKey();
        }

        //static void IntArray(int[] intArray)
        //{
        //    foreach (int item in intArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void DoubleArray(double[] doubleArray)
        //{
        //    foreach (double item in doubleArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void StringArray(string[] stringArray)
        //{
        //    foreach (string item in stringArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        static void PrintAllValue<PrintAll>(PrintAll[] value)
        {
            foreach (PrintAll item in value)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
        }

        static void PrintData<PrintAll>(PrintAll data)
        {
            Console.WriteLine($"Data:{data}");
        }
    }
}