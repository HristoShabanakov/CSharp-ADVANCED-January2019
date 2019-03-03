using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input;
        Queue<string> list = new Queue<string>();
        while ((input = Console.ReadLine()) != "End")
        {
            if (input != "Paid")
            {
                list.Enqueue(input);

                continue;
            }

            while (list.Count > 0)
            {
               Console.WriteLine($"{list.Dequeue()}");
            }
        }
        Console.WriteLine($"{list.Count} people remaining.");
    }
}
