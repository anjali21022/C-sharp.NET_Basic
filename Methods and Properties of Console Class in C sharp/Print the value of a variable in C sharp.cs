using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class print_the_value_of_a_variable_in_C_sharp
    {
        static void Main(string[] args)
        {
            string name = "Anjali";
            // 3 Methods Shown to print the value
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
    }
}
