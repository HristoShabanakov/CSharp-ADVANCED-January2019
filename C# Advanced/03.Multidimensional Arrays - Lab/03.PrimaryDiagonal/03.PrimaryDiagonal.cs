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
        int maxSum = int.MinValue;
        int maxRowIndex = 0;
        int maxCollIndex = 0;
        //In order to prevent getting out from the matrix loop to -1
        //start=>|7,1,3,2,1
        //1,3,5,7|<=end,5
        //5,6,2,4,8
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                var currentSum = matrix[row, col] //calculate the sum of the current cell
                    + matrix[row, col + 1]  //going one cell right
                    + matrix[row + 1, col] // going one cell down
                    + matrix[row + 1, col + 1]; // going one cell down/diagonal

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRowIndex = row;
                    maxCollIndex = col;
                }
            }
        }
        Console.WriteLine($"{matrix[maxRowIndex, maxCollIndex]} {matrix[maxRowIndex, maxCollIndex + 1]}");
        Console.WriteLine($"{matrix[maxRowIndex + 1, maxCollIndex]} {matrix[maxRowIndex + 1, maxCollIndex + 1]}");
        Console.WriteLine(maxSum);
    }
}

