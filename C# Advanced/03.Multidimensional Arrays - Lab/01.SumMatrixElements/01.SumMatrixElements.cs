using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var dimensions = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = dimensions[0];
        int cols = dimensions[1];

        var matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            var currentRow = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }

        Console.WriteLine(rows);
        Console.WriteLine(cols);

        var sum = 0;

        foreach (var item in matrix)
        {
            sum += item;
        }
        Console.WriteLine(sum);
    }
}

