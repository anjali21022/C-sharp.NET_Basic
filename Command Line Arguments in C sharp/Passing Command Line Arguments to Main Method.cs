using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Arguments
{
    internal class Passing_Command_Line_Arguments_to_Main_Method
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First Command Line Argument {args[0]}");
            Console.WriteLine($"Second Command Line Argument {args[1]}");
            Console.WriteLine($"Third Command Line Argument {args[2]}");
            Console.ReadLine();
        }
    }
}
