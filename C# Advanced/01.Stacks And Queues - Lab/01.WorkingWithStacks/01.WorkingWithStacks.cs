using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<char> someStack = new Stack<char>();
        //I Love C#
        string input = Console.ReadLine();

        foreach (var symbol in input)
        {
            someStack.Push(symbol);
        }

        while (someStack.Count != 0)
        {
            Console.Write(someStack.Pop());
        }
        Console.WriteLine();
    }
}

