using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_in_C_sharp
{
    internal class Example_to_understand_String_Literals
    {
        static void Main(string[] args)
        {
            string str1 = "Dot Net Tutorials";
            string str2 = @"Dot Net Tutorials";

            string str3 = "Dot\nNet\tTutorials";
            string str4 = @"Dot\nNet\tTutorials";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);

            Console.ReadKey();
        }
    }
}
