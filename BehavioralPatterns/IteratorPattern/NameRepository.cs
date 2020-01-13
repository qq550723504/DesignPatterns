namespace IteratorPattern
{
    public class NameRepository : IContainer
    {
        public static string[] Names = { "Robert", "John", "Julie", "Lora" };
        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int index;

            public virtual bool HasNext()
            {
                if (index < Names.Length)
                {
                    return true;
                }
                return false;
            }

            public virtual object Next()
            {
                if (HasNext())
                {
                    return Names[index++];
                }
                return null;
            }
        }
    }
}
