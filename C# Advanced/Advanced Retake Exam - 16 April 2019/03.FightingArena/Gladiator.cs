namespace FightingArena
{
    using System;

    public class Gladiator
    {
        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }
        public int GetTotalPower()
        {
            int statSum = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            //return the sum of the stat properties plus the sum of the weapon properties.
            int weaponSum = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            int result = statSum + weaponSum;

            return result;
        }

        public int  GetWeaponPower()
        {
            //return the sum of the weapon properties.
            int weaponSum = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;

            return weaponSum;
        }

        public int GetStatPower()
        {
            //return the sum of the stat properties.
            int statSum = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return statSum;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.GetTotalPower()}]" + Environment.NewLine +
                $"  Weapon Power: [{this.GetWeaponPower()}]" + Environment.NewLine +
                $"  Stat Power: [{this.GetStatPower()}]";
        }
    }
}
