namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories.InputCommands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _04.BarrackWars_TheCommandsStrikeBack.Contracts;

    public class AddCommand : Command
    {
        public AddCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.UnitRepository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
