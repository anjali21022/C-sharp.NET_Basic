using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class Argument_Passed_and_Return_Value_Function
    {
        static void Main(string[] args)
        {
            int x = 23, y = 45;
            int Result = Sum(x, y);
            Console.WriteLine($"Sum is {Result}");
            Console.ReadKey();
        }
        static int Sum(int x, int y)
        {
            int Sum = x + y;
            return Sum;
        }
    }
}
