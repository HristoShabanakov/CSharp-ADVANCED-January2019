namespace _02.VehiclesExtension.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 1; i <= 3; i++)
            {
                string[] vehicleArgs = Console.ReadLine().Split();

                double fuelQuantity = double.Parse(vehicleArgs[1]);
                double fuelConsumption = double.Parse(vehicleArgs[2]);
                int tankCapacity = int.Parse(vehicleArgs[3]);

                Vehicle vehicle = null;

                if (i == 1)
                {
                    vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (i == 2)
                {
                    vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else
                {
                    vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }

                vehicles.Add(vehicle);
            }

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string commandType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);

                    Vehicle currentVehicle = vehicles.FirstOrDefault(x => x.GetType().Name == commandType);

                    Console.WriteLine(currentVehicle.Drive(distance));
                }

                else if (command == "Refuel")
                {
                    double fuelAmount = double.Parse(commandArgs[2]);
                    Vehicle currentVehicle = vehicles.FirstOrDefault(x => x.GetType().Name == commandType);

                    try
                    {
                        currentVehicle.Refuel(fuelAmount);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    double distance = double.Parse(commandArgs[2]);

                    Bus currentBus = (Bus)vehicles.FirstOrDefault(x => x.GetType().Name == commandType);

                    Console.WriteLine(currentBus.DriveEmpty(distance));
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
