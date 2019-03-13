namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var randomList = new RandomList();

            randomList.Add("Test");
            randomList.Add("Pesto");
            randomList.Add("Testo");
            randomList.Add("Random");

            Console.WriteLine(randomList.RemoveRandomElement());
        }
    }
}
