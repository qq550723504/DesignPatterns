using System;

namespace FacadePattern
{
    public class Square : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
