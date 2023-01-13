using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program4
    {
        const float PI = 3.14f; //Constant Variable
        static int x = 145; //Static Variable
        int y = 235; //Non-Static Variable

        //CLass Constructor
        public Program4(int a)
        {
            y = a; //Initializing Non-Static Variable
        }

        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");

            Program4 obj1 = new Program4(687);
            Program4 obj2 = new Program4(890);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"obj1 value: {obj1.y}");
            Console.WriteLine($"obj2 value: {obj2.y}");
            Console.Read();
        }
    }
}
