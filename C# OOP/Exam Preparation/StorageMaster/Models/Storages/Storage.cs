namespace StorageMaster.Models.Storages
{
    using StorageMaster.Models.Products;
    using StorageMaster.Models.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Storage
    {
        private List<Product> products;

        private Vehicle[] garage;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.products = new List<Product>();
            //Initialize the array
            this.garage = new Vehicle[this.GarageSlots];

            this.FillGarageWithInitialVehicles(vehicles);
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        //Read‐only representation of the products in storage.
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        //Returns true if the sum of the products’ weights is equal to or larger than the storage capacity.
        //(calculated property
        public bool isFull
        {
            get { return this.Products.Sum(p => p.Weight) >= this.Capacity; }
        }

        //Read‐only representation of the garage array.
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);


        public Vehicle GetVehicle(int garageSlots)
        {
            return null;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            return 0;
        }

        public int UnloadVehicle(int garageSlot)
        {
            return 0;
        }

        //In order to fill in the IEnumerable Collection we need a method.
        private void FillGarageWithInitialVehicles(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index] = vehicle;
                index++;
            }
        }
    }
}
