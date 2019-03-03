using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Func<List<int>, int> smallest = x => x.Min();
        
        Console.WriteLine(smallest(numbers));
    }
}

