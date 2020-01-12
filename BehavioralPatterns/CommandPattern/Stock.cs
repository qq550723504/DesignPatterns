using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Stock
    {
        private readonly string Name = "ABC";
        private readonly int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [ Name:{ Name }, Quantity:{ Quantity } ] bought");
        }
        public void Sell()
        {
            Console.WriteLine($"Stock [ Name:{ Name },Quantity:{ Quantity }] sold");
        }
    }
}
