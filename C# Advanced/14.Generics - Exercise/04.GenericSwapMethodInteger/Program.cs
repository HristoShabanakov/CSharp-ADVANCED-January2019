

namespace _04.GenericSwapMethodInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int line = int.Parse(Console.ReadLine());
                box.Add(line);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Swap(box.Data, firstIndex, secondIndex);

            Console.WriteLine(box);
        }

        static void Swap<T>(List<T> listWithData, int firstIndex, int secondIndex)
        {
            T temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secondIndex];
            listWithData[secondIndex] = temp;
        }
    }
}
