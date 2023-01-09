using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_Numberic_data_types_without_decimal
    {
        static void Main(string[] args)
        {
            Int16 num1 = 126;
            Int32 num2 = 456;
            Int64 num3 = 785;

            Console.WriteLine($"Int16 Mav Value is: {Int16.MaxValue} Int16 Min Value is: {Int16.MinValue}");
            Console.WriteLine($"Int16 Size is: {sizeof(Int16)} Byte");
            Console.WriteLine($"Int32 Mav Value is: {Int32.MaxValue} Int32 Min Value is: {Int32.MinValue}");
            Console.WriteLine($"Int32 Size is: {sizeof(Int32)} Byte");
            Console.WriteLine($"Int64 Mav Value is: {Int64.MaxValue} Int64 Min Value is: {Int64.MinValue}");
            Console.WriteLine($"Int64 Size is: {sizeof(Int64)} Byte");
            Console.ReadKey();
        }
    }
}
