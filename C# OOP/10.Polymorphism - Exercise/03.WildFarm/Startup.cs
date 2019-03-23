
namespace _03.WildFarm.Models.Foods
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Animal> animals = new List<Animal>();

           

            while (input != "End")
            {
                string[] animalArgs = input.Split();

                Animal animal = AnimalFactory.Create(animalArgs);

                string[] foodArgs = Console.ReadLine().Split();

                Food food = FoodFactory.Create(foodArgs);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                input = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
