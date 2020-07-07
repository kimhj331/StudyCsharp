using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Squre(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int Int, int exponent)
        {
            int result = Int;
            for (int i = 0; i < exponent; i++)
            {
                result *= Int;
            }
            return result;
        }
    }
}

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Squre()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
