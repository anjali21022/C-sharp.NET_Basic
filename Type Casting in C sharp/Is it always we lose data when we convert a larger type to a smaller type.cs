using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_in_C_sharp
{
    internal class Is_it_always_we_lose_data_when_we_convert_a_larger_type_to_a_smaller_type
    {
        static void Main(string[] args)
        {
            int Intnum1 = 200;
            byte Bytenum1 = (byte)Intnum1;
            Console.WriteLine($"Original Value: {Intnum1} Converted Value: {Bytenum1}");

            int Intnum2 = 500;
            byte Bytenum2 = (byte)Intnum2;
            Console.WriteLine($"\nOriginal Value: {Intnum2} Converted Value: {Bytenum2}");

            Console.ReadKey();
        }
        
    }
}
