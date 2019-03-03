
namespace _04.HotelReservation
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Season season = Enum.Parse<Season>(input[2]);
            Discount discount = Discount.None;

            if(input.Length == 4)
            {
                discount = Enum.Parse<Discount>(input[3]);
            }

            var priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);
            Console.WriteLine(priceCalculator.CalculatePrice().ToString("f2"));
        }

    }
}
