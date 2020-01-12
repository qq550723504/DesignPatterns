namespace CommandPattern
{
    public class SellStock : IOrder
    {
        private readonly Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}
