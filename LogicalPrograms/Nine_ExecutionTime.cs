using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Nine_ExecutionTime
    {
        public void Run()
        {
            int num = 100;
            var watch = Stopwatch.StartNew();
            Console.WriteLine("Even numbers are " );

            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("  "+i);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The ODD numbers from the given range {0} is -- ", num);
            for (int j = 0; j <= num; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(" " + j);
                }

            }
            watch.Stop();
            Console.WriteLine("\n");
            Console.WriteLine("\n Execution  Time is " + watch.ElapsedMilliseconds);


        }
    }
}
