using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_in_C_sharp
{
    internal class Break_Statement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"I is: {i}");
                if ( i == 7)
                {
                    break;
                }                
            }
            Console.WriteLine("Out of for-loop");
            Console.ReadKey();
        }
    }
}
