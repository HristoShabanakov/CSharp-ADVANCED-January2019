﻿namespace SoftUniRestaurant.Models.Foods
{
    public class Soup : Food
    {
        private const int initialServingSize = 245;

        public Soup(string name, decimal price) 
            : base(name, initialServingSize, price)
        {
        }
    }
}
