using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        //add" ‐> add 1 to each number;
        Func<List<int>, List<int>> addFunc = x => x.Select(a => a += 1).ToList();
        Func<List<int>, List<int>> subtractFunc = x => x.Select(a => a -= 1).ToList();
        Func<List<int>, List<int>> multiplyFunc = x => x.Select(a => a *= 2).ToList();

        Action<List<int>> printNumbers = x => Console.WriteLine(string.Join(" ", x));


        string command = Console.ReadLine();

        while (command != "end")
        {
            if (command == "add")
            {
                numbers = addFunc(numbers);
            }
            else if (command == "subtract")
            {
                numbers = subtractFunc(numbers);
            }
            else if (command == "multiply")
            {
                numbers = multiplyFunc(numbers);
            }
            else if (command == "print")
            {
                printNumbers(numbers);
            }

            command = Console.ReadLine();
        }
    }
}
