using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_in_C_sharp
{
    internal class Function_Method
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 10;
            y = 15;
            int sum = Add(x, y);
            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
