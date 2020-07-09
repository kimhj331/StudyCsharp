using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThrow
{
    class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.")
                {
                    HelpLink = "http://www.naver.com",
                    Source = "UsingTrow line34"
                };

        }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(2);
                DoSomething(3);
                //DoSomething(12);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine($"도움말링크 : {ex.HelpLink}");
                Console.WriteLine($"Source : {ex.Source}");
                throw;
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다");
            }
        }
        
    }
}
