using System;
using System.Linq;

namespace UsingIndexer
{
    class Mylist
    {
        private int[] array;

        public Mylist()
        {
            array = new int[3];
        }

        //인덱스로 값을 갖도록함
        public int this[int index]
        {
            get { return array[index]; }
            //set { array[index] = value; } 해당식을 쓰면 배열범위 벗어남
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
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
            Mylist list = new Mylist();
            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            list[3] = 4;


        }
    }
}
