namespace PlayersAndMonsters.Models.Cards.Contracts
{
    public interface ICard
    {
        string Name { get; } // no set in the abstract class the setter has to be private or change it later if its needed.

        int DamagePoints { get; set; } // if there is set the implementation in the abstract class has to be always public.

        int HealthPoints { get; }
    }
}
