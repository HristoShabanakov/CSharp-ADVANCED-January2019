using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        //We can put direct the input into the stack and reverse its order.
        Stack<string> symbols = new Stack<string>(input.Reverse());

        var result = int.Parse(symbols.Pop());

        while (symbols.Any())
        {
            var nextSymbol = symbols.Pop();

            if (nextSymbol == "+")
            {
                result += int.Parse(symbols.Pop());
            }
            else if (nextSymbol == "-")
            {
                result -= int.Parse(symbols.Pop());
            }
        }
        Console.WriteLine(result);
    }
}

