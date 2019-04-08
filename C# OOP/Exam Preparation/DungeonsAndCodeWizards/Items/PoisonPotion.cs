
namespace DungeonsAndCodeWizards.Items
{
    using Characters;

    public class PoisonPotion : Item
    {
        private const int PoisonWeight = 5;

        public PoisonPotion() 
            : base(PoisonWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            EnsureIsAlive(character);
            character.Health -= 20;
        }
    }
}

