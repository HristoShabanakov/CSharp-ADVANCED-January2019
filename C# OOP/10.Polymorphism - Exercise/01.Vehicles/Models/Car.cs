
namespace _01.Vehicles.Models
{
   public  class Car : Vehicle
    {
        private const double airConditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            :base(fuelQuantity,fuelConsumption + airConditionConsumption)
        {
        }
    }
}
