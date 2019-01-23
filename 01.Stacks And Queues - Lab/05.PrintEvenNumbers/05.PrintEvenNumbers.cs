using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> numbers = new Queue<int>(input);

        while (numbers.Count > 0)
        {
            if (numbers.Peek() % 2 != 0)
            {
                numbers.Dequeue();

                continue;
            }

            if (numbers.Count == 1)
            {
                Console.Write($"{numbers.Peek()}");

                numbers.Dequeue();

                continue;
            }

            Console.Write($"{numbers.Peek()},");

            numbers.Dequeue();
            
        }
    }
}

