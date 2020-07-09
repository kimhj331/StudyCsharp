using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct //값 형식 이어야 한다
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class //참조 형식 이어야 한다.
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base{}
    class Derived : Base { }
    class BaseArray<U> : Base 
    { 
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U //일반화 메서드 U의 속성을 상속받음
        {
            Source.CopyTo(Array, 0);
        }
    }

    class Program
    {
        public static T CreateInstamce<T>() where T : new() // 기본 생성자가 있어야 한다.
        {
            return new T();
        }
        static void Main(string[] args)
        {
            //StructArray<string> a = new StructArray<string>(3);   //값형식이 아닌 문자열일경우 오류발생 
            RefArray<string> b = new RefArray<string>(4);           //문자열은 참조형식이므로 사용가능 

            BaseArray < Base > c = new BaseArray<Base>(4);
            c.Array[0] = new Base(); 
            c.Array[1] = new Derived(); //베이스를 상속받았기때문에 사용가능
            c.Array[2] = CreateInstamce<Base>();
            c.Array[3] = CreateInstamce<Derived>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
        }
    }
}
