using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Between_Convert.ToString_and_ToString_Method_in_c_sharp
{
    internal class Difference_Between_Convert
    {
        public static void Main()
        {
            Customer C1 = null;
            C1.ToString();
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}