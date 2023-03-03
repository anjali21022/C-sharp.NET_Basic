using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables_in_C_sharp;

namespace Const_and_Read_Only_in_C_sharp
{
    class Program
    {
        readonly int number = 5;
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.number);
            Console.ReadLine();
        }
    }
}
