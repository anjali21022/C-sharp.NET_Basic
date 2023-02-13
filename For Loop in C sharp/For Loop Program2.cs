//Program to enter a number and check whether it is a prime number or not using for loop in C# Language
//A Prime Number is a number that should be greater than 1 and it is only divided by 1 and itself. In other words,
//we can say that the prime numbers can’t be divided by other numbers than itself and 1. For example, 2, 3, 5, 7, 11, 13, 17, 19, and 23…., are the prime numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class For_Loop_Program2
    {
        static void Main(string[] args)
        {
            int number, i;
            Console.Write("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    break;
                }

            }
            if (i == number && number >= 2)
            {
                Console.WriteLine($"{number} is a Prime Number");
            }

            else
            {
                Console.WriteLine($"{number} is not a Prime Number");
            }
            Console.ReadKey();
        }
    }
}
