using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_in_C_sharp
{
    internal class Built_in_C_sharp_Functions
    {
        static void Main(string[] args)
        {
            int number = 50;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"SquareRoot of {number} is {squareRoot}.");
            Console.ReadKey();
        }
    }
}
