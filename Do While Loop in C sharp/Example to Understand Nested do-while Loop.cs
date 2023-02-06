using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop_in_C_sharp
{
    internal class Nested_do_while_Loop
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("I am from Outer do-while loop");
                do
                {
                    Console.WriteLine("I am from Inner do-while loop");
                }
                while (1 > 10);
            }
            while (2 > 10);
            Console.ReadKey();
        }
    }
}
