namespace SoftUniRestaurant.Models.Tables
{
    public class OutsideTable : Table
    {
        private const decimal initialPricePerPerson = 3.5m;

        public OutsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, initialPricePerPerson)
        {
        }
    }
}
