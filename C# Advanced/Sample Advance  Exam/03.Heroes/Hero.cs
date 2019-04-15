namespace Heroes
{
    using System;

    public class Hero
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public override string ToString()
        {
            return $"Hero: {Name} – {this.Level}lvl" + Environment.NewLine +
                $"Item:" + Environment.NewLine +
                $"  * Strength: {Item.Strength}" + Environment.NewLine +
                $"  * Ability: {Item.Ability}" + Environment.NewLine +
                $"  * Intelligence: {Item.Intelligence}";
        }
    }
}
