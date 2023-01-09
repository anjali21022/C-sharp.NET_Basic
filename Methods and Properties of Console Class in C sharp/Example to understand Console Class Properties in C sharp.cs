using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class Example_to_understand_Console_Class_Properties_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class Properties";
            Console.WriteLine("BackgroundColor : Red");
            Console.WriteLine("ForegroundColor : White");
            Console.WriteLine("Title : Understanding Console Class Properties");
            Console.ReadKey();
        }
    }
}
