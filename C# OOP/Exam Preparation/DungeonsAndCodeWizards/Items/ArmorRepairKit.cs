namespace DungeonsAndCodeWizards.Items
{
    using Characters;

    public class ArmorRepairKit : Item
    {
        private const int ArmorRepairKitWeight = 10;

        public ArmorRepairKit() 
            : base(ArmorRepairKitWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            EnsureIsAlive(character);
            //The character’s armor restored up to the base armor value.
            character.Armor = character.BaseArmor;
        }
    }
}
