using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_in_C_sharp
{
    internal class Switch_Statement2
    {
        static void Main(string[] args)
        {
            string str = "C##";
            Console.WriteLine("Switch Statement Started");
            switch(str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It's a Programming Language");
                    break;

                case "MSSQL":
                case "MySQL":
                case "Oracle":
                    Console.WriteLine("It's a Database");
                    break;

                case "MVC":
                case "WEB API":
                    Console.WriteLine("It's a Framework");
                    break;
            }
            Console.WriteLine("Switch Statement Ended");
            Console.ReadKey();
        }
    }
}
