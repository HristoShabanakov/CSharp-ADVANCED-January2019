using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        string[][] table = new string[rows][];

        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split(", ");

            table[i] = rowValues;
        }
        string[] commandArgs = Console.ReadLine().Split();

        string command = commandArgs[0];
        string header = commandArgs[1];
        int headerIndex = Array.IndexOf(table[0], header);

        if (command == "hide")
        {
            table.Where((x, i) => Array.IndexOf(x, i) != headerIndex);
            for (int row = 0; row < table.Length; row++)
            {
                Console.WriteLine(string.Join(" | ", table[row]
                    .Where((x, i) => i != headerIndex)
                    .ToArray()));
                //lineToPrint.RemoveAt(headerIndex);
                //lineToPrint.AddRange(table[row].Take(headerIndex).ToList());
                //lineToPrint.AddRange(table[row].Skip(headerIndex + 1).ToList());
                //Console.WriteLine(string.Join(" | ",lineToPrint));
                //table[row] = lineToPrint.ToArray();
            }
        }
        else if (command == "sort")
        {
            string[] headerRow = table[0];
            Console.WriteLine(string.Join(" | ", table[0]));

            table = table.OrderBy(x => x[headerIndex]).ToArray();

            foreach (var row in table)
            {
                if (row != headerRow)
                {
                    Console.WriteLine(string.Join(" | ", row));
                }
            }
        }
        else if (command == "filter")
        {
            string parameter = commandArgs[2];
            string[] headerRow = table[0];

            Console.WriteLine(string.Join(" | ", headerRow));

            for (int i = 1; i < table.Length; i++)
            {
                if (table[i][headerIndex] == parameter)
                {
                    Console.WriteLine(string.Join(" | ", table[i]));
                }
            }
        }


    }
}

