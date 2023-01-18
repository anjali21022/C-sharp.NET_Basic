using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class Nested_IF_ELSE_Statements_using_Ternary_Operator
    {
        static void Main(string[] args)
        {
            int a = 10, b = 12, c = 15;
            int LargestNumber = 0;

            Console.WriteLine($"a={a}, b={b}, c={c}");
            LargestNumber = (a > b) ? ((a > c) ? (a) : (c)) : ((b > c) ? (b) : (c));
            Console.WriteLine($"The LargestNumber is {LargestNumber}");

            Console.ReadKey();
        }
    }
}
