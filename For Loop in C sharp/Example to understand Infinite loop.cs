using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class Infinite_loop
    {
        static void Main(string[] args)
        {
            int number = 10;
            int i = 1;
            for(; i <= number;)
            {
                Console.WriteLine("Hello");
            }
            Console.ReadKey();
        }
    }
}
