using System;
using static System.Console;

namespace IntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //크기가 서로다른정수의 변환
            sbyte a = sbyte.MaxValue;
            WriteLine($"a = {a}");
            int b = (int)a; //int b = a도 가능 (int) 명시적으로 표현
            WriteLine($"b = {b}");
            int x = 128;
            WriteLine($"x = {x}");
            sbyte y = (sbyte)x; 
            /*
                큰타입을 작은 타입에 넣을때
                sbyte y = x; 불가 컴파일러가 거름
                (sbyte)삽입시 오버플로우 발생
            */
            WriteLine($"y = {y}"); // -128로 print됨 

            // 부동소수점 형식 사이의 변환
            double pi = 3.14159265358979323846264338327950244;
            WriteLine($"pi = {pi}");
            float pi2 = (float)pi;
            WriteLine($"pi2 = {pi2}");
            /* 
                오버플로우 발생하지않음 
                값을 받아올 때 각각 자신의 가수부가 
                담을 수 있는 부분까지만 저장하고 나머지는 버린다.
             */

            //부호있는 정수와 없는형식의 변환
            int under = -30;
            uint high = (uint)under;
            WriteLine($"uint = {high}");
            // 언더플로우 발생

        }
    }
}
