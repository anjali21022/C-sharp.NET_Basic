using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_Value_and_Call_by_Reference_in_C_sharp
{
    internal class Call_By_Value1
    {
        static void Main(string[] args)
        {
            int a = 15;
            UpdateValue(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        private static void UpdateValue(int b)
        {
            b = 30;
        }
    }
}
