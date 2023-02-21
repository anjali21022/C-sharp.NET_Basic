using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class function_overloading1
    {
        static void Main(string[] args)
        {
            int x = 12, y = 9, c, d;
            c = add(x, y);
            Console.WriteLine($"Sum of {x} and {y} is {c}");
            d = add(x, y, c);
            Console.WriteLine($"Sum of {x} and {y} and {c} is {d}");
            Console.WriteLine($"Sum of 10.5 and 17.8 is {add(10.5f, 17.8f)}");
            Console.ReadKey();
        }
        static int add(int a, int b)
        {
            return a + b;
        }
        static int add(int a, int b, int w)
        {
            return a +b + w;
        }
        static float add(float a, float b)
        {
            return a + b;
        }
    }
}
