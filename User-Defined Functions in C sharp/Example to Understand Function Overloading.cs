using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class Function_Overloading
    {
        static void Main(string[] args)
        {
            int a = 12, b = 35, c, d;
            c = add(a, b);
            Console.WriteLine($" Sum of {a} and {b} is {c}");
            d = add(a, b, c);
            Console.WriteLine($" Sum of {a} and {b} and {c} is {d}");
            Console.ReadKey();
        }
        static int add(int x, int y)
        {
            return x + y;
        }
        static int add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
