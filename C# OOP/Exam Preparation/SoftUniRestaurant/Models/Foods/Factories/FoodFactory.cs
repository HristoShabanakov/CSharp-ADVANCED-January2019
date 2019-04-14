using SoftUniRestaurant.Models.Foods.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace SoftUniRestaurant.Models.Foods.Factories
{
    public class FoodFactory
    {
        //From the input list get input format to create food.
        //Creating a factory using Reflection
        public IFood CreateFood(string foodType, string name, decimal price)
        {
            Type type = Assembly.
                GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == foodType);

            IFood food = (IFood)Activator.CreateInstance(type, name, price);

            return food;
        }
    }
}
