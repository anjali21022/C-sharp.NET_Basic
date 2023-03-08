using System;
namespace PropertyDemo
{
    public class Calculator
    {
        int _Number1, _Number2, _Result;

        //Write-Only Properties
        //Only Set Accessor, No Get Accessor
        public int SetNumber1
        {
            set
            {
                _Number1 = value;
            }
        }
        public int SetNumber2
        {
            set
            {
                _Number2 = value;
            }
        }

        //Read-Only Property
        //Only Get Accessor, No Set Accessor
        public int GetResult
        {
            get
            {
                return _Result;
            }
        }
        public void Add()
        {
            _Result = _Number1 + _Number2;
        }
        public void Sub()
        {
            _Result = _Number1 - _Number2;
        }
        public void Mul()
        {
            _Result = _Number1 * _Number2;
        }
        public void Div()
        {
            _Result = _Number1 / _Number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter two Numbers:");
            calculator.SetNumber1 = int.Parse(Console.ReadLine());
            calculator.SetNumber2 = int.Parse(Console.ReadLine());

            calculator.Add();
            Console.WriteLine($"The Sum is: {calculator.GetResult}");

            calculator.Sub();
            Console.WriteLine($"The Sub is: {calculator.GetResult}");

            calculator.Mul();
            Console.WriteLine($"The Mul is: {calculator.GetResult}");

            calculator.Div();
            Console.WriteLine($"The Div is: {calculator.GetResult}");
            Console.ReadKey();
        }
    }
}