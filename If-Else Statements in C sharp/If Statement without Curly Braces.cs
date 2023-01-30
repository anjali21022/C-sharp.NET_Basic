using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class If_Statement_without_Curly_Braces
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter a Number");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 10)
                Console.WriteLine($"{Number} is greater than 10");
            Console.WriteLine("End of Main BlocK");
            Console.ReadKey();
        }
    }
}
