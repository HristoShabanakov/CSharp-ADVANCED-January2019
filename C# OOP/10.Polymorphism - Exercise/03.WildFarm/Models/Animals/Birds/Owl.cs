namespace _03.WildFarm.Models.Foods
{
    using System.Collections.Generic;

    public class Owl : Bird
    {
        private const double GainValue = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, GainValue);
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
