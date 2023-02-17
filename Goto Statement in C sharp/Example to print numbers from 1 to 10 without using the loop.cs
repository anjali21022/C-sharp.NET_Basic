using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_in_C_sharp
{
    internal class Example_to_print_numbers_from_1_to_10_without_using_the_loop
    {
        static void Main(string[] args)
        {
            int count = 1;
        label_Loop:
            Console.WriteLine(count);
            count++;
            if (count <= 10)
            {
                goto label_Loop;
            }
            Console.ReadKey();
        }
    }
}
