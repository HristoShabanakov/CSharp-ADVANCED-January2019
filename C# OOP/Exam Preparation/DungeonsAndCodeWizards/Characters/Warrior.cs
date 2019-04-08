using System;
using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Contracts;

namespace DungeonsAndCodeWizards.Characters
{
    public class Warrior : Character, IAttackable
    {
        //Warrior class always has 100 Base Health, 50 Base Armor, 40 Ability Points, and a Satchel as a bag.
        private const double baseHealth = 100;
        private const double baseArmor = 50;
        private const double abilityPoints = 40;
        
        public Warrior(string name, Faction faction) 
            : base(name, baseHealth, baseArmor, abilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            EnsureBothCharactersAreAlive(character);
            //If the character they are trying to attack is the same character.
            if (this.Name == character.Name)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if(this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }

            character.TakeDamage(abilityPoints);
        }
    }
}
