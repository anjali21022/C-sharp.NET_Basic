//Program to check whether a number is Armstrong number or not using for loop C# Language
//An Armstrong Number is a number that is equal to the sum of, the power of each digit by the total number of digits.
//For example, the numbers such as 0, 1, 153, 370, 371, 407, 1634, 8208, 9474 are Armstrong numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class For_Loop_Program1
    {
        static void Main(string[] args)
        {
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;
            //Step1: Take the input
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            //Step3: Store the number in a temporary variable
            int temporaryNumber = number;
            //Step3: Find the total number of digits in number as well as
            //Store each each digit in the digit array
            while (number > 0)
            {
                digitArray[i++] = number % 10;
                number = number / 10;
                digitCount++;
            }
            //Step4: Calculate the result
            for (i = 0; i < digitCount; i++)
            {
                sum += Math.Pow(digitArray[i], digitCount);
            }
            //Step5: Check whether it is prime number or not
            if (sum == temporaryNumber)
            {
                Console.WriteLine($"{temporaryNumber} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{temporaryNumber} is not an Armstrong number");
            }
            Console.ReadLine();
        }
    }
}
