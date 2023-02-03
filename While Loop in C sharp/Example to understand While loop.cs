using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_in_C_sharp
{
    internal class While_loop
    {
        static void Main(string[] args)
        {
            int x = 1;
            while(x<=5)
            {
                Console.WriteLine("Value of x:" + x);
                x++;
            }
            Console.ReadKey();
        }

    }
}
