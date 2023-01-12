using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Type_Conversion_using_Parse___Method
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            int i = int.Parse(str1);

            string str2 = "True";
            bool b = bool.Parse(str2);

            Console.WriteLine($"String Original Value is {str1}, Converted Value is {i}");
            Console.WriteLine($"String Original Value is {str2}, Converted Value is {b}");
            Console.ReadKey();
        }
    }
}
