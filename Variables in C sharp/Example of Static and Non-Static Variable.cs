using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program
    { 
        static int x = 100;
        int y = 200;
        static void Main(string[] args)
        {
            Console.WriteLine($"x value: {x}");
            Program obj = new Program();
            Console.WriteLine($"y value: {obj.y}");
            Console.Read();
        }
    }
}
