using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent");
        }
    
        ~Parent()
        {
            Console.WriteLine($"{Name}.~Parent");
        }
        public void PMethod()
        {
            Console.WriteLine($"{Name}.PMethod");
        }
    }
    class child : Parent
    {
        public child(string Name) : base(Name) //생성자
        {
            Console.WriteLine($"{this.Name}.child");
        }
        ~child()
        {
            Console.WriteLine($"{Name}.~child");
        }
        public void CMethod()
        {
            Console.WriteLine($"{Name}.childMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent a = new Parent("a");
            a.PMethod();

            child b = new child("b");
            b.PMethod();
            b.CMethod();
        }
    }
}
