

namespace _02.GenericBoxOfInteger
{
    using System;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int content = int.Parse(Console.ReadLine());
                Box<int> boxWithString = new Box<int>(content);
                Console.WriteLine(boxWithString.ToString());
            }
        }
    }
}
