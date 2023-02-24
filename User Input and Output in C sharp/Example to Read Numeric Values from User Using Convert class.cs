using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_and_Output_in_C_sharp
{
    internal class Read_Numeric_Values_from_User_Using_Convert_class
    {
        static void Main(string[] args)
        {
            string UserInput;
            int intval;
            double doubleval;

            Console.WriteLine("Enter Integer Value");
            UserInput = Console.ReadLine();
            // Converts to integer type
            intval = Convert.ToInt32(UserInput);
            Console.WriteLine("You entered {0}", intval);

            Console.Write("Enter double value: ");
            UserInput = Console.ReadLine();
            // Converts to double type
            doubleval = Convert.ToDouble(UserInput);
            Console.WriteLine("You entered {0}", doubleval);
        }
    }
}
