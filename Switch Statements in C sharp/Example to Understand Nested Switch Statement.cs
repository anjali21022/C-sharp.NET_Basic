using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_in_C_sharp
{
    internal class Nested_Switch_Statement
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a number between 1 to 3
            Console.WriteLine("Enter a Number Between 1 to 3");
            int number = Convert.ToInt32(Console.ReadLine());

            //outer switch
            switch(number)
            {
                case 1:
                    Console.WriteLine("You entered one");
                    //Ask the user to enter a character R, G, or B
                    Console.WriteLine("Enter a color code (R/G/B):");
                    char color = Convert.ToChar(Console.ReadLine());

                    //Inner Switch
                    switch (Char.ToUpper(color))
                    {
                        case 'R':
                            Console.WriteLine("You have Selected Red Color");
                            break;
                        case 'G':
                            Console.WriteLine("You have Selected Green Color");
                            break;
                        case 'B':
                            Console.WriteLine("You have Selected Blue Color");
                            break;
                        default:
                            Console.WriteLine($"You Have Enter Invalid Color Code: {Char.ToUpper(color)}");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("You entered two");
                    break;

                case 3:
                    Console.WriteLine("You entered three");
                    break;

                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
