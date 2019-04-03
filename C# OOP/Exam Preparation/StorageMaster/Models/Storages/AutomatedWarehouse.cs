namespace StorageMaster.Models.Storages
{
    using StorageMaster.Models.Vehicles;

    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;

        //It is not posible to instance an array with private const int [].
        //Has to be static with defaul set of vehicles.
        private static Vehicle[] DefaultVehicles = new Vehicle[]
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, AutomatedWarehouseCapacity, AutomatedWarehouseGarageSlots, DefaultVehicles)
        {
        }
    }
}
