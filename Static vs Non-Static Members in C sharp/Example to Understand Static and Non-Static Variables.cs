using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_Non_Static_Members
{
    internal class Example
    {
        int x; // Non-Static Variable
        static int y = 200; //Static Variable
        public Example(int x)
        {
            //Initializing Non-Static Variable
            this.x = x;
        }
        static void Main(string[] args)
        {
            //Accessing Static Variable using class name
            //Before Object Creation
            Console.WriteLine($"Static Variable Y = {Example.y}");
            //Accessing Static Variable using without class name
            //It’s possible because we are accessing the variable
            //from the same class
            Console.WriteLine($"Static Variable Y = {y}");
            //Creating Object1
            Example obj1 = new Example(50);
            //Creating Object2
            Example obj2 = new Example(100);
            //Accessing Non-Static Variable using Object of the class
            Console.WriteLine($"Object1 x = {obj1.x} and Object2 x = {obj2.x}");

        }
    }
}
