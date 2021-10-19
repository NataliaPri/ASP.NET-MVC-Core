using System;
using System.Threading;

public class Example
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(ThreadProc);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);

            Console.WriteLine("Main thread exits.");
        }

        static void ThreadProc(Object stateInfo)
        {
            Console.WriteLine("Hello from the thread pool.");
        }
    }
    //       Main thread does some work, then sleeps.
    //       Hello from the thread pool.
    //       Main thread exits.
