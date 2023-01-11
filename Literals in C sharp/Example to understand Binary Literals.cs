using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_understand_Binary_Literals
    {
        static void Main(string[] args)
        {
            int a = 0b100111101;
            int b = 0b11110010;

            Console.WriteLine($"Value of a is: {a}");
            Console.WriteLine($"Value of b is: {b}");
            Console.WriteLine($"Character Value of a is: {Convert.ToChar(a)}");
            Console.WriteLine($"Character Value of b is: {Convert.ToChar(b)}");

            Console.ReadKey();
        }
    }
}
