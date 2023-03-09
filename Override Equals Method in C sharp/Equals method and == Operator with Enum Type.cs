using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_Method_in_C_sharp
{
    internal class Equals_method_and____Operator_with_Enum_Type
    {
        public class Program
        {
            public static void Main()
            {
                Direction direction1 = Direction.East;
                Direction direction2 = Direction.East;
                Console.WriteLine(direction1 == direction2);
                Console.WriteLine(direction1.Equals(direction2));
                Console.ReadKey();
            }
        }
        public enum Direction
        {
            East = 1,
            West = 2,
            North = 3,
            South = 4
        }
    }
}
