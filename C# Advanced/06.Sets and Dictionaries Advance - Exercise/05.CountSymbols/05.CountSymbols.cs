using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

        foreach (var symbol in input)
        {
            if (!symbolsCount.ContainsKey(symbol))
            {
                symbolsCount[symbol] = 0;
            }
            symbolsCount[symbol]++;
        }

        Console.WriteLine(string.Join(Environment.NewLine, symbolsCount
            .OrderBy(x => x.Key)
            .Select(x => $"{x.Key}: {x.Value} time/s")));

        //foreach (var kvp in symbolsCount)
        //{
        //  Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        //}
    }
}

