using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class custom_if_statement_inside_for_loop
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (; ;)
            {
                Console.WriteLine("Hello C#");
                i++;
                if (i > 5)
                    break;
            }
            Console.ReadKey();
        }
    }
}
