using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked_and_Unchecked_Keywords_in_C_sharp
{
    internal class Unchecked_keyword
    {
        static void Main(string[] args)
        {
            int a = 2147483647;
            int b = 2147483647;
            int c = unchecked(a + b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
