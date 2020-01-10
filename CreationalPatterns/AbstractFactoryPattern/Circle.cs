using System;

namespace AbstractFactoryPattern
{
    public class Circle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}