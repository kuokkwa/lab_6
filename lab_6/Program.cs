namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();

            Car car = new Car(87, 55);
            Bus bus = new Bus(66, 50);
            Train train = new Train(115, 100);

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.MoveAllVehicles();

            Route route = new Route("'start point'", "'end point'");
            string optimalRouteForCar = network.CalculateOptimalRoute(route, car);
            string optimalRouteForBus = network.CalculateOptimalRoute(route, bus);
            string optimalRouteForTrain = network.CalculateOptimalRoute(route, train);

            Console.WriteLine(optimalRouteForCar);
            Console.WriteLine(optimalRouteForBus);
            Console.WriteLine(optimalRouteForTrain);

            car.EmbarkPassengers(2);
            bus.EmbarkPassengers(10);
            train.EmbarkPassengers(50);

            car.DisembarkPassengers(1);
            bus.DisembarkPassengers(7);
            train.DisembarkPassengers(30);
        }
    }
}