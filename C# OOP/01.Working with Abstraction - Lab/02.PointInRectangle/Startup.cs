
namespace _02.PointInRectangle
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {

            int[] rectagnleCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var topLeft = new Point(rectagnleCoordinates[0], rectagnleCoordinates[1]);
            var bottomRight = new Point(rectagnleCoordinates[2], rectagnleCoordinates[3]);
            var rectangle = new Rectangle(topLeft, bottomRight);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var point = new Point(pointCoordinates[0], pointCoordinates[1]);
                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
