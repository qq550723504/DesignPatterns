namespace DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        protected readonly IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            _decoratedShape.Draw();
        }
    }
}
