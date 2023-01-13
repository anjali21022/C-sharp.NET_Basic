using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program2
    {
        static int x = 100; //Static Variable
        int y = 200; //Non-Static Variable

        //Class Constructor
        public Program2(int a)
        {
            y = a; //Initializing non-static variable
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"x value is: {x}");
            Program2 obj1 = new Program2(500);
            Program2 obj2 = new Program2(700);
            Console.WriteLine($"y vaue is: {obj1.y}");
            Console.WriteLine($"y value is: {obj2.y}");
            Console.Read();
        }
    }
}
