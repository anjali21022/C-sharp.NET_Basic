using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_in_C_sharp
{
    internal class Recursion1
    {
        static void Main(string[] args)
        {
            int number = 5;
            int Result = fun(number);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        static int fun(int n)
        {
            int Result = 0;
            for (int i = 1; i <= n; i++)
            {
                Result = Result + i;
            }
            return Result;
        }
    }
}
