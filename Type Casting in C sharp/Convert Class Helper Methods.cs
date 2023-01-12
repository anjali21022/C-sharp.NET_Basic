using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Convert_Class_Helper_Methods
    {
        static void Main(string[] args)
        {
            string str = "100"; 
            int i1 = Convert.ToInt32(str);

            double d = 12.34;
            int i2 = Convert.ToInt32(d);

            float f = 55.6F;
            string i3 = Convert.ToString(f);

            Console.WriteLine($"String Original value {str}, Converted Value {i1}");
            Console.WriteLine($"Double Original Value {d}, Converted Value {i2}");
            Console.WriteLine($"Float Original Value {f}, Converted Value {i3}");

            Console.ReadKey();
        }
    }
}
