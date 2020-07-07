using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //while (i>0)
            //{
            //    console.writeline(i--);
            //}
            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey~");
            List<string> subs = new List<string> { "Banana", "Strawberry" };
            strings.AddRange(subs);
            

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
