using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rackCapacity = int.Parse(Console.ReadLine());
        //Start from the last piece
        Stack<int> clothesValues = new Stack<int>(inputValues);

        //We start from 1 because we take the first rack with clothes.
        int racks = 1;
        int sum = 0;

        while(clothesValues.Any()) // clothes.Values.Count > 0
        {
            //5 4 8 6 3 8 7 7 9
            //Sum is 0 we add the first value in the Stack to it and check if its bigger or equal to rackCapacity.
            //With Peek we look up the first value in the Stack.
            //Check the capacity of a current rack, how many pieces of clothes you can put there.
            if (sum + clothesValues.Peek() <= rackCapacity)
            {
                //Pop removes value from the Stack.
                sum +=clothesValues.Pop();
            }
            
            else
            {
                sum = 0;
                racks++;
            }
        }
        Console.WriteLine(racks);
    }
}
