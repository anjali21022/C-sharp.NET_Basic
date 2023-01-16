using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_sharp
{
    internal class Example_to_Understand_Logical_Operators
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;
            bool z;

            //Logical And Operator (&&)
            z = x && y;
            Console.WriteLine("Logical And Operator (&&):" + z);

            //Logical OR Operator (||)
            z = x || y;
            Console.WriteLine("Logical OR Operator (||):" + z);

            //Logical Not Operator(!)
            z = !x;
            Console.WriteLine("Logical Not Operator(!):" + z);

            Console.ReadKey();
        }
    }
}
