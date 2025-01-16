using System;

namespace Loops {

    class For {

        public static void forLoop() {

            // for loop : repeate some code a specific of times.

            System.Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                System.Console.WriteLine("Namaskar - " + i);
            }
        }
    }
}