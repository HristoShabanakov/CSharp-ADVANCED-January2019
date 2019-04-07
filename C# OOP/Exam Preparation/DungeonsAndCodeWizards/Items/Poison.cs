
namespace DungeonsAndCodeWizards.Items
{
    using Characters;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Poison : Item
    {
        private const int PoisonWeight = 5;

        public Poison() : base(PoisonWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAilve)
            {
                character.Health -= 20;

                if(character.Health < 0)
                {
                    //character.IsAilve = false;
                }
            }
        }
    }
}
