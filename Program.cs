using System;
using System.Threading;

namespace Multithreading_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A thread is the execution path of a program
            // - We can use multiple threads to perform different tasks at the same time
            // - Current thread running is "Main" thread
            // - requires using System.Threading

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            // if method doesn't have params, you can call threads to run methods like this
            /* Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp); */

            // if method has params, use lambda function (aka anonymous function)
            Thread thread1 = new Thread(() => CountDown("Timer 1"));
            Thread thread2 = new Thread(() => CountUp("Timer 2"));

            thread1.Start();
            thread2.Start();


            Console.WriteLine(mainThread.Name + " is complete!");
            Console.ReadKey();
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine( name + ": " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 Complete!");
        }
        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name + ": " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 Complete!");
        }
    }
}
