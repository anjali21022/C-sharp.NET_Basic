using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_and_Output_in_C_sharp
{
    internal class Concatenated_string_using_String_formatting
    {
        static void Main(string[] args)
        {
            int number1 = 15, number2 = 20, sum;
            sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
        }
    }
}
