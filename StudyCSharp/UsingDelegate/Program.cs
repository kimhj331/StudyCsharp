using System;

namespace UsingDelegate
{
    delegate int MyDelegate(int a, int b);//대리자 선언

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            //이전 사용방법
            //Console.WriteLine(Calc.Plus(3, 4));
            //Console.WriteLine(Calc.Minus(3, 4));


            MyDelegate Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
