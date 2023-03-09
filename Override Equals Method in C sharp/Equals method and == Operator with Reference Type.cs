using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_Method_in_C_sharp
{
    internal class Equals_method_and____Operator_with_Reference_Type
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Pranaya";
            C1.LastName = "Rout";
            Customer C2 = C1;
            Console.WriteLine($"C1 == C2: {C1 == C2}");
            Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
            Console.ReadKey();
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

