using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OverRoadingApp
{
    class Program
    {
        /// <summary>
        /// 덧셈, 두 수를 더한다
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int</returns>
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// 덧셈 double 두 수를 더한다
        /// </summary>
        /// <param name="a">double</param>
        /// <param name="b">double</param>
        /// <returns>double</returns>
        static double Plus(double a, double b)
        {
            return a + b;
        }
        static double Plus(double a, double b, double c)
        {
            return a + b + c;
        }
        static float Plus(float a, float b)
        {
            return a + b;
        }
        static double Plus(int a, double b)
        {
            return a + b;
        }
        static int Sum(params int[] args)
        {
            int result = 0;
            foreach (var item in args)
            {
                result += item;
            }
            return result;
        }
        static void MyMethod(string arg1 = "", string arg2 = "")
        {
            Console.WriteLine("MyMethod B");
        }
        static void MyMethod()
        {
            Console.WriteLine("MyMethod A");
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(Plus(2.156,132));
            int sum = Sum(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine(sum);
            */
            MyMethod("","");
        }
    }
}
