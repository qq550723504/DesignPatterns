using System;

namespace FactoryPattern
{
    public class Rectangle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
