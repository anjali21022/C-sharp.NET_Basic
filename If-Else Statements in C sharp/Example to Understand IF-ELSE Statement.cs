using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class IF_ELSE_Statement
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter a Number");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine($"{Number} is an even number");
            }
            else
            {
                Console.WriteLine($"{Number} is an odd number");
            }
            Console.ReadKey();
        }
    }
}
