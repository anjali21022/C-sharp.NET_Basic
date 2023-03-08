using Call_by_Value_and_Call_by_Reference_in_C_sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_in_C_sharp
{
    public class Employee
    {
        //Private Data Members
        private int _EmpId, _Age;
        private string _EmpName, _Address;

        // Public Properties
        public int EmpId
        {
            set
            {
                _EmpId = value;
            }
            get
            {
                return _EmpId;
            }
        }

        public int Age
        {
            set
            {
                _Age = value;
            }
            get
            {
                return _Age;
            }
        }

        public string EmpName
        {
            set
            {
                _EmpName = value;
            }
            get
            {
                return _EmpName;
            }
        }

        public string Address
        {
            set
            {
                _Address = value;
            }
            get
            {
                return _Address;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee();
                employee.EmpId = 101;
                employee.EmpName = "Anjali";
                employee.Age = 22;
                employee.Address = "Ghansoli";

                Console.WriteLine("Employee Details");
                Console.WriteLine("Employee Id:" + employee.EmpId);
                Console.WriteLine("Employee Name:" + employee.EmpName);
                Console.WriteLine("Employee Age:" + employee.Age);
                Console.WriteLine("Employee Address:" + employee.Address);
                Console.ReadKey();
            }
        }
    }
}
