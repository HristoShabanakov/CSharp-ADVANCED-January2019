
namespace PersonsInfo
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Team team = new Team("Shabby");

            team.AddPlayer(new Person("Player1", "ATL", 5, 1000));
            team.AddPlayer(new Person("Player2", "STR", 50, 1000));
            team.AddPlayer(new Person("Player3", "DEF", 6, 1000));
            team.AddPlayer(new Person("Player4", "MID", 25, 1000));
            team.AddPlayer(new Person("Player5", "GOL", 76, 1000));

            var firstTeam = team.FirstTeam;
            var reserveTeam = team.ReserveTeam;

            Console.WriteLine(firstTeam.Count);
            Console.WriteLine(reserveTeam.Count);

        }
    }
}
