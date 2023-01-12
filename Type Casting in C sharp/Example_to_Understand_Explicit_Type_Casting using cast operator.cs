using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Example_to_Understand_Explicit_Type_Casting_using_cast_operator
    {
        static void Main(string[] args)
        {
            double numDouble = 12.34;
            int numint = (int)numDouble;

            Console.WriteLine($"Original Double Value {numDouble}");
            Console.WriteLine($"Converted Int Value {numint}");

            Console.ReadKey();
        }
    }
}
