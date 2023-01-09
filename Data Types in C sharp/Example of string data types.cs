using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_string_data_types
    {
        static void Main(string[] args)
        {
            string str = "Anjali";
            var howmanybytes = str.Length * sizeof(char);
            Console.WriteLine($"String Value is: {str}");
            Console.WriteLine($"String bytes is: {howmanybytes}");
            Console.ReadKey();
        }
    }
}
