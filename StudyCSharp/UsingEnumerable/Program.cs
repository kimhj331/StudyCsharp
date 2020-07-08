﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingEnumerable
{
    class Mylist : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1; //인덱스를 타지않은경우 

        public Mylist()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            { return array[index]; }
            set
            { 
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public object Current {
            get { return array[position]; }
        } 

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public bool MoveNext() 
        {
            if (position == array.Length)
            {
                Reset();
                return false;
            }
            position++;
            return true;
        }
        public void Reset()
        {
            position = -1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //while(list.MoveNext())
            //{
            //    Console.WriteLine(list.Current());
            //}
        }

        
    }
}
