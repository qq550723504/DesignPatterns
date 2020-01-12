using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Shape
    {
        protected IDrawAPI _drawAPI;

        public Shape(IDrawAPI drawAPI) 
        {
            _drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
