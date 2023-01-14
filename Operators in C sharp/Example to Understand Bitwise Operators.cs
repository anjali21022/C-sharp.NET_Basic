using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Bitwise_Operators
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 27;
            int Result;

            //Bitwise OR Operator (|)
            Result = a | b;
            Console.WriteLine($"Bitwise OR Operator (|): {Result}");

            //Bitwise AND Operator (&)
            Result = a & b;
            Console.WriteLine($"Bitwise AND Operator (&): {Result}");

            //Bitwise XOR Operator (^)
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR Operator (^): {Result}");

            Console.ReadKey();
        }
    }
}
