using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Threads :
             *          - thread is an execution path of program.
             *          - we can use multiple threads to perform.
             *          - different tasks of our program the same time.
             *          - current thread running is "main" thread
             *          - using system.Threading;
             */

            //Thread mainThread = Thread.CurrentThread;
            //mainThread.Name = "Main Thread";
            //Console.WriteLine("Current Thread name is:" + mainThread.Name);

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            //CountDown();
            //CountUp();
            //Console.WriteLine($"\n{mainThread.Name} is complete!!!");

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);

            thread1.Start();
            thread2.Start();

            Console.WriteLine($"\n{mainThread.Name} is complete!!!");

            Console.ReadKey();
        }

        static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nTimer #1 is complete!!!\n");
        }

        static void CountUp()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nTimer #2 is complete!!!");
        }
    }
}