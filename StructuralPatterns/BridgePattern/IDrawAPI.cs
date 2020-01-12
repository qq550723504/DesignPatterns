using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public interface IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y);
    }
}
