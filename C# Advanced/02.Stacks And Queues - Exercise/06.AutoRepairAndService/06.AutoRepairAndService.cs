using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] cars = Console.ReadLine().Split();

        string input;

        Queue<string> vehicles = new Queue<string>(cars);
        Stack<string> servedVehicles = new Stack<string>();

        while ((input = Console.ReadLine()) != "End")
        {
            string[] commands = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (commands[0] == "Service")
            {
                Console.WriteLine($"Vehicle {vehicles.Peek()} got served.");
                string car = vehicles.Peek();
                vehicles.Dequeue();
                servedVehicles.Push(car);

            }
            else if (commands[0] == "CarInfo")
            {
                string currentCar = commands[1];
                if (!vehicles.Contains(currentCar))
                {
                    Console.WriteLine("Served.");
                }
                else
                {
                    Console.WriteLine("Still waiting for service.");
                }
            }
            else if (commands[0] == "History")
            {

                Console.WriteLine(string.Join(", ", servedVehicles));
            }
        }

        if (vehicles.Any())
        {
            Console.WriteLine($"Vehicles for service: {string.Join(", ", vehicles)}");
        }
        Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");

    }
}

