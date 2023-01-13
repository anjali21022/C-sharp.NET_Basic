using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program3
    {
        static int x = 100; //Static Variable
        int y = 200; //Non-Static Variable

        public Program3(int a)
        {
            y = a; //Initializing Non-Static Variable
            x = a; //Initializing Static Variable
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"x value is: {x}");

            Program3 obj1 = new Program3(300);
            Console.WriteLine($"obj1 y value is: {obj1.y}");
            Console.WriteLine($"obj1 x value is: {x}");

            Program3 obj2 = new Program3(400);
            Console.WriteLine($"\nobj2 y value is: {obj2.y}");
            Console.WriteLine($"obj2 x value is: {x}");

            Console.Read();
        }
    }
}
