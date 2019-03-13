namespace CustomStack
{
    using System.Collections.Generic;

    public class StackOfStrings :Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(params string[] data)
        {
            foreach (var element in data)
            {
                this.Push(element);
            }
        }
    }
}
