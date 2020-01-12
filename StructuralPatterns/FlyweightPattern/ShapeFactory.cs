using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            var circle = (Circle)circleMap.GetValueOrDefault(color);

            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine($"Creating circle of color :{ color}");
            }
            return circle;
        }
    }
}
