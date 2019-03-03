using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Func<int, int, bool> notDivisable = (x, y) => x % y != 0;
        Action<List<int>> printNumbers = x => Console.WriteLine(string.Join(" ",x));

        bool isValid = true;
        var result = new List<int>();

        for (int i = 1; i <=n; i++)
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                if (notDivisable(i, numbers[j]))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                result.Add(i);
            }

            isValid = true;
        }
        printNumbers(result);
    }
}

