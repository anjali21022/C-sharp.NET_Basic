﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_in_C_sharp
{
    internal class Calculate_the_Factorial_of_a_Number_using_Recursion
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"The factorial of {x} is {factorial(x)}");
            Console.ReadKey();
        }
        static int factorial(int number)
        {
            if (number == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }
    }
}
