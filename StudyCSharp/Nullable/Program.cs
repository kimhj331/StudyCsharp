using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nullable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            float? c = null;
            string s = null;


          
            WriteLine(a.HasValue);
            if (a.HasValue)
            {
                WriteLine(a.Value);
            }
            WriteLine(b == null);
            WriteLine(string.IsNullOrEmpty(s));
            WriteLine(string.IsNullOrWhiteSpace(s));

            c = 3.141592F;
            if (c.HasValue)
            {
                WriteLine($"c = {c}");
            }
            c = null;
        }
    }
}
