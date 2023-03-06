using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables_in_C_sharp;

namespace Const_and_Read_Only_in_C_sharp
{
    internal class Program
    {
        readonly int x; //Readonly Variable
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            //Accessing Readonly variable using instance
            Console.WriteLine($"{obj1.x}");
            Console.Read();
        }
    }
}
