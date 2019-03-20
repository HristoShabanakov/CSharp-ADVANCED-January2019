namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var shapes = new List<IDrawable>();

            shapes.Add(new Rectangle(10, 15));
            shapes.Add(new Circle(8));
            shapes.Add(new Rectangle(5, 10));
            shapes.Add(new Circle(10));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Draw());
            }
        }
    }
}
