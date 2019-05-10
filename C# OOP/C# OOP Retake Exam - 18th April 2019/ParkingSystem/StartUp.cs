using System;

namespace ParkingSystem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoftPark softPark = new SoftPark();

            Car car = new Car("BMW", "123");

            string parkSpot = "A3";
            string parkSpot2 = "B1";

            //Car car2 = new Car("M1", "124");

            //softPark.ParkCar(parkSpot,car);
            //softPark.ParkCar(parkSpot2,car);

            softPark.ParkCar(parkSpot, car);
            softPark.ParkCar(parkSpot2, car);
            

        }
    }
}
