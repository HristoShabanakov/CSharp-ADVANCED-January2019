namespace _05.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const double BaseDoughCalories = 2;
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private Dictionary<string, double> validFlourTypes;
        private Dictionary<string, double> validBakingTechniques;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.validBakingTechniques = new Dictionary<string, double>();
            this.validFlourTypes = new Dictionary<string, double>();
            this.SeedFlourTypes();
            this.SeedBakingTechniques();
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!validFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (!validBakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1...200].");
                }
                this.weight = value;
            }
        }
        public double CalculateCalories()
        {
            return BaseDoughCalories * this.Weight * this.validFlourTypes[this.FlourType] *
                this.validBakingTechniques[this.BakingTechnique];
        }

        private void SeedFlourTypes()
        {
            this.validFlourTypes.Add("white", 1.5);
            this.validFlourTypes.Add("wholegrain", 1.0);
        }

        private void SeedBakingTechniques()
        {
            this.validBakingTechniques.Add("crispy", 0.9);
            this.validBakingTechniques.Add("chewy", 1.1);
            this.validBakingTechniques.Add("homemade", 1.0);
        }
    }
}
