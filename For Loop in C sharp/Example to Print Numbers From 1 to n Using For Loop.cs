using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_sharp
{
    internal class For_Loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 1; counter <= number; counter++)
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
