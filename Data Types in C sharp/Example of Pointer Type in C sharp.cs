using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_Pointer_Type_in_C_sharp
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // declare a variable
                int number = 10;
                // store variable number address location in pointer variable ptr
                int* ptr = &number;
                Console.WriteLine($"Value :{number}");
                Console.WriteLine($"Address :{(int)ptr}");
                Console.ReadKey();
            }            
        }
    }
}
