namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Fighter : BaseMachine, IFighter
    {
        private const int initialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.AggressiveMode = true;
            ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            this.AggressiveMode = !this.AggressiveMode;

            if (AggressiveMode == true)
            {
                AttackPoints += 50;
                DefensePoints -= 25;
            }
            else
            {
                AttackPoints -= 50;
                DefensePoints += 25;
            }
        }

        public override string ToString()
        {
            var status = this.AggressiveMode ? "ON" : "OFF";

            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($" *Aggresive: {status}");
            return result.ToString().TrimEnd();
        }
    }
}
