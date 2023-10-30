using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Car: Vehicle
    {
        public Car(double speed, double capacity) : base(speed, capacity)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Car is moving...");
        }
    }
}
