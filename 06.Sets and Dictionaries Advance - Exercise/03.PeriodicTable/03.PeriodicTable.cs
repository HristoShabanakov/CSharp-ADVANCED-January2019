using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> elements = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            foreach (var el in input)
            {
                elements.Add(el);
            }
        }

        Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
    }
}

