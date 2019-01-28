using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> userNames = new HashSet<string>();
        //User followed by...
        var userFollowers = new Dictionary<string, HashSet<string>>();
        //User is following...
        var userFollwing = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Statistics")
            {
                break;
            }

            string[] splitetInput = input.Split();

            if (splitetInput.Length == 4)
            {
                string username = splitetInput[0];
                if(!userNames.Contains(username))
                {
                    userNames.Add(username);
                    userFollowers.Add(username, new HashSet<string>()); //same function two different syntax
                    userFollwing[username] = new HashSet<string>();
                }
            }

            else
            {
                string heFollows = splitetInput[0];
                string followed = splitetInput[2];

                //A vlogger can follow as many other vloggers as he wants, 
                //but he cannot follow himself or follow someone he is already a follower of.
                if (userNames.Contains(heFollows) &&
                    userNames.Contains(followed) &&
                    heFollows != followed)
                {
                    userFollowers[followed].Add(heFollows);
                    userFollwing[heFollows].Add(followed);
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {userNames.Count} vloggers in its logs.");

        var topUser = userFollowers
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => userFollwing[x.Key].Count())
            .FirstOrDefault();

        Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {userFollwing[topUser.Key].Count} following");

        foreach (var username in topUser.Value.OrderBy(x=>x))
        {
            Console.WriteLine($"*  {username}");
        }

        int count = 2;

        foreach (var kvp in userFollowers.Where(x=>x.Key != topUser.Key).OrderByDescending(x => x.Value.Count)
            .ThenBy(x => userFollwing[x.Key].Count()))
        {
            Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {userFollwing[kvp.Key].Count} following");
            count++;
        }
    }
}

