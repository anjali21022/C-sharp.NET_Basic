using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_C_sharp
{
    internal class Example_to_Understand_Local_Variables
    {
        static void Main(string[] args)
        {
            Console.Read();
        }
        public void NonStaticBlock()
        {
            //By Default, every local variable is going to be non-static variable
            //The Scope is limited to this method only
            int x = 100;
        }
        public static void StaticBlock()
        {
            //By Default, every local variable is going to be a static variable
            //The Scope is limited to this method only
            int y = 100;
        }
    }
}
