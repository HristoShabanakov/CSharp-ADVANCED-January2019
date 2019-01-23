using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(input);
        string commandInput;

        while ((commandInput = Console.ReadLine().ToLower()) != "end")
        {
            var tokens = commandInput.Split();
            var command = tokens[0].ToLower();

            if (command == "add")
            {
                int numberOne = int.Parse(tokens[1]);
                int numberTwo = int.Parse(tokens[2]);

                stack.Push(numberOne);
                stack.Push(numberTwo);

                continue;
            }

            if (command == "remove")
            {
                var countOfRemovedNums = int.Parse(tokens[1]);
                if (stack.Count < countOfRemovedNums) { continue; }
                for (int i = 0; i < countOfRemovedNums; i++)
                {
                    stack.Pop();
                }
            }
        }
        Console.WriteLine($"Sum: {stack.Sum()}");
    }
}

