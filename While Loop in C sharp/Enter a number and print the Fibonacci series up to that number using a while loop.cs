using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_sharp
{
    internal class while_loop2
    {
        static void Main(string[] args)
        {
            int i, n, j, k;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            Console.Write($"{i} {j}");
            k = i + j;
            while(k<=n)
            {
                Console.WriteLine($"\n{k}");
                i = j;
                j = k;
                k = i + j;
            }
            Console.ReadKey();
        }
    }
}
