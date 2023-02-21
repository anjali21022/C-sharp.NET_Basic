using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class Argument_Passed_but_no_Return_Value_Function
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Sum(x, y);
            Console.ReadKey();
        }
        static void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"Sum is {sum}");
        }
    }    
}
