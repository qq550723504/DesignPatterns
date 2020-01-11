using System.Collections.Generic;

namespace PrototypePattern
{
    public class ShapeCache
    {
        private static readonly Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = shapeMap.GetValueOrDefault(shapeId);
            return (Shape)cachedShape.Clone();
        }

        public static void LoadCache()
        {
            var circle = new Circle();
            circle.SetId("1");
            shapeMap.Add(circle.GetId(), circle);

            var square = new Square();
            square.SetId("2");
            shapeMap.Add(square.GetId(), square);

            var rectangle = new Rectangle();
            rectangle.SetId("3");
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
