using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Common
{
    public static class ExceptionMessages
    {
        public const string InvalidUsername = "Player's username cannot be null or an empty string.";

        public const string InvalidUserHealth = "Player's health bonus cannot be less than zero.";

        public const string InvalidDamagePoints = "Damage points cannot be less than zero.";

        public const string InvalidCardName = "Card's name cannot be null or an empty string.";

        public const string InvalidCardDamagePoints = "Card's damage points cannot be less than zero.";

        public const string InvalidCardHealthPoints = "Card's HP cannot be less than zero.";

        public const string DeadPlayer = "Player is dead!";

        public const string NullCard = "Card cannot be null!";

        public const string CardAlreadyExists = "Card {0} already exists!";

        public const string NullPlayer = "Player cannot be null";

        public const string PlayerAlreadyExists = "Player {0} already exists!";
    }
}
