using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nr = new List<int>();
            HashSet<int> num = new HashSet<int>();


            Stopwatch stopwatch = new Stopwatch();
            int g = 0;
            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000000; i++)
            {
                num.Add(i);
            }
            for(int i = 0; i < nr.Count; i++)
            {
                if (i > 9999 && i < 10001) g = i;
                i = g;

            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
