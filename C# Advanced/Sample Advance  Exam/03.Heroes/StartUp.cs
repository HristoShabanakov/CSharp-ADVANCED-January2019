using System;

namespace Heroes
{
    public class StartUp
    {
        public static void Main()
        {
            HeroRepository repository = new HeroRepository();

            Item item = new Item(23, 35, 48);

            Console.WriteLine(item);

            Hero hero = new Hero("Hero Name", 24, item);

            Console.WriteLine(hero);

            repository.Remove("Hero Name");

            Hero heroStrength = repository.GetHeroWithHighestStrength();
            Hero heroAbility = repository.GetHeroWithHighestAbility();
            Hero heroIntelligence = repository.GetHeroWithHighestIntelligence();

            Console.WriteLine(repository.Count);

            Console.WriteLine(repository);
        }
    }
}
