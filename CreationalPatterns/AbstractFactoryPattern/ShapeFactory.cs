namespace AbstractFactoryPattern
{
    public class ShapeFactory:AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return shapeType switch
            {
                "CIRCLE" => new Circle(),
                "RECTANGLE" => new Rectangle(),
                "SQUARE" => new Square(),
                _ => null,
            };
        }

        public override IColor GetColor(string color) => null;
    }
}