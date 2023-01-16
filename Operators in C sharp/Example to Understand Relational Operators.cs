using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Relational_Operators
    {
        static void Main(string[] args)
        {
            bool Result;
            int a = 3;
            int b = 6;

            //Equal to (==) Operator
            Result = a == b;
            Console.WriteLine($"Equal To Operator: {Result}");

            //Not Equal To (!=) Operator
            Result = a != b;
            Console.WriteLine($"Not Equal To Operator: {Result}");

            //Less than (<) Operator
            Result = a < b;
            Console.WriteLine($"Less Than Operator: {Result}");

            //Greater than (>) Operator
            Result = a > b;
            Console.WriteLine($"Greater Than Operator: {Result}");

            //Less than equal to (<=) Operator
            Result = a <= b;
            Console.WriteLine($"Less Than Equal To Operator: {Result}");

            //Greater than equal to (>=) Operator
            Result = a >= b;
            Console.WriteLine($"Greater Than Equal To Than Operator: {Result}");
            
            Console.ReadKey();
        }
    }
}
