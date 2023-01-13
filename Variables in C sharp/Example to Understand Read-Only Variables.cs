using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Program6
    {
        const float PI = 3.14f; // Constant Variables
        static int x = 10; // static Variables
        int y = 20; //Non-Static Variables
        readonly int z; // Readonly Variables

        //Class Constructor
        public Program6(int a)
        {
            y = a; //Initializing Non-Static Variable
        }

        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");

            Program6 obj1 = new Program6(810);
            Program6 obj2 = new Program6(406);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"Obj1 y value: {obj1.y} & Readonly z value: {obj1.z}");
            Console.WriteLine($"Obj2 y value: {obj2.y} & Readonly z value: {obj2.z}");
            Console.Read();
        }

    }
}
