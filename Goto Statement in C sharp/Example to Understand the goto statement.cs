using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_in_C_sharp
{
    internal class the_goto_statement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Statement");
            goto label1;
            Console.WriteLine("2nd Statement");
            label1:
            Console.WriteLine("3rd Statement");
            Console.WriteLine("End of Main Method");
            Console.ReadKey();
        }
    }
}
