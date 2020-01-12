using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class Circle : IShape
    {
        private readonly string _color;
        private int _x;
        private int _y;
        private int _radius;

        public Circle(string color)
        {
            _color = color;
        }

        public void SetX(int x)
        {
            _x = x;
        }

        public void SetY(int y)
        {
            _y = y;
        }

        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Circle: Draw() [Color :{ _color}, x :{ _x }, y :{ _y }, radius :{ _radius}");
        }
    }
}
