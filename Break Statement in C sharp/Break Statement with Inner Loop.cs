using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_in_C_sharp
{
    internal class Break_Statement_with_Inner_Loop
    {
        static void Main(string[] args)
        {
            for (int outer = 1; outer <= 5; outer++)
            {
                Console.WriteLine($"Outer : {outer}");
                for (int inner = 1; inner <= 5; inner++)
                {
                    Console.Write($"Inner: {inner} ");
                    if (inner == 3)
                    {
                        break;
                    }
                }
                Console.WriteLine();                
            }
            Console.ReadKey();
        }
    }
}
