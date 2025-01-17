using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymerphism
{
    public class VehicalSystem
    {
        public class Truck
        {
            public virtual void Sound()
            {
                Console.WriteLine("Truck Sound Method Called");
            }
        }
        public class Car :Truck
        {
            public override void Sound()
            {
                Console.WriteLine("Car Sound Method Called");
            }
        }
        public class MotorCycle : Car
        {
            public override void Sound()
            {
                Console.WriteLine("MotorCycle Sound Method Called");
            }
        }
    }
}
