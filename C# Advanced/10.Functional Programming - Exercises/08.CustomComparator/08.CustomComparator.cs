using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);

        Action<int[], int[]> print = (x, y) => Console.WriteLine($"{ string.Join(" ", x)} { string.Join(" ", y)}");

        int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
        int[] oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();

        Array.Sort(evenNumbers, new Comparison<int>(sortFunc));
        Array.Sort(oddNumbers, new Comparison<int>(sortFunc));

        print(evenNumbers, oddNumbers);
    }
}

