using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StirngSerchApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            string g = "Good Morning";
            /*
            WriteLine(g);

            WriteLine($"IndexOf 'Good':{g.IndexOf('o')}");           //같은게 없으면 -1, 있으면 시작하는 문자열 자리
            WriteLine($"LastIndexOf 'Good' : {g.LastIndexOf("o")}"); //해당 문자열이 존재하는 가장 마지막자리 찾아냄

            //bool StartsWith() 현재 문자열이 지정된 문자열로 끝나는지 평가한다.
            WriteLine($"StartsWith 'Good':{g.StartsWith("Good")}"); //해당 문자열이 "Good"으로 시작할 경우 ture반환

            //bool Contains
            WriteLine($"Contains 'Good':{g.Contains("Good")}");

            //★Replace★
            WriteLine($"Replace 'Morning' to 'Evening':" +
                      $"{g.Replace("Morning","Evening")}");
            //대, 소문자로 변환
            WriteLine($"ToLower : {g.ToLower()}");
            WriteLine($"ToUpper : {g.ToUpper()}");

            //Insert
            WriteLine($"Insert : {g.Insert(g.IndexOf("Good"), "Very ")}");

            //Remove
            WriteLine($"Remove: {"I Don't Love You".Remove(1,6)}");

            //Trim 현재 문자열 앞 뒤에있는 공백을 제거한 새 문자열을 반환한다.
            WriteLine($"Trim: '{" No Space ".Trim()}'");
            WriteLine($"Trim: '{" No Space ".TrimStart()}'");
            WriteLine($"Trim: '{" No Space ".TrimEnd()}'");
            */

            //문자열 분할하기
            string codes = "MSFT,GOOG, AMZN, AAPL, RHT";
            var result = codes.Split(',');
            foreach (var item in result)
            {
                WriteLine($"each item = '{item.Trim()}'");
            }

            //해당 범위 문자만 출력하기
            WriteLine($"substring : {g.Substring(0, 4)}");

            //Format
            
            DateTime dt = DateTime.Now;
            WriteLine("한국식 > {0:yyyy-MM-dd HH:mm:ss}", dt);           //년월일시분초
            WriteLine($"미국식 > {dt.ToString("d/M/yyyy tt HH:mm:ss", new CultureInfo("en-US"))}");
            WriteLine(string.Format("{0:M MM MMM MMMM}", dt));
            WriteLine(string.Format("{0:d dd ddd dddd}", dt)); //일 0일 요일 X요일
            //WriteLine(string.Format("{0:H HH HHH HHHH}", dt)); 변화없음
            WriteLine(string.Format("{0, -7}DEF", "ABC"));

            decimal mvalue = 270000000000000m;
            WriteLine($"{mvalue:C}"); // 천단위 별로 콤마찍힘
            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));

        }
    }
}
