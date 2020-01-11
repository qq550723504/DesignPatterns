using System;

namespace PrototypePattern
{
    public class Square : Shape
    {
        public Square() 
        {
            _entity = "Shape";
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
