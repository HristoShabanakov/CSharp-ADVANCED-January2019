namespace StorageMaster.Core
{
    using global::StorageMaster.Factories;
    using global::StorageMaster.Models.Products;
    using global::StorageMaster.Models.Storages;
    using global::StorageMaster.Models.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StorageMaster
    {
        //Initialize the Factory
        private Dictionary<string, Stack<Product>> products;
        private ProductFactory productFactory;

        private StorageFactory storageFactory;

        private Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;


        public StorageMaster()
        {
            this.products = new Dictionary<string, Stack<Product>>();
            this.storages = new Dictionary<string, Storage>();
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);
            if (!this.products.ContainsKey(type))
            {
                this.products.Add(type, new Stack<Product>());
            }
            products[type].Push(product);

            string result = $"Added {type} to pool";

            return result;
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = this.storageFactory.CreateStorage(type, name);
            this.storages.Add(name, storage);

            string result = $"Registered {name}";

            return result;
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];

            currentVehicle = storage.GetVehicle(garageSlot);

            string result = $"Selected {this.currentVehicle.GetType().Name}";

            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            foreach (string productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }
                //Its important to figure out the Dictionary<string,Stack> will be most suitable for this method.
                //The Stack allows us to Pop easily the last element of the collection.
                if (!this.products.ContainsKey(productName) ||
                    this.products[productName].Count == 0)
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }
                //the last product with that name in the pool is removed from the pool and loaded in the vehicle.
                Product product = this.products[productName].Pop();
                this.currentVehicle.LoadProduct(product);
                loadedProductsCount++;

                string result = $"Loaded {loadedProductsCount} / {productNames.Count()} products into {this.currentVehicle.GetType().Name} ";
                return result;

            }
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!this.storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (!this.storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage storageSource = this.storages[sourceName];
            Storage destinationStorage = this.storages[destinationName];
            Vehicle vehicle = storageSource.GetVehicle(sourceGarageSlot);

            int destinationGarageSlot = storageSource.SendVehicleTo(sourceGarageSlot, destinationStorage);

            string result = $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";

            return result;


        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            int countProductsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;
            int unloadedProductsCounter = storage.UnloadVehicle(garageSlot);

            string result = $"Unloaded {unloadedProductsCounter}/{countProductsInVehicle} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];
            Dictionary<string, int> productsAndCount = new Dictionary<string, int>();

            foreach (Product product in storage.Products)
            {
                string productTypeName = product.GetType().Name;

                if (!productsAndCount.ContainsKey(productTypeName))
                {
                    productsAndCount.Add(productTypeName, 1);
                }
                else
                {
                    productsAndCount[productTypeName]++;
                }
            }

            double productsSum = storage.Products.Sum(p => p.Weight);
            int storageCapacity = storage.Capacity;

            string[] productsAndString = productsAndCount.OrderByDescending(p => p.Value)
                 .ThenBy(p => p.Key)
                 .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                 .ToArray();

            string stockLine = $"Stock({productsSum}/{storageCapacity}): [{string.Join(", ", productsAndString)}]";
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}
