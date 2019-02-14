

namespace _06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }

            double element = double.Parse(Console.ReadLine());

            double count = GetCountOfGreaterElements<double>(box.Data, element);

            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T element)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Swap<T>(List<T> listWithData, int firstIndex, int secondIndex)
        {
            T temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secondIndex];
            listWithData[secondIndex] = temp;
        }
    }
}
