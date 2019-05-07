namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tank : BaseMachine, ITank
    {
        private const int initialHealthPoints = 100;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.DefenseMode = true;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (DefenseMode == true)
            {
                AttackPoints -= 40;
                DefensePoints += 30;
            }
            else
            {
                AttackPoints += 40;
                DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            var status = this.DefenseMode ? "ON" : "OFF";

            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($" *Defense: {status}");
            return result.ToString().TrimEnd();
        }
    }
}
