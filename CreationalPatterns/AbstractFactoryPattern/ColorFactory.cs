namespace AbstractFactoryPattern
{
    public class ColorFactory:AbstractFactory
    {
        public override IShape GetShape(string shapeType)=>null;

        public override IColor GetColor(string color)
        {
            return color switch
            {
            "RED" => new Red(),
                "GREEN" => new Green(),
                "BLUE" => new Blue(),
                _ => null,
            };
        }
    }
}