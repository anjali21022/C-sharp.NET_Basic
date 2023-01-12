using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Statements_in_C_sharp
{
    internal class Control_Flow_Statements1
    {
        static void Main(string[] args)
        {
            if (10 > 5)
            {
                Console.WriteLine("Executing Statement1");
                Console.WriteLine("Executing Statement2");
            }
            else
            {
                Console.WriteLine("Executing Statement3");
                Console.WriteLine("Executing Statement4");
            }
            Console.WriteLine("Executing Statement5");
            Console.ReadKey();
        }
    }
}
//Used if else showing breakage, jumping in program.
