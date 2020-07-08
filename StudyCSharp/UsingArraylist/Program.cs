using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UsingArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADD컬렉션의 가장 마지막에 있는 요소 뒤에 새 요소를 추가
            //object형태로 값을 넣음
            //ArrayList list = new ArrayList();
            //중괄호 안에 넣을경우 초기화가능
            ArrayList list = new ArrayList { 123,456,789 };
            for (int i = 0; i < 10; i++)
            {
                int iresult = list.Add(i)+1;
                Console.WriteLine($"{iresult}번째에 {i}추가완료");
            }

            foreach (Object item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //인덱스위치에 해당하는 값을 삭제
            //0,1,2 즉 세번째 있는 값을 지워라
            list.Remove(2);
            foreach (Object item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // 인덱스위치에 해당하는 값을 추가
            //Insert
            list.Insert(4,4.5);
            foreach (Object item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //clear 리스트 내용 삭제
            list.Clear();
            foreach (Object item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

        }
    }
}
