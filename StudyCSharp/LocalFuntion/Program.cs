using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFuntion
{
    class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerchar(i);
            }
            char ToLowerchar(int i) //내부 로컬함수
            {
                if (arr[i] < 65 || arr[i] > 90) //A~Z AXCII값 65~90
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }
        static string ToUpperString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToUpperchar(i);
            }
            char ToUpperchar(int i) //내부 로컬함수
            {
               // if (arr[i] > 65 && arr[i] < 90) //A~Z AXCII값 65~90
                    
                if(arr[i]>='a'&&arr[i]<='z')
                    return (char)(arr[i] - 32);
                else return arr[i];
            }

            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToUpperString("Good Morning."));
        }
    }
}
