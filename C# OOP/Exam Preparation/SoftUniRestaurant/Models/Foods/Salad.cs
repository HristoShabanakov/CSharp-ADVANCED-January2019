namespace SoftUniRestaurant.Models.Foods
{
    public class Salad : Food
    {
        private const int initialServingSize = 300;

        public Salad(string name, decimal price) 
            : base(name, initialServingSize, price)
        {
        }
        
    }
}
