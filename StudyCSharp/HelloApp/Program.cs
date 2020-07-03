using static System.Console; // Console.Writeline -> WriteLine

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : HelloApp.exe <이름>");
                return;
            }
            WriteLine($"Hello, {args[0]}!");
        }
    }
}
