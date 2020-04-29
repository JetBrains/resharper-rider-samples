using System;
using System.Collections.Generic;
using System.Threading;

namespace ParallelDebugging
{
    internal static class Program
    {
        // Change Run Configuration to "Parallel Debugging"
        // Set breakpoint on Console.WriteLine
        // Start debugging
        // When breakpoint is hit:
        // * Switch threads in drop down in Debug tool window
        // * See how execution point and `value` is updated when switching
        // * Switch from Frames pane to Threads pane - call stacks now grouped by Thread
        // * Switch to Parallel Stacks view. This shows a diagram of common call stacks per thread
        //   E.g. 10 threads up to `DoWork`, then will split off, some threads in `DoWorkEven`, some in `DoWorkOdd`
        //   Then more in `DoWorkFinal`. Hover over number of number of threads to see which threads
        private static void DoWorkFinal(int value)
        {
            var message = $"Finished! Value was: {value}";
            Console.WriteLine(message);
        }
        
        private static void DoWorkThree(int value)
        {
            DoWorkFinal(value);
        }

        private static void DoWorkEven(int value)
        {
            if (value % 3 == 0)
                DoWorkThree(value);
            else
                DoWorkFinal(value);
        }

        private static void DoWorkOdd(int value)
        {
            if (value % 3 == 0)
                DoWorkThree(value);
            else
                DoWorkFinal(value);
        }
        
        private static void DoWork(object o)
        {
            // Small delay so that all threads get started before first breakpoint is hit
            Thread.Sleep(100);
            
            var value = (int) o;
            if (value % 2 == 0)
                DoWorkEven(value);
            else
                DoWorkOdd(value);
        }
        
        public static void Main(string[] args)
        {
            // Create a list of named threads. Random number as parameter means threads
            // have different call stacks before hitting DoWorkFinal - better view for
            // Parallel Stacks tool window
            var random = new Random();
            var threads = new List<Thread>();
            for (var i = 0; i < 10; i++)
            {
                var thread = new Thread(DoWork)
                    {Name = $"MyThread_{i}"};
                thread.Start(random.Next(100));

                threads.Add(thread);
            }
            
            // Wait for the threads to finish
            foreach (var thread in threads)
                thread.Join();
            Console.ReadLine();
        }
    }
}