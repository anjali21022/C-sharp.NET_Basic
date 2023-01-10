using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Data_Types_in_C_sharp
{
    internal class Example_to_Get_the_Minimum_and_Maximum_Range_of_Values_of_Built_in_Data_Types_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Float Max Value is:{float.MaxValue} Float Min Value is: {float.MinValue}");
            Console.WriteLine($"Integer Max Value is:{int.MaxValue} Integer Min Value is: {int.MinValue}");
            Console.WriteLine($"Double Max Value is:{double.MaxValue} Double Min Value is: {double.MinValue}");
            Console.WriteLine($"Long Max Value is:{long.MaxValue} Long Min Value is: {long.MinValue}");
            Console.WriteLine($"Byte Max Value is:{byte.MaxValue} Byte Min Value is: {byte.MinValue}");
            Console.ReadKey();
        }
    }
}
