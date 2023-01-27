using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements_in_C_sharp
{
    internal class If_and_Else_Block_without_Curly_Braces
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a == 10)
                Console.WriteLine("Hi"); //This Statement belongs to IF Block
            else
                Console.WriteLine("Hello"); //This Statement belongs to ELSE Block
            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
