namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pilot : IPilot
    {
        private string name;

        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                }
                this.name = value;
            }
        }

        private IList<IMachine> Machines;


        public void AddMachine(IMachine machine)
        {
           if(machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }

            this.Machines.Add(machine);
        }

        public string Report()
        {
            var report = new StringBuilder();
            report.AppendLine($"{this.Name} - {this.Machines.Count} machines");
            foreach (var machine in this.Machines)
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
