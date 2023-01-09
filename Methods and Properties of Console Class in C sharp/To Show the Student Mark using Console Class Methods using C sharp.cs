// A Program to enter the Student Registration Number, Name, Mark1, Mark2, Mark3, and calculate the total mark and average marks and then print the student details in the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Properties_of_Console_Class_in_C_sharp
{
    internal class To_Show_the_Student_Mark_using_Console_Class_Methods_using_C_sharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("Enter Student Registration Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Mark's of Three Subject");
            Console.WriteLine("Subject 1");
            int Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject 2");
            int Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject 3");
            int Mark3 = Convert.ToInt32(Console.ReadLine());
            int TotalMark = Mark1 + Mark2 + Mark3;
            int AverageMark = TotalMark / 3;

            Console.WriteLine("\nStudent Details are as follows:");
            Console.WriteLine($"Student Registration Number is: {Number}");
            Console.WriteLine($"Student Name is: {Name}");
            Console.WriteLine($"Student Total Mark is: {TotalMark}");
            Console.WriteLine($"Student Average Mark is: {AverageMark}");
            Console.ReadKey();
        }
    }
}
