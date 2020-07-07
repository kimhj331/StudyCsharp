using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RefReturn
{
    class Product 
    {
        private int price = 100;

        public ref int GetPrice(){
            return ref price;
        }
        public void PrintPrice(){
            WriteLine($"Price : {price}");
        }

    }
    class MainApp
    {
        static void Main(string[] args){
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice(); 
            //값을 담을 변수 지정
            //ref로 선언하면 값 변경시 class에 있는 변수도 변경된다

            carrot.PrintPrice();

            ref_local_price = 3000;
            carrot.PrintPrice();
        }
    }
}
