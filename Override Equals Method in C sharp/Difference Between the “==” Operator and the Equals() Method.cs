using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_Method_in_C_sharp
{
    internal class Difference_Between_the______Operator_and_the_Equals___Method
    {
        public static void Main()
        {
            int Number1 = 10;
            int Number2 = 10;
            Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
            Console.WriteLine($"Number1.Equals(Number2): {Number1.Equals(Number2)}");
            Console.ReadKey();
        }
    }
}
