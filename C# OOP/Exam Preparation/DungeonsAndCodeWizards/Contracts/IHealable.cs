
namespace DungeonsAndCodeWizards.Contracts
{
    using Characters;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IHealable
    {
        void Heal(Character character);
    }
}
