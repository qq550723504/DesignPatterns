namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice) 
        {
            return choice switch
            {
                "SHAPE" => new ShapeFactory(),
                "COLOR" => new ColorFactory(),
                _ => null,
            };
        }
    }
}
