namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> heroes;
        

        public int Count => this.heroes.Count;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

       public void Remove(string name)
       {
            //Removes an entity by given hero name. Getting the index from collection as int.
            int index = this.heroes.FindIndex(h => h.Name == name);

            if(index != -1)
            {
                this.heroes.RemoveAt(index);
            }
       }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.heroes.OrderByDescending(h => h.Item.Strength).First();

            return hero;
        }
        //Returns the Hero which poses the item with the highest ability. 
        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.heroes.OrderByDescending(h => h.Item.Ability).First();
            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.heroes.OrderByDescending(h => h.Item.Intelligence).First();
            return hero;
        }

        //Print all the heroes. 
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var hero in heroes)
            {
                stringBuilder.Append($"{hero.ToString()}");
            }

            return stringBuilder.ToString();
        }


    }
}
