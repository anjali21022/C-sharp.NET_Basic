using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_Method_in_C_sharp
{
    internal class Overriding_the_Equals_Method_of_the_Object_Class
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Pranaya";
            C1.LastName = "Rout";
            Customer C2 = new Customer();
            C2.FirstName = "Pranaya";
            C2.LastName = "Rout";
            Console.WriteLine($"C1 == C2: {C1 == C2}");
            Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
            Console.ReadKey();
        }
    }
    public class Customer1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            // If the passed object is null, return False
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not Customer Type, return False
            if (!(obj is Customer))
            {
                return false;
            }
            return (this.FirstName == ((Customer)obj).FirstName)
                && (this.LastName == ((Customer)obj).LastName);
        }
    }
}

