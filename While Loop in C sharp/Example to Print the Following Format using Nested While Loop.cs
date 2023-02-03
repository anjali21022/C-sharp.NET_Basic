using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_sharp
{
    internal class Nested_While_Loop
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER  A NUMBER ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
