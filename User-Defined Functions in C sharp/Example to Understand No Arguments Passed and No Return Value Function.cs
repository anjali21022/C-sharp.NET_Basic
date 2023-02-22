using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Functions_in_C_sharp
{
    internal class No_Arguments_Passed_and_No_Return_Value_Function
    {
        static void Main(string[] args)
        {
            Sum();
            Console.ReadKey();
        }
        static void Sum()
        {
            int x = 13;
            int y = 4;
            int sum = x + y;
            Console.WriteLine(sum); 
        }
    }
}
