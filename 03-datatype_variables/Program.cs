using System;

namespace FirstProgram {

    class Program {

        static void Main(String[] __) {
            
            int x;  // initialization
            x = 123; // declaration
            Console.WriteLine("Value of x : " + x);

            int y = 321; // initialization + declaration
            Console.WriteLine("Value of y : " + y);

            int age = 22;
            Console.WriteLine("My age is : " + age);

            char symbol = '#';
            Console.WriteLine("Symbole is : " + symbol);

            float height = 5.7f; // f is required for floating numbers
            Console.WriteLine("My Height is : " + height);

            double fixValue = 3.14; // 
            Console.WriteLine("Value of PI : " + fixValue);

            bool isAlive = true;
            Console.WriteLine("Are you Alive ? : " + isAlive);

            string str = "This is a String...";
            Console.WriteLine(str);
        }
    }
}