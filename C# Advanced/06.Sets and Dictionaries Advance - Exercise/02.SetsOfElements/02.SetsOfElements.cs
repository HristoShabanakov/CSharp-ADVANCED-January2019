using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        HashSet<int> numbersFromN = new HashSet<int>();
        HashSet<int> numbersFromM = new HashSet<int>();

        int n = input[0];
        int m = input[1];

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbersFromN.Add(numbers);
        }

        for (int i = 0; i < m; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbersFromM.Add(numbers);
        }

        Console.WriteLine(string.Join(" ", numbersFromN.Intersect(numbersFromM)));
    }
}   

