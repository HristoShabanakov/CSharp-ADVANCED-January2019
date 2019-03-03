using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int push = commands[0];
        int remove = commands[1];
        int search = commands[2];

        Queue<int> numbers = new Queue<int>();

        for (int i = 0; i < push; i++)
        {
            numbers.Enqueue(input[i]);
        }

        for (int i = 0; i < remove; i++)
        {
            numbers.Dequeue();
        }

        if (numbers.Contains(search))
        {
            Console.WriteLine("true");
        }
        else if (numbers.Count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine($"{numbers.Min()}");
        }

    }
}


