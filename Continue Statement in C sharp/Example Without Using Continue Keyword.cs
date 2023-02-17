using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement_in_C_sharp
{
    internal class Example_Without_Using_Continue_Keyword
    {
        static void Main(string[] args)
        {
            for (int outer = 0; outer <= 7; outer++)
            {
                Console.WriteLine($"Outer : {outer}");
                for (int inner = 0; inner <= 7; inner++)
                {
                    if (inner != 3)
                    {
                        Console.Write($" Inner : {inner}");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
