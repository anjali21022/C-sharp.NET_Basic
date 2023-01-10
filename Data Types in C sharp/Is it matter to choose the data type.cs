using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Is_it_matter_to_choose_the_data_type
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                short s1 = 200;
                short s2 = 200;
                short s3 = 200;
            }
            stopwatch1.Stop();
            Console.WriteLine($"short took: {stopwatch1.ElapsedMilliseconds} MS");

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                decimal s1 = 200;
                decimal s2 = 200;
                decimal s3 = 200;
            }
            stopwatch2.Stop();
            Console.WriteLine($"decimal took: {stopwatch2.ElapsedMilliseconds} MS");

            Console.ReadKey();
        }
    }
}
