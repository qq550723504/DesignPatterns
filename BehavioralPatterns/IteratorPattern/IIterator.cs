namespace IteratorPattern
{
    public interface IIterator
    {
        public bool HasNext();
        public object Next();
    }
}
