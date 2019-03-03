using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int pumpsCount = int.Parse(Console.ReadLine());

        Queue<int> difference = new Queue<int>();

        for (int i = 0; i < pumpsCount; i++)
        {
            int[] pumpProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Add the difference between two pumps in the Queue
            difference.Enqueue(pumpProps[0] - pumpProps[1]);
        }
        int index = 0;

        while (true)
        {
            Queue<int> copyDifference = new Queue<int>(difference);
            int fuel = -1;
            

            while (copyDifference.Any())
            {
                if (copyDifference.Peek() > 0 && fuel == -1)
                {
                    fuel = copyDifference.Dequeue();
                    difference.Enqueue(difference.Dequeue());
                }
                else if (copyDifference.Peek() < 0 && fuel == -1)
                {
                    copyDifference.Enqueue(copyDifference.Dequeue());
                    difference.Enqueue(difference.Dequeue());
                    index++;
                }
                else
                {
                    fuel += copyDifference.Dequeue();
                    if (fuel < 0)
                    {
                        
                        break;
                    }
                }
            }
            if (fuel >= 0)
            {
                Console.WriteLine(index);
                return;
            }
            index++;
        }
    }
}

