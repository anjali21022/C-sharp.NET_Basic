using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_in_C_sharp
{
    internal class String_Concatenation
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                str = "DotNet Tutorials" + str;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
