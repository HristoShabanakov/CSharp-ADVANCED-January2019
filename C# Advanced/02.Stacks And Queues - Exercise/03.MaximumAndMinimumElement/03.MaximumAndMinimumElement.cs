using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int pushElement = 1;
        int deleteElement = 2;
        int printMaxValue = 3;
        int printMinValue = 4;

        Stack<int> numbers = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (queries[0] == pushElement)
            {
                int element = queries[1];
                numbers.Push(element);
            }
            else if (queries[0] == deleteElement)
            {
                numbers.Pop();
            }

            else if (queries[0] == printMaxValue)
            {
                Console.WriteLine($"{numbers.Max()}");
            }
            else if (queries[0] == printMinValue)
            {
                Console.WriteLine($"{numbers.Min()}");
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}

