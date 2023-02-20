using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_in_C_sharp
{
    internal class Using_goto_in_Switch_Statement
    {
        static void Main(string[] args)
        {
            int number = 20;
            switch (number)
            {
                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    // goto statement transfer
                    // the control to case 5
                    goto case 5;
                default:
                    Console.WriteLine("No match found");
                    break;
            }
            Console.ReadKey();
        }
    }
}
