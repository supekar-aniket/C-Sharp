using System;

namespace Loops {
    class WhileLoop {

        public static void whileLoop() {

            // while loop : repeate some code while some condition remains true

            //simple code
            // /* 
            // System.Console.WriteLine("Enter your name :");
            // string name = System.Console.ReadLine();

            // while (name == "")
            // {
            //     System.Console.WriteLine("Enter your name :");
            //     name = System.Console.ReadLine();

            // }

            // System.Console.WriteLine("Hello " + name);

            // Advanced
            string name = "";

            while (name == "")
            {
                System.Console.WriteLine("Enter your name :");
                name = Console.ReadLine();
            }

            System.Console.WriteLine("Hello " + name);
            // */
        }
    }
}