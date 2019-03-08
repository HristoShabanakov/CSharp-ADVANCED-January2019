namespace _05.PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => name; 
            set
            {
                if(value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols");
                }
                this.name = value;
            }
        }

        public int ToppingsCount => this.toppings.Count;

        public void AddTopping(Topping topping)
        {
            if (this.ToppingsCount == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0...10].");
            }
            this.toppings.Add(topping);
        }
        public double GetTotalCalories()
        {
            return dough.CalculateCalories() + this.toppings
                .Select(x=>x.CalculateCalories())
                .Sum();
        }
    }
}
