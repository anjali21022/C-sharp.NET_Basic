using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_Understand_Integer_Literals
    {
        static void Main(string[] args)
        {
            //Decimal Literal
            int a = 145;
            //Hexa-Decimal Literal
            int b = 0x782f;
            //Binary Literal
            int c = 0b010;

            Console.WriteLine($"Decimal Literal is: {a}");
            Console.WriteLine($"Hexa-Decimal Literal is: {b}");
            Console.WriteLine($"Binary Literal is: {c}");
            Console.ReadKey();
        }
    }
}
