namespace StorageMaster.Models.Vehicles
{
    using StorageMaster.Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Vehicle
    {
        private int capacity;

        //In order to use IReadOnlyCollection you have to create a List.
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;

            //Initialize the List in which we are going to store products.
            this.trunk = new List<Product>();
        }
        public int Capacity { get; private set; }

        //To the real world will be exposed the List of Products as ReadOnly.
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        //Returns true if the sum of the products weights is equal to or larger than the vehicle capacity.
        //(calculated property)
        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        //Returns true if the vehicle doesn’t have any products in the trunk (calculated property).
        public bool IsEmpty => this.Trunk.Count == 0;


        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!.");
            }

            //Getting the last element of list.
            Product product = this.trunk[this.trunk.Count - 1];
            //Removing it from the list.
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }
    }
}
