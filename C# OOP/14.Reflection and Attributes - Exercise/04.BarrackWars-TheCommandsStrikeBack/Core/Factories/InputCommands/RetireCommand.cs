namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories.InputCommands
{
    using Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.UnitRepository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
