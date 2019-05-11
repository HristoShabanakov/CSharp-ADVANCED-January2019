namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Models;
    using System.Collections.Generic;

    public class MachinesManager : IMachinesManager
    {
        private IDictionary<string, IPilot> pilots;
        private IDictionary<string, IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new Dictionary<string, IPilot>();
            this.machines = new Dictionary<string, IMachine>();
        }
        public string HirePilot(string name)
        {
            if (this.pilots.ContainsKey(name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            var pilot = new Pilot(name);
            this.pilots.Add(name, pilot);
            return string.Format(OutputMessages.PilotHired, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.ContainsKey(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            var tank = new Tank(name, attackPoints, defensePoints);
            this.machines.Add(name, tank);
            return string.Format(OutputMessages.TankManufactured, name, tank.AttackPoints, tank.DefensePoints);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.ContainsKey(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            var fighter = new Fighter(name, attackPoints, defensePoints);
            this.machines.Add(name, fighter);
            return string.Format(OutputMessages.FighterManufactured, name, fighter.AttackPoints, fighter.DefensePoints, "ON");
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!this.pilots.ContainsKey(selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            if (!this.machines.ContainsKey(selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            if(this.machines[selectedMachineName].Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            this.machines[selectedMachineName].Pilot = this.pilots[selectedPilotName];
            this.pilots[selectedPilotName].AddMachine(this.machines[selectedMachineName]);
            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!this.machines.ContainsKey(attackingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }

            if (!this.machines.ContainsKey(defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            var attackingMachine = this.machines[attackingMachineName];
            var defendingMachine = this.machines[defendingMachineName];

            if(attackingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }

            if(defendingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attackingMachine.Attack(defendingMachine);
            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            if (!this.pilots.ContainsKey(pilotReporting))
            {
                return string.Format(OutputMessages.PilotNotFound, pilotReporting);
            }

            return this.pilots[pilotReporting].Report();
        }

        public string MachineReport(string machineName)
        {
            if (!this.machines.ContainsKey(machineName))
            {
                return string.Format(OutputMessages.MachineNotFound, machineName);
            }

            return this.machines[machineName].ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (this.machines.ContainsKey(fighterName))
            {
                if(this.machines[fighterName] is Fighter fighter)
                {
                    fighter.ToggleAggressiveMode();
                    return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
                }
            }
            return string.Format(OutputMessages.MachineNotFound, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (this.machines.ContainsKey(tankName))
            {
                if(this.machines[tankName] is Tank tank)
                {
                    tank.ToggleDefenseMode();
                    return string.Format(OutputMessages.TankOperationSuccessful, tankName);
                }
            }
            return string.Format(OutputMessages.MachineNotFound, tankName);
        }
    }
}