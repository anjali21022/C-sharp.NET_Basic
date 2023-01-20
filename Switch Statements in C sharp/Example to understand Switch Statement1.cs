using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_in_C_sharp
{
    internal class Switch_Statement1
    {
        static void Main(string[] args)
        {
            string str = "C#";
            switch(str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It is a Programming Language");
                    break;

                case "MySQL":
                case "MSSQL":
                case "Oracle":
                    Console.WriteLine("It's a Database");
                    break;

                case "MVC":
                case "WEB API":
                    Console.WriteLine("IT's a Freamework");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
