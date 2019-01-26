using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        int[] orderQueries = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int food = 0;

        Queue<int> orders = new Queue<int>(orderQueries);

        Console.WriteLine($"{orders.Max()}");

        while (orders.Any())
        {
            if (food + orders.Peek() <= foodQuantity)
            {
                food += orders.Dequeue();
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(' ', orders)}");
                break;
            }

        }
        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
    }
}

