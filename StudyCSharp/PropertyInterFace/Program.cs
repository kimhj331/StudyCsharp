using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterFace
{
    interface INamedValue
    { 
        string Name
        {
            get;
            set;
        }
        string Value
        { get; set; }
        string GetOtherValue();
    }
    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string GetOtherValue()
        {
            return "";
        }
    }

    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue
            {
                Name = "이름",
                Value = "김희지"
            };
            NamedValue height = new NamedValue
            {
                Name = "키",
                Value = "155cm"
            };
            NamedValue nicname = new NamedValue
            {
                Name = "별명",
                Value = "고구마"
            };
        }
    }
}
