using System;
using System.Threading;
using System.Threading.Tasks; 
using System.Diagnostics;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main()
        {
            //TPL- Task Parallel Library
            
            int[] numbers ={12,45,36,78,49,25,45,66};
            Stopwatch stopwatch =new Stopwatch();

            //Sequential
            stopwatch.Start();
            foreach(var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential) :{stopwatch.ElapsedMilliseconds} ms");

            //Parallel
            stopwatch.Restart();

            Parallel.ForEach(numbers, num  => {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallely) :{stopwatch.ElapsedMilliseconds} ms");
        }
        static void Compute(int x)
        {

            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }
    }
}
