using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChains
{
    //delegate 메소드_반환_값 대리자_명 (type 메소드_인수)
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccired; //이벤트가 발생했다고 통보
    }
    class EventLisener
    {
        private string name;
        public EventLisener(string name)
        {
            this.name = name;
        }
        public void SomthingHappend(string message)
        {
            Console.WriteLine($"{name}.SomthingHappend:{message}");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventLisener lisener1 = new EventLisener("Listener1"); //name을 listener1로 설정
            EventLisener lisener2 = new EventLisener("Listener2");

            notifier.EventOccired += lisener1.SomthingHappend; //이전에 값을 준적이 한번도 없지만 += 쓰는것이 룰이다.
            notifier.EventOccired += lisener2.SomthingHappend;
            notifier.EventOccired("You've got mail");

            Console.WriteLine();

            notifier.EventOccired -= lisener2.SomthingHappend;
            notifier.EventOccired("Download complete.");

            Console.WriteLine();


        }       
    }
}
