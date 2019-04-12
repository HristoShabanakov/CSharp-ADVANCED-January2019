namespace SoftUniRestaurant.Models.Drinks
{
    public class Water : Drink
    {
        private const decimal waterPrice = 1.50m;

        public Water(string name, int servingSize, string brand) 
            : base(name, servingSize, waterPrice, brand)
        {
        }
    }
}
