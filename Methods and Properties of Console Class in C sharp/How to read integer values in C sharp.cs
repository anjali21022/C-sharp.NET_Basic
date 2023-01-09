using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class How_to_read_integer_values_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Another Number");
            int Num2 = Convert.ToInt32(Console.ReadLine()); 
            int Result = Num1 + Num2;
            Console.WriteLine($"The Sum of Two Number is: {Result}");
            Console.ReadKey();
        }
    }
}
