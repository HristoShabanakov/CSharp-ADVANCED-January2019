namespace _03.Ferrari
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();

            ICar car = new Ferrari(name);
            
            Console.WriteLine(car.ToString());
        }
    }
}
