

namespace DefiningClasses
{
    using System.Collections.Generic;

    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            //Every Trainer starts with 0 badges.
            this.BadgesCount = 0;
            //Every Trainer has a list of Pokemons
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }

        public int BadgesCount { get; set; }

        //Collection of pokemon
        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.Pokemons.Count}";
        }
    }
}
