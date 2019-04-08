namespace DungeonsAndCodeWizards.Bags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Bag
    {
        private int capacity;
        private List<Item> items;
        //Default value: 100.
        private const int DefaultCapacity = 100;

        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        protected Bag()
        {
            this.Capacity = DefaultCapacity;
            this.items = new List<Item>();
        }
        public int Capacity { get; private set; }

        //Read‐only collection of type Item.
        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        //Calculated property. The sum of the weights of the items in the bag.
        public int Load => this.Items.Sum(i => i.Weight);
        

        public void AddItem(Item item)
        {
            //If the current load +the weight of the item attempted to be added is greater than the bag’s capacity.
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            //If no items exist in the bag
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            //If an item with that name doesn’t exist in the bag.
            var itemName = this.items.FirstOrDefault(x => x.GetType().Name == name);

            if(itemName == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            //If both checks pass, the item is removed from the bag and returned to the caller.
            this.items.Remove(itemName);

            return itemName;
        }

    }
}
