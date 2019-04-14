namespace SoftUniRestaurant.Models.Foods
{
    public class MainCourse : Food
    {
        private const int initialServingSize = 500;

        public MainCourse(string name, decimal price) 
            : base(name, initialServingSize, price)
        {
        }
    }
}
