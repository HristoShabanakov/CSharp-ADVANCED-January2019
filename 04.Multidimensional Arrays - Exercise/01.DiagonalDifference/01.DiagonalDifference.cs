using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        int[][] matrix = new int[n][];

        for (int row = 0; row < n; row++)
        {
            matrix[row] = Console.ReadLine()
           .Split(' ', StringSplitOptions
           .RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
        }
        for (int row = 0;row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                if (row == col)
                    primaryDiagonal += matrix[row][col];
                if (row == matrix.Length - col - 1)
                    secondaryDiagonal += matrix[row][col];
            }
        }

        int difference = primaryDiagonal - secondaryDiagonal;
        
        Console.WriteLine(Math.Abs(difference));
    }
}

