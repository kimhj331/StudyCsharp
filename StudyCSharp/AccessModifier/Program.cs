using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temper;
        public void SetTemper(int temper)
        {
            if (temper < -5 || temper > 42)
            {
                throw new Exception("Out of Temperature range");
            }
            this.temper = temper;
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn On Water {temper}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemper(20);
                heater.TurnOnWater();

                heater.SetTemper(-2);
                heater.TurnOnWater();


                heater.SetTemper(50);
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
