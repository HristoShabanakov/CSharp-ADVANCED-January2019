namespace _04.BarrackWars_TheCommandsStrikeBack.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
