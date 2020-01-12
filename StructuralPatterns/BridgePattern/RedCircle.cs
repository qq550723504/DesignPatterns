using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class RedCircle : IDrawAPI
    {
        public virtual void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle[ color: red, radius:{radius}, x: {x}, {y}]");
        }
    }
}
