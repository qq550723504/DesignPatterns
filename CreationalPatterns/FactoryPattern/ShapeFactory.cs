namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            return shapeType switch
            {
                "CIRCLE" => new Circle(),
                "RECTANGLE" => new Rectangle(),
                "SQUARE" => new Square(),
                _ => null,
            };
        }
    }
}
