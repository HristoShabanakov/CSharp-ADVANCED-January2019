

namespace _04.HotelReservation
{
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private Discount discount;

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discount = discount;
        }
        public decimal CalculatePrice()
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100;

            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal discountedAmount = priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
    public enum Season
    {
        Autumn = 1,
        Spring = 2,
        Winter = 3,
        Summer = 4
    }

    public enum Discount
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }
}
