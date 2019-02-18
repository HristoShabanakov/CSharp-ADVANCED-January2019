using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] leftSocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] rightSocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int pairOfSocks = 0;

        Stack<int> leftGivenSocks = new Stack<int>(leftSocks);
        Queue<int> rightGivenSocks = new Queue<int>(rightSocks);
        Queue<int> createdPair = new Queue<int>();

        while (leftGivenSocks.Any() && rightGivenSocks.Any())
        {
            
            int firstSock = leftGivenSocks.Peek();
            int secondSock = rightGivenSocks.Peek();

            if (firstSock == secondSock)
            {
                rightGivenSocks.Dequeue();
                firstSock++;
                leftGivenSocks.Pop();
                leftGivenSocks.Push(firstSock);
                leftGivenSocks.Reverse();
            }
            else if(secondSock > firstSock)
            {
                leftGivenSocks.Pop();
            }
            else if(firstSock > secondSock)
            {
                pairOfSocks = firstSock + secondSock;
                createdPair.Enqueue(pairOfSocks);
                leftGivenSocks.Pop();
                rightGivenSocks.Dequeue();
            }
        }
        Console.WriteLine($"{createdPair.Max()}");
        Console.WriteLine(string.Join(" ", createdPair));
    }
}

