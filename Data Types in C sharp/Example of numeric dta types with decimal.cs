using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_of_numeric_data_types_with_decimal
    {
        static void Main(string[] args)
        {
            Single a = 1.23f;
            Double b = 1.23;
            Decimal c = 1.23m;

            Console.WriteLine($"Single Min Value is: {Single.MinValue} Single Max Value is: {Single.MaxValue}");
            Console.WriteLine($"Single Size is: {sizeof(Single)} Byte");
            Console.WriteLine($"Double Min Value is: {Double.MinValue} Double Max Value is: {Double.MaxValue}");
            Console.WriteLine($"Double Size is: {sizeof(Double)} Byte");
            Console.WriteLine($"Decimal Min Value is: {Decimal.MinValue} Decimal Max Value is: {Decimal.MaxValue}");
            Console.WriteLine($"Decimal Size is: {sizeof(Decimal)} Byte");
            Console.ReadKey();
        }
    }
}
