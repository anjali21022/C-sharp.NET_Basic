using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Example_to_Understand_Explicit_Type_Casting
    {
        static void Main(string[] args)
        {
            double numDouble = 12.34;
            int numint = numDouble;

            Console.WriteLine($"Original Double Value {numDouble}");
            Console.WriteLine($"Converted Int Value {numint}");

            Console.ReadKey();
        }
    }
}

//You will not get an output in these program you will get an error which is only the output.
