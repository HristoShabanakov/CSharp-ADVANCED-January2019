using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

        int divisibleNumber = int.Parse(Console.ReadLine());

        Func<int, bool> notDivisible = x => x % divisibleNumber != 0;

        numbers = numbers.Where(notDivisible).ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}

