using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_Value_and_Call_by_Reference_in_C_sharp
{
    internal class Call_by_Reference_with_Value_Types
    {
        static void Main(string[] args)
        {
            int a = 15;
            UpdateValue(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static void UpdateValue(ref int b)
        {
            b = 30;
        }
    }
}
