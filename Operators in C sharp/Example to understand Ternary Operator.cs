using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_understand_Ternary_Operator
    {
        static void Main(string[] args)
        {
            int a = 20, b = 10, res;
            res = ((a > b) ? a : b);
            Console.WriteLine("Result = " + res);
            Console.ReadKey();
        }
    }
}
