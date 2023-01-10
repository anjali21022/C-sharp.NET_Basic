using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Example_to_Understand_Implicit_Type_Casting
    {
        static void Main(string[] args)
        {
            int numInt = 1500;
            Type numIntType = numInt.GetType();
            double numDouble = numInt;
            Type numDoubleType = numDouble.GetType();

            Console.WriteLine($"numInt Value: {numInt}");
            Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size {sizeof(int)} Byte");

            Console.WriteLine($"numDouble Value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"Double Size {sizeof(double)} Bytes");

            Console.ReadKey();
        }
    }
}
