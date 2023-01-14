using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Increment_and_Decrement_Operators
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            int z;
            z = x++ * --y;
            Console.WriteLine($"x={x}, y={y}, z={z}");
            Console.ReadKey();
        }
    }
}
