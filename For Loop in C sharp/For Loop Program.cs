//Program to enter a number and check whether that no is the perfect number or not using for loop in C#
//A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself.
//For instance, 6 has divisors 1, 2 and 3, and 1 + 2 + 3 = 6, so 6 is a perfect number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class For_Loop_Program
    {
        static void Main(string[] args)
        {
            int number, i, sum = 0;
            Console.WriteLine("Enter a Number");
            number = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number && number != 0)
                Console.WriteLine($"{number} is a Perfect Number");
            else
                Console.WriteLine($"{number} is not a Perfect Number");
            Console.ReadKey();
        }
    }
}
