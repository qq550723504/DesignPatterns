namespace SingletonPattern
{
    public class MySingle:SingleInstance<MySingle>
    {
        private MySingle() { }

        public int Age { get; set; }
    }
}
