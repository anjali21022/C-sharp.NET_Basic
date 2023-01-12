using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class If_Block
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter a Number");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 10)
            {
                Console.WriteLine($"{Number} is greater than 10");
                Console.WriteLine("Condition is true so execution of if block");
                Console.WriteLine("End of if block");
            }
            Console.WriteLine("\nEnd of Main Method");
            Console.ReadKey();
        }
    }
}
