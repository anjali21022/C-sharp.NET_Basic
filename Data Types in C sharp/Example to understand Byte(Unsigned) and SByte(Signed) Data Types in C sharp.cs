using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Data_Types_in_C_sharp
{
    internal class Example_to_understand_Byte_Unsigned__and_SByte_Signed__Data_Types_in_C_sharp
    {
       static void Main(string[] args)
        {
            byte b1 = 65;
            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Character of {b1} is: {(char)b1}");
            Console.WriteLine($"Byte Max Value is: {sbyte.MaxValue}  Byte Min Value is: {sbyte.MinValue}");
            Console.WriteLine($"Byte Size: {sizeof(sbyte)}");

            sbyte b2 = 45;
            sbyte b3 = -98;
            Console.WriteLine($"\nDecimal: {b2} {b3}");
            Console.WriteLine($"ASCII Character of {b2} is: {(char)b2}");
            Console.WriteLine($"ASCII Character of {b3} is: {(char)b3}");
            Console.WriteLine($"SByte Max Value is: {sbyte.MaxValue}  SByte Min Value is: {sbyte.MinValue}");
            Console.WriteLine($"SByte Size: {sizeof(sbyte)}");
            Console.ReadKey();
        }
    }
}
