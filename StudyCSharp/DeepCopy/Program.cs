using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass
            {
                MyField1 = this.MyField1, //this는 class자체의 myfiled
                MyField2 = this.MyField2
            };
            return newCopy; //새로 힙을 배정해 복사시킴.(다른주소, 같은값)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow copy");
            //아무 의미없는 구분 코드블럭
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} : {source.MyField2}");
                Console.WriteLine($"{target.MyField1} : {target.MyField2}");
            }

            Console.WriteLine("Deep copy");
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} : {source.MyField2}");
                Console.WriteLine($"{target.MyField1} : {target.MyField2}");

            }
        }
    }
}
