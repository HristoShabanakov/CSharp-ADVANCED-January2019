
namespace DungeonsAndCodeWizards.Characters
{
    using Bags;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Character
    {
        private const double defaultRestHealMultiplier = 0.2;
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private Faction faction;
        private bool isAlive;
        private double restHealMultiplier;

        public Character()
        {
            //Set them with the constructor, because both of them have default values.
            this.IsAlive = true;
            this.RestHealMultiplier = defaultRestHealMultiplier;
        }

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {

        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                this.name = value;
            }
        }

        public double BaseHealth { get; private set; }

        public double Health
        {
            get => this.health;

            set
            {
                if (value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                }
                else if (value <= 0)
                {
                    this.health = 0;
                    this.IsAlive = false;
                }
                else
                {
                    this.health = value;
                }
            }

        }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get => this.armor;

            set
            {
                if (value > this.BaseArmor)
                {
                    this.armor = this.BaseArmor;
                }
                else if (value < 0)
                {
                    this.armor = 0;
                }
                else
                {
                    this.armor = value;
                }
            }

        }

        public double AbilityPoints { get; private set; }

        public Bag Bag
        {
            get => this.bag;

            private set
            {
                this.bag = value;
            }

        }

        public Faction Faction
        {
            get => this.faction;
            private set
            {
                this.faction = value;
            }

        }


        public bool IsAlive { get; set; }

        //Could be overriden - it has to be virtual
        public virtual double RestHealMultiplier { get; private set; }

        public void TakeDamage(double hitPoints)
        {
            EnsureIsAlive();

            if (this.Armor - hitPoints >= 0)
            {
                this.Armor -= hitPoints;
            }
            else
            {
                var remainder = hitPoints - this.Armor;
                this.Armor = 0;
                this.Health -= remainder;
            }
        }

        public void Rest()
        {
            EnsureIsAlive();

            this.Health += this.baseHealth + this.RestHealMultiplier;

            //var increaseHealth = this.Health + (this.BaseHealth * this.RestHealMultiplier);
            //this.Health = increaseHealth;
        }


        //The item affects the character with the item effect.
        public void UseItem(Item item)
        {
            EnsureIsAlive();
            //Using the key word this to take the character.
            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {

        }

        public void GiveCharacterItem(Item item, Character character)
        {

        }

        public void ReceiveItem(Item item)
        {

        }

        private void EnsureIsAlive()
        {
            if (!this.isAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
