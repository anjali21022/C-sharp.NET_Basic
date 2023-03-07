using System;
namespace PropertyDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
    class Program1
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Age = 101;
            employee.Name = "Pranaya";
            employee.Address = "BBSR, Odisha, India";

            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Address: {employee.Address}");
            Console.ReadKey();
        }
    }
}
