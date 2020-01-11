namespace BuilderPattern
{
    public interface IItem
    {
        public string Name { get; }

        public IPacking Packing();
        public float Price { get; }
    }
}
