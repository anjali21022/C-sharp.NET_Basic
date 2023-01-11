using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_Understand_Character_Literals
    {
        static void Main(string[] args)
        {
            //Character Literal using Single Quote
            char ch1 = 'A';
            Console.WriteLine($"Single Quote: {ch1}");
            //Character Literal using Unicode Representation
            char ch2 = '\u0045';
            Console.WriteLine($"Unicode Representation: {ch2}");
            //Character Literal using Escape Sequence
            Console.WriteLine("Escape Sequence: Hello\n.NET Tutorials\tWelcome");
            Console.ReadKey();
        }
    }
}
