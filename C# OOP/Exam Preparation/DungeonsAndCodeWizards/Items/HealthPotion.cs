namespace DungeonsAndCodeWizards.Items
{
    using Characters;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HealthPotion : Item
    {
        private const int HealthPotionWeight = 5;

        public HealthPotion() : base(HealthPotionWeight)
        {
        }
        

        public override void AffectCharacter(Character character)
        {
            if (character.IsAilve)
            {
                character.Health += 20;
            }

        }
    }
}
