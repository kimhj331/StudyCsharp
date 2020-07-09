using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> Intlist = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Intlist.Add(i);
            //}

            //foreach (int e in Intlist)
            //{
            //    Console.Write($"{e} ");
            //}
            //Console.WriteLine();

            //Intlist.RemoveAt(2);

            //foreach (var e in Intlist)
            //{
            //    Console.Write($"{e} ");
            //}
            //Console.WriteLine();

            //Intlist.Insert(2, 2);

            //foreach (var e in Intlist)
            //{
            //    Console.Write($"{e} ");
            //}
            //Console.WriteLine();

            //Queue<double> queue = new Queue<double>();

            //queue.Enqueue(1.1);
            //queue.Enqueue(2.2);
            //queue.Enqueue(3.3);
            //queue.Enqueue(4.4);
            //queue.Enqueue(5.5);

            //foreach (var e in queue)
            //{
            //    Console.Write($"{e } ");
            //}
            //Console.WriteLine();

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 1;
            dic["둘"] = 2;
            dic["셋"] = 3;
            dic["넷"] = 4;

            Console.WriteLine(dic["하나"]);
        }
    }
}
