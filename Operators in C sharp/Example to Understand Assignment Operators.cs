using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Assignment_Operators
    {
        static void Main(string[] args)
        {
            int x = 10;

            // Add Assignment Operator
            x += 5;
            Console.WriteLine($"Add Assignment Operator: {x}");

            // Subtract Assignment Operator
            x = 30;
            x -= 5;
            Console.WriteLine($"Subtract Assignment Operator: {x}");

            // Multiply Assignment Operator
            x = 6;
            x *= 5;
            Console.WriteLine($"Multiply Assignment Operator: {x}");

            // Division Assignment Operator
            x = 15;
            x /= 5;
            Console.WriteLine($"Division Assignment Operator: {x}");

            // Modulus Assignment Operator
            x = 50;
            x %= 5;
            Console.WriteLine($"Modulus Assignment Operator: {x}");

            Console.ReadKey();
        }
    }
}
