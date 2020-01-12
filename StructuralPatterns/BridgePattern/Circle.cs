using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Circle : Shape
    {
        private int _x, _y, _radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI)
            : base(drawAPI)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            _drawAPI.DrawCircle(_radius, _x, _y);
        }
    }
}
