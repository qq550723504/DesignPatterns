namespace BuilderPattern
{
    public abstract class Burger : IItem
    {
        public IPacking Packing() => new Wrapper();
        public abstract string Name { get; }

        public abstract float Price { get; }
    }
}
