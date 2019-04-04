namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories.InputCommands
{
    using Contracts;

    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string output = this.UnitRepository.Statistics;
            return output;
        }
    }
}
