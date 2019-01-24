using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] arr = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            var currentRow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            arr[row] = currentRow;
        }

        while (true)
        {
            var command = Console.ReadLine();

            if (command.ToLower() == "end")
            {
                break;
            }

            var commandParts = command.Split();
            var commandOperator = commandParts[0];
            var commandRow = int.Parse(commandParts[1]);
            var commandCol = int.Parse(commandParts[2]);
            var value = int.Parse(commandParts[3]);

            //Check if the coordinates are valid - we are not going out of the arrays.
            if (commandRow < 0
                || commandRow >= arr.Length
                || commandCol < 0
                || commandCol >= arr[commandRow].Length)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            if (commandOperator == "Add")
            {
                arr[commandRow][commandCol] += value;
            }
            else if (commandOperator == "Subtract")
            {
                arr[commandRow][commandCol] -= value;
            }
        }

        foreach (var row in arr)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

