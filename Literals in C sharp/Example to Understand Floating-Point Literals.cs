using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_Understand_Floating_Point_Literals
    {
        static void Main(string[] args)
        {
            // Double literal
            double a = 100; //By Default Floating Point Literal is double
            //float literal
            float b = 100.23F; //Suffix with F
            //decimal literal
            decimal c = 100.23M; //Suffix with M
            //double literal
            double d = 100D; //Suffix with D

            Console.WriteLine($"Double Literal: {a}");
            Console.WriteLine($"Float Literal: {b}");
            Console.WriteLine($"Decimal Literal: {c}");
            Console.WriteLine($"Double Literal: {d}");

            Console.ReadKey();
        }
    }
}
