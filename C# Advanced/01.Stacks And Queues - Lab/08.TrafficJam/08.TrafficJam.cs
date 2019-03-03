using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        var countPerGreenLight = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();
        var totalPassed = 0;
        var sb = new StringBuilder();

        while (true)
        {
            var currentLine = Console.ReadLine();

            if (currentLine == "end")
            {
                sb.AppendLine($"{totalPassed} cars passed the crossroads.");
                Console.Write(sb);
                break;
            }

            if (currentLine != "green")
            {
                cars.Enqueue(currentLine);
            }
            else
            {
                var carToPass = Math.Min(countPerGreenLight, cars.Count);

                for (int i = 0; i < carToPass; i++)
                {
                    sb.AppendLine($"{cars.Dequeue()} passed!");

                    totalPassed++;
                }
            }
        }
    }
}

