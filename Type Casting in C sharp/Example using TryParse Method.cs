using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Example_using_TryParse_Method
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            bool IsConverted1 = int.TryParse(str1 , out int I1);
            if (IsConverted1)
            {
                Console.WriteLine($"Original String Value: {str1}, Converted Int Value: {I1}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str1} to Integer");
            }

            string str2 = "Hello";
            bool IsConverted2 = int.TryParse(str2, out int I2);
            if (IsConverted2)
            {
                Console.WriteLine($"Original String Value: {str2}, Converted Int Value: {I2}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str2} to Integer");
            }

            Console.ReadKey();
        }
    }
}
