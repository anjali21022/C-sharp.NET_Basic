//If you are using a float, then it will print a maximum of 7 digits, if you are using double, maximum it will print 15 digits and if you are using a decimal maximum, it will print 29 digits.
//For a better understanding, please have a look at the below example which shows the accuracy of float, double, and decimal data types in C# language.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_in_C_sharp
{
    internal class Example_to_Understand_Accuracy_of_float__double__decimal
    {
        static void Main(string[] args)
        {
            //7 digits max
            float a = 1.123456789123f;
            //15 digits max
            double b = 2.12345678987654321122234;
            //29 digits max
            decimal c = 3.12345677778900987654321111234555678987654m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
