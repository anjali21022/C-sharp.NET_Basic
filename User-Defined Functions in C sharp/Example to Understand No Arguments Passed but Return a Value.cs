using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class No_Arguments_Passed_but_Return_a_Value
    {
        static void Main(string[] args)
        {
            int Result = sum();
            Console.WriteLine($"Sum is {Result}");
            Console.ReadKey();
        }
        static int sum()
        {
            int x = 3;
            int y = 29;
            int sum =  x + y;
            return sum;
        }
    }
}
