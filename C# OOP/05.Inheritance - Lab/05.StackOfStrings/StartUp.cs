namespace CustomStack
{
    using System;

    public class StartUp
    {
       public static void Main()
        {
            var stack = new StackOfStrings();

            stack.AddRange("1", "2", "3");

            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Console.WriteLine(string.Join(" ", stack));
            }
        }
    }
}
