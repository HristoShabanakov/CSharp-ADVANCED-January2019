namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        protected Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = this.CardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; private set; }

        public string Username
        {
            get => this.username;

            private set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, ExceptionMessages.InvalidUsername);

                this.username = value;
            }
        }

        public int Health
        {
            get => this.health;

             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }
                this.health = value;
            }
        }

        public bool IsDead => this.Health <= 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }
            
            //this.Health = Math.Max(this.Health - damagePoints, 0);
            this.health -= damagePoints;
        }

        public override string ToString()
        {
            return string.Format(ConstantMessages.PlayerReportInfo,
                this.Username,
                this.Health,
                this.CardRepository.Count);
        }
    }
}
