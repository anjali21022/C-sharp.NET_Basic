using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class Ladder_If_Else_Statements
    {
        static void Main(string[] args)
        {
            int a = 20;
            if (a == 10)
            {
                Console.WriteLine("a is 10");
            }
            else if (a == 15)
            {
                Console.WriteLine("a is 15");
            }
            else if (a == 20)
            {
                Console.WriteLine("a is 20");
            }
            else
            {
                Console.WriteLine("a is not present");
            }
            Console.ReadKey();
        }
    }
}
