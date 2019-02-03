using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split().ToList();

        Func<string, string> format = x => $"{x}";

        Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(format)));

        print(names);
    }
}

