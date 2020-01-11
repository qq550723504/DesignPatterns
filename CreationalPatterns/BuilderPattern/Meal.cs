using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Meal
    {
        private readonly List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (var item in items)
            {
                cost += item.Price;
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item :{item.Name} , Packing :{item.Packing()}, Price :{item.Price}");
            }
        }
    }
}
