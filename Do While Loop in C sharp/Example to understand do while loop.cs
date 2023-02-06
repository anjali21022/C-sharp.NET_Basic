using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop_in_C_sharp
{
    internal class do_while_loop
    {
        static void Main(string[] args)
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number <= 5);
            Console.ReadKey();
        }
    }
}
