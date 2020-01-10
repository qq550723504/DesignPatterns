using System;

namespace FactoryPattern
{
    public class Square : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
