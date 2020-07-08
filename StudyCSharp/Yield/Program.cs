using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class MyEnumerator 
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        //yield를 사용하면 Foreach사용가능 
        //return은 값을 보낸후 다음작업을 기다림
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
