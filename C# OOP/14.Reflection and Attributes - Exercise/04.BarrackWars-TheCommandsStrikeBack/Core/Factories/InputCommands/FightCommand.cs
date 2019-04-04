namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories.InputCommands
{
    using System;
    using Contracts;

    public class FightCommand : Command
    {
        public FightCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
