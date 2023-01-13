using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program5
    {
        const float PI = 3.14f; //Constant Variable
        static int x = 145; //Static Variable
        int y = 235; //Non-Static Variable

        //CLass Constructor
        public Program5(int a)
        {
            y = a; //Initializing Non-Static Variable
        }

        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");
            x = 123; //Modifying Static Variable
            //PI = 3.15f; //Trying to Modify the Constant Variable, Error

            Program5 obj1 = new Program5(687);
            Program5 obj2 = new Program5(890);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"obj1 value: {obj1.y}");
            Console.WriteLine($"obj2 value: {obj2.y}");
            Console.Read();
        }
    }
}
// The error which we get at line 28 is the output of the program getting to know the difference between static and constant.
