using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<int> symbols = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                symbols.Push(i);
            }
            else if (input[i] == ')')
            {
                var openBracketIndex = symbols.Pop();

                Console.WriteLine(input.Substring(openBracketIndex, i - openBracketIndex + 1));
            }
        }
    }
}

