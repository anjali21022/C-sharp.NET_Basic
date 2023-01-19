using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_in_C_sharp
{
    internal class Switch_Case_Statements3
    {
        static void Main(string[] args)
        {
            string Category;
            //taking topic name
            string topic = "Inheritance";

            if (topic.Equals("Introduction to C#") ||
                topic.Equals("Variables") ||
                topic.Equals("Data Types"))
            {
                Category = "Basic";
            }
            else if (topic.Equals("Loops") ||
                topic.Equals("If-else Statement") ||
                topic.Equals("Jump Statement"))
            {
                Category = "Control Flow";
            }
            else if (topic.Equals("Inheritance") ||
                topic.Equals("Polymorphism") ||
                topic.Equals("Encapsulation") ||
                topic.Equals("Abstraction"))
            {
                Category = "OOPS Concept";
            }
            else
            {
                Category = "Invalid";
            }
            Console.WriteLine($"{topic} Category is of {Category}");
            Console.ReadKey();
        }
    }
}
