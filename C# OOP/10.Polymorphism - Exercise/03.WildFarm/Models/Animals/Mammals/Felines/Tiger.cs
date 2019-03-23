namespace _03.WildFarm.Models.Foods
{
    using System.Collections.Generic;

    public class Tiger : Feline
    {
        private const double GainValue = 1.0;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, GainValue);
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
