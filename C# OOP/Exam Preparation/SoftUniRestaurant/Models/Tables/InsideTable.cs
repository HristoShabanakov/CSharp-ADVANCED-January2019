namespace SoftUniRestaurant.Models.Tables
{
    public class InsideTable : Table
    {
        private const decimal initialPricePerPerson = 2.5m;

        public InsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, initialPricePerPerson)
        {
        }
    }
}
