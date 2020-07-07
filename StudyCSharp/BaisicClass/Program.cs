using System;
using System.Drawing;

namespace BaisicClass
{
    class cat
    {
        public string Name;
        public Color Color;
        //기본 생성자
        public cat()
        {
            Name = "";
            Color = Color.Empty;
        }
        //파라미터 생성자
        public cat(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        ~cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cat kitty = new cat();
            kitty.Color = Color.Black;
            kitty.Name = "kitty";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            cat Nero = new cat("Nero",Color.White);
            Nero.Meow();
            Console.WriteLine($"{Nero.Name} : {Nero.Color}");

        }
    }
}
