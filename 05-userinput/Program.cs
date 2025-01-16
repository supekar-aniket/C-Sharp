using System;

namespace FirstProgram {

    class Program {

        static void Main(String[] args) {

            Console.WriteLine("Whats Your Name ?");
            string name = Console.ReadLine();   // used for accept user input

            Console.WriteLine("Whats your age ?");
            int age = Convert.ToInt32(Console.ReadLine());  // convert input into integer 

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}