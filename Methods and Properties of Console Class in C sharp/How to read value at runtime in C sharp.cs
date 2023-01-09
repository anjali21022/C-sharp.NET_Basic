using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class How_to_read_value_at_runtime_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string a = Console.ReadLine();
            Console.WriteLine("Hello " + a);
            Console.ReadKey();
        }
    }
}
