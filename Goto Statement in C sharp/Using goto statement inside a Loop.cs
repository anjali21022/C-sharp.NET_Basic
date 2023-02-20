using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_in_C_sharp
{
    internal class Using_goto_statement_inside_a_Loop
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    goto label1;
                }
                Console.WriteLine(i);
            }
            label1:
                Console.WriteLine("Labeled Statement");
            
            Console.ReadKey();
        }
    }
}
