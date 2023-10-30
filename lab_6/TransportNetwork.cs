using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public string CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            return $"Calculating the optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}...";
        }
    }
}
