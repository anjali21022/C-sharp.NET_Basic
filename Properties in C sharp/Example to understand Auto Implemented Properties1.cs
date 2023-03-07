using System;
namespace PropertyDemo
{
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark;
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = -100;
            student.Name = null;
            student.PassMark = 0;
            Console.WriteLine($"ID = {student.ID}, Name = {student.Name}, PassMark = {student.PassMark}");
            Console.ReadKey();
        }
    }
}