using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_in_C_sharp
{
    internal class Example_to_Understand_the_goto_statement1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Statement");
            goto label2;
            Console.WriteLine("2nd Statement");
        label1:
            Console.WriteLine("3rd Statement");
        label2:
            Console.WriteLine("4th Statement");
        label3:
            Console.WriteLine("5th Statement");
        label4:
            Console.WriteLine("6th Statement");
            Console.WriteLine("End of Main Method");
            Console.ReadKey();
        }
    }
}
