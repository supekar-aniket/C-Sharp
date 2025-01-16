using System;

namespace FirstProgram {

    class Program {

        static void Main(String[] __) {

            /*
            Constant : 
                - immutable value.
                - which are known at compile time and do not change for the life of the program.
            */

            const double pi = 3.14;
            Console.WriteLine("Value if PI is : " + pi);

            /*
            Typecasting :
                    - Convert one value into another datatype.
                    - It is usefull when we accept user input (Strings) different datatypes.
            */

            float x = 3.14f;

            int a = Convert.ToInt32(x);
            Console.WriteLine("Value of a is:"+ a);

            // When we want to find which datatype it is then use GetTyoe();

            Console.WriteLine(a.GetType());

            int str1 = 1111;
            string str2 = Convert.ToString(str1);
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());

            string str3 = "#";
            char ch = Convert.ToChar(str3);
            Console.WriteLine(str3.GetType());
            Console.WriteLine(ch.GetType());

            string str4 = "true";
            bool b1 = Convert.ToBoolean(str4);
            Console.WriteLine(str4.GetType());
            Console.WriteLine(b1.GetType());

        }
    }
}