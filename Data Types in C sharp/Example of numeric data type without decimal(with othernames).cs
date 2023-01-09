using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_numeric_data_type_without_decimal_with_othernames
    {
        static void Main(string[] args)
        {
            short num1 = 167;
            int num2 = 432;
            long num3 = 745;

            Console.WriteLine($"Short Max Value is: {short.MaxValue} Short Min Value is:{short.MinValue}");
            Console.WriteLine($"Short size is: {sizeof(short)} Byte");
            Console.WriteLine($"int Max Value is: {int.MaxValue} int Min Value is:{int.MinValue}");
            Console.WriteLine($"int size is: {sizeof(int)} Byte");
            Console.WriteLine($"long Max Value is: {long.MaxValue} long Min Value is:{long.MinValue}");
            Console.WriteLine($"long size is: {sizeof(long)} Byte");
            Console.ReadKey();
        }
    }
}