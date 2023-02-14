using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class For_Loop_Program3
    {
        static void Main(string[] args)
        {
            int number, number1 = 0, number2 = 1, temp;
            Console.Write("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1)
            {
                Console.Write($"{number1} {number2}");
                temp = number1 + number2;
                for (; temp <= number;)
                {
                    Console.Write($" {temp}");
                    number1 = number2;
                    number2 = temp;
                    temp = number1 + number2;
                }
            }
            else
                Console.WriteLine("please enter a number greater than zero");
            Console.ReadKey();
        }
    }
}
