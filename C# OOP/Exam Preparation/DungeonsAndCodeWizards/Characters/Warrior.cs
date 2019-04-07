using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Bags;

namespace DungeonsAndCodeWizards.Characters
{
    public class Warrior : Character
    {
        public Warrior(string name, double health, double armor, double abilityPoints, Bag bag) : base(name, health, armor, abilityPoints, bag)
        {
        }
        

        public void Attack(Character character)
        {

        }
    }
}
