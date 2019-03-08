
namespace _05.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const double BaseToppingCalories = 2;
        private double weight;
        private string type;
        private Dictionary<string, double> validTypes;

        public Topping(string type, double weight)
        {
            this.validTypes = new Dictionary<string, double>();
            this.SeedTypes();
            this.Type = type;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            return BaseToppingCalories * this.Weight * this.validTypes[this.Type.ToLower()];
        }

        public string Type
        {
            get => type; 

            set
            {
                if (!this.validTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get => weight;
            
            set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1...50].");
                }
               this.weight = value;
            }
        }

        private void SeedTypes()
        {
            this.validTypes.Add("meat", 1.2);
            this.validTypes.Add("veggies", 0.8);
            this.validTypes.Add("cheese", 1.1);
            this.validTypes.Add("sauce", 0.9);
        }

    }
}
