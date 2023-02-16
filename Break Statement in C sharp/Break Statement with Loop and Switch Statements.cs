using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_in_C_sharp
{
    internal class Break_Statement_with_Loop_and_Switch_Statements
    {
        static void Main(string[] args)
        {
            double[] measurements = { 1, 20, 3, double.NaN };
            foreach(double measurement in measurements)
            {
                switch (measurement)
                {
                    case 1:
                        Console.WriteLine($"Value is {measurement}; too low");
                        break;

                    case 20:
                        Console.WriteLine($"Value is {measurement}; too high");
                        break;                                            

                    case double.NaN:
                        Console.WriteLine("Invalid");
                        break;

                   default:
                        Console.WriteLine($"Value is {measurement}");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
