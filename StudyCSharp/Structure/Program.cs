using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p3d1; //struct는 new하지 않음
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;
            //var result = p3d1.ToString;
            Console.WriteLine(p3d1.ToString());
        }
    }
}
