using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Property
{
    class BirthDayInfo
    {
        //소문자로 작성
        private DateTime birthday;
        private int age;
        //대문자로 작성
        public string Name
        {
            get;
            set;
        } = "unknown";

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }

        }
        public int Age
        {
            get
            {
                //Subtract(a)a만큼 빼주고 .Ticks로 반환
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                BirthDayInfo info = new BirthDayInfo
                {
                    Name = "서현",
                    Birthday = new DateTime(1991, 6, 28)
                };

                Console.WriteLine($"{info.Name} : {info.Birthday:yyyy-MM-dd}({info.Age} 세)");


                //무명형식으로 선언 시 get만 가능하다.
                var myInstance = new { Name = "김희지", Age = "25" };
                Console.WriteLine(myInstance.Name, myInstance.Age);
                //myInstance.Name = "김지희";

                var b = new { Subject = "수학", Score = new int[] { 99, 88, 77 } };
                Console.WriteLine($"{b.Subject}");
                foreach (var item in b.Score)
                {
                    Console.WriteLine($"{item}");
                }
            
            }
        }
    }
}
