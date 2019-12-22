namespace PlayersAndMonsters.Models.Cards
{
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using System;

    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;


        protected Card(string name, int damagePoints, int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }
        public string Name
        {
            get => this.name;

            private set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, ExceptionMessages.InvalidCardName);

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get => this.damagePoints;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }
                this.damagePoints = value;
            }
        }

        public int HealthPoints
        {
            get => this.healthPoints;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }
                this.healthPoints = value;
            }
        }

        public override string ToString()
        {
            return string.Format(ConstantMessages.CardReportInfo,
                this.Name,
                this.DamagePoints);
        }
    }
}
