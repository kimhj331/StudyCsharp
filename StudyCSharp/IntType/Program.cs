using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace IntType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte a = sbyte.MinValue;   //MinValue= -128 MaxValue = 127
            byte c = byte.MinValue;     //MinValue= 0 MaxValue = 225

            short d = short.MinValue;   //MinValue= -32768 MaxValue = 32767
            ushort e = ushort.MinValue; //MinValue= 0 MaxValue = 65535

            int f = int.MinValue;       //MinValue= -2147483648 MaxValue = 2147483687
            */

            byte a = 255;
            WriteLine($"a = {a}");
            byte b = 0b1111_1111;   //2진수 0b
            WriteLine($"b = {b}");
            byte c = 0xFF;          //10진수 0x
            WriteLine($"c = {c}");

            byte d = byte.MaxValue;
            WriteLine($"d = {d}");
            WriteLine($"d = {++d}");

            double g = double.MaxValue;
        }
    }
}
