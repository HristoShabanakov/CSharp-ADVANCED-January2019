using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var colorClothCount = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");

            string color = input[0];
            string[] clothes = input[1].Split(",");

            if (!colorClothCount.ContainsKey(color))
            {
                colorClothCount[color] = new Dictionary<string, int>();
            }

            for (int index = 0; index < clothes.Length; index++)
            {
                string cloth = clothes[index];

                if (!colorClothCount[color].ContainsKey(cloth))
                {
                    colorClothCount[color][cloth] = 0;
                }

                colorClothCount[color][cloth]++;
            }
        }

        string[] search = Console.ReadLine().Split();

        string colorToSearch = search[0];
        string clothToSearch = search[1];

        foreach (var kvp in colorClothCount)
        {
            string color = kvp.Key;
            var clothCount = kvp.Value;

            Console.WriteLine($"{color} clothes:");

            foreach (var kvpClothCount in clothCount)
            {
                string cloth = kvpClothCount.Key;
                int count = kvpClothCount.Value;

                if (color == colorToSearch && cloth == clothToSearch)
                {
                    Console.WriteLine($"* {cloth} - {count} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cloth} - {count}");
                }
            }
        }
    }
}

