using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEnumerableGeneric
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }
        public int Lenth
        {
            get { return array.Length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() //아무영향 없음
        {
            throw new NotImplementedException();
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strlist = new MyList<string>();
            strlist[0] = "abc "; //쓰려면 Indexer필요함
            strlist[1] = "def ";
            strlist[2] = "efg ";
            strlist[3] = "0123 ";

            foreach (var item in strlist) //쓰려면 IEumerator필요함
            {
                Console.WriteLine($"'{item.Trim()}'");
            }
        }
    }
}
