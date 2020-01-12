using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Rectangle : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
