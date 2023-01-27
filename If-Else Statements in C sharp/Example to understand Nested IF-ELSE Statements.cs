using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class Nested_IF_ELSE_Statements
    {
        static void Main(string[] args)
        {
            int a = 10, b = 25, c = 15;
            int LargestNumber = 0;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Outer If - Inner If Block");
                    LargestNumber = a;
                }
                else
                {
                    Console.WriteLine("Outer else - Inner else Block");
                    LargestNumber = b;
                }
            }
            else
            {
                Console.WriteLine("Outer Else Block");
                if (b > c)
                {
                    Console.WriteLine("outer Else - Inner If Block");
                    LargestNumber = b;
                }
                else
                {
                    Console.WriteLine("outer Else - Inner else Block");
                    LargestNumber = b;
                }
            }
            Console.WriteLine($"LargestNumber is: {LargestNumber}");
            Console.ReadKey();
        }        

    }
}
