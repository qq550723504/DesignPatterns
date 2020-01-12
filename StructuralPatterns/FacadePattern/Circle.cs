using System;

namespace FacadePattern
{
    public class Circle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
