namespace SoftUniRestaurant.Models.Tables
{
    using SoftUniRestaurant.Models.Drinks.Contracts;
    using SoftUniRestaurant.Models.Foods.Contracts;
    using SoftUniRestaurant.Models.Tables.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;
        private int tableNumber;
        private decimal pricePerPerson;

        protected Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = this.capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public ICollection<IFood> Foods => throw new NotImplementedException();

        public ICollection<IDrink> Drinks => throw new NotImplementedException();

        public int TableNumber { get ; set ; }

        public int Capacity
        {
            get => this.capacity;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => this.numberOfPeople;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                this.numberOfPeople = value;
            }

        }

        public decimal PricePerPerson { get ; set; }

        public bool IsReserved { get; set; }

        public decimal Price { get => this.PricePerPerson * NumberOfPeople;}

        public void Reserve(int numberOfPeople)
        {
            //Reserves the table with the count of people given. 
        }

        public void OrderFood(IFood food)
        {
            //Orders the provided food (think of a way to collect all the food which is ordered). 
        }

        public void OrderDrink(IDrink drink)
        {
            //Orders the provided drink (think of a way to collect all the drinks which are ordered). 
        }

        public decimal GetBill()
        {
            //Returns the bill for all of the ordered drinks and food. 
            return 10;
        }

        public void Clear()
        {
            //Removes all of the ordered drinks and food and finally frees the table and sets the count of people to 0. 
        }

        public string GetOccupiedTableInfo()
        {
            return $"Table: {this.TableNumber}";
        }

    }
}
