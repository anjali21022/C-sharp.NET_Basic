using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing_in_C_sharp
{
    internal class Example_to_Understand_Boxing_and_Unboxing
    {
        static void Main(string[] args)
        {
            int x = 10;
            object y = x; //Boxing
            int z = (int)y; //Unboxing
        }
    }
}
