namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public int Count => this.gladiators.Count;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            //adds an gladiator to the arena.
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            //removes an gladiator by given name.
            int index = this.gladiators.FindIndex(g => g.Name == name);

            if (index != -1)
            {
                this.gladiators.RemoveAt(index);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            //returns the Gladiator which has the highest stat. 
            Gladiator gladiator = this.gladiators.OrderByDescending(g => g.GetStatPower()).First();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            //returns the Gladiator which poses the weapon with the highest power. 
            Gladiator gladiator = this.gladiators.OrderByDescending(g => g.GetWeaponPower()).First();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            //returns the Gladiator which has the highest total power.
            Gladiator gladiator = this.gladiators.OrderByDescending(g => g.GetStatPower()).First();

            return gladiator;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }

    }
}
