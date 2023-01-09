using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class Example_to_Understand_ReadKey_and_Read_method_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Key");
            int var1 = Console.Read();
            Console.WriteLine($"ASCII Value of Entered Key is: {var1}");

            Console.WriteLine("Enter Another Key");
            ConsoleKeyInfo var2 = Console.ReadKey();
            Console.WriteLine($"\nEntered Key is: {var2.Key} \nASCII: {(int)var2.KeyChar}");
            Console.ReadKey();
        }
    }
}
