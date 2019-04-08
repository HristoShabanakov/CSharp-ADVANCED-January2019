namespace DungeonsAndCodeWizards
{
    using Characters;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Item
    {
        private int weight;

        public int Weight { get; private set; }

        protected Item(int weight)
        {
            this.Weight = weight;
        }

        //This method should be implemented in all classes, and in each class should have different functionality.
        //Therefore it must be an abstract. The method does not require a body.
        public abstract void AffectCharacter(Character character);
        
        //Only the inherited classes should know about this method
        protected void EnsureIsAlive(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!.");
            }
        }


    }
}
