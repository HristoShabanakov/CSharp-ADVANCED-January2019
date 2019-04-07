namespace DungeonsAndCodeWizards.Bags
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Backpack : Bag
    {
        private const int BackpackCapacity = 100;

        public Backpack() 
            : base(BackpackCapacity)
        {
        }
    }
}
