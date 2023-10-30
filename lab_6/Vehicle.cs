using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Vehicle
    {
        public double Speed { get; set; }
        public double Capacity { get; set; }
        public int Passengers { get; private set; }

        public Vehicle(double speed, double capacity)
        {
            Speed = speed;
            Capacity = capacity;
            Passengers = 0;
        }

        public abstract void Move();

        public bool EmbarkPassengers(int count)
        {
            if (Passengers + count <= Capacity)
            {
                Passengers += count;
                Console.WriteLine($"{count} passengers boarded the {this.GetType().Name}");
                return true;
            }
            else
            {
                Console.WriteLine($"The {this.GetType().Name} is already full. Passengers cannot board");
                return false;
            }
        }

        public bool DisembarkPassengers(int count)
        {
            if (Passengers - count >= 0)
            {
                Passengers -= count;
                Console.WriteLine($"{count} passengers disembarked from the {this.GetType().Name}");
                return true;
            }
            else
            {
                Console.WriteLine($"There are not enough passengers on the {this.GetType().Name} to disembark {count} passengers");
                return false;
            }
        }
    }
}
