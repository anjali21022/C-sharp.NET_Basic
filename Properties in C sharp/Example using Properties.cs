using System;
namespace PropertyDemo2
{
    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 35;
        public int ID
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID value should be greater than zero");
                }
                _ID = value;
            }
            get
            {
                return _ID;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                _Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
            }
        }
        public int PassMark
        {
            get
            {
                return _PassMark;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 101;
            student.Name = "Pranaya";

            Console.WriteLine($"ID = {student.ID}");
            Console.WriteLine($"Name = {student.Name}");
            Console.WriteLine($"Pass Mark = {student.PassMark}");
            Console.ReadKey();
        }
    }
}