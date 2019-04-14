namespace SoftUniRestaurant.Models.Foods
{
    public class Dessert : Food
    {
        private const int initialServingSize = 200;

        public Dessert(string name, decimal price) 
            : base(name, initialServingSize, price)
        {
        }
    }
}
