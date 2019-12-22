using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController managerController;

        public Engine(IReader reader, IWriter writer, IManagerController managerController)
        {
            this.reader = reader;
            this.writer = writer;
            this.managerController = managerController;
        }
        public void Run()
        {
            while (true)
            {
                string line = this.reader.ReadLine();

                if (line == "Exit")
                {
                    break;
                }

                string[] lineParts = line.Split();
                string command = lineParts[0];
                string result = string.Empty;

                string cardName;
                switch (command)
                {
                    case "AddPlayer":
                        string playerType = lineParts[1];
                        string playerUsername = lineParts[2];

                        result = this.managerController.AddPlayer(playerType, playerUsername); 
                        break;
                    case "AddCard":
                        string cardType = lineParts[1];
                        cardName = lineParts[2];

                        result = this.managerController.AddCard(cardType, cardName);
                        break;
                    case "AddPlayerCard":
                        string username = lineParts[1];
                        cardName = lineParts[2];

                        result = this.managerController.AddPlayerCard(username, cardName);
                        break;
                    case "Fight":
                        string attackUsername = lineParts[1];
                        string enemyUsername = lineParts[2];

                        result = this.managerController.Fight(attackUsername, enemyUsername);
                        break;
                    case "Report":
                        result = this.managerController.Report();
                        break;
                }

                this.writer.WriteLine(result);
            }
            
        }
    }
}
