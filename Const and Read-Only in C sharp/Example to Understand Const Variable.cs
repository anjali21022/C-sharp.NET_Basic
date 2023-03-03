using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables_in_C_sharp;

namespace Const_and_Read_Only_in_C_sharp
{
    internal class Const_Variable
    {
        //we need to assign a value to the const variable
        //at the time of const variable declaration else it will
        //give compile time error
        const float PI = 3.14f; //Constant Variable
        static void Main(string[] args)
        {
            //Const variables are static in nature
            //so we can access them by using class name 
            Console.WriteLine(Const_Variable.PI);
            //We can also access them directly within the same class
            Console.WriteLine(PI);
            //We can also declare a constant variable within a function
            const int Number = 10;
            Console.WriteLine(Number);
            //Once after declaration we cannot change the value 
            //of a constant variable. So, the below line gives an error
            //Number = 20;
            Console.ReadLine();
        }
    }
}
