using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Bitwise_Operators1
    {
        static void Main(string[] args)
        {
            bool a = true, b = false, Result;
            // Bitwise AND Operator
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");
            // Bitwise OR Operator
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");
            // Bitwise XOR Operator
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");
            Console.ReadKey();
        }
    }
}
