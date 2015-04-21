namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class TestProgram
    {
        static void Main()
        {
            List<Shape> list = new List<Shape>()
            {
                new Rectangle(4,6),
                new Triangle(4,4),
                new Square(5)
            };

            list.ForEach(x=>Console.WriteLine(x.GetType().Name +" "+ x.CalculateSurface()));
            
        }
    }
}
