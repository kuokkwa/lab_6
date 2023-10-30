using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Human
    {
        public double Speed { get; set; }

        public Human(double speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine("Human is moving...");
        }
    }
}
