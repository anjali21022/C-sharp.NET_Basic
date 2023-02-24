using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_and_Output_in_C_sharp
{
    internal class Another_way_of_Reading_Numeric_Values
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer Value");
            int intval = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0}", intval);

            Console.Write("Enter Double Value");
            double doubleval = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You entered {0}", doubleval);
        }
    }
}
