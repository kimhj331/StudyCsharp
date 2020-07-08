using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["이름"] = "김희지";
            ht["주소"] = "부산광역시 남구";
            ht["전번"] = "010-5341-8210";
            ht["키"] = 155.12;
            ht["결혼여부"] = false;

            Console.WriteLine($"{ht["키"]:0.0}");
        }
    }
}
