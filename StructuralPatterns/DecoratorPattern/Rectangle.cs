using System;

namespace DecoratorPattern
{
    public class Rectangle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
