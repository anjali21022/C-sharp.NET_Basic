using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_in_C_sharp
{
    internal class Recursion
    {
        static void Main(string[] args)
        {
            int x = 3;
            fun2(x);
            Console.ReadKey();
        }
        static void fun2(int n)
        {
            if (n > 0)
            {
                fun2(n - 1);
                Console.Write($"{n} ");
            }
        }
    }
}
