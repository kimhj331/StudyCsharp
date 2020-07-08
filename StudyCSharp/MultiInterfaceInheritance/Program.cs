using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    interface IWalkAble
    {
        void walk();
    }
    public class Vehicle
    {
        public string Year;
        public string Company;
        public float HorsePower;
    }
    public class Testclass : IRunnable, IWalkAble
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }

        public void walk()
        {
            Console.WriteLine("Walk!");
        }
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable; // 이미 구현했기때문에 as IRunnable 생략가능
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();

            Testclass test = new Testclass();

            IRunnable run = test as IRunnable;
            test.Run();
            IWalkAble walk = test as IWalkAble;
            test.walk();
        }
    }
}
