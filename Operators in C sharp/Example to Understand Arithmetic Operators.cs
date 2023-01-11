using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Arithmetic_Operators
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 30;
            int Result;

            //Addition Operator
            Result = (a + b);
            Console.WriteLine($"Addition Operator: {Result}");

            //Subtraction Operator
            Result = (a - b);
            Console.WriteLine($"Subtraction Operator: {Result}");

            //Multiplication Operator
            Result = (a * b);
            Console.WriteLine($"Multiplication Operator: {Result}");

            //Division Operator
            Result = (a / b);
            Console.WriteLine($"Division Operator: {Result}");

            //Modulus Operator
            Result = (a + b);
            Console.WriteLine($"Modulus Operator: {Result}");

            Console.ReadKey();
        }
    }
}
