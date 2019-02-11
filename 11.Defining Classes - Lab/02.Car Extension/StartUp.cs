using System;

namespace _02.Car_Extension
{
    class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "M3";
            car.Year = 2019;
            car.FuelConsumption = 20;
            car.FuelQuantity = 200;
            car.Drive(2000);

            Console.WriteLine(car.GetInformation());
        }
    }
}
