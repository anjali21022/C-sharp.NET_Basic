using System;
namespace ReadOnlyDemo
{
    class Program
    {
        readonly int number;

        //Initialize Readonly Variable through constructor
        public Program(int num)
        {
            number = num;
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program(100);
            Console.WriteLine(obj1.number);

            //You cannot change the value of a readonly variable once it is initialized
            //The following statement will give us compile time error 
            //obj1.number = 20;

            Program obj2 = new Program(200);
            Console.WriteLine(obj2.number);

            Console.ReadLine();
        }
    }
}