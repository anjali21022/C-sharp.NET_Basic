using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_in_C_sharp
{
    internal class Switch_Statement4
    {
        static void Main(string[] args)
        {
            string category;
            string topic = "Inheritance";
            switch(topic)
            {
                case "Introduction to C#":
                case "Variable":
                case "Data Types":
                    category = "Basic";
                    break;

                case "Loops":
                case "If-else Statement":
                case "Jump Statement":
                    category = "Control Flow";
                    break;

                case "Inheritance":
                case "Polymorphism":
                case "Encapsulation":
                case "Abstraction":
                    category = "OOPS Concept";
                    break;

                default:
                    category = "Invalid";
                    break;                     
            }
            Console.WriteLine($"{topic} Category is of {category}");
            Console.ReadKey();
        }
    }
}
