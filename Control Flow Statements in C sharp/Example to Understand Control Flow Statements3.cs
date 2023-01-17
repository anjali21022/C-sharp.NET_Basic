using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Statements_in_C_sharp
{
    internal class Control_Flow_Statements3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Statment1");            
            Console.WriteLine("Executing Statment2");
            goto statement4;   //goto label someLabel:
            Console.WriteLine("Executing Statment3");
            statement4:    //label:
            Console.WriteLine("Executing Statment4");
            Console.WriteLine("Executing Statment5");
            Console.ReadKey();
        }        
    }
}
//Used goto Control Statement
