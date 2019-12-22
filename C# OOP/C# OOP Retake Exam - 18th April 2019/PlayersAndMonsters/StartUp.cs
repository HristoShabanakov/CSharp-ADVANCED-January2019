namespace PlayersAndMonsters
{
    using Core;
    using Core.Contracts;
    using Core.Factories;
    using Core.Factories.Contracts;
    using Repositories;
    using Repositories.Contracts;
    using IO;
    using IO.Contracts;
    using Models.BattleFields;
    using Models.BattleFields.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPlayerFactory playerFactory = new PlayerFactory();
            IPlayerRepository playerRepository = new PlayerRepository();
            ICardRepository cardRepository = new CardRepository();
            ICardFactory cardFactory = new CardFactory();
            IBattleField battleField = new BattleField();

            IManagerController managerController = new ManagerController(
                playerFactory, playerRepository, 
                cardFactory, cardRepository,
                battleField);

            IEngine engine = new Engine(reader, writer, managerController);
            engine.Run();
        }
    }
}