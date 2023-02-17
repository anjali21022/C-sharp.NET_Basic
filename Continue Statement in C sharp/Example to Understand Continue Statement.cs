using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement_in_C_sharp
{
    internal class Continue_Statement
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine($"I : {i}");
            }
            Console.ReadKey();
        }
    }
}
