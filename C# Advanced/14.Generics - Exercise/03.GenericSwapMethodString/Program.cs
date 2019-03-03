

namespace _03.GenericSwapMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
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
