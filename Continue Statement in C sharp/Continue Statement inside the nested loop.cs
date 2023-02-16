using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement_in_C_sharp
{
    internal class Continue_Statement_inside_the_nested_loop
    {
        static void Main(string[] args)
        {
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer : {outer}");
                for (int inner = 1; inner <= 5; inner++)
                {
                    if (inner == 2)
                    {
                        continue;
                    }
                    Console.Write($"Inner : {inner}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();            
        }
    }
}
