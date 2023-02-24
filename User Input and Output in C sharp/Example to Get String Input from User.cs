using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_and_Output_in_C_sharp
{
    internal class Get_String_Input_from_User
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter a string - ");
            str = Console.ReadLine();
            Console.WriteLine($"You entered {str}");
        }
    }
}
