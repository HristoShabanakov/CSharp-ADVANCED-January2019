using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var allChildren = Console.ReadLine().Split();
        Queue<string> children = new Queue<string>(allChildren);

        var number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (children.Count > 1)
        {
            var currentChild = children.Dequeue();

            if (counter % number != 0)
            {
                children.Enqueue(currentChild);
            }

            else
            {
                Console.WriteLine($"Removed {currentChild}");

            }
            counter++;
        }
        Console.WriteLine($"Last is {children.Dequeue()}");
    }
}

