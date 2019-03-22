

namespace _01.Vehicles.Models
{
    using System;
    public class Startup
    {
        static void Main()
        {
            string[] carArgs = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carArgs[1]);
            double carFuelConsumption = double.Parse(carArgs[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckArgs = Console.ReadLine().Split();

            double truckFuelQuantity = double.Parse(truckArgs[1]);
            double truckFuelConsumption = double.Parse(truckArgs[2]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string commandType = commandArgs[1];

                if(command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);

                    if (commandType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }

                else
                {
                    double fuelAmount = double.Parse(commandArgs[2]);

                    if (commandType == "Car")
                    {
                      car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
