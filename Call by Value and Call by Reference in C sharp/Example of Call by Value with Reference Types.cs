using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_Value_and_Call_by_Reference_in_C_sharp
{
    internal class Call_by_Value_with_Reference_Types
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";
            Employee Emp2 = Emp1;
            Emp1.Name = "Smith";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Name}");
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
}
