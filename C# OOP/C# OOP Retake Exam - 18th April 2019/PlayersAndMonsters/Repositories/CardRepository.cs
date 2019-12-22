using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private IDictionary<string, ICard> cardsByName;

        public CardRepository()
        {
            this.cardsByName = new Dictionary<string, ICard>();
        }

        public int Count => this.cardsByName.Count;

        public IReadOnlyCollection<ICard> Cards => this.cardsByName.Values.ToList(); // working with dictionary.

        public void Add(ICard card)
        {
            ThrowIfCardIsNull(card, ExceptionMessages.NullCard);

            if (this.cardsByName.ContainsKey(card.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CardAlreadyExists,card.Name));
            }

            this.cardsByName.Add(card.Name, card);
        }

        public ICard Find(string name)
        {
            ICard card = null;

            //If there is a card it will change null with card's value.

            if (this.cardsByName.ContainsKey(name))
            {
                card = this.cardsByName[name];
            }

            return card;
        }

        public bool Remove(ICard card)
        {
            ThrowIfCardIsNull(card,ExceptionMessages.NullCard);

            bool hasRemoved = this.cardsByName.Remove(card.Name); // remove method in dictionary returns bool.

            return hasRemoved;
        }

        private static void ThrowIfCardIsNull(ICard card, string message)
        {
            if (card == null)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
