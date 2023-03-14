using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing_in_C_sharp
{
    internal class Performance_Implication_of_Unboxing
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                Unboxing();
            }

            stopwatch1.Stop();
            Console.WriteLine($"Unboxing took: {stopwatch1.ElapsedMilliseconds} MS");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                WithoutBoxingAndUnboxing();
            }
            stopwatch2.Stop();
            Console.WriteLine($"WithoutBoxingAndUnboxing took: {stopwatch2.ElapsedMilliseconds} MS");
            Console.ReadKey();
        }
        //With Unboxing
        public static void Unboxing()
        {
            object j = 100;
            int i = (int)j; //Unboxing
        }
        //Without Boxing
        public static void WithoutBoxingAndUnboxing()
        {
            int i = 100;
            int j = i; //No Boxing and No Unboxing
        }
    }
}
