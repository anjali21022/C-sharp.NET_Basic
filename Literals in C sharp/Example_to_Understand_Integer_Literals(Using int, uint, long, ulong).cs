using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_Understand_Integer_Literals_Using_int__uint__long__ulong_
    {
        static void Main(string[] args)
        {
            //Integer
            int a = 100;
            //Unsigned Integer
            uint b = 100U;
            //Long 
            long c = 100L;
            //Unsigned Long
            ulong d = 100UL;

            Console.WriteLine($"Integer: {a}");
            Console.WriteLine($"Unsigned Integer: {b}");
            Console.WriteLine($"Long: {c}");
            Console.WriteLine($"Unsigned Long: {d}");
            Console.ReadKey();
        }
    }
}
