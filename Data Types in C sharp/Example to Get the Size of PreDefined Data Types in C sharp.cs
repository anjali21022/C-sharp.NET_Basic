using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_to_Get_the_Size_of_PreDefined_Data_Types_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Size of Integer: {sizeof(int)}");
            Console.WriteLine($"Size of Character: {sizeof(char)}");
            Console.WriteLine($"Size of Byte: {sizeof(byte)}");
            Console.WriteLine($"Size of Float: {sizeof(float)}");
            Console.WriteLine($"Size of Boolean: {sizeof(Boolean)}");
            Console.WriteLine($"Size of Long: {sizeof(long)}");
            Console.WriteLine($"Size of Double: {sizeof(double)}");
            Console.ReadKey();
        }
    }
}
