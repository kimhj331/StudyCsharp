using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericClass 
{
    //클래스에 일반화시 클래스 내부에 T사용가능
    class MyList<T> 
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index]; }
            //set { array[index] = value; } 해당식을 쓰면 배열범위 벗어남
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        /// <summary>
        /// 사이즈를 나타내는 프로퍼티
        /// </summary>
        public int Length
        {
            get { return array.Length; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            //for (int i = 0; i < str_list.Length; i++)
            //{
            //    Console.WriteLine(str_list[i]);
            //}
            foreach (var item in str_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            MyList<float> f_list = new MyList<float>();
            f_list[0] = 0f;
            f_list[1] = 0.1f;
            f_list[2] = 0.2f;
            f_list[3] = 0.3f;
            for (int i = 0; i < f_list.Length; i++)
            {
                Console.WriteLine(f_list[i]);
            }

        }
    }
}
