using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//인터페이스는 구현이 없다.

//추상클래스는 자기 스스로 구현 가능하다
//추상 선언하여 일종의 약속을 지정할수있다.
//추상클래스는 인스턴스화가 불가능하다
namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethod();  
    }
    class Derived : AbstractBase
    {
        //추상클래스 약속을 가져와 쓸때 override로 사용한다.
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //추상클래스는 new로 인스턴스화 하지 못한다
            //대신에 상속받은 class로 인스턴스화 가능하다.
            AbstractBase obj = new Derived();
            obj.AbstractMethod(); //privateMethod는 본인과 상속 class이외에서 사용 불가
            obj.PublicMethodA();

        }
    }
}
