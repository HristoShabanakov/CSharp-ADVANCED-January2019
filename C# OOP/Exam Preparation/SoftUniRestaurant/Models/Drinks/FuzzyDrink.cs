﻿namespace SoftUniRestaurant.Models.Drinks
{
    public class FuzzyDrink : Drink
    {
        private const decimal fuzzyDrinkPrice = 2.50m;

        public FuzzyDrink(string name, int servingSize,string brand) 
            : base(name, servingSize, fuzzyDrinkPrice, brand)
        {
        }
    }
}
