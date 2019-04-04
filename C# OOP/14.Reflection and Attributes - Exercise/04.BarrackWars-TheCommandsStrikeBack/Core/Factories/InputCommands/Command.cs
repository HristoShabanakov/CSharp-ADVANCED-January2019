namespace _04.BarrackWars_TheCommandsStrikeBack.Core.Factories.InputCommands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IUnitFactory unitFactory;
        private IRepository unitRepository;

        protected Command(string[] data, IUnitFactory unitFactory, IRepository unitRepository)
        {
            this.data = data;
            this.unitFactory = unitFactory;
            this.unitRepository = unitRepository;
        }

        protected string[] Data => this.data;

        protected IUnitFactory UnitFactory => this.unitFactory;

        protected IRepository UnitRepository => this.unitRepository;

        public abstract string Execute();
    }
}
