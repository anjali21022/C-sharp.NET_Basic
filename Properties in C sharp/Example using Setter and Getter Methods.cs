using System;
namespace PropertyDemo1
{
    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 35;
        public void SetID(int ID)
        {
            if (ID < 0)
            {
                throw new Exception("ID value should be greater than zero");
            }
            _ID = ID;
        }
        public int GetID()
        {
            return _ID;
        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not be empty");
            }
            _Name = Name;
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(_Name))
            {
                return "No Name";
            }
            return _Name;
        }
        public int GetPassMark()
        {
            return _PassMark;
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetID(101);
            student.SetName("Pranaya");

            Console.WriteLine($"ID = {student.GetID()}");
            Console.WriteLine($"Name = {student.GetName()}");
            Console.WriteLine($"Pass Mark = {student.GetPassMark()}");
            Console.ReadKey();
        }
    }
}