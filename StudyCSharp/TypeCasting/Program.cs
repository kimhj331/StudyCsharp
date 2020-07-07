using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class타입 변환
namespace TypeCasting
{
    class Mamal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }
    class Dog : Mamal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Cat : Mamal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mamal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = mammal as Dog; //(Dog)mammal
                dog.Bark();
            }

            Mamal mammal2 = new Cat();
            Cat cat;

            if (mammal2 is Cat)
            {
                cat = mammal as Cat; //(Dog)mammal
                cat.Meow();
            }

        }
    }
}
