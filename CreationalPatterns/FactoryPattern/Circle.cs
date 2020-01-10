using System;

namespace FactoryPattern
{
    public class Circle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
