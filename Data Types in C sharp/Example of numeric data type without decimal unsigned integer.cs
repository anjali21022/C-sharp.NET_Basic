using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_numeric_data_type_without_decimal_unsigned_integer
    {
        static void Main(string[] args)
        {
            ushort num1 = 145;
            uint num2 = 456;
            ulong num3 = 723;

            Console.WriteLine($"UShort Min Value is: {ushort.MinValue} UShort Max Value is: {ushort.MaxValue}");
            Console.WriteLine($"UShort Size is: {sizeof(ushort)} Byte");
            Console.WriteLine($"Uint Min Value is: {uint.MinValue} Uint Max Value is: {uint.MaxValue}");
            Console.WriteLine($"Uint Size is: {sizeof(uint)} Byte");
            Console.WriteLine($"Ulong Min Value is: {ulong.MinValue} Ulong Max Value is: {ulong.MaxValue}");
            Console.WriteLine($"Ulong Size is: {sizeof(ulong)} Byte");
            Console.ReadKey();
        }
    }
}
