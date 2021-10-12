using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace ConsoleApp2
{
    class Program
    {
        private static object lockObject = new object();

        private static int[] memF = new int[100];

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Thread thread = new Thread(new ThreadStart(Fib));
        }

        private static int Fib(int n)
        {
            lock (lockObject)
                {
                    if (n <= 1) return n;

                    if (memF[n] != 0) return memF[n];

                    memF[n] = Fib(n - 2) + Fib(n - 1);
                    return memF[n];

                }
            {
                Console.WriteLine(n);

                Thread.Sleep(1000);
            }
        }

        List<int> list =
    Enumerable.Range(0, 50)
              .AsParallel()
              .AsOrdered()    
              .Select(Compute)
              .ToList();
        int Compute(int i)
        {
            return i;
            Console.WriteLine();
        }

    }



    
}
