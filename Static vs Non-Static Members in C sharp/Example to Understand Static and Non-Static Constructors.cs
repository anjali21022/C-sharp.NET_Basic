using System;
namespace StaticNonStaticDemo
{
    class Example1
    {
        //Static Constructor
        //Executed only once
        //First block of code to be executed inside a class
        //Before Main Method body start executing, this constructor will execute
        static Example1()
        {
            Console.WriteLine("Static Constructor is Called");
        }

        //Non-Static Constructor
        //Executed once per object
        //When we create an instance, this constructor will execute
        public Example1()
        {
            Console.WriteLine("Non-Static Constructor is Called");
        }

        //Program Execution will start from the Main method
        //But before executing the Main method body, it will
        //execute the static constructor
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Start");
            Example obj1 = new Example();
            Example obj2 = new Example();
            Console.WriteLine("Main Method Execution End");
            Console.ReadLine();
        }
    }
}