using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_char_data_types
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            Console.WriteLine($"Character: {ch}");
            Console.WriteLine($"Equivalent Character is: {(byte)ch}");
            Console.WriteLine($"Char Max Value is: {(int)char.MaxValue} Char Min Value is: {(int)char.MinValue}");
            Console.WriteLine($"Char Size is: {sizeof(char)} Byte");
            Console.ReadKey();
        }
    }
}
