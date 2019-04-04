namespace _04.BarrackWars_TheCommandsStrikeBack.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
