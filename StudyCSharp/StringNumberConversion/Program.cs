using System;
using static System.Console;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자를 문자열로
            int a = 12345;
            string b = a.ToString();
            WriteLine($"b = {b}");

            float c = 3.141592f;
            string d = c.ToString();
            WriteLine($"c = {c}");

            //문자열을 숫자로
            string e = "123456*";
            /*
            int f = Convert.ToInt32(e);
            WriteLine($"f = {f}");
            float h = float.Parse(e);
            WriteLine($"h = {h}");
            Double g = Double.Parse(e);
            */

            //문자열 안에 숫자가아닌 글자가 있을때
            if (int.TryParse(e, out int abc))
            {
                WriteLine($"abc = {abc}");
            }
            else
            {
                WriteLine("e값 변환시 에러 발생, 문자열 확인요망");
            }
            /*
                TryParse(변환할변수, out 받을변수) -> 변환가능하면 true값 리턴, 
                result == true?e:0
            */

        }
    }
}
