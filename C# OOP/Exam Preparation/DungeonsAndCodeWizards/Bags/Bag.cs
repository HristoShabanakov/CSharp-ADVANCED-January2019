namespace DungeonsAndCodeWizards.Bags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Bag
    {
        private List<Item> items;

        private const int BagCapacity = 100;

        protected Bag(int bagCapacity)
        {
            this.Capacity = BagCapacity;
            this.items = new List<Item>();
        }
        public int Capacity { get; private set; }

        public int Load
        {
            get => this.items.Sum(i => i.Weight);
        }

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public void AddItem(Item item)
        {
            
        }

        public Item GetItem(string name)
        {
            throw new InvalidOperationException("Bag is empty!");
        }

    }
}
