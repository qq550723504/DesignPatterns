using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var abcStock = new Stock();

            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);

            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();

            Console.ReadKey();
        }
    }
}
