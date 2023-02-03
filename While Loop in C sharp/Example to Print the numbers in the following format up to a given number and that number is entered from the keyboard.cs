using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_sharp
{
    internal class while_loop1
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            i = 2;
            while(i<=n)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadKey();
        }
    }
}
