using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program1
    {
        static int x = 100;
        int y = 200;
        static void Main(string[] args)
        {
            Console.WriteLine($"x value is: {x}");
            Program1 obj1 = new Program1();
            Program1 obj2 = new Program1();
            Console.WriteLine($"y value is: {obj1.y}");
            Console.WriteLine($"y value is: {obj2.y}");
            Console.Read();
        }
    }
}
