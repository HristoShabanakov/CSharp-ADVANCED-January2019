
namespace _01.Logger.Layouts.Contracts
{
    using Loggers;
    using Appenders;
    using Appenders.Contracts;
    using Loggers.Contracts;
    using System;
    using Loggers.Enums;
    using Core.Contracts;
    using Core;

    public class Startup
    {
        public static void Main()
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
