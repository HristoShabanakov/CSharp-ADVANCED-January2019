
namespace DungeonsAndCodeWizards.Core
{
    using DungeonsAndCodeWizards.Characters;
    using DungeonsAndCodeWizards.Items;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class DungeonMaster
    {
        private List<Character> characters;
        private Stack<Item> items;

        public DungeonMaster()
        {
            this.characters = new List<Character>();
            this.items = new Stack<Item>();
        }
        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];

            if (!Enum.TryParse(faction, out Faction factionResult))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }

            Character character;

            if (characterType == "Warrior")
            {
                character = new Warrior(name, factionResult);
            }
            else if (characterType == "Cleric")
            {
                character = new Cleric(name, factionResult);
            }
            else
            {
                throw new ArgumentException($"Invalid character type \"{characterType }\"!");
            }
            this.characters.Add(character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];

            Item item;

            switch (itemName)
            {
                case "ArmorRepairKit":
                    item = new ArmorRepairKit();
                    break;
                case "HealthPotion":
                    item = new HealthPotion();
                    break;
                case "PoisionPotion":
                    item = new PoisonPotion();
                    break;
                default:
                    throw new ArgumentException($"Invalid item \"{itemName}\"!");
            }
            this.items.Push(item);

            return $"{itemName} added to pool";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character = GetCharacter(characterName);

            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            var item = this.items.Pop();
            character.Bag.AddItem(item);

            return $"{characterName} picked up {item.GetType().Name}!";


        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            var character = GetCharacter(characterName);
            //Get the item from character's bag.
            var item = character.Bag.GetItem(itemName);
            //Use the item on the character.
            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            var giver = GetCharacter(giverName);
            var receiver = GetCharacter(receiverName);

            var item = giver.Bag.GetItem(itemName);
            giver.UseItemOn(item, receiver);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            var giver = GetCharacter(giverName);
            var receiver = GetCharacter(receiverName);

            var giverItem = giver.Bag.GetItem(itemName);

            receiver.ReceiveItem(giverItem);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in characters.OrderByDescending(x => x.IsAlive).ThenBy(x => x.Health))
            {
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, " +
                    $"Status: {(character.IsAlive ? "Alive" : "Dead")}");
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string attackerName = args[0];
            string receiverName = args[1];

            var attacker = GetCharacter(attackerName);
            var receiver = GetCharacter(receiverName);

            if (attacker is Cleric)
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            ((Warrior)attacker).Attack(receiver);

            sb.AppendLine(string.Format("{0} attacks {1} for {2} hit points! " +
                "{1} has {3}/{4} HP and " +
                "{5}/{6} AP left!", attacker.Name, receiver.Name, attacker.AbilityPoints,
                receiver.Health, receiver.BaseHealth, receiver.Armor, receiver.BaseArmor));

            if (!receiver.IsAlive)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            var healer = GetCharacter(healerName);
            var receiver = GetCharacter(healingReceiverName);

            if(healer is Warrior)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            ((Cleric)healer).Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in characters.Where(x => x.IsAlive))
            {
                sb.AppendLine($"{character.Name} rests ({character.Health} => {currentHealth})");
            }
            throw new NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }

        private Character GetCharacter(string characterName)
        {
            //Check if the character exists in the party.
            var character = this.characters.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            return character;
        }
    }
}
