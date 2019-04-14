using SoftUniRestaurant.Models.Foods.Contracts;
using System;

namespace SoftUniRestaurant.Models.Foods
{
    public abstract class Food : IFood
    {
        private string name;
        private int servingSize;
        private decimal price;

        

        protected Food(string name, int servingSize, decimal price)
        {
            this.Name = name;
            this.ServingSize = servingSize;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            //Always put them private, and then if its needed change the Access Modifier.
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }
                this.name = value;
            }
        }

        public int ServingSize
        {
            get => this.servingSize;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Serving size cannot be less or equal to zero");
                }
                this.servingSize = value;
            }
        }

        public decimal Price
        {
            get => this.price;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{name}: {servingSize}g - {price:f2}";
        }
    }
}
