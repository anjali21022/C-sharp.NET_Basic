using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_to_Get_the_Default_Values_of_built_in_Data_Types_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default Value of Integer: {default(int)}");
            Console.WriteLine($"Default Value of Character: {default(char)}");
            Console.WriteLine($"Default Value of Byte: {default(byte)}");
            Console.WriteLine($"Default Value of Float: {default(float)}");
            Console.WriteLine($"Default Value of Boolean: {default(Boolean)}");
            Console.WriteLine($"Default Value of Long: {default(long)}");
            Console.WriteLine($"Default Value of Double: {default(double)}");
            Console.ReadKey();
        }
    }
}
