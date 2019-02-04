using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        Func<string, bool> findLength = x => x.Length <= length;
        //List<string> names = Console.ReadLine().Split().Where(x => x.Length <= n).ToList();

        Action<string> printNames = x => Console.WriteLine(x);
        //Console.WriteLine(string.Join("\n", names.Where(x => x.Length <= n)));

        Console.ReadLine()
            .Split()
            .Where(findLength)
            .ToList()
            .ForEach(printNames);
    }
}
