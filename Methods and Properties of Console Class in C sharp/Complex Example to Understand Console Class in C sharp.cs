//write one program to accept Employee Details like EmployeeId, Name, Salary, Address, and Department, and then we will print the accepted information on the console window.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class Complex_Example_to_Understand_Console_Class_in_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter Employee Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            string Department = Console.ReadLine();

            Console.WriteLine("\nEmployee Details are as follows:");
            Console.WriteLine($"Employee Id is: {Id}");
            Console.WriteLine($"Employee Name is: {Name}");
            Console.WriteLine($"Employee Salary is: {Salary}");
            Console.WriteLine($"Employee Address is: {Address}");
            Console.WriteLine($"Employee Department is: {Department}");
            Console.ReadKey();
        }
    }
}
