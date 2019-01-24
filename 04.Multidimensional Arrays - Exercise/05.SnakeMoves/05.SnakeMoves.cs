using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine()
           .Split(' ', StringSplitOptions
           .RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

        int rows = dimensions[0];
        int cols = dimensions[1];

        char[][] matrix = new char[rows][];

        var snakeStr = Console.ReadLine().ToCharArray();

        Queue<char> snakeQueue = new Queue<char>(snakeStr);

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new char[cols];
            for (int col = 0; col < cols; col++)
            {
                char charToAdd = snakeQueue.Dequeue();
                matrix[row][col] = charToAdd;
                snakeQueue.Enqueue(charToAdd);
            }
        }

        Console.WriteLine(String.Join(Environment.NewLine, matrix
                .Select(r => String.Join(" ", r))));
    }
}

