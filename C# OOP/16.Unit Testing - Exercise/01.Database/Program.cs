namespace _01.Database
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        
        static void Main()
        {
            Database database = new Database(1, 2, 3, 4, 5);

            Database datab = new Database(new List<int> { 1, 3, 5, 6 });
        }
    }
}
