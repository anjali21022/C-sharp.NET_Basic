using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_Value_and_Call_by_Reference_in_C_sharp
{
    internal class Call_By_Value
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = a;
            b = 34;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
