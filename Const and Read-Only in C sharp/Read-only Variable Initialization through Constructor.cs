using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_and_Read_Only_in_C_sharp
{
    class Program1
    {
        readonly int number = 5;
        //You can also initialize through constructor
        public Program1()
        {
            number = 20;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.number);
            //You cannot change the value of a readonly variable once it is initialized
            //The following statement will give us compile time error 
            //obj.number = 20;
            Console.ReadLine();
        }
    }
}
