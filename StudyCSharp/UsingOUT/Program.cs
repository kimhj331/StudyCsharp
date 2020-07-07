using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsingOUT
{
    class Program
    {
        static void Divide(int a, int b, out int qoun, out int rem)
        {
            qoun = a / b;
            rem = a % b;
        }
        static void Main(string[] args)
        {
            int a= 10;
            int b= 3;
            Divide(a, b, out int c, out int d);
            WriteLine($"Divide ({a},{b}) = \n qou : {c} \n rem : {d}");
        }
    }
}
