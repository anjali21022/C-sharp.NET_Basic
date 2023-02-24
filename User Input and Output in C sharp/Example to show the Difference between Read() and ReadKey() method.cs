using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_and_Output_in_C_sharp
{
    internal class Difference_between_Read___and_ReadKey___method
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.WriteLine("Ascii Value = {0}", userInput);
        }
    }
}
