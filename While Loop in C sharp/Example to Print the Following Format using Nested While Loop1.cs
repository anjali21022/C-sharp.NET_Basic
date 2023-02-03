using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_sharp
{
    internal class Nested_While_Loop1
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a<=5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
            Console.ReadKey();
        }
    }
}
